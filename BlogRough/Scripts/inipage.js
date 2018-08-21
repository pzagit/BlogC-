$(document).ready(function () {
    $('#fullpage').fullpage({
        scrollBar: false,
        scrollingSpeed: 900,
        
    });
    new fullpage('#fullpage', {
        anchors: ['pic1', 'pic2', 'pic3']
    });
});