const taskInput = document.getElementById("taskInput");
const addTaskBtn = document.getElementById("addTaskBtn");
const taskList = document.getElementById("taskList");

// Load tasks from localStorage
document.addEventListener("DOMContentLoaded", loadTasks);

// Add task button click
addTaskBtn.addEventListener("click", addTask);

// Add task on Enter key
taskInput.addEventListener("keypress", function(e) {
  if (e.key === "Enter") {
    addTask();
  }
});

function addTask() {
  const taskText = taskInput.value.trim();
  if (taskText === "") return;

  const task = {
    text: taskText,
    completed: false
  };

  createTaskElement(task);
  saveTask(task);

  taskInput.value = "";
}

function createTaskElement(task) {
  const li = document.createElement("li");

  const checkbox = document.createElement("input");
  checkbox.type = "checkbox";
  checkbox.checked = task.completed;

  const span = document.createElement("span");
  span.textContent = task.text;

  const deleteBtn = document.createElement("button");
  deleteBtn.textContent = "X";
  deleteBtn.classList.add("delete-btn");

  if (task.completed) {
    li.classList.add("completed");
  }

  // Toggle completed
  checkbox.addEventListener("change", function() {
    li.classList.toggle("completed");
    updateLocalStorage();
  });

  // Delete task
  deleteBtn.addEventListener("click", function() {
    li.remove();
    updateLocalStorage();
  });

  li.appendChild(checkbox);
  li.appendChild(span);
  li.appendChild(deleteBtn);
  taskList.appendChild(li);
}

function saveTask(task) {
  const tasks = getTasks();
  tasks.push(task);
  localStorage.setItem("tasks", JSON.stringify(tasks));
}

function getTasks() {
  return JSON.parse(localStorage.getItem("tasks")) || [];
}

function loadTasks() {
  const tasks = getTasks();
  tasks.forEach(task => createTaskElement(task));
}

function updateLocalStorage() {
  const tasks = [];
  document.querySelectorAll("#taskList li").forEach(li => {
    const text = li.querySelector("span").textContent;
    const completed = li.classList.contains("completed");
    tasks.push({ text, completed });
  });
  localStorage.setItem("tasks", JSON.stringify(tasks));
}