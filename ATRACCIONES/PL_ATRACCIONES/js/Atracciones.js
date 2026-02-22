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
    $.cookie('Disponibilidad', 'True', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Horario', 'K-D 9:00 AM-5:00 PM', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Estado', '2', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Condicion', 'false', { expires: TLC, path: '/', domain: g_Dominio });

    SeleccionAtraccion();
}
function btnChocones() {
    //Crear las cookies con la información de la atraccion seleccionada
    //(nombre, valor, {tiempo vida, path, domain})
    $.cookie('Nombre', 'Los Chocadores', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Tipo', 'Carros chocones', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Capacidad', '30', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Duracion', '3', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Disponibilidad', 'True', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Horario', 'K-D 9:00 AM-5:00 PM', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Estado', '2', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Condicion', 'false', { expires: TLC, path: '/', domain: g_Dominio });

    SeleccionAtraccion();
}
function btnAbismo() {
    //Crear las cookies con la información de la atraccion seleccionada
    //(nombre, valor, {tiempo vida, path, domain})
    $.cookie('Nombre', 'Al abismo', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Tipo', 'Torre', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Capacidad', '10', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Duracion', '1', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Disponibilidad', 'True', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Horario', 'K-D 9:00 AM-5:00 PM', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Estado', '2', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Condicion', 'false', { expires: TLC, path: '/', domain: g_Dominio });

    SeleccionAtraccion();
}
function btnSerpiente() {
    //Crear las cookies con la información de la atraccion seleccionada
    //(nombre, valor, {tiempo vida, path, domain})
    $.cookie('Nombre', 'Serpiente', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Tipo', 'Montaña rusa', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Capacidad', '15', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Duracion', '4', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Disponibilidad', 'False', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Horario', 'K-D 9:00 AM-5:00 PM', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Estado', '2', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Condicion', 'False', { expires: TLC, path: '/', domain: g_Dominio });

    SeleccionAtraccion();
}
function btnGiros() {
    //Crear las cookies con la información de la atraccion seleccionada
    //(nombre, valor, {tiempo vida, path, domain})
    $.cookie('Nombre', 'Los giros', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Tipo', 'Rueda de chicago', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Capacidad', '40', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Duracion', '5', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Disponibilidad', 'True', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Horario', 'K-D 9:00 AM-5:00 PM', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Estado', '2', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Condicion', 'False', { expires: TLC, path: '/', domain: g_Dominio });

    SeleccionAtraccion();
}
function btnSillas() {
    //Crear las cookies con la información de la atraccion seleccionada
    //(nombre, valor, {tiempo vida, path, domain})
    $.cookie('Nombre', 'Sillas voladoras', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Tipo', 'Carresul', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Capacidad', '40', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Duracion', '5', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Disponibilidad', 'True', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Horario', 'K-D 9:00 AM-5:00 PM', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Estado', '2', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Condicion', 'False', { expires: TLC, path: '/', domain: g_Dominio });

    SeleccionAtraccion();
}
function btnSky() {
    //Crear las cookies con la información de la atraccion seleccionada
    //(nombre, valor, {tiempo vida, path, domain})
    $.cookie('Nombre', 'Sky Master', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Tipo', 'Rueda de chicago', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Capacidad', '10', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Duracion', '3', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Disponibilidad', 'True', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Horario', 'K-D 9:00 AM-5:00 PM', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Estado', '2', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Condicion', 'False', { expires: TLC, path: '/', domain: g_Dominio });

    SeleccionAtraccion();
}
function btnStar() {
    //Crear las cookies con la información de la atraccion seleccionada
    //(nombre, valor, {tiempo vida, path, domain})
    $.cookie('Nombre', 'Star Flyer', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Tipo', 'Torre', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Capacidad', '15', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Duracion', '2', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Disponibilidad', 'True', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Horario', 'K-D 9:00 AM-5:00 PM', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Estado', '2', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Condicion', 'False', { expires: TLC, path: '/', domain: g_Dominio });

    SeleccionAtraccion();
}
function btnTarantula() {
    //Crear las cookies con la información de la atraccion seleccionada
    //(nombre, valor, {tiempo vida, path, domain})
    $.cookie('Nombre', 'Tarántula', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Tipo', 'Montaña rusa', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Capacidad', '25', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Duracion', '5', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Disponibilidad', 'True', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Horario', 'K-D 9:00 AM-5:00 PM', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Estado', '2', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Condicion', 'False', { expires: TLC, path: '/', domain: g_Dominio });

    SeleccionAtraccion();
}
function btnTornado() {
    //Crear las cookies con la información de la atraccion seleccionada
    //(nombre, valor, {tiempo vida, path, domain})
    $.cookie('Nombre', 'Tornado', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Tipo', 'Montaña rusa', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Capacidad', '20', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Duracion', '4', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Disponibilidad', 'False', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Horario', 'K-D 9:00 AM-5:00 PM', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Estado', '2', { expires: TLC, path: '/', domain: g_Dominio });
    $.cookie('Condicion', 'False', { expires: TLC, path: '/', domain: g_Dominio });

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

                Swal.fire({
                    title: "Error al seleccionadar la atracción.",
                    width: 600,
                    padding: "3em",
                    color: "#716add",
                    background: "url(/img/Fondo.png) no-repeat center center",
                    backdrop: `
                        rgba(0,0,123,0.4)
                        url("/img/Caballito.gif")
                        Center top
                        no-repeat  `,
                    confirmButtonText: "Aceptar",
                    timer: 1500
                });
            }
            else {
                if ((res != '') && (res != undefined)) {
                    $("#divTablaInfoAtracciones").html(res);

                    Swal.fire({
                        title: "La atraccion fue seleccionada.",
                        width: 600,
                        padding: "3em",
                        color: "#716add",
                        background: "url(/img/Fondo.png) no-repeat center center",
                        backdrop: `
                        rgba(0,0,123,0.4)
                        url("/img/Caballito.gif")
                        Center top
                        no-repeat  `,
                        showConfirmButton: false,
                        timer: 1500
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
function btnIniciar() {
    //Se valida que ya está seleccionada una atracción
    if ($.cookie("Nombre") != undefined) { 
        //Se verifica la disponibilidad de la atracción
        if ($.cookie("Disponibilidad") == "False") {

            Swal.fire({
                title: "La atracción no está disponible no se puede iniciar.",
                width: 600,
                padding: "3em",
                icon: 'error',
                color: "#716add",
                background: "url(/img/Fondo.png) center center / cover no-repeat",
                showConfirmButton: false,
                timer: 2000
            });
            return
        }
        //Se verifica si la atracción está en mantenimiento
        if ($.cookie("Estado") == "3") {

            Swal.fire({
                title: "La atracción está en mantenimiento no se puede iniciar.",
                width: 600,
                padding: "3em",
                icon: 'error',
                color: "#716add",
                background: "url(/img/Fondo.png) center center / cover no-repeat",
                showConfirmButton: false,
                timer: 2000
            });
            return
        }
        //Se verifica si la atracción se encuentra cerrada
        if ($.cookie("Condicion") == "False") {

            Swal.fire({
                title: "La atracción debe estar abierta para iniciarla.",
                width: 600,
                padding: "3em",
                icon: 'error',
                color: "#716add",
                background: "url(/img/Fondo.png) center center / cover no-repeat",
                showConfirmButton: false,
                timer: 2000
            });
            return
        }
        //Se verifica si la atracción esta iniciada
        if ($.cookie("Estado") == "1") {

            Swal.fire({
                title: "La atracción ya esta iniciada.",
                width: 600,
                padding: "3em",
                icon: 'info',
                iconColor: '#ffffff', 
                color: "#716add",
                background: "url(/img/Fondo.png) center center / cover no-repeat",
                showConfirmButton: false,
                timer: 2000
            });
        }
        else {
            accionarAtraccion("Iniciar");
        }
    } else {
        Swal.fire({
            title: "Debe seleccionar una atracción.",
            width: 600,
            padding: "3em",
            icon: 'info',
            iconColor: '#ffffff', 
            color: "#716add",
            background: "url(/img/Fondo.png) center center / cover no-repeat",
            showConfirmButton: false,
            timer: 2000
        });
    }
}
function btnDetener() {
    //Se valida que ya está seleccionada una atracción
    if ($.cookie("Nombre") != undefined) { 
        //Se verifica la disponibilidad de la atracción
        if ($.cookie("Disponibilidad") == "False") {

            Swal.fire({
                title: "La atracción no está disponible no se puede detener.",
                width: 600,
                padding: "3em",
                icon: 'error',
                color: "#716add",
                background: "url(/img/Fondo.png) center center / cover no-repeat",
                showConfirmButton: false,
                timer: 2000
            });
            return
        }
        //Se verifica si la atracción está en mantenimiento
        if ($.cookie("Estado") == "3") {

            Swal.fire({
                title: "La atracción está en mantenimiento no se puede detener.",
                width: 600,
                padding: "3em",
                icon: 'error',
                color: "#716add",
                background: "url(/img/Fondo.png) center center / cover no-repeat",
                showConfirmButton: false,
                timer: 2000
            });
            return
        }
        //Se verifica si la atracción se encuentra cerrada
        if ($.cookie("Condicion") == "False") {

            Swal.fire({
                title: "La atracción debe estar abierta para detenerla.",
                width: 600,
                padding: "3em",
                icon: 'error',
                color: "#716add",
                background: "url(/img/Fondo.png) center center / cover no-repeat",
                showConfirmButton: false,
                timer: 2000
            });
            return 
        }
        //Se verifica si la atracción esta detenida
        if ($.cookie("Estado") == "2") {

            Swal.fire({
                title: "La atracción ya está detenida.",
                width: 600,
                padding: "3em",
                icon: 'info',
                iconColor: '#ffffff',
                color: "#716add",
                background: "url(/img/Fondo.png) center center / cover no-repeat",
                showConfirmButton: false,
                timer: 2000
            });
        }
        else {
            accionarAtraccion("Detener");
        }
    } else {
        Swal.fire({
            title: "Debe seleccionar una atracción.",
            width: 600,
            padding: "3em",
            icon: 'info',
            iconColor: '#ffffff', 
            color: "#716add",
            background: "url(/img/Fondo.png) center center / cover no-repeat",
            showConfirmButton: false,
            timer: 2000
        });
    }
}
function btnMantenimiento() {
    //Se valida que ya está seleccionada una atracción
    if ($.cookie("Nombre") != undefined) {
        //Se verifica la disponibilidad de la atracción
        if ($.cookie("Disponibilidad") == "False") {

            Swal.fire({
                title: "La atracción no está disponible no se puede dar mantenimiento.",
                width: 600,
                padding: "3em",
                icon: 'error',
                color: "#716add",
                background: "url(/img/Fondo.png) center center / cover no-repeat",
                showConfirmButton: false,
                timer: 2000
            });
            return
        }
        //Se verifica si la atracción se encuentra abierta
        if ($.cookie("Condicion") == "True") {

            Swal.fire({
                title: "No se le puede dar mantenimiento a la atracción si se encuentra abierta.",
                width: 600,
                padding: "3em",
                icon: 'info',
                iconColor: '#ffffff',
                color: "#716add",
                background: "url(/img/Fondo.png) center center / cover no-repeat",
                showConfirmButton: false,
                timer: 2000
            });
            return
        }
        //Se verifica si la atracción esta iniciada
        if ($.cookie("Estado") == "1") {

            Swal.fire({
                title: "No se le puede dar mantenimiento a la atracción si se encuentra iniciada.",
                width: 600,
                padding: "3em",
                icon: 'info',
                iconColor: '#ffffff',
                color: "#716add",
                background: "url(/img/Fondo.png) center center / cover no-repeat",
                showConfirmButton: false,
                timer: 2000
            });
            return
        }
        //Se verifica si la atracción está en mantenimiento
        if ($.cookie("Estado") == "3") {

            Swal.fire({
                title: "La atracción ya está en mantenimiento.",
                width: 600,
                padding: "3em",
                icon: 'info',
                iconColor: '#ffffff', 
                color: "#716add",
                background: "url(/img/Fondo.png) center center / cover no-repeat",
                showConfirmButton: false,
                timer: 2000
            });
        }
        else {
            accionarAtraccion("Mantenimiento");
        }
    } else {
        Swal.fire({
            title: "Debe seleccionar una atracción.",
            width: 600,
            padding: "3em",
            icon: 'info',
            iconColor: '#ffffff', 
            color: "#716add",
            background: "url(/img/Fondo.png) center center / cover no-repeat",
            showConfirmButton: false,
            timer: 2000
        });
    }
}
function btnAbrir() {
    //Se valida que ya está seleccionada una atracción
    if ($.cookie("Nombre") != undefined) {
        //Se verifica la disponibilidad de la atracción
        if ($.cookie("Disponibilidad") == "False") {

            Swal.fire({
                title: "La atracción no está disponible no se puede abrir.",
                width: 600,
                padding: "3em",
                icon: 'error',
                color: "#716add",
                background: "url(/img/Fondo.png) center center / cover no-repeat",
                showConfirmButton: false,
                timer: 2000
            });
            return
            if ($.cookie("Estado") == "1") {

                Swal.fire({
                    title: "La atracción no está iniciada no se puede abrir.",
                    width: 600,
                    padding: "3em",
                    icon: 'error',
                    color: "#716add",
                    background: "url(/img/Fondo.png) center center / cover no-repeat",
                    showConfirmButton: false,
                    timer: 2000
                });
                return
            }
        }
        //Se verifica si la atracción está en mantenimiento
        if ($.cookie("Estado") == "3") {

            Swal.fire({
                title: "La atracción está en mantenimiento no se puede abrir.",
                width: 600,
                padding: "3em",
                icon: 'error',
                color: "#716add",
                background: "url(/img/Fondo.png) center center / cover no-repeat",
                showConfirmButton: false,
                timer: 2000
            });
        }
        else {
            accionarAtraccion("Abrir");
        }
    } else {
        Swal.fire({
            title: "Debe seleccionar una atracción.",
            width: 600,
            padding: "3em",
            icon: 'info',
            iconColor: '#ffffff', 
            color: "#716add",
            background: "url(/img/Fondo.png) center center / cover no-repeat",
            showConfirmButton: false,
            timer: 2000
        });
    }
}
function btnCerrar() {
    //Se valida que ya está seleccionada una atracción
    if ($.cookie("Nombre") != undefined) { 
        //Se verifica la disponibilidad de la atracción
        if ($.cookie("Disponibilidad") == "False") {

            Swal.fire({
                title: "La atracción no está disponible no se puede cerrar.",
                width: 600,
                padding: "3em",
                icon: 'error',
                color: "#716add",
                background: "url(/img/Fondo.png) center center / cover no-repeat",
                showConfirmButton: false,
                timer: 2000
            });
        }
        else {
            accionarAtraccion("Cerrar");
        }
    } else {
        Swal.fire({
            title: "Debe seleccionar una atracción.",
            width: 600,
            padding: "3em",
            icon: 'info',
            iconColor: '#ffffff', 
            color: "#716add",
            background: "url(/img/Fondo.png) center center / cover no-repeat",
            showConfirmButton: false,
            timer: 2000
        });
    }
}
function btnDisponibilidad() {
    //Se valida que ya está seleccionada una atracción
    if ($.cookie("Nombre") != undefined) { 
        //Se verifica si la atracción es en mantenimiento
        if ($.cookie("Estado") == "3") { 

            Swal.fire({
                title: "La atracción está en mantenimiento.",
                width: 600,
                padding: "3em",
                icon: 'info',
                iconColor: '#ffffff',
                color: "#716add",
                background: "url(/img/Fondo.png) center center / cover no-repeat",
                showConfirmButton: false,
                timer: 2000
            });
            return
        }
        //Se valida la disponibilidad de la atracción
        if ($.cookie("Disponibilidad") == "True") {

            Swal.fire({
                title: "La atracción está operativa.",
                width: 600,
                padding: "3em",
                color: "#716add",
                background: "url(/img/Fondo.png) center center / cover no-repeat",
                backdrop: `
                        rgba(0,0,123,0.4)
                        url("/img/Caballito.gif")
                        Center top
                        no-repeat  `,
                showConfirmButton: false,
                timer: 2000
            });
        }
        else {
            Swal.fire({
                title: "La atracción está fuera de servicios.",
                width: 600,
                padding: "3em",
                icon: 'info',
                iconColor: '#ffffff',
                color: "#716add",
                background: "url(/img/Fondo.png) center center / cover no-repeat",
                showConfirmButton: false,
                timer: 2000
            });
        }
    } else {
        Swal.fire({
            title: "Debe seleccionar una atracción.",
            width: 600,
            padding: "3em",
            icon: 'info',
            iconColor: '#ffffff', 
            color: "#716add",
            background: "url(/img/Fondo.png) center center / cover no-repeat",
            showConfirmButton: false,
            timer: 2000
        });
    }
}
function accionarAtraccion(accion) {
    //Se define el arreglo que contiene los valores del objeto de parámetros 
    //que se le enviara al code behind(Web Method)
    var obj_Parametros_JS = new Array();

    //Se definen los valores que va a tener cada posición del arreglo
    obj_Parametros_JS[0] = accion; //En esta posición va a estar el nombre de la acción de la atracción
    obj_Parametros_JS[1] = $.cookie('Nombre'); //Se extran los valor de cada cookie
    obj_Parametros_JS[2] = $.cookie('Tipo');
    obj_Parametros_JS[3] = $.cookie('Capacidad');
    obj_Parametros_JS[4] = $.cookie('Duracion');
    obj_Parametros_JS[5] = $.cookie('Disponibilidad');
    obj_Parametros_JS[6] = $.cookie('Horario');
    obj_Parametros_JS[7] = $.cookie('Estado');
    obj_Parametros_JS[8] = $.cookie('Condicion');

    //Se crea la estructura de los parámetros en formato JSON
    var parametros = JSON.stringify({ 'obj_Parametros_JS': obj_Parametros_JS });

    //El métodos AJAX de JQUERY para invocar o consumir el code behind del formulario (WEB METHOD)
    //Se le indica cual va a ser el nombre del web method que vamos a ejecutar en el code behind
    jQuery.ajax({
        type: "POST",
        url: "frmAtracciones.aspx/accionaAtraccion", //representa la ruta en donde está el web method a ejecutar
        data: parametros,
        contentType: "application/json; chartset=utf-8",
        dataType: "json",
        cache: false,
        success: function (msg) {
            var res = msg.d;

            if (res === undefined) {

                Swal.fire({
                    title: "Error al accionar la atracción.",
                    width: 600,
                    padding: "3em",
                    icon: 'error',
                    color: "#716add",
                    background: "url(/img/Fondo.png) center center / cover no-repeat",
                    showConfirmButton: false,
                    timer: 2000
                });
            }
            else {
                var arreglo = new Array();
                var str;

                str = res;

                /*Método que separa la información de respuesta cada vez que se encuentr la palabra clave <SPLITER>*/
                arreglo = (str.split("<SPLITER>"));
                resultado = arreglo[0];

                if ((resultado != '') && (resultado != undefined)) {
                    $("#divTablaEstadoAtracciones").html(arreglo[0]);

                    $.cookie('Estado', arreglo[1], { expires: TLC, path: '/', domain: g_Dominio });
                    $.cookie('Condicion', arreglo[2], { expires: TLC, path: '/', domain: g_Dominio });

                    Swal.fire({
                        title: "La atraccion fue accionada.",
                        width: 600,
                        padding: "3em",
                        color: "#716add",
                        background: "url(/img/Fondo.png) no-repeat center center",
                        backdrop: `
                        rgba(0,0,123,0.4)
                        url("/img/Caballito.gif")
                        Center top
                        no-repeat  `,
                        showConfirmButton: false,
                        timer: 2000
                    });
                }
                else {
                    $("#divTablaEstadoAtracciones").html("");
                }
            }

        },
        failure: function (msg) {

        },
        error: function (msg) {

        }
    })
}