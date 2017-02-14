$(document).ready(function () {
    function submitClick(e) {
        alert("I was clicked");
    }

    $("#myDayPicker").kendoDatePicker();
    $("#submitButton").kendoButton({
        click: submitClick
    });
});