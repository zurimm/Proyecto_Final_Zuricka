document.addEventListener("DOMContentLoaded", function () {

    var role = localStorage.getItem('rol');
    const myArray = role.split("@");
    var dominio = myArray[1];
    vistUsuario(dominio);

    var img = localStorage.getItem('image');
    console.log(img);

    var div = document.getElementById("imageEvento");


    div.innerHTML += ' <a href="single-post.html"><img style="max-width: 50%;" src="../../assetsUsuario/img/' + img  +'_.jpg" alt="" class="img-fluid"></a>';
});

function vistUsuario(dominio) {
    console.log(dominio);
    const dom = dominio;
    const admin = 'ola.admin.com';
    const soporte = 'ola.soporte.com'

    if (dom === admin || dom == soporte) {
        document.getElementById("admin").style.display = "block";
        document.getElementById("usuario").style.display = "none";
    } else {
        document.getElementById("admin").style.display = "none";
    }
}

