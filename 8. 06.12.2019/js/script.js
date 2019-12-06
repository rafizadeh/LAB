let dragged = document.querySelector(".dragArea");
let dropped = document.querySelector(".dropArea");

dragged.ondragstart = function (ev) {
    ev.dataTransfer.setData("text", this.id);
}
dropped.ondragover = e => e.preventDefault();

dropped.ondrop = function (e) {
    let id = e.dataTransfer.getData("text");
    let element = document.getElementById(id);

    element.style.marginTop = e.offsetY - element.offsetHeight / 2 + "px";
    element.style.marginLeft = e.offsetX - element.offsetWidth / 2 + "px";

    // elementi sola soykeyir
    if (e.offsetX < element.offsetWidth / 2)
    {
        element.style.marginLeft = 0 + "px";
    }
 // elementi yuxari soykeyir
    if (e.offsetY < element.offsetHeight / 2)
    {
        element.style.marginTop = 0 + "px";
    }
  // elementi saga soykeyir
    if(e.offsetX > this.offsetWidth - element.offsetWidth)
    {
        element.style.marginLeft = this.offsetWidth - element.offsetWidth  + "px";
    }
      // elementi ashagiya soykeyir
    if(e.offsetY > this.offsetHeight - element.offsetHeight)
    {
        element.style.marginTop = this.offsetHeight - element.offsetHeight  + "px";
    }
    this.append(element);
}