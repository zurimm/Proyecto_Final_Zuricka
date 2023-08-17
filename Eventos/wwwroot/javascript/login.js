document.addEventListener("DOMContentLoaded", function () {
    console.log(window.location.href);

    if (window.location.href == "https://localhost:7193") {
        window.location.href = "../Home/Index";
        console.log(window.location.href);
        console.log("redireccionar");

        window.alert("Ha ocurrido un problema, por favor intente de nuevo");

    } else {
        console.log(window.location);
    }
});


