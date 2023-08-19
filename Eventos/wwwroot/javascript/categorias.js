document.addEventListener("DOMContentLoaded", function () {

    if (window.location.href == "https://localhost:7193/Evento/Create") {
        window.location.href = "../cat_evento/Create";
        console.log(window.location.href);
        console.log("redireccionar");
    } else {
        console.log(window.location);
    }
});