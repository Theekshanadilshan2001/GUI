let menu = document.querySelector('#menu-icon');
let navbar = document.querySelector('.navbar');

menu.onclick = () => {
    menu.classList.toggle('bx-x');
    navbar.classList.toggle('active');
}

window.onscroll = () => {
    menu.classList.remove('bx-x');
    navbar.classList.remove('active');
}

const typed = new Typed('.multiple-text', {
    strings: ['Physical Fitness', 'Weight Gain', 'Strength Training', 'Fat Lose', 'Personal Trainning', 'Nutrition Plans'],
    typeSpeed: 60,
    backSpeed: 60,
    backDelay: 1000,
    loop: true,
});

function calculateBMI() {
    const height = document.getElementById('bmi-height').value;
    const weight = document.getElementById('bmi-weight').value;
  
    if (height > 0 && weight > 0) {
      const bmi = (weight / ((height / 100) ** 2)).toFixed(2);
      document.getElementById('bmi-result').innerText = `Your BMI: ${bmi}`;
    } else {
      alert('Please enter valid height and weight!');
    }
  }
  
  function calculateTDEE() {
    const weight = document.getElementById('tdee-weight').value;
    const height = document.getElementById('tdee-height').value;
    const age = document.getElementById('tdee-age').value;
    const activity = document.getElementById('tdee-activity').value;
  
    if (weight > 0 && height > 0 && age > 0) {
      const bmr = (10 * weight) + (6.25 * height) - (5 * age) + 5; // For males
      const tdee = (bmr * activity).toFixed(2);
      document.getElementById('tdee-result').innerText = `Your TDEE: ${tdee} kcal`;
    } else {
      alert('Please fill out all fields!');
    }
  }
  
  function calculateBodyFat() {
    const neck = document.getElementById('bf-neck').value;
    const waist = document.getElementById('bf-waist').value;
    const hip = document.getElementById('bf-hip').value; // Optional for females
  
    if (neck > 0 && waist > 0) {
      const bodyFat = hip
        ? (495 / (1.29579 - 0.35004 * Math.log10(waist - neck) + 0.22100 * Math.log10(hip))) - 450
        : (495 / (1.0324 - 0.19077 * Math.log10(waist - neck) + 0.15456 * Math.log10(neck))) - 450;
  
      document.getElementById('bf-result').innerText = `Your Body Fat: ${bodyFat.toFixed(2)}%`;
    } else {
      alert('Please fill out all required fields!');
    }
  }

  
  function createAccount() {
    const name = document.getElementById('name').value;
    const age = document.getElementById('age').value;
    const sex = document.getElementById('sex').value;
    const email = document.getElementById('email').value;
  
    if (name && age && sex && email) {
      document.getElementById('join-result').innerText = `Welcome to Royal Fitness, ${name}! Your account has been created.`;
      document.getElementById('join-form').reset(); // Clear form fields
    } else {
      alert('Please fill in all the fields!');
    }
  }

  
  // create local storage //

  function createAccount() {
    const name = document.getElementById('name').value;
    const age = document.getElementById('age').value;
    const sex = document.getElementById('sex').value;
    const email = document.getElementById('email').value;
  
    if (name && age && sex && email) {
      const user = { name, age, sex, email };
      localStorage.setItem('user', JSON.stringify(user));
      document.getElementById('join-result').innerText = `Welcome to Royal Fitness, ${name}! Your account has been created.`;
      document.getElementById('join-form').reset();
    } else {
      alert('Please fill in all the fields!');
    }
  }
  
   // Setup javascript //

   let users = JSON.parse(localStorage.getItem("users")) || [];
let currentUser = null;

function setupAccount() {
  const name = document.getElementById("setup-name").value;
  const username = document.getElementById("setup-username").value;
  const password = document.getElementById("setup-password").value;
  const weight = parseFloat(document.getElementById("setup-weight").value);
  const tdee = parseFloat(document.getElementById("setup-tdee").value);
  const goal = document.getElementById("setup-goal").value;

  if (!name || !username || !password || !weight || !tdee || !goal) {
    alert("Please fill out all fields!");
    return;
  }

  const user = {
    name,
    username,
    password,
    weight,
    tdee,
    goal,
    calories: goal === "Fat Loss" ? tdee - 250 : goal === "Muscle Build" ? tdee + 250 : tdee + 500,
    weights: [{ week: 1, date: new Date().toLocaleDateString(), weight }],
  };

  users.push(user);
  localStorage.setItem("users", JSON.stringify(users));
  alert("Account setup complete! Redirecting to your profile...");
  window.location.href = "profile.html";
}

function signIn() {
  const username = document.getElementById("signin-username").value;
  const password = document.getElementById("signin-password").value;

  currentUser = users.find((user) => user.username === username && user.password === password);

  if (!currentUser) {
    document.getElementById("signin-error").innerText = "Invalid username or password!";
    return;
  }

  localStorage.setItem("currentUser", JSON.stringify(currentUser));
  alert("Login successful!");
  window.location.href = "profile.html";
}

function initializeProfile() {
  currentUser = JSON.parse(localStorage.getItem("currentUser"));
  if (!currentUser) {
    alert("Please sign in first.");
    window.location.href = "signin.html";
    return;
  }

  document.getElementById("greeting").innerText = `Welcome back, ${currentUser.name}!`;
  document.getElementById("calorie-message").innerText = `Your total calorie intake is ${currentUser.tdee} kcal. Since your goal is ${currentUser.goal}, you should consume ${currentUser.calories} kcal per day.`;

  const tbody = document.getElementById("weight-table").querySelector("tbody");
  tbody.innerHTML = currentUser.weights
    .map((entry) => `<tr><td>${entry.week}</td><td>${entry.date}</td><td>${entry.weight} kg</td></tr>`)
    .join("");
}

function updateWeight() {
  const newWeight = parseFloat(document.getElementById("weight-log").value);
  if (isNaN(newWeight)) {
    alert("Please enter a valid weight.");
    return;
  }

  const lastWeight = currentUser.weights[currentUser.weights.length - 1].weight;
  const weightChange = newWeight - lastWeight;

  if (currentUser.goal === "Fat Loss" && weightChange > -0.2) {
    currentUser.calories -= 100;
  } else if (currentUser.goal === "Muscle Build" && weightChange < 0.2) {
    currentUser.calories += 100;
  } else if (currentUser.goal === "Strength Training" && weightChange < 0.4) {
    currentUser.calories += 100;
  }

  currentUser.weights.push({
    week: currentUser.weights.length + 1,
    date: new Date().toLocaleDateString(),
    weight: newWeight,
  });

  localStorage.setItem("currentUser", JSON.stringify(currentUser));
  initializeProfile();
}
