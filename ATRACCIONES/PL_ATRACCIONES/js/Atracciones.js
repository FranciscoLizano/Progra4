//Dominio que se asocia a las cookies
var g_Dominio = "localhost";

//Tiempo de vida de las cookies en el navedador dado en días
var TLC = 60; 

function btnCaballitos() {
    //Crear las cookies con la información de la atraccion seleccionada
    //(nombre, valor, {tiempo vida, path, domain})
    $.cookie('Nombre', 'Caballitos', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Tipo', 'Carresul', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Capacidad', '30', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Duracion', '3', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Disponibilidad', 'true', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Horario', 'K-D 9:00 AM-5:00 PM', { expires: TLC, path: '/', domain: g_Dominio });

    SeleccionAtraccion();
}
function btnChocones() {
    //Crear las cookies con la información de la atraccion seleccionada
    //(nombre, valor, {tiempo vida, path, domain})
    $.cookie('Nombre', 'Los Chocadores', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Tipo', 'Carros chocones', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Capacidad', '30', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Duracion', '3', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Disponibilidad', 'true', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Horario', 'K-D 9:00 AM-5:00 PM', { expires: TLC, path: '/', domain: g_Dominio });

    SeleccionAtraccion();
}
function btnAbismo() {
    //Crear las cookies con la información de la atraccion seleccionada
    //(nombre, valor, {tiempo vida, path, domain})
    $.cookie('Nombre', 'Al abismo', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Tipo', 'Torre', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Capacidad', '10', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Duracion', '1', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Disponibilidad', 'true', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Horario', 'K-D 9:00 AM-5:00 PM', { expires: TLC, path: '/', domain: g_Dominio });

    SeleccionAtraccion();
}
function btnSerpiente() {
    //Crear las cookies con la información de la atraccion seleccionada
    //(nombre, valor, {tiempo vida, path, domain})
    $.cookie('Nombre', 'Serpiente', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Tipo', 'Montaña rusa', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Capacidad', '15', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Duracion', '4', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Disponibilidad', 'false', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Horario', 'K-D 9:00 AM-5:00 PM', { expires: TLC, path: '/', domain: g_Dominio });

    SeleccionAtraccion();
}
function btnGiros() {
    //Crear las cookies con la información de la atraccion seleccionada
    //(nombre, valor, {tiempo vida, path, domain})
    $.cookie('Nombre', 'Los giros', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Tipo', 'Rueda de chicago', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Capacidad', '40', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Duracion', '5', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Disponibilidad', 'true', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Horario', 'K-D 9:00 AM-5:00 PM', { expires: TLC, path: '/', domain: g_Dominio });

    SeleccionAtraccion();
}
function btnSillas() {
    //Crear las cookies con la información de la atraccion seleccionada
    //(nombre, valor, {tiempo vida, path, domain})
    $.cookie('Nombre', 'Sillas voladoras', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Tipo', 'Carresul', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Capacidad', '40', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Duracion', '5', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Disponibilidad', 'true', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Horario', 'K-D 9:00 AM-5:00 PM', { expires: TLC, path: '/', domain: g_Dominio });

    SeleccionAtraccion();
}
function btnSky() {
    //Crear las cookies con la información de la atraccion seleccionada
    //(nombre, valor, {tiempo vida, path, domain})
    $.cookie('Nombre', 'Sky Master', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Tipo', 'Rueda de chicago', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Capacidad', '10', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Duracion', '3', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Disponibilidad', 'true', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Horario', 'K-D 9:00 AM-5:00 PM', { expires: TLC, path: '/', domain: g_Dominio });

    SeleccionAtraccion();
}
function btnStar() {
    //Crear las cookies con la información de la atraccion seleccionada
    //(nombre, valor, {tiempo vida, path, domain})
    $.cookie('Nombre', 'Star Flyer', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Tipo', 'Torre', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Capacidad', '15', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Duracion', '2', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Disponibilidad', 'true', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Horario', 'K-D 9:00 AM-5:00 PM', { expires: TLC, path: '/', domain: g_Dominio });

    SeleccionAtraccion();
}
function btnTarantula() {
    //Crear las cookies con la información de la atraccion seleccionada
    //(nombre, valor, {tiempo vida, path, domain})
    $.cookie('Nombre', 'Tarántula', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Tipo', 'Montaña rusa', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Capacidad', '25', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Duracion', '5', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Disponibilidad', 'true', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Horario', 'K-D 9:00 AM-5:00 PM', { expires: TLC, path: '/', domain: g_Dominio });

    SeleccionAtraccion();
}
function btnTornado() {
    //Crear las cookies con la información de la atraccion seleccionada
    //(nombre, valor, {tiempo vida, path, domain})
    $.cookie('Nombre', 'Tornado', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Tipo', 'Montaña rusa', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Capacidad', '20', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Duracion', '4', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Disponibilidad', 'false', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Horario', 'K-D 9:00 AM-5:00 PM', { expires: TLC, path: '/', domain: g_Dominio });

    SeleccionAtraccion();
}

function SeleccionAtraccion() {
    //Se define el arreglo que contiene los valores del objeto de parámetros 
    //que se le envian al code behind
    var obj_Parametros_JS = new Array();

    //Se definen los valores de la posición del arreglo
    obj_Parametros_JS[0] = $.cookie('Nombre'); //Se extran los valor de cada cookie
    obj_Parametros_JS[1] = $.cookie('Tipo');
    obj_Parametros_JS[2] = $.cookie('Capacidad');
    obj_Parametros_JS[3] = $.cookie('Duracion');
    obj_Parametros_JS[4] = $.cookie('Disponibilidad');
    obj_Parametros_JS[5] = $.cookie('Horario');

    //Se crea la estructura de los parámetros en formato JSON
    var parametros = JSON.stringify({ 'obj_Parametros_JS': obj_Parametros_JS });

    //El métodos AJAX de JQUERY para invocar o consumir el code behind del formulario (WEB METHOD)
    //Se le indica cual va a ser el nombre del web method que vamos a ejecutar en el code behind
    jQuery.ajax({
        type: "POST",
        url: "frmAtracciones.aspx/seleccionarAtraccion", //representa la ruta en donde está el web method a ejecutar
        data: parametros,
        contentType: "application/json; chartset=utf-8",
        dataType: "json",
        cache: false,
        success: function (msg) {
            var res = msg.d;

            if (res === undefined) {
                alert('Ocurrió un error al intentar seleccionar la Atracción');
            }
            else {
                if ((res != '') && (res != undefined)) {
                    $("#divTablaInfoAtracciones").html(res);

                    Swal.fire({
                        position: 'center-center',
                        icon: 'success',
                        title: "Atracción",
                        text: "La atraccion fue seleccionada",
                        showConfirmButton: false,
                        timer: 2500,
                        timerProgressBar: true
                    });
                }
                else {
                    $("#divTablaInfoAtracciones").html("");
                }
            }

        },
        failure: function (msg) {

        },
        error: function (msg) {

        }
    })
}