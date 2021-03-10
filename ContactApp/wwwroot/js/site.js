// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function ShowHideDiv() {
    var element = document.getElementById("category");
    var selectedValue = element.options[element.selectedIndex].text;

    var textBox = document.getElementById("other");
    var selectlist = document.getElementById("business");

    if (selectedValue == "Other") {
        textBox.style.display = "";
    }
    else {
        textBox.style.display = "none";
    }

    if (selectedValue == "Business") {
        selectlist.style.display = "";
    }
    else {
        selectlist.style.display = "none";
    }
}