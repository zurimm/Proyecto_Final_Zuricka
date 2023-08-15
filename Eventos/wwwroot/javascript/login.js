function validadom() {
    var correo = document.getElementById("emailprimer").value;
    if (correo.includes("ola.admin.com")) {
        console.log("funcionó");
        llamarCodigoCS(correo);
    }
    else if (correo.includes("ola.soport.com")) {
        console.log("funcionó");

    } else {
        console.log("redireccionando a interfaz ususarios");
    }
}
function llamarCodigoCS(email) {

    $.ajax({

        url: "/Control/AdministradorsController/test", // Ruta al método en el controlador
        type: "GET",
        dataType: "json",
        success: function (data) {
            // Manipular los datos recibidos del controlador
            console.log("Información del usuario:", data);
            // Hacer algo con los datos, como actualizar la vista
        },
        error: function (xhr, status, error) {
            console.error("Error en la solicitud:", error);
        }
    });

}