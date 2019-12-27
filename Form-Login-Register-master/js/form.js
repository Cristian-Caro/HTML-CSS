/*(function(){
    $(document).ready(function(){
        $('.alt-form').click(function(){
            $('.form-content').animate({
                height: "toggle",
                opacity: 'toggle'
            }, 600);
        });

        let formRegistro = document.getElementsByName('form-input');
        for (let i = 0; i < formRegistro.length; i++) {
            formRegistro[i].addEventListener('blur', function(){
                if (this.value.length >= 1) {
                    //alert("Logueado...!!");
                    this.nextElementSibling.classList.add('active');
                    this.nextElementSibling.classList.remove('error');
                } else if (this.value.length = "") {
                    //alert("Debe llenar los campos...!!");
                    this.nextElementSibling.classList.add('error');
                    this.nextElementSibling.classList.remove('active');
                } else {
                    //alert("Los campos deben ser llenados...!!");
                    this.nextElementSibling.classList.remove('active');
                }
            })
        }

    })
}())*/
function mail(email){

    var mailres = true;            
    var cadena = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ1234567890@._-";
    
    var arroba = document.formulario.email.indexOf("@",0);
    if ((document.formulario.email.lastIndexOf("@")) != arroba) arroba = -1;
    
    var punto = document.formulario.email.lastIndexOf(".");
                
     for (var contador = 0 ; contador < texto.length ; contador++){
        if (cadena.indexOf(texto.substr(contador, 1),0) == -1){
            mailres = false;
            break;
     }
    }

    if ((arroba > 1) && (arroba + 1 < punto) && (punto + 1 < (document.formulario.email.length)) && (mailres == true) && (document.formulario.email.indexOf("..",0) == -1))
     mailres = true;
    else
     mailres = false;                
    return mailres;

}
function validar(){
    var usuario, clave1, clave2;
    usuario= document.getElementById('correo').value;
    clave1= document.getElementById('pass').value;

    if(usuario===""||clave1===""){
        alert("Debe ingresar usuario y contraseña...!");
        return false;
    }
}