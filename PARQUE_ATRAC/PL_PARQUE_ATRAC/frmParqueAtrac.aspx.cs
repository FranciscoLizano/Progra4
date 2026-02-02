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
        // Se instancian los objetos de BLL y DAL
        cls_ParqueAtrac_DAL obj_ParqueAtrac_DAL = new cls_ParqueAtrac_DAL();
        cls_ParqueAtrac_BLL obj_ParqueAtrac_BLL = new cls_ParqueAtrac_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCaballitos_Click(object sender, EventArgs e)
        {
            obj_ParqueAtrac_DAL.sNombre = "Caballitos";
            obj_ParqueAtrac_DAL.sTipo = "Carrusel";
            obj_ParqueAtrac_DAL.byCapacidad = 20;
            string sCapacidad = obj_ParqueAtrac_DAL.byCapacidad + " Personas";
            obj_ParqueAtrac_DAL.byDuracion = 3;
            string sDuracion = obj_ParqueAtrac_DAL.byDuracion + " Minutos";
            obj_ParqueAtrac_DAL.sDisponibilidad = "En operación";
            obj_ParqueAtrac_DAL.sHorario = "K-D 9:00 AM-5:00 PM";

            var html = new StringBuilder();

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
            html.Append("<td>" + sCapacidad + "</td>");
            html.Append("</tr>");
            html.Append("<tr>");
            html.Append("<td>Duración</td>");
            html.Append("<td>" + sDuracion + "</td>");
            html.Append("</tr>");
            html.Append("<tr>");
            html.Append("<td>Disponibilidad</td>");
            html.Append("<td>" + obj_ParqueAtrac_DAL.sDisponibilidad + "</td>");
            html.Append("</tr>");
            html.Append("<tr>");
            html.Append("<td>Horario </td>");
            html.Append("<td>" + obj_ParqueAtrac_DAL.sHorario + "</td>");
            html.Append("</tr>");
            html.Append("</tbody>");
            html.Append("</table>");

            divTablaInfoAtraccion.InnerHtml = html.ToString();
        }

        protected void btnChocadores_Click(object sender, EventArgs e)
        {
            obj_ParqueAtrac_DAL.sNombre = "Los Chocadores";
            obj_ParqueAtrac_DAL.sTipo = "Carros chocones";
            obj_ParqueAtrac_DAL.byCapacidad = 30;
            string sCapacidad = obj_ParqueAtrac_DAL.byCapacidad + " Personas";
            obj_ParqueAtrac_DAL.byDuracion = 3;
            string sDuracion = obj_ParqueAtrac_DAL.byDuracion + " Minutos";
            obj_ParqueAtrac_DAL.sDisponibilidad = "En operación";
            obj_ParqueAtrac_DAL.sHorario = "K-D 9:00 AM-5:00 PM";

            var html = new StringBuilder();

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
            html.Append("<td>" + sCapacidad + "</td>");
            html.Append("</tr>");
            html.Append("<tr>");
            html.Append("<td>Duración</td>");
            html.Append("<td>" + sDuracion + "</td>");
            html.Append("</tr>");
            html.Append("<tr>");
            html.Append("<td>Disponibilidad</td>");
            html.Append("<td>" + obj_ParqueAtrac_DAL.sDisponibilidad + "</td>");
            html.Append("</tr>");
            html.Append("<tr>");
            html.Append("<td>Horario </td>");
            html.Append("<td>" + obj_ParqueAtrac_DAL.sHorario + "</td>");
            html.Append("</tr>");
            html.Append("</tbody>");
            html.Append("</table>");

            divTablaInfoAtraccion.InnerHtml = html.ToString();
        }

        protected void btnAbismo_Click(object sender, EventArgs e)
        {
            obj_ParqueAtrac_DAL.sNombre = "Al abismo";
            obj_ParqueAtrac_DAL.sTipo = "Torre";
            obj_ParqueAtrac_DAL.byCapacidad = 10;
            string sCapacidad = obj_ParqueAtrac_DAL.byCapacidad + " Personas";
            obj_ParqueAtrac_DAL.byDuracion = 1;
            string sDuracion = obj_ParqueAtrac_DAL.byDuracion + " Minutos";
            obj_ParqueAtrac_DAL.sDisponibilidad = "En operación";
            obj_ParqueAtrac_DAL.sHorario = "K-D 9:00 AM-5:00 PM";

            var html = new StringBuilder();

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
            html.Append("<td>" + sCapacidad + "</td>");
            html.Append("</tr>");
            html.Append("<tr>");
            html.Append("<td>Duración</td>");
            html.Append("<td>" + sDuracion + "</td>");
            html.Append("</tr>");
            html.Append("<tr>");
            html.Append("<td>Disponibilidad</td>");
            html.Append("<td>" + obj_ParqueAtrac_DAL.sDisponibilidad + "</td>");
            html.Append("</tr>");
            html.Append("<tr>");
            html.Append("<td>Horario </td>");
            html.Append("<td>" + obj_ParqueAtrac_DAL.sHorario + "</td>");
            html.Append("</tr>");
            html.Append("</tbody>");
            html.Append("</table>");

            divTablaInfoAtraccion.InnerHtml = html.ToString();
        }

        protected void btnSerpiente_Click(object sender, EventArgs e)
        {
            obj_ParqueAtrac_DAL.sNombre = "Serpiente";
            obj_ParqueAtrac_DAL.sTipo = "Montaña rusa";
            obj_ParqueAtrac_DAL.byCapacidad = 15;
            string sCapacidad = obj_ParqueAtrac_DAL.byCapacidad + " Personas";
            obj_ParqueAtrac_DAL.byDuracion = 4;
            string sDuracion = obj_ParqueAtrac_DAL.byDuracion + " Minutos";
            obj_ParqueAtrac_DAL.sDisponibilidad = "Fuera de Servicio";
            obj_ParqueAtrac_DAL.sHorario = "K-D 9:00 AM-5:00 PM";

            var html = new StringBuilder();

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
            html.Append("<td>" + sCapacidad + "</td>");
            html.Append("</tr>");
            html.Append("<tr>");
            html.Append("<td>Duración</td>");
            html.Append("<td>" + sDuracion + "</td>");
            html.Append("</tr>");
            html.Append("<tr>");
            html.Append("<td>Disponibilidad</td>");
            html.Append("<td>" + obj_ParqueAtrac_DAL.sDisponibilidad + "</td>");
            html.Append("</tr>");
            html.Append("<tr>");
            html.Append("<td>Horario </td>");
            html.Append("<td>" + obj_ParqueAtrac_DAL.sHorario + "</td>");
            html.Append("</tr>");
            html.Append("</tbody>");
            html.Append("</table>");

            divTablaInfoAtraccion.InnerHtml = html.ToString();
        }

        protected void btnGiros_Click(object sender, EventArgs e)
        {
            obj_ParqueAtrac_DAL.sNombre = "Los giros";
            obj_ParqueAtrac_DAL.sTipo = "Rueda de chicago";
            obj_ParqueAtrac_DAL.byCapacidad = 40;
            string sCapacidad = obj_ParqueAtrac_DAL.byCapacidad + " Personas";
            obj_ParqueAtrac_DAL.byDuracion = 5;
            string sDuracion = obj_ParqueAtrac_DAL.byDuracion + " Minutos";
            obj_ParqueAtrac_DAL.sDisponibilidad = "En operación";
            obj_ParqueAtrac_DAL.sHorario = "K-D 9:00 AM-5:00 PM";

            var html = new StringBuilder();

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
            html.Append("<td>" + sCapacidad + "</td>");
            html.Append("</tr>");
            html.Append("<tr>");
            html.Append("<td>Duración</td>");
            html.Append("<td>" + sDuracion + "</td>");
            html.Append("</tr>");
            html.Append("<tr>");
            html.Append("<td>Disponibilidad</td>");
            html.Append("<td>" + obj_ParqueAtrac_DAL.sDisponibilidad + "</td>");
            html.Append("</tr>");
            html.Append("<tr>");
            html.Append("<td>Horario </td>");
            html.Append("<td>" + obj_ParqueAtrac_DAL.sHorario + "</td>");
            html.Append("</tr>");
            html.Append("</tbody>");
            html.Append("</table>");

            divTablaInfoAtraccion.InnerHtml = html.ToString();
        }

        protected void btnSkyMaster_Click(object sender, EventArgs e)
        {
            obj_ParqueAtrac_DAL.sNombre = "Sky Master";
            obj_ParqueAtrac_DAL.sTipo = "Rueda de chicago";
            obj_ParqueAtrac_DAL.byCapacidad = 10;
            string sCapacidad = obj_ParqueAtrac_DAL.byCapacidad + " Personas";
            obj_ParqueAtrac_DAL.byDuracion = 3;
            string sDuracion = obj_ParqueAtrac_DAL.byDuracion + " Minutos";
            obj_ParqueAtrac_DAL.sDisponibilidad = "En operación";
            obj_ParqueAtrac_DAL.sHorario = "K-D 9:00 AM-5:00 PM";

            var html = new StringBuilder();

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
            html.Append("<td>" + sCapacidad + "</td>");
            html.Append("</tr>");
            html.Append("<tr>");
            html.Append("<td>Duración</td>");
            html.Append("<td>" + sDuracion + "</td>");
            html.Append("</tr>");
            html.Append("<tr>");
            html.Append("<td>Disponibilidad</td>");
            html.Append("<td>" + obj_ParqueAtrac_DAL.sDisponibilidad + "</td>");
            html.Append("</tr>");
            html.Append("<tr>");
            html.Append("<td>Horario </td>");
            html.Append("<td>" + obj_ParqueAtrac_DAL.sHorario + "</td>");
            html.Append("</tr>");
            html.Append("</tbody>");
            html.Append("</table>");

            divTablaInfoAtraccion.InnerHtml = html.ToString();
        }

        protected void btnStarFlyer_Click(object sender, EventArgs e)
        {
            obj_ParqueAtrac_DAL.sNombre = "Star Flyer";
            obj_ParqueAtrac_DAL.sTipo = "Torre";
            obj_ParqueAtrac_DAL.byCapacidad = 15;
            string sCapacidad = obj_ParqueAtrac_DAL.byCapacidad + " Personas";
            obj_ParqueAtrac_DAL.byDuracion = 2;
            string sDuracion = obj_ParqueAtrac_DAL.byDuracion + " Minutos";
            obj_ParqueAtrac_DAL.sDisponibilidad = "En operación";
            obj_ParqueAtrac_DAL.sHorario = "K-D 9:00 AM-5:00 PM";

            var html = new StringBuilder();

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
            html.Append("<td>" + sCapacidad + "</td>");
            html.Append("</tr>");
            html.Append("<tr>");
            html.Append("<td>Duración</td>");
            html.Append("<td>" + sDuracion + "</td>");
            html.Append("</tr>");
            html.Append("<tr>");
            html.Append("<td>Disponibilidad</td>");
            html.Append("<td>" + obj_ParqueAtrac_DAL.sDisponibilidad + "</td>");
            html.Append("</tr>");
            html.Append("<tr>");
            html.Append("<td>Horario </td>");
            html.Append("<td>" + obj_ParqueAtrac_DAL.sHorario + "</td>");
            html.Append("</tr>");
            html.Append("</tbody>");
            html.Append("</table>");

            divTablaInfoAtraccion.InnerHtml = html.ToString();
        }

        protected void btnTarantula_Click(object sender, EventArgs e)
        {
            obj_ParqueAtrac_DAL.sNombre = "Tarántula";
            obj_ParqueAtrac_DAL.sTipo = "Montaña rusa";
            obj_ParqueAtrac_DAL.byCapacidad = 25;
            string sCapacidad = obj_ParqueAtrac_DAL.byCapacidad + " Personas";
            obj_ParqueAtrac_DAL.byDuracion = 5;
            string sDuracion = obj_ParqueAtrac_DAL.byDuracion + " Minutos";
            obj_ParqueAtrac_DAL.sDisponibilidad = "En operación";
            obj_ParqueAtrac_DAL.sHorario = "K-D 9:00 AM-5:00 PM";

            var html = new StringBuilder();

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
            html.Append("<td>" + sCapacidad + "</td>");
            html.Append("</tr>");
            html.Append("<tr>");
            html.Append("<td>Duración</td>");
            html.Append("<td>" + sDuracion + "</td>");
            html.Append("</tr>");
            html.Append("<tr>");
            html.Append("<td>Disponibilidad</td>");
            html.Append("<td>" + obj_ParqueAtrac_DAL.sDisponibilidad + "</td>");
            html.Append("</tr>");
            html.Append("<tr>");
            html.Append("<td>Horario </td>");
            html.Append("<td>" + obj_ParqueAtrac_DAL.sHorario + "</td>");
            html.Append("</tr>");
            html.Append("</tbody>");
            html.Append("</table>");

            divTablaInfoAtraccion.InnerHtml = html.ToString();
        }

        protected void btnTornado_Click(object sender, EventArgs e)
        {
            obj_ParqueAtrac_DAL.sNombre = "Tornado";
            obj_ParqueAtrac_DAL.sTipo = "Montaña rusa";
            obj_ParqueAtrac_DAL.byCapacidad = 20;
            string sCapacidad = obj_ParqueAtrac_DAL.byCapacidad + " Personas";
            obj_ParqueAtrac_DAL.byDuracion = 4;
            string sDuracion = obj_ParqueAtrac_DAL.byDuracion + " Minutos";
            obj_ParqueAtrac_DAL.sDisponibilidad = "En operación";
            obj_ParqueAtrac_DAL.sHorario = "K-D 9:00 AM-5:00 PM";

            var html = new StringBuilder();

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
            html.Append("<td>" + sCapacidad + "</td>");
            html.Append("</tr>");
            html.Append("<tr>");
            html.Append("<td>Duración</td>");
            html.Append("<td>" + sDuracion + "</td>");
            html.Append("</tr>");
            html.Append("<tr>");
            html.Append("<td>Disponibilidad</td>");
            html.Append("<td>" + obj_ParqueAtrac_DAL.sDisponibilidad + "</td>");
            html.Append("</tr>");
            html.Append("<tr>");
            html.Append("<td>Horario </td>");
            html.Append("<td>" + obj_ParqueAtrac_DAL.sHorario + "</td>");
            html.Append("</tr>");
            html.Append("</tbody>");
            html.Append("</table>");

            divTablaInfoAtraccion.InnerHtml = html.ToString();
        }
    }
}