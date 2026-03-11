const questionElement = document.getElementById("question");
const optionsElement = document.getElementById("options");
const nextBtn = document.getElementById("nextBtn");
const timerElement = document.getElementById("timer");

let currentQuestionIndex = 0;
let score = 0;
let timeLeft = 10;
let timer;

// Questions Array
const questions = [
  {
    question: "Which language runs in the browser?",
    options: ["Java", "C", "Python", "JavaScript"],
    correct: 3
  },
  {
    question: "What does CSS stand for?",
    options: [
      "Computer Style Sheets",
      "Cascading Style Sheets",
      "Creative Style System",
      "Colorful Style Sheets"
    ],
    correct: 1
  },
  {
    question: "Which HTML tag is used for JavaScript?",
    options: ["<js>", "<script>", "<javascript>", "<code>"],
    correct: 1
  }
];

function startQuiz() {
  currentQuestionIndex = 0;
  score = 0;
  nextBtn.innerText = "Next";
  showQuestion();
}

function showQuestion() {
  resetState();
  startTimer();

  const currentQuestion = questions[currentQuestionIndex];
  questionElement.innerText = currentQuestion.question;

  currentQuestion.options.forEach((option, index) => {
    const button = document.createElement("button");
    button.innerText = option;
    button.addEventListener("click", () => selectAnswer(index));
    optionsElement.appendChild(button);
  });
}

function resetState() {
  clearInterval(timer);
  nextBtn.style.display = "none";
  optionsElement.innerHTML = "";
}

function selectAnswer(selectedIndex) {
  clearInterval(timer);

  const correctIndex = questions[currentQuestionIndex].correct;
  const buttons = optionsElement.children;

  for (let i = 0; i < buttons.length; i++) {
    if (i === correctIndex) {
      buttons[i].classList.add("correct");
    } else if (i === selectedIndex) {
      buttons[i].classList.add("incorrect");
    }
    buttons[i].disabled = true;
  }

  if (selectedIndex === correctIndex) {
    score++;
  }

  nextBtn.style.display = "block";
}

nextBtn.addEventListener("click", () => {
  currentQuestionIndex++;
  if (currentQuestionIndex < questions.length) {
    showQuestion();
  } else {
    showScore();
  }
});

function showScore() {
  resetState();
  questionElement.innerText = `Quiz Finished! Your score: ${score} / ${questions.length}`;
  nextBtn.innerText = "Restart";
  nextBtn.style.display = "block";
  nextBtn.onclick = startQuiz;
}

// BONUS: Timer
function startTimer() {
  timeLeft = 10;
  timerElement.innerText = `Time Left: ${timeLeft}s`;

  timer = setInterval(() => {
    timeLeft--;
    timerElement.innerText = `Time Left: ${timeLeft}s`;

    if (timeLeft === 0) {
      clearInterval(timer);
      selectAnswer(-1); // No selection
    }
  }, 1000);
}

startQuiz();