$(document).ready(function () {

    $("#CheckAll").change(function () {
        $status = $("#CheckAll").checked;
       $('input[type="checkbox"]').prop("checked", "true");
    });
});