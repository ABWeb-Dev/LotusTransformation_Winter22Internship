$(function () {

    $(window).on('resize', function () {

        $('.navbar').css("right", $(window).width() * .125);

    });
});