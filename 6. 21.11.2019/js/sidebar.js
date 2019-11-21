let openSidebar = document.querySelector(".openSidebar");
let close = document.querySelector(".close")

openSidebar.addEventListener("click", function(){
    document.body.classList.add("active");
})

close.addEventListener("click", function(){
    document.body.classList.remove("active");
})