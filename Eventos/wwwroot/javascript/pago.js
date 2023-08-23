document.addEventListener("DOMContentLoaded", function () {
    


    var role = localStorage.getItem('rol');
    const myArray = role.split("@");
    var dominio = myArray[1];

    const dom = dominio;
    const admin = 'ola.admin.com';
    const soporte = 'ola.soporte.com'


    if (dom === admin || dom == soporte) {
        window.location.href = "../../Evento/Index";

    } else {
        if (window.location.href == "https://localhost:7193/Evento/Edit") {
            window.location.href = "../Metodo_pago/Create";
            console.log(window.location.href);
            console.log("redireccionar");
        } else {
            console.log(window.location);
        }
    }
});

function mostrarAlerta() {
    window.alert("Pago realizado correctamente!");
}