// Select the menu and navbar elements safely
document.addEventListener('DOMContentLoaded', () => {
  let menu = document.querySelector('#menu-icon');
  let navbar = document.querySelector('.navbar');

  if (menu && navbar) {
      menu.onclick = () => {
          menu.classList.toggle('bx-x');
          navbar.classList.toggle('active');
      };

      window.onscroll = () => {
          menu.classList.remove('bx-x');
          navbar.classList.remove('active');
      };
  }
});

// Typed.js configuration (ensure .multiple-text exists in your HTML)
document.addEventListener('DOMContentLoaded', () => {
  if (document.querySelector('.multiple-text')) {
      const typed = new Typed('.multiple-text', {
          strings: ['Physical Fitness', 'Weight Gain', 'Strength Training', 'Fat Loss', 'Personal Training', 'Nutrition Plans'],
          typeSpeed: 60,
          backSpeed: 60,
          backDelay: 1000,
          loop: true,
      });
  }
});

// Account setup logic
document.addEventListener("DOMContentLoaded", () => {
  // Get the button element safely
  const setupButton = document.getElementById("setup-account-button");

  if (setupButton) {
      setupButton.addEventListener("click", setupAccount);
  } else {
      console.error("Setup Account button not found!");
  }

  let users = JSON.parse(localStorage.getItem("users")) || [];

  function setupAccount() {
      const name = document.getElementById("setup-name").value;
      const username = document.getElementById("setup-username").value;
      const password = document.getElementById("setup-password").value;
      const weight = parseFloat(document.getElementById("setup-weight").value);
      const tdee = parseFloat(document.getElementById("setup-tdee").value);
      const goal = document.getElementById("setup-goal").value;

      // Validation
      if (!name || !username || !password || isNaN(weight) || isNaN(tdee) || !goal) {
          alert("Please fill out all fields!");
          return;
      }

      const calories =
          goal === "Fat Loss" ? tdee - 250 : goal === "Muscle Build" ? tdee + 250 : tdee + 500;

      const user = {
          name,
          username,
          password,
          weight,
          tdee,
          goal,
          calories,
          weights: [{ week: 1, date: new Date().toLocaleDateString(), weight }],
      };

      users.push(user);
      localStorage.setItem("users", JSON.stringify(users));

      alert("Account setup complete! Redirecting to your profile...");
      window.location.href = "profile.html";
  }
});


// script.js

// Function to determine greeting based on current time
function getGreeting() {
    const currentHour = new Date().getHours();
    if (currentHour < 12) return "Good Morning";
    if (currentHour < 18) return "Good Afternoon";
    return "Good Evening";
  }
  
  // Load user data from localStorage or setup page
  function loadUserData() {
    const userName = localStorage.getItem("userName") || "Guest";
    const userTDEE = localStorage.getItem("userTDEE") || "Not set";
    const weightHistory = JSON.parse(localStorage.getItem("weightHistory") || "[]");
  
    // Set greeting and user data
    document.getElementById("greeting-time").textContent = getGreeting();
    document.getElementById("user-name").textContent = userName;
    document.getElementById("user-tdee").textContent = userTDEE;
  
    // Populate weight history table
    const weightTable = document.getElementById("weight-table");
    weightTable.innerHTML = ""; // Clear table
    weightHistory.forEach((weight, index) => {
      const row = document.createElement("tr");
      row.innerHTML = `<td>Week ${index + 1}</td><td>${weight} kg</td>`;
      weightTable.appendChild(row);
    });
  }
  
  // Handle weight updates
  function handleWeightUpdate() {
    const weightInput = document.getElementById("weight-input");
    const newWeight = parseFloat(weightInput.value);
    if (!isNaN(newWeight) && newWeight > 0) {
      const weightHistory = JSON.parse(localStorage.getItem("weightHistory") || "[]");
      weightHistory.push(newWeight);
      localStorage.setItem("weightHistory", JSON.stringify(weightHistory));
      weightInput.value = ""; // Clear input field
      loadUserData(); // Refresh table
    } else {
      alert("Please enter a valid weight!");
    }
  }
  
  // Event listeners
  document.addEventListener("DOMContentLoaded", () => {
    loadUserData();
  
    const updateButton = document.getElementById("update-button");
    updateButton.addEventListener("click", handleWeightUpdate);
  });
  
  