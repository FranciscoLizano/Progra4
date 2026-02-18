// COoKIEs: Almacena la informaion del navegador
// Ver 
var g_Dominio = "LocalHost";
var TLC = 60;
/*
MARCA: 
MODELO:
TRANSMISION


*/

function btnBAIC() {
    // se para por agumentos 
    // nombre, valor, {tiempo vida, path, domain}
    $.cookie('MARCA', 'BAIC', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('MODELO', 'BAIC', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('TRANSMISION', 'BAIC', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('VELOCIDAD', 'BAIC', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('KILOMETRAJE', 'BAIC', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('ESTADO', 'BAIC', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('ANIO', 'BAIC', { expires: TLC, path: '/', domain: g_Dominio });
}

function seleccionvehiculo() [
    // definimos el areglo que contiene loe objeto de parametros que vamos a enviar el cod bigjai
    var obj_Parametros_JS = new Array();

obj_Parametros_JS[0] = $.cookie('MARCA');
obj_Parametros_JS[0] = $.cookie('MODELO');
obj_Parametros_JS[0] = $.cookie('TRANSMISION');
obj_Parametros_JS[0] = $.cookie('VELOCIDAD');
obj_Parametros_JS[0] = $.cookie('MKILOMETRAJEARCA');
obj_Parametros_JS[0] = $.cookie('ESTADO');
obj_Parametros_JS[0] = $.cookie('ANIO');


var parametros = JSON.stringify({
    'obj_Parametros_JS': obj_Parametros_JS
});
jQuery.ajax({
    type: "POST",
    URL: "frmvehiculosHTML.aspx/seleccionvehiculo",
    data: parametros,
    contentType: 
})