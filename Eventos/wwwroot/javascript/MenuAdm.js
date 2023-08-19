

function mostrarBotones() {
    var x = document.getElementById("botones");
    if (x.style.display === "none") {
        document.getElementById("botonOpciones").innerHTML = "Ocultar opciones";
        document.getElementById("tablaAdm").style.marginTop = "9%";
        x.style.display = "block";
    } else {
        document.getElementById("botonOpciones").innerHTML = "Mostrar Opciones";
        x.style.display = "none";
        document.getElementById("tablaAdm").style.marginTop = "2%";
    }
}

