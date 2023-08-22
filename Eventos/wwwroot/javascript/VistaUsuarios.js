document.addEventListener("DOMContentLoaded", function () {

    var role = localStorage.getItem('rol');
    const myArray = role.split("@");
    var dominio = myArray[1];
    vistUsuario(dominio);

});

function vistUsuario(dominio) {
    console.log(dominio);
    const dom = dominio;
    const admin = 'ola.admin.com';
    const soporte = 'ola.soporte.com'

    if (dom === admin || dom == soporte) {
        document.getElementById("TablaEvento").style.display = "block";
        document.getElementById("ParaUsuario").style.display = "none";
    } else {
        document.getElementById("TablaEvento").style.display = "none";
    }
}
