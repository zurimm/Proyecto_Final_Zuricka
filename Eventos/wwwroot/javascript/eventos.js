document.addEventListener("DOMContentLoaded", function () {

    if (window.location.href == "https://localhost:7193/Home/Validate") {
        window.location.href = "../Evento/Create";
        console.log(window.location.href);
        console.log("redireccionar");
    } else {
        console.log(window.location);
    }
});