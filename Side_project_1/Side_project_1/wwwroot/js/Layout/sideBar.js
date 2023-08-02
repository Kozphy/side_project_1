let personalInfoBtn = document.querySelector(".personalInfo");
let personalInfoContent = document.querySelector(".personalInfoSection");

showPersonalInfo();

function showPersonalInfo() {
    personalInfoBtn.addEventListener("click", function (e) {
        personalInfoContent.classList.toggle("show");
    });
}