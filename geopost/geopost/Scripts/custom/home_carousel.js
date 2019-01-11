$("#HomeCarouselContainer").parent().css({ "width": "100%", "background": "none"});
var angleIndex = 360.0 / $("#HomeCarouselContainer").children("div").length * 2;
var translateIndex = 300;
var i = 0;
var hover = false;

animateCards(0, "Right");
animateCards(0, "Right");
animateCards(0, "Right");
animateCards(0, "Right");

    $(document).ready(function () {

        setInterval(function () {
            if(!hover){
                animateCards(1, "Right");
            }
        }, 4000);

        setTimeout(function() {
            $(".progress").children().animate(
            { width: "70%" },
            {
                easing: "swing",
                duration: "8s"
            });

            //.css({ "width": "50%" });

        }, 2000);
    });


    function animateCards(dur, direction) {
        if (direction === "Left") {
            i -= 2;
        }
        $("#HomeCarouselContainer").children("div").each(function () {
            var indexInc = parseInt($(this).data('id')) + i;
            
            var $elem = $(this);

            var angle = 360 + angleIndex * indexInc;
            var angleDeg = angle * Math.PI / 180;
            var marginLeft = (Math.sin(angleDeg) * translateIndex + translateIndex).toString() + "px";
            var marginTop = (Math.cos(angleDeg) * translateIndex / 5).toString() + "px";

            //$(".center").html(i);
            if ($(this).hasClass("back")) {
                angle += 180;
                $(this).animate({
                    position: "absolute"
                }, {
                    easing: 'swing',
                    duration: dur,
                    step: function() {
                        $elem.css({
                            transition: 'all 1s ease',
                            transform: 'rotateY(' + angle + 'deg)',
                            marginLeft: marginLeft,
                            marginTop: marginTop,
                            zIndex: 1,
                            borderColor: $(this).data('theme-color'),
                            opacity: 0.4
                        });
                    }
                });
            } else {
                $(this).animate({
                    position: "absolute"
                }, {
                    easing: 'swing',
                    duration: dur,
                    step: function () {
                        $elem.css({
                            transition: 'all 1s ease',
                            transform: 'rotateY(' + angle + 'deg)',
                            marginLeft: marginLeft,
                            marginTop: marginTop,
                            borderColor: $(this).data('theme-color'),
                            zIndex: 5
                        });
                    }
                });
            }
        });
        i++;
    }

    $('div.front').mouseenter(function () {
        hover = true;
        $(this).css({ "box-shadow": "0px 0px 100px " + $(this).data('theme-color') });
    });

    $("div.front").mouseleave(function () {
        hover = false;
        $(this).css({ "box-shadow": "none" });
    });

    $('img.arrow').mouseenter(function () {
        $(this).css({ "box-shadow": "0px 0px 100px #ff0000", "opacity": "1.0" });
        hover = true;
    });

    $("img.arrow").mouseleave(function () {
        $(this).css({ "box-shadow": "none", "opacity": "0.7" });
        hover = false;
    });

    $(".progress").mouseenter(function () {
        $(this).css({ "box-shadow": "0px 0px 5px #ffffff" });
    });

    $(".progress").mouseleave(function () {
        $(this).css({ "box-shadow": "none" });
    });

    function cardClick(id) {
        alert(id);
    }