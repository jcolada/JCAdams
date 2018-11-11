var theContainer = document.getElementById("myContainer");
var theThing = document.getElementById("thing");


theContainer.addEventListener("click", getClickPosition, false);

function getClickPosition(e) {
    var parentPosition = getPosition(theContainer);
    var xPosition = e.clientX - parentPosition.x - (theThing.offsetWidth / 2);
    var yPostiion = e.clientY - parentPosition.y - (theThing.offsetHeight / 2);

    var translated3dValue = "translate3d(" + xPosition + "px," + yPostiion + "px, 0)";
    theThing.style.transform = translated3dValue;
}

function getPosition(element) {
    var xPosition = 0;
    var yPosition = 0;

    while (element) {
        xPosition += (element.offsetLeft - element.scrollLeft + element.clientLeft);
        yPosition += (element.offsetTop - element.scrollTop + element.clientTop);
        element = element.offsetParent;
    }
    return {
        x: xPosition,
        y: yPosition
    };
}