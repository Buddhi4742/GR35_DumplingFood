// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


// References to DOM Elements

/// Display container which has active class
var id = $('.tab-section .active').attr('id');
$('.cmcontainer').hide();
$('.cmcontainer#' + id + 'C').show();

//// Change the tab when user clicks
$('.tab-section a').click(function () {
	// console.log(this.id);
	if (!$(this).hasClass('active')) {
		// $('.container').hide();

		$('.tab-section a').removeClass('active');
		$(this).addClass('active');
		$('.cmcontainer').hide();
		$('.cmcontainer#' + this.id + 'C').show();
	}
});

           

var front = document.querySelector('.face-front');
var back = document.querySelector('.face-back');
var flip = document.querySelector('.book-content');
var uno = document.querySelectorAll('.book');
var portada = document.querySelectorAll('#portada');

var contZindex = 2;
var customZindex = 1;

for (var i = 0; i < uno.length; i++) {
	uno[i].style.zIndex = customZindex;
	customZindex--;

	uno[i].addEventListener('click', function (e) {

		var tgt = e.target;
		var unoThis = this;

		unoThis.style.zIndex = contZindex;
		contZindex++;

		if (tgt.getAttribute('class') == 'face-front') {
			unoThis.style.zIndex = contZindex;
			contZindex += 20;
			setTimeout(function () {
				unoThis.style.transform = 'rotateY(-180deg)';
			}, 500);
		}
		if (tgt.getAttribute("class") == 'face-back') {
			unoThis.style.zIndex = contZindex;
			contZindex += 20;

			setTimeout(function () {
				unoThis.style.transform = 'rotateY(0deg)';
			}, 500);
		}

		if (tgt.getAttribute('id') == 'portada') {
			flip.classList.remove("trnsf-reset");
			flip.classList.add("trnsf");
		}
		if (tgt.getAttribute('id') == 'trsf') {
			flip.classList.remove("trnsf");
			flip.classList.add("trnsf-reset");
		}

	});
}

/*modal box*/



// Get the modal
var modl = document.getElementById("myMdl");

// Get the button that opens the modal
var btn = document.getElementById("mybtn");

// Get the <span> element that closes the modal
var span = document.getElementsByClassName("close")[0];

// When the user clicks the button, open the modal
btn.onclick = function () {
	modl.style.display = "block";
}

// When the user clicks on <span> (x), close the modal
span.onclick = function () {
	modl.style.display = "none";
}

// When the user clicks anywhere outside of the modal, close it
window.onclick = function (event) {
	if (event.target == modl) {
		modl.style.display = "none";
	}
}


//cart 
$(function () {
	$('#addi').click(function () {
		$('.brmodal').addClass('open');

		if ($('.brmodal').hasClass('open')) {
			$('.ctcontainer').addClass('blur');
		}
	});

	$('.close').click(function () {
		$('.brmodal').removeClass('open');
		$('.ctcontainer').removeClass('blur');
	});
});

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

