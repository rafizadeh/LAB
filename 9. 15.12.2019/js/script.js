$(document).ready(function(){
    $(".drop_home_menu").hide();

    $(".dropdown").mouseenter(function(){
        $(".drop_home_menu").removeClass("d-none")
        $(".drop_home_menu").slideDown(500);
    })

    $(".dropdown").mouseleave(function(){
        if($('.drop_home_menu').is(':hover') === false){
            $(".drop_home_menu").slideUp(500);
        }
        $(".drop_home_menu").slideUp(500);
    })


});

// $(".search-cart-sum").mouseleave(function(){
//     if($('.cart-dropdown').is(':hover') === false){
//         $(".cart-dropdown").slideUp(100);
//     }  
// });