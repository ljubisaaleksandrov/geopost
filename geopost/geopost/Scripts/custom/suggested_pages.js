var ActionReadLater = "read-later";
var ActionPageLike = "page-like";

var adjustWidth = function () {
    if (typeof $(".page-sidebar") !== "undefined" && typeof $(".page-sidebar").offset() !== "undefined") {
        var suggestedPages = $(".suggested-post-pages");
        $(suggestedPages).insertAfter(".page-social-shaing");

        var mainContentdistanceRight = $(window).width() - $(".page-sidebar").offset().left - 10;

        if (mainContentdistanceRight > 350) {
            $(suggestedPages).width(mainContentdistanceRight);

            var maxSidebarTop = $(".page-sidebar").offset().top + $(".page-sidebar").height();
            var maxSocialShare = $(".page-social-shaing").offset().top + $(".page-social-shaing").height();

            var maxTop = maxSidebarTop > maxSocialShare ? maxSidebarTop : maxSocialShare;
            $(suggestedPages).css({ "bottom": 50 });
            //$(suggestedPages).css({ "top": (maxTop + 30) });

            $.each($(suggestedPages).children(), function (index, element) {

                var delay = (20 + index * 0.5) * 1000;
                setTimeout(function () {
                    $(element).css({ "right": -mainContentdistanceRight });
                    $(element).show('slide', { direction: 'right' }, 500);
                }, delay);

            });
        }
        else {
            //$.each($(suggestedPages).children(), function (index, element) {

            //    var delay = (1 + index * 0.5) * 1000;
            //    setTimeout(function () {
            //        $(element).css({ "left": -mainContentdistanceRight });
            //        $(element).show('slide', { direction: 'left' }, 500);
            //    }, delay);
            //});
        }
    }
};

$(document).on('mouseover', '.suggested-page-btn', function (event) {
});

$(document).on('click', '.suggested-page-btn', function (event) {
    var currentState = $(this).data("current-state");
    var action = $(this).data("action-type");
    var imgSrc;

    if (typeof action !== "undefined") {
        event.stopPropagation();
        if (currentState) {
            imgSrc = $(this).data("img-true-src");
        }
        else {
            imgSrc = $(this).data("img-false-src");
        }

        if (action === ActionReadLater) {
            var currentCount = parseInt($(".navbar-read-later-notification").text());
            currentCount = currentCount + (currentState ? 1 : -1);
            $(".navbar-read-later-notification").text(currentCount);
        }
    }

    $(this).children('img').attr("src", imgSrc);
    $(this).data("current-state", !currentState);
});



$(document).ready(function (event) {
    adjustWidth();
});

$(window).resize(function () {
    adjustWidth();
});