// Menu and Navbar Toggle
document.addEventListener("DOMContentLoaded", () => {
  const menu = document.querySelector("#menu-icon");
  const navbar = document.querySelector(".navbar");

  if (menu && navbar) {
    menu.onclick = () => {
      menu.classList.toggle("bx-x");
      navbar.classList.toggle("active");
    };

    window.onscroll = () => {
      menu.classList.remove("bx-x");
      navbar.classList.remove("active");
    };
  }
});

// Typed.js Configuration
document.addEventListener("DOMContentLoaded", () => {
  if (document.querySelector(".multiple-text")) {
    new Typed(".multiple-text", {
      strings: [
        "Physical Fitness",
        "Weight Gain",
        "Strength Training",
        "Fat Loss",
        "Personal Training",
        "Nutrition Plans",
      ],
      typeSpeed: 60,
      backSpeed: 60,
      backDelay: 1000,
      loop: true,
    });
  }
});

// Account Setup Logic
document.addEventListener("DOMContentLoaded", () => {
  const setupButton = document.getElementById("setup-account-button");

  if (setupButton) {
    setupButton.addEventListener("click", () => {
      const name = document.getElementById("setup-name").value.trim();
      const username = document.getElementById("setup-username").value.trim();
      const password = document.getElementById("setup-password").value.trim();
      const weight = parseFloat(document.getElementById("setup-weight").value.trim());
      const tdee = parseFloat(document.getElementById("setup-tdee").value.trim());
      const goal = document.getElementById("setup-goal").value.trim();

      if (!name || !username || !password || isNaN(weight) || isNaN(tdee) || !goal) {
        alert("Please fill out all fields!");
        return;
      }

      const users = JSON.parse(localStorage.getItem("users")) || [];
      const userExists = users.some((user) => user.username === username);

      if (userExists) {
        alert("Username already exists. Please choose a different username.");
        return;
      }

      const user = {
        name,
        username,
        password,
        weight,
        tdee,
        goal,
        weights: [{ date: new Date().toLocaleDateString(), weight }],
      };

      users.push(user);
      localStorage.setItem("users", JSON.stringify(users));

      alert("Account setup complete! Redirecting to your profile...");
      window.location.href = "profile.html";
    });
  }
});

// Sign-In Logic
document.addEventListener("DOMContentLoaded", () => {
  const signinButton = document.getElementById("signin-button");

  if (signinButton) {
    signinButton.addEventListener("click", () => {
      const username = document.getElementById("signin-username").value.trim();
      const password = document.getElementById("signin-password").value.trim();

      const users = JSON.parse(localStorage.getItem("users")) || [];
      const user = users.find(
        (user) => user.username === username && user.password === password
      );

      if (user) {
        localStorage.setItem("currentUser", username);
        alert("Login successful! Redirecting to your profile...");
        setTimeout(() => {
          window.location.href = "profile.html";
        }, 2000);
      } else {
        alert("Invalid username or password, or account does not exist!");
      }
    });
  }
});

// Profile Page Logic
function loadUserData() {
  const username = localStorage.getItem("currentUser");
  const users = JSON.parse(localStorage.getItem("users")) || [];
  const user = users.find((user) => user.username === username);

  if (!user) {
    alert("No user data found. Please sign in first.");
    window.location.href = "signin.html";
    return;
  }

  document.getElementById("greeting-time").textContent = getGreeting();
  document.getElementById("user-name").textContent = user.name;
  document.getElementById("user-tdee").textContent = user.tdee;

  const weightTable = document.getElementById("weight-table");
  weightTable.innerHTML = "";
  user.weights.forEach((entry, index) => {
    const row = document.createElement("tr");
    row.innerHTML = `<td>Week ${index + 1}</td><td>${entry.weight} kg</td>`;
    weightTable.appendChild(row);
  });
}

function handleWeightUpdate() {
  const username = localStorage.getItem("currentUser");
  const users = JSON.parse(localStorage.getItem("users")) || [];
  const userIndex = users.findIndex((user) => user.username === username);

  if (userIndex === -1) {
    alert("No user data found. Please sign in first.");
    return;
  }

  const newWeight = parseFloat(document.getElementById("weight-input").value.trim());
  if (!isNaN(newWeight) && newWeight > 0) {
    users[userIndex].weights.push({
      date: new Date().toLocaleDateString(),
      weight: newWeight,
    });
    localStorage.setItem("users", JSON.stringify(users));
    document.getElementById("weight-input").value = "";
    loadUserData();
  } else {
    alert("Please enter a valid weight!");
  }
}

document.addEventListener("DOMContentLoaded", () => {
  if (document.getElementById("profile-page")) {
    loadUserData();
    document.getElementById("update-button").addEventListener("click", handleWeightUpdate);
  }
});

// Greeting Function
function getGreeting() {
  const hour = new Date().getHours();
  if (hour < 12) return "Good Morning";
  if (hour < 18) return "Good Afternoon";
  return "Good Evening";
}
