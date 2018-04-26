// JS
// eslint-disable-next-line
import { toggleClass } from "./js/class";

window.onload = function() {
  var menuToggle = document.getElementById("menu-toggle");
  var menu = document.getElementById("menu");
  var menuOpen = false;
  function toggleMenu() {
    toggleClass(menu, "active-menu");
    menuOpen = !menuOpen;
    menu.setAttribute("aria-expanded", menuOpen);
  }
  menuToggle.addEventListener("click", function() {
    toggleMenu();
  });
  document.body.addEventListener(
    "click",
    function() {
      if (menuOpen) {
        toggleMenu();
      }
    },
    true
  );
};

// CSS
require("./styles/main.scss");
