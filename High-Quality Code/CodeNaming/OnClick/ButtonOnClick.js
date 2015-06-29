//Refactor the following examples to produce code with well-named identifiers in JavaScript
//Task3
function buttonOnClick () {
    var myWindow, browser, isMozilla;
    myWindow = window;
    browser = myWindow.navigator.appCodeName;
    isMozilla = browser === "Mozilla";
    if (isMozilla) {
        alert("Yes");
    }else {
        alert("No");
    }
}