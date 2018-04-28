// JS
// eslint-disable-next-line
import { toggleClass } from "./js/class";

window.onload = () => {
  var menuToggle = document.getElementById("menu-toggle");
  var menu = document.getElementById("menu");
  var menuOpen = false;
  function toggleMenu() {
    toggleClass(menu, "active-menu");
    menuOpen = !menuOpen;
    menu.setAttribute("aria-expanded", menuOpen);
  }
  menuToggle.addEventListener("click", e => {
    toggleMenu();
  });
  document.body.addEventListener(
    "click",
    e => {
      if (menuOpen && e.target !== menuToggle) {
        toggleMenu();
      }
    },
    true
  );
};

// CSS
require("./styles/main.scss");
