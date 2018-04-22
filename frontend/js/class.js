var removeClass = function (elem, className) {
    if (elem === null) {
        return;
    }
    elem.className = elem.className.replace(className, '')
}

var addClass = function (elem, className) {
    if (elem === null) {
        return;
    }
    if (elem.className.indexOf(className) < 0) {
        elem.className += className;
    }
}

var classExists = function (elem, className) {
    if (elem === null) {
        return null;
    }

    if (elem.className.indexOf(className) < 0) {
        return false;
    }

    return true;
}

export function toggleClass(elem, className) {
    var activeClassExists = classExists(elem, className);

    if (activeClassExists != null) {
        if (activeClassExists) {
            removeClass(elem, ' ' + className)
        } else {
            addClass(elem, ' ' + className)
        }
    }
}