// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
$('.controls .buttons').click(function () {

    $(this).addClass('button-active').siblings().removeClass('button-active');

    let filter = $(this).attr('data-filter');
    if (filter == 'all') {
        $('.dishf .image').show(400);
    } else {
        $('.dishf .image').not('.' + filter).hide(200);
        $('.dishf .image').filter('.' + filter).show(400);
    }s

});

});