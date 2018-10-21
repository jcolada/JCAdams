var divTPG = document.getElementById("dbtnTPG");
var divKES = document.getElementById("dbtnKES");
var divSW = document.getElementById("dbtnSW");

var textTPG = document.getElementById("workTPG");
var textKES = document.getElementById("workKES");
var textSW = document.getElementById("workSW");


divTPG.onclick = function() {
    textTPG.style.display = 'block';
    textKES.style.display = 'none';
    textSW.style.display = 'none';
    divTPG.classList = 'row padding border border-primary'
    divKES.classList = 'row padding border border-secondary'
    divSW.classList = 'row padding border border-secondary'
};

divKES.onclick = function() {
    textTPG.style.display = 'none';
    textKES.style.display = 'block';
    textSW.style.display = 'none';
    divTPG.classList = 'row padding border border-secondary'
    divKES.classList = 'row padding border border-primary'
    divSW.classList = 'row padding border border-secondary'
};

divSW.onclick = function() {
    textTPG.style.display = 'none';
    textKES.style.display = 'none';
    textSW.style.display = 'block';
    divTPG.classList = 'row padding border border-secondary'
    divKES.classList = 'row padding border border-secondary'
    divSW.classList = 'row padding border border-primary'
};