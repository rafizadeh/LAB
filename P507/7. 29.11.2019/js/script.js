// click edeceyimiz elementi gotururuk
let accList = document.querySelectorAll(".accordion .title");

for (let i = 0; i < accList.length; i++) {
    accList[i].addEventListener("click", function () {
        // scrollHeight property'sini arashdirin!
        console.log(this.nextElementSibling.scrollHeight);
        if (this.nextElementSibling.style.maxHeight == "") {
            this.nextElementSibling.style.maxHeight = this.nextElementSibling.scrollHeight + "px";
        } else {
            this.nextElementSibling.style.maxHeight = "";
        }
        // iconlari veziyyetlerine gore ayarlamaq uchun if sherti
        if (this.children[1].classList.contains("fa-angle-down")) {
            this.children[1].classList.replace("fa-angle-down", "fa-angle-up");
        } else {
            this.children[1].classList.replace("fa-angle-up", "fa-angle-down");
        }
    });
}