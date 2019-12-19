$(document).ready(function () {
    $(".myBtn").click(function () {
        $("body").css("background", "rgba(0,0,0,.4)");
        $(".myPopup").fadeIn();
    })
    $(".fa-times-circle").click(function () {
        $("body").css("background", "white");
        $(".myPopup").hide();
    })
    $(document).on('keyup', window, function(ev){
        if(ev.keyCode === 27){
            $("body").css("background", "white");
            $(".myPopup").hide();
        }
    })
});