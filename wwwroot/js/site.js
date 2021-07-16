// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.



!(function ($) {
	"use strict";
	// Activate smooth scroll on page load with hash links in the url
	$(document).ready(function () {
		if (window.location.hash) {
			var initial_nav = window.location.hash;
			if ($(initial_nav).length) {
				var scrollto = $(initial_nav).offset().top - scrolltoOffset;
				$('html, body').animate({
					scrollTop: scrollto
				}, 1500, 'easeInOutExpo');
			}
		}
	});


	// Toggle .header-scrolled class to #header when page is scrolled
	$(window).scroll(function () {
		if ($(this).scrollTop() > 100) {
			$('#header').addClass('header-scrolled');
			$('#topbar').addClass('topbar-scrolled');
		} else {
			$('#header').removeClass('header-scrolled');
			$('#topbar').removeClass('topbar-scrolled');
		}
	});

	if ($(window).scrollTop() > 100) {
		$('#header').addClass('header-scrolled');
		$('#topbar').addClass('topbar-scrolled');
	}

	// Real view height for mobile devices
	if (window.matchMedia("(max-width: 767px)").matches) {
		$('#hero').css({
			height: $(window).height()
		});
	}


	// Back to top button
	$(window).scroll(function () {
		if ($(this).scrollTop() > 100) {
			$('.back-to-top').fadeIn('slow');
		} else {
			$('.back-to-top').fadeOut('slow');
		}
	});

	$('.back-to-top').click(function () {
		$('html, body').animate({
			scrollTop: 0
		}, 1500, 'easeInOutExpo');
		return false;
	});

	// Menu list isotope and filter
	$(window).on('load', function () {
		var menuIsotope = $('.menu-container').isotope({
			itemSelector: '.menu-item',
			layoutMode: 'fitRows'
		});

		$('#menu-flters li').on('click', function () {
			$("#menu-flters li").removeClass('filter-active');
			$(this).addClass('filter-active');

			menuIsotope.isotope({
				filter: $(this).data('filter')
			});
		});
	});

	// Testimonials carousel (uses the Owl Carousel library)
	$(".events-carousel").owlCarousel({
		autoplay: true,
		dots: true,
		loop: true,
		items: 1
	});

	// Testimonials carousel (uses the Owl Carousel library)
	$(".testimonials-carousel").owlCarousel({
		autoplay: true,
		dots: true,
		loop: true,
		items: 1
	});

	// Initiate venobox lightbox
	$(document).ready(function () {
		$('.venobox').venobox();
	});

})(jQuery);

