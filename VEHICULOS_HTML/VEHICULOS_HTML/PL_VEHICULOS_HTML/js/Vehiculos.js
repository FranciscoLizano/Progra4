//COOKIES: Almacenamiento de información del navegador
//WEB METHODS: Invocar - Comsumir web methods que están en el code behind del formulario (lado servidor)

var g_Dominio = "localhost"; //Dominio asociado a las cookies
var TLC = 60; //Tiempo de vida que van a tener las cookies en el navegador

/*
MARCA: CONTROLA EL VALOR DE LA MARCA DEL VEHICULO
MODELO: CONTROLA EL VALOR DEL MODELO DEL VEHICULO
TRANSMISION: CONTROLA EL VALOR DE LA TRANSMISION DEL VEHICULO
VELOCIDAD: CONTROLA EL VALOR DE LA VELOCIDAD DEL VEHICULO
KILOMETRAJE: CONTROLA EL VALOR DEL KILOMETRAJE DEL VEHICULO
ESTADO: CONTROLA EL VALOR DEL ESTADO DEL VEHICULO
AÑO: CONTROLA EL VALOR DEL AÑO DEL VEHICULO
*/

function btnBAIC() {
    //Crear las cookies con la información del vehículo seleccionado
    //(nombre, valor, {tiempo vida, path, domain})
    $.cookie('MARCA', 'BAIC', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('MODELO', 'BJ40', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('TRANSMISION', 'True', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('VELOCIDAD', '0', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('KILOMETRAJE', '0', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('ESTADO', 'False', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('ANIO', '2025', { expires: TLC, path: '/', domain: g_Dominio });

    seleccionVehiculo();
}

function btnTigo() {
    //Crear las cookies con la información del vehículo seleccionado
    //(nombre, valor, {tiempo vida, path, domain})
    $.cookie('MARCA', 'Chery', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('MODELO', 'TIGGO 4 PRO', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('TRANSMISION', 'true', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('VELOCIDAD', '0', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('KILOMETRAJE', '0', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('ESTADO', 'False', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('ANIO', '2025', { expires: TLC, path: '/', domain: g_Dominio });

    seleccionVehiculo();
}

function btnSPARK() {
    //Crear las cookies con la información del vehículo seleccionado
    //(nombre, valor, {tiempo vida, path, domain})
    $.cookie('MARCA', 'Chevrolet', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('MODELO', 'SPARK', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('TRANSMISION', 'true', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('VELOCIDAD', '0', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('KILOMETRAJE', '0', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('ESTADO', 'False', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('ANIO', '2023', { expires: TLC, path: '/', domain: g_Dominio });

    seleccionVehiculo();
}

function btnHilux() {
    //Crear las cookies con la información del vehículo seleccionado
    //(nombre, valor, {tiempo vida, path, domain})
    $.cookie('MARCA', 'TOYOTA', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('MODELO', 'HILUX', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('TRANSMISION', 'False', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('VELOCIDAD', '0', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('KILOMETRAJE', '0', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('ESTADO', 'False', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('ANIO', '2024', { expires: TLC, path: '/', domain: g_Dominio });

    seleccionVehiculo();
}

function btnBMW() {
    //Crear las cookies con la información del vehículo seleccionado
    //(nombre, valor, {tiempo vida, path, domain})
    $.cookie('MARCA', 'BMW', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('MODELO', 'X3', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('TRANSMISION', 'False', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('VELOCIDAD', '0', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('KILOMETRAJE', '0', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('ESTADO', 'False', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('ANIO', '2023', { expires: TLC, path: '/', domain: g_Dominio });

    seleccionVehiculo();
}

function btnTucson() {
    //Crear las cookies con la información del vehículo seleccionado
    //(nombre, valor, {tiempo vida, path, domain})
    $.cookie('MARCA', 'Hyundai', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('MODELO', 'Tucson', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('TRANSMISION', 'False', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('VELOCIDAD', '0', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('KILOMETRAJE', '0', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('ESTADO', 'False', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('ANIO', '2024', { expires: TLC, path: '/', domain: g_Dominio });

    seleccionVehiculo();
}

function seleccionVehiculo() {
    //Definimos el arreglo que contiene los valores del objeto de parámetros que vamos a enviar al code behind (Web Method)
    var obj_Parametros_JS = new Array();

    //Definir los valores de cada item o posición del arreglo
    obj_Parametros_JS[0] = $.cookie('MARCA'); //Extraigo el valor de cada cookie
    obj_Parametros_JS[1] = $.cookie('MODELO');
    obj_Parametros_JS[2] = $.cookie('TRANSMISION');
    obj_Parametros_JS[3] = $.cookie('VELOCIDAD');
    obj_Parametros_JS[4] = $.cookie('KILOMETRAJE');
    obj_Parametros_JS[5] = $.cookie('ESTADO');
    obj_Parametros_JS[6] = $.cookie('ANIO');

    //Crear la estructura de los parámetros en formato JSON
    var parametros = JSON.stringify({ 'obj_Parametros_JS': obj_Parametros_JS });

    //A través de métodos AJAX de JQUERY vamos a invocar o consumir el code behind del formulario (WEB METHOD)
    //Aquí lo que indicamos es cual va a ser el nombre del web method que vamos a ejecutar en el code behind
    jQuery.ajax({
        type: "POST",
        url: "frmVehiculosHTML.aspx/seleccionVehiculo", //representa la ruta en donde está el web method a ejecutar
        data: parametros,
        contentType: "application/json; chartset=utf-8",
        dataType: "json",
        cache: false,
        success: function (msg) {
            var res = msg.d;

            if (res === undefined) {
                alert('Ocurrió un error al intentar seleccionar el vehículo');
            }
            else {
                if ((res != '') && (res != undefined)) {
                    $("#divTablaInfoVehiculo").html(res);

                    Swal.fire({
                        position: 'center-center',
                        icon: 'success',
                        title: "Ejercicio de Vehículos HTML",
                        text: "El vehículo ha sido seleccionado",
                        showConfirmButton: false,
                        timer: 1000,
                        timerProgressBar: true
                    });
                }
                else {
                    $("#divTablaInfoVehiculo").html("");
                }
            }

        },
        failure: function (msg) {

        },
        error: function (msg) {

        }
    })

}