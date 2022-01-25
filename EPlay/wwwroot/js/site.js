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


    // articles
    //var article1 = $('<div/>')
    //    .attr('class', 'articles')
    //    .attr('id',1);
    //var article2 = $('<div/>')
    //    .attr('class', 'articles')
    //    .attr('id', 2);
    //var article3 = $('<div/>')
    //    .attr('class', 'articles')
    //    .attr('id', 3);
    //var article4 = $('<div/>')
    //    .attr('class', 'articles')
    //    .attr('id', 4);
    //var article5 = $('<div/>')
    //    .attr('class', 'articles')
    //    .attr('id', 5);

    //var img1 = $('<img/>')
    //    .attr('src', "/sign up right now_2.png");
    //var img2 = $('<img/>')
    //    .attr('src', "/2022_season_rewards_1_1600x900.png");
    //var img3 = $('<img/>')
    //    .attr('src', "/S1mple-CS-GO.jpeg");
    //var img4 = $('<img/>')
    //    .attr('src', "/20210829_Helena-Kristiansson_ESL-One-Fall_00874.jpg");
    //var img5 = $('<img/>')
    //    .attr('src', "/20191026_Bart-Oerbekke_ESL-ONE_Hamburg_25526.jpg");

    //var lbl1 = $('<label/>')
    //    .text("At the end of November we will get things rolling again with ESL PUBG Open as we have the qualifiers for Open: Winter starting November 22nd! The full tournament will take place in the first two weekends of December to round off the year of ESL PUBG and once again there is $2,000 up for grabs!");
    //var lbl2 = $('<label/>')
    //    .text("LoL Esports 2022 Season Rewards and Drops Update!");
    //var lbl3 = $('<label/>')
    //    .text("Simple wins his first Major and becomes the #1 CSGO Pro Player");
    //var lbl4 = $('<label/>')
    //    .text("ESL One Fall: Bootcamp Edition has come to a close! Over the course of the past couple of weeks we’ve seen some fantastic Dota and some serious upsets, with Tundra Esports being crowned Champions!");
    //var lbl5 = $('<label/>')
    //    .text("Twelve teams will be competing for a $400,000 prize pool in ESL One Fall: Bootcamp Edition, coming your way next month!");


    //article1.append(img1,lbl1);
    //article2.append(img2,lbl2);
    //article3.append(img3,lbl3);
    //article4.append(img4,lbl4);
    //article5.append(img5,lbl5);


    //$('.content-primary').append(article1,article2,article3,article4,article5);


});