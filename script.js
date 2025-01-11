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
  