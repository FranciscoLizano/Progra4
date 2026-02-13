using BLL_PARQUE_ATRAC.ParqueAtrac;
using DAL_PARQUE_ATRAC.ParqueAtrac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PL_PARQUE_ATRAC
{
    public partial class frmParqueAtrac : System.Web.UI.Page
    {
        // Se define in objeto de tipo de variable de sesión
        private const string VariableSesion = "ParqueAtracDal";

        // Se instancian los objetos de BLL y DAL los BLL no se utilizan aun 
        cls_ParqueAtrac_DAL obj_ParqueAtrac_DAL = new cls_ParqueAtrac_DAL();
        cls_ParqueAtrac_BLL obj_ParqueAtrac_BLL = new cls_ParqueAtrac_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            //La siguiente condición permite evaluar si se da el evento postback(recarga de la página)
            if (IsPostBack)
            {
                /* Se verifica si la variable de sesión es NULL para crear el objeto y asignarlo 
                    a la variable de sesión de lo contrario lo que tenga la variable de sesión se le asigna 
                    al objeto */
                if (Session[VariableSesion] == null)
                {
                    obj_ParqueAtrac_DAL = new cls_ParqueAtrac_DAL();
                    Session[VariableSesion] = obj_ParqueAtrac_DAL;
                }
                else
                {
                    //En la variable de sesión se respaldan los datos
                    obj_ParqueAtrac_DAL = (cls_ParqueAtrac_DAL)Session[VariableSesion];
                }
            }
        }

        #region Los eventos de selección de las atracciones
        /// <summary>
        /// Evento para seleccionar la atraccion de los caballitos 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnCaballitos_Click(object sender, EventArgs e)
        {
            obj_ParqueAtrac_DAL.sNombre = "Caballitos";
            obj_ParqueAtrac_DAL.sTipo = "Carrusel";
            obj_ParqueAtrac_DAL.byCapacidad = 20;
            obj_ParqueAtrac_DAL.byDuracion = 3;
            obj_ParqueAtrac_DAL.bDisponibilidad = true;
            obj_ParqueAtrac_DAL.sHorario = "K-D 9:00 AM-5:00 PM";

            ObtenerInformacion(ref obj_ParqueAtrac_DAL);
            LimpiaEstadoAtraccion();
        }

        /// <summary>
        /// Evento para seleccionar la atraccion de Los Chocadores 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnChocadores_Click(object sender, EventArgs e)
        {
            obj_ParqueAtrac_DAL.sNombre = "Los Chocadores";
            obj_ParqueAtrac_DAL.sTipo = "Carros chocones";
            obj_ParqueAtrac_DAL.byCapacidad = 30;
            obj_ParqueAtrac_DAL.byDuracion = 3;
            obj_ParqueAtrac_DAL.bDisponibilidad = true;
            obj_ParqueAtrac_DAL.sHorario = "K-D 9:00 AM-5:00 PM";

            ObtenerInformacion(ref obj_ParqueAtrac_DAL);
            LimpiaEstadoAtraccion();
        }

        /// <summary>
        /// Evento para seleccionar la atraccion del Al abismo 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnAbismo_Click(object sender, EventArgs e)
        {
            obj_ParqueAtrac_DAL.sNombre = "Al abismo";
            obj_ParqueAtrac_DAL.sTipo = "Torre";
            obj_ParqueAtrac_DAL.byCapacidad = 10;
            obj_ParqueAtrac_DAL.byDuracion = 1;
            obj_ParqueAtrac_DAL.bDisponibilidad = true;
            obj_ParqueAtrac_DAL.sHorario = "K-D 9:00 AM-5:00 PM";

            ObtenerInformacion(ref obj_ParqueAtrac_DAL);
            LimpiaEstadoAtraccion();
        }

        /// <summary>
        /// Evento para seleccionar la atraccion de la Serpiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSerpiente_Click(object sender, EventArgs e)
        {
            obj_ParqueAtrac_DAL.sNombre = "Serpiente";
            obj_ParqueAtrac_DAL.sTipo = "Montaña rusa";
            obj_ParqueAtrac_DAL.byCapacidad = 15;
            obj_ParqueAtrac_DAL.byDuracion = 4;
            obj_ParqueAtrac_DAL.bDisponibilidad = false;
            obj_ParqueAtrac_DAL.sHorario = "K-D 9:00 AM-5:00 PM";

            ObtenerInformacion(ref obj_ParqueAtrac_DAL);
            LimpiaEstadoAtraccion();
        }

        /// <summary>
        /// Evento para seleccionar la atraccion de Los giros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnGiros_Click(object sender, EventArgs e)
        {
            obj_ParqueAtrac_DAL.sNombre = "Los giros";
            obj_ParqueAtrac_DAL.sTipo = "Rueda de chicago";
            obj_ParqueAtrac_DAL.byCapacidad = 40;
            obj_ParqueAtrac_DAL.byDuracion = 5;
            obj_ParqueAtrac_DAL.bDisponibilidad = true;
            obj_ParqueAtrac_DAL.sHorario = "K-D 9:00 AM-5:00 PM";

            ObtenerInformacion(ref obj_ParqueAtrac_DAL);
            LimpiaEstadoAtraccion();
        }

        /// <summary>
        /// Evento para seleccionar la atraccion de Sky Master
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSkyMaster_Click(object sender, EventArgs e)
        {
            obj_ParqueAtrac_DAL.sNombre = "Sky Master";
            obj_ParqueAtrac_DAL.sTipo = "Rueda de chicago";
            obj_ParqueAtrac_DAL.byCapacidad = 10;
            obj_ParqueAtrac_DAL.byDuracion = 3;
            obj_ParqueAtrac_DAL.bDisponibilidad = true;
            obj_ParqueAtrac_DAL.sHorario = "K-D 9:00 AM-5:00 PM";

            ObtenerInformacion(ref obj_ParqueAtrac_DAL);
            LimpiaEstadoAtraccion();
        }

        /// <summary>
        /// Evento para seleccionar la atraccion de Star Flyer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnStarFlyer_Click(object sender, EventArgs e)
        {
            obj_ParqueAtrac_DAL.sNombre = "Star Flyer";
            obj_ParqueAtrac_DAL.sTipo = "Torre";
            obj_ParqueAtrac_DAL.byCapacidad = 15;
            obj_ParqueAtrac_DAL.byDuracion = 2;
            obj_ParqueAtrac_DAL.bDisponibilidad = true;
            obj_ParqueAtrac_DAL.sHorario = "K-D 9:00 AM-5:00 PM";

            ObtenerInformacion(ref obj_ParqueAtrac_DAL);
            LimpiaEstadoAtraccion();
        }

        /// <summary>
        /// Evento para seleccionar la atraccion de la Tarántula
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnTarantula_Click(object sender, EventArgs e)
        {
            obj_ParqueAtrac_DAL.sNombre = "Tarántula";
            obj_ParqueAtrac_DAL.sTipo = "Montaña rusa";
            obj_ParqueAtrac_DAL.byCapacidad = 25;
            obj_ParqueAtrac_DAL.byDuracion = 5;
            obj_ParqueAtrac_DAL.bDisponibilidad = true;
            obj_ParqueAtrac_DAL.sHorario = "K-D 9:00 AM-5:00 PM";

            ObtenerInformacion(ref obj_ParqueAtrac_DAL);
            LimpiaEstadoAtraccion();
        }

        /// <summary>
        /// Evento para seleccionar la atraccion del Tornado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnTornado_Click(object sender, EventArgs e)
        {
            obj_ParqueAtrac_DAL.sNombre = "Tornado";
            obj_ParqueAtrac_DAL.sTipo = "Montaña rusa";
            obj_ParqueAtrac_DAL.byCapacidad = 20;
            obj_ParqueAtrac_DAL.byDuracion = 4;
            obj_ParqueAtrac_DAL.bDisponibilidad = true;
            obj_ParqueAtrac_DAL.sHorario = "K-D 9:00 AM-5:00 PM";

            ObtenerInformacion(ref obj_ParqueAtrac_DAL);
            LimpiaEstadoAtraccion();
        }

        /// <summary>
        /// Evento donde se muestra la información de la atracción seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ObtenerInformacion(ref cls_ParqueAtrac_DAL obj_ParqueAtrac_DAL)
        {
            string disponibilidad = string.Empty;

            var html = new StringBuilder();

            /*  Se controla la información que se le muestra al usuario para indicar si la atracción 
                 esta en operación o fuera de servicio */
            if (obj_ParqueAtrac_DAL.bDisponibilidad == false)
            {
                disponibilidad = "Fuera de Servicio";
            }
            else
            {
                disponibilidad = "Operativa";
            }

            html.Append("<table>");
            html.Append("<tbody>");
            //En esta fila de define el encabezados de tabla
            html.Append("<tr>");
            html.Append("<th>Atributo</th>");
            html.Append("<th>Valor</th>");
            html.Append("</tr>");
            //Las siguientes son las filas de Detalle de la tabla
            html.Append("<tr>");
            html.Append("<td>Nombre de la atracción</td>");
            html.Append("<td>" + obj_ParqueAtrac_DAL.sNombre + "</td>");
            html.Append("</tr>");
            html.Append("<tr>");
            html.Append("<td>Tipo de atracción</td>");
            html.Append("<td>" + obj_ParqueAtrac_DAL.sTipo + "</td>");
            html.Append("</tr>");
            html.Append("<tr>");
            html.Append("<td>Capacidad</td>");
            html.Append("<td>" + obj_ParqueAtrac_DAL.byCapacidad + " Personas" + "</td>");
            html.Append("</tr>");
            html.Append("<tr>");
            html.Append("<td>Duración</td>");
            html.Append("<td>" + obj_ParqueAtrac_DAL.byDuracion + " Minutos" + "</td>");
            html.Append("</tr>");
            html.Append("<tr>");
            html.Append("<td>Disponibilidad</td>");
            html.Append("<td>" + disponibilidad + "</td>");
            html.Append("</tr>");
            html.Append("<tr>");
            html.Append("<td>Horario </td>");
            html.Append("<td>" + obj_ParqueAtrac_DAL.sHorario + "</td>");
            html.Append("</tr>");
            html.Append("</tbody>");
            html.Append("</table>");

            divTablaInfoAtraccion.InnerHtml = html.ToString();
        }
        #endregion

        #region Los eventos de las acciones de las atracciones
        /// <summary>
        /// Evento para iniciar la atracción
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnIniciar_Click(object sender, EventArgs e)
        {
            obj_ParqueAtrac_DAL = (cls_ParqueAtrac_DAL)Session[VariableSesion];

            string mensaje = string.Empty;

            if (obj_ParqueAtrac_DAL.sNombre == null)
            {
                mensaje = "alert('Debe Seleccionar la Atracción')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Mensaje de la página", mensaje, true);
                return;
            }

            if (obj_ParqueAtrac_DAL.bDisponibilidad == false)
            {
                mensaje = "alert('La atracción debe de estar Operativa para realizar esta acción')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Mensaje de la página", mensaje, true);
                return;
            }

            if (obj_ParqueAtrac_DAL.iEstado == 5)
            {
                mensaje = "alert('La atracción no puede iniciar por estar en mantenimiento')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Mensaje de la página", mensaje, true);
                return;
            }

            if (obj_ParqueAtrac_DAL.iEstado != 3)
            {
                mensaje = "alert('Para iniciar la atracción esta debe de estar abierta')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Mensaje de la página", mensaje, true);
            }
            else
            {
                obj_ParqueAtrac_BLL.Iniciar(ref obj_ParqueAtrac_DAL);
                ObtenerInformacion(ref obj_ParqueAtrac_DAL);
                ObtienerEstadoAtraccion(ref obj_ParqueAtrac_DAL, "Iniciada");
            }

        }

        /// <summary>
        /// Evento para detener la atracción
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnDetener_Click(object sender, EventArgs e)
        {
            obj_ParqueAtrac_DAL = (cls_ParqueAtrac_DAL)Session[VariableSesion];

            string mensaje = string.Empty;

            if (obj_ParqueAtrac_DAL.sNombre == null)
            {
                mensaje = "alert('Debe Seleccionar la Atracción')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Mensaje de la página", mensaje, true);
                return;
            }

            if (obj_ParqueAtrac_DAL.bDisponibilidad == false)
            {
                mensaje = "alert('La atracción debe de estar Operativa para realizar esta acción')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Mensaje de la página", mensaje, true);
                return;
            }

            if (obj_ParqueAtrac_DAL.iEstado == 5)
            {
                mensaje = "alert('La atracción no se puede detener por estar en mantenimiento')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Mensaje de la página", mensaje, true);
                return;
            }

            if (obj_ParqueAtrac_DAL.iEstado != 3)
            {
                mensaje = "alert('Para detener la atracción esta debe de estar abierta')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Mensaje de la página", mensaje, true);
            }
            else
            {
                obj_ParqueAtrac_BLL.Iniciar(ref obj_ParqueAtrac_DAL);
                ObtenerInformacion(ref obj_ParqueAtrac_DAL);
                ObtienerEstadoAtraccion(ref obj_ParqueAtrac_DAL, "Detenida");
            }

        }

        /// <summary>
        /// Evento para dar mantenimiento a la atracción
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnMantenimiento_Click(object sender, EventArgs e)
        {
            obj_ParqueAtrac_DAL = (cls_ParqueAtrac_DAL)Session[VariableSesion];

            string mensaje = string.Empty;

            if (obj_ParqueAtrac_DAL.sNombre == null)
            {
                mensaje = "alert('Debe Seleccionar la Atracción')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Mensaje de la página", mensaje, true);
                return;
            }

            if (obj_ParqueAtrac_DAL.bDisponibilidad == false)
            {
                mensaje = "alert('La atracción debe de estar Operativa para realizar esta acción')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Mensaje de la página", mensaje, true);
                return;
            }

            if (obj_ParqueAtrac_DAL.iEstado == 3)
            {
                mensaje = "alert('No se puede realizar mantenimiento a la atracción si esta se encuentra abierta')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Mensaje de la página", mensaje, true);
            }
            else
            {
                obj_ParqueAtrac_BLL.Mantenimiento(ref obj_ParqueAtrac_DAL);
                ObtenerInformacion(ref obj_ParqueAtrac_DAL);
                ObtienerEstadoAtraccion(ref obj_ParqueAtrac_DAL, "En Mantenimiento");
            }

        }

        /// <summary>
        /// Evento para abrir la atracción
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnAbrir_Click(object sender, EventArgs e)
        {
            obj_ParqueAtrac_DAL = (cls_ParqueAtrac_DAL)Session[VariableSesion];

            string mensaje = string.Empty;

            if (obj_ParqueAtrac_DAL.sNombre == null)
            {
                mensaje = "alert('Debe Seleccionar la Atracción')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Mensaje de la página", mensaje, true);
                return;
            }

            if (obj_ParqueAtrac_DAL.iEstado == 5)
            {
                mensaje = "alert('La atracción no se puede abrir por estar en mantenimiento')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Mensaje de la página", mensaje, true);
                return;
            }

            if (obj_ParqueAtrac_DAL.bDisponibilidad == false)
            {
                mensaje = "alert('La atracción debe de estar Operativa para realizar esta acción')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Mensaje de la página", mensaje, true);
            }
            else
            {
                obj_ParqueAtrac_BLL.Abrir(ref obj_ParqueAtrac_DAL);
                ObtenerInformacion(ref obj_ParqueAtrac_DAL);
                ObtienerEstadoAtraccion(ref obj_ParqueAtrac_DAL, "Abierta");
            }

        }

        /// <summary>
        /// Evento para cerrar la atracción
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnCerrar_Click(object sender, EventArgs e)
        {
            obj_ParqueAtrac_DAL = (cls_ParqueAtrac_DAL)Session[VariableSesion];

            string mensaje = string.Empty;

            if (obj_ParqueAtrac_DAL.sNombre == null)
            {
                mensaje = "alert('Debe Seleccionar la Atracción')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Mensaje de la página", mensaje, true);
                return;
            }

            if (obj_ParqueAtrac_DAL.bDisponibilidad == false)
            {
                mensaje = "alert('La atracción debe de estar Operativa para realizar esta acción')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Mensaje de la página", mensaje, true);
            }
            else
            {
                obj_ParqueAtrac_BLL.Cerrar(ref obj_ParqueAtrac_DAL);
                ObtenerInformacion(ref obj_ParqueAtrac_DAL);
                ObtienerEstadoAtraccion(ref obj_ParqueAtrac_DAL, "Cerrada");
            }
        }

        /// <summary>
        /// Evento para ver la disponibilidad de la atracción
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnDisponibilidad_Click(object sender, EventArgs e)
        {
            obj_ParqueAtrac_DAL = (cls_ParqueAtrac_DAL)Session[VariableSesion];

            string mensaje = string.Empty;
            string Disponibilidad = string.Empty;

            if (obj_ParqueAtrac_DAL.sNombre == null)
            {
                mensaje = "alert('Debe Seleccionar la Atracción')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Mensaje de la página", mensaje, true);
                return;
            }

            if (obj_ParqueAtrac_DAL.bDisponibilidad == false)
            {
                mensaje = "alert('La atracción debe de estar Operativa para realizar esta acción')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Mensaje de la página", mensaje, true);
                return ;
            }

            Disponibilidad = "Operativa";
            mensaje = "alert('La Atracción se encuentra: "+ Disponibilidad + "')";
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Mensaje de la página", mensaje, true);

        }

        /// <summary>
        /// En este evento se muestra la información de las acciones de las atracciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ObtienerEstadoAtraccion(ref cls_ParqueAtrac_DAL obj_ParqueAtrac_DAL, string accion)
        {
            string Estado = string.Empty;
            var html = new StringBuilder();

            switch (obj_ParqueAtrac_DAL.iEstado)
            {
                case 1:
                    Estado = "Encendida";
                    break;
                case 2:
                    Estado = "Apagada";
                    break;
                case 3:
                    Estado = "Abierta";
                    break;
                case 4:
                    Estado = "Cerrada";
                    break;
                case 5:
                    Estado = "En Mantenimiento";
                    break;
                default:
                    Estado = "Desconocido";
                    break;
            }

            html.Append("<table>");
            html.Append("<tbody>");
            //Fila de Encabezados de tabla
            html.Append("<tr>");
            html.Append("<th>Acción</th>");
            html.Append("<th>Tipo</th>");
            html.Append("<th>Nombre</th>");
            html.Append("<th>Estado</th>");
            html.Append("</tr>");
            //Fila de Detalles de la tabla
            html.Append("<tr>");
            html.Append("<td>" + accion + "</td>");
            html.Append("<td>" + obj_ParqueAtrac_DAL.sTipo + "</td>");
            html.Append("<td>" + obj_ParqueAtrac_DAL.sNombre.ToString() + "</td>");
            html.Append("<td>" + Estado + "</td>");
            html.Append("</tr>");
            html.Append("</tbody>");
            html.Append("</table>");

            divTablaEstadoAtraccion.InnerHtml = html.ToString();
        }
        #endregion

        #region Eventos para limpiar datos

        /// <summary>
        /// En este evento se envía vacía la información de la acción de la atracción
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void LimpiaEstadoAtraccion()
        {
            divTablaEstadoAtraccion.InnerHtml = "";
        }

        #endregion
    }
}