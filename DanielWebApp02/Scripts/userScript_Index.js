$(document).ready(function () {
    function submitClick(e) {
        alert(daypicker.value());
    }

    $("#myDayPicker").kendoDatePicker();
    $("#submitButton").kendoButton({
        click: submitClick
    });

    var daypicker = $("#myDayPicker").data("kendoDatePicker");

});