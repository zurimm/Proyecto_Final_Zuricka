document.addEventListener("DOMContentLoaded", function () {
    console.log(window.location.href);

    if (window.location.href == "https://localhost:7193/Home/Validate") {
        window.location.href = "../Soporte/Create";
        console.log(window.location.href);
        console.log("redireccionar");


    } else {
        console.log(window.location);
    }
});

function mostrarBotones() {
    var x = document.getElementById("botones");
    if (x.style.display === "none") {
        document.getElementById("botonOpciones").innerHTML = "Ocultar opciones";

        x.style.display = "block";
    } else {
        document.getElementById("botonOpciones").innerHTML = "Mostrar Opciones";
        x.style.display = "none";
    }
}

