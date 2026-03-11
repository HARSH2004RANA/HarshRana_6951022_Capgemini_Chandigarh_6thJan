const registerForm = document.getElementById("registerForm");
const loginForm = document.getElementById("loginForm");

// Email validation function
function validateEmail(email) {
  const regex = /^[^\\s@]+@[^\\s@]+\\.[^\\s@]+$/;
  return regex.test(email);
}

// Get users from localStorage
function getUsers() {
  return JSON.parse(localStorage.getItem("users")) || [];
}

// Save users to localStorage
function saveUsers(users) {
  localStorage.setItem("users", JSON.stringify(users));
}

// Register
registerForm.addEventListener("submit", function(e) {
  e.preventDefault();

  const username = document.getElementById("regUsername").value.trim();
  const email = document.getElementById("regEmail").value.trim();
  const password = document.getElementById("regPassword").value;
  const confirmPassword = document.getElementById("regConfirmPassword").value;

  if (!validateEmail(email)) {
    alert("Invalid email format!");
    return;
  }

  if (password.length < 6) {
    alert("Password must be at least 6 characters long!");
    return;
  }

  if (password !== confirmPassword) {
    alert("Passwords do not match!");
    return;
  }

  const users = getUsers();

  // Check if username already exists
  const userExists = users.find(user => user.username === username);
  if (userExists) {
    alert("Username already taken!");
    return;
  }

  users.push({ username, email, password });
  saveUsers(users);

  alert("Registration successful!");
  registerForm.reset();
});

// Login
loginForm.addEventListener("submit", function(e) {
  e.preventDefault();

  const username = document.getElementById("loginUsername").value.trim();
  const password = document.getElementById("loginPassword").value;

  const users = getUsers();

  const validUser = users.find(user =>
    user.username === username && user.password === password
  );

  if (validUser) {
    alert("Login successful!");
    loginForm.reset();
  } else {
    alert("Invalid username or password!");
  }
});