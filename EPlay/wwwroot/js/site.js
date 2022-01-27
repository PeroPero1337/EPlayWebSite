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

    var game = $('#selectGame');
    var proview = $('#EplayProView');

    $('#selectGame option[value=3]').attr('selected', 'selected');
    proview.attr("href", "https://probuildstats.com/");

    game.on('change', function () {
        if (this.value == 1)
            proview.attr("href", "https://www.hltv.org/");
        else if (this.value == 2)
            proview.attr("href", "https://www.hltv.org/");
        else if (this.value == 3)
            proview.attr("href", "https://probuildstats.com/");
    });


    //cookie button
    var button = document.querySelector("#cookieConsent button[data-cookie-string]");
    button.addEventListener("click", function (event) {
        document.cookie = button.dataset.cookieString;
    }, false);

    try {
        function updateScroll() {
            var element = document.getElementById("scroller");
            element.scrollTop = element.scrollHeight;
        }

        updateScroll();
    }
    catch (ex) {
        console.log(ex);
    }

    

});