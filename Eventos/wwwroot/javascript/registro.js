

document.addEventListener("DOMContentLoaded", function () {
    
    console.log("El script se cargó correctamente.");

});
function validarEmail(email) {

    console.log(email);
    const expresionRegular = /^(([^<>()[\]\.,;:\s@\"]+(\.[^<>()[\]\.,;:\s@\"]+)*)|(\".+\"))@(([^<>()[\]\.,;:\s@\"]+\.)+[^<>()[\]\.,;:\s@\"]{2,})$/i;


    return expresionRegular.test(email);

}

function validar() {
    const correo = document.getElementById("email").value;
    var result = validarEmail(correo);
    if (result == false) {
        document.getElementById("email").value = "";
        window.alert("Dirección email no es correcta");
    }

}

function validarContrasena(contrasena) {
  
    if (contrasena.length < 8) {
        return false;
    }



    const tieneMayuscula = /[A-Z]/.test(contrasena);
    const tieneMinuscula = /[a-z]/.test(contrasena);
    const tieneNumero = /[0-9]/.test(contrasena);

    return tieneMayuscula && tieneMinuscula && tieneNumero;
}

function validarcontra() {
    const correo = document.getElementById("contrasena").value;
    const correo2 = document.getElementById("contrasena2").value;
    var result = validarContrasena(correo);
    var result2 = validarContrasena(correo2);
    if (result == false || result2 ==false) {
        document.getElementById("contrasena").value = "";
        document.getElementById("contrasena2").value = "";
        window.alert("contraseña no cumple con los requerimientos");
    }
    if (correo != correo2) {
        document.getElementById("contrasena").value = "";
        document.getElementById("contrasena2").value = "";
        window.alert("contraseñas son diferentes");
    }

}
function mostrarcontrasena() {
    if (document.getElementById("contrasena").type == 'password') {
        document.getElementById("contrasena").setAttribute('type', 'text');
    } else {
        document.getElementById("contrasena").setAttribute('type', 'password');
    }
}

function mostrarcontrasena2() {
    if (document.getElementById("contrasena2").type == 'password') {
        document.getElementById("contrasena2").setAttribute('type', 'text');
    } else {
        document.getElementById("contrasena2").setAttribute('type', 'password');
    }
}