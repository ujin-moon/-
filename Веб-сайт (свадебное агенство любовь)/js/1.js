function leftright1() {
    $("div").animate({right:"300px"},500)
    $("button").on(click,leftright2())
}
function leftright2() {
    $("div").animate({ right: "0px" }, 500);
    $("button").on(click,leftright1())
}