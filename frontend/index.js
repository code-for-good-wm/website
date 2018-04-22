// JS
// eslint-disable-next-line
import { toggleClass } from "./js/class";

window.onload = function() {
    var menuToggle = document.getElementById("menu-toggle")
    var menu = document.getElementById("menu")
    menuToggle.addEventListener("click", function(){
        toggleClass(menu, "active-menu");
    });
}

// CSS
require("./styles/main.scss");