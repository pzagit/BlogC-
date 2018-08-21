$(document).ready(function () {
    // hide .navbar first
    $(".navbar").hide();
    // fade in .navbar
    $(function () {
        $(window).scroll(function () {

            // set distance user needs to scroll before we start fadeIn
            if ($(this).scrollTop() > 50) {
                $('.navbar').fadeIn();
                $('.intro').fadeIn();
            } else {
                $('.navbar').fadeOut();
                $('.intro').fadeOut();
            }
        });
    });
});