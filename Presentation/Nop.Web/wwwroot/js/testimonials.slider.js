$(function () {
    if (!$.fn || !$.fn.slick) return;

    $('.testimonials-slider').slick({
        centerMode: true,
        centerPadding: '80px',
        slidesToShow: 3,
        arrows: false,
        dots: true,
        autoplay: true,
        autoplaySpeed: 5000,
        responsive: [
            {
                breakpoint: 992,
                settings: {
                    slidesToShow: 1,
                    centerPadding: '40px'
                }
            },
            {
                breakpoint: 600,
                settings: {
                    slidesToShow: 1,
                    centerPadding: '20px'
                }
            }
        ]
    });
});