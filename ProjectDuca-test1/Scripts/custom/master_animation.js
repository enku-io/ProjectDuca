$(document).ready(function () {
    var isExpanded = false;
    var firstTime = true;
    $("#duca_icon").click(function () {
        if (isExpanded) {
            $("nav").removeClass("animate_out");
            $("nav").addClass("animate_in");
            isExpanded = false;
        } else {
            if (!firstTime) {
                $("nav").removeClass("animate_in");
            }
            $("nav").addClass("animate_out");
            isExpanded = true;
            firstTime = false;
        }
    });
});