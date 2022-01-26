// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.


// Write your JavaScript code.
$(document).ready(function () {
    //date-picker
    $('input[data-date-picker="true"').datepicker({
        dateFormat: "dd.mm.yy",
        changemonth: true,
        changeyear: true
    });


    //cookie button
    var button = document.querySelector("#cookieConsent button[data-cookie-string]");
    button.addEventListener("click", function (event) {
        document.cookie = button.dataset.cookieString;
    }, false);




});