using DLL_ATRACCIONES.Atracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PL_ATRACCIONES
{
    public partial class frmAtracciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static string seleccionVehiculo(List<string> obj_Parametros_JS)
        {
            try
            {

                #region Variable global o de sesion (objeto de la entidad Atracciones)
                cls_Atracciones_DAL obj_Atracciones_DAL= new cls_Atracciones_DAL(); 
                #endregion

                string _mensaje = string.Empty;
                string disponibilidad = string.Empty;

                /* Se obtine los datos del objeto del JavaScript y se descompone para
                    asignar los valores al objeto de atracciones */
                obj_Atracciones_DAL.sNombre = obj_Parametros_JS[0].ToString();
                obj_Atracciones_DAL.sTipo = obj_Parametros_JS[1].ToString();
                obj_Atracciones_DAL.byCapacidad = Convert.ToByte(obj_Parametros_JS[2].ToString());
                obj_Atracciones_DAL.byDuracion = Convert.ToByte(obj_Parametros_JS[3].ToString());
                obj_Atracciones_DAL.bDisponibilidad = Convert.ToBoolean(obj_Parametros_JS[4].ToString());
                obj_Atracciones_DAL.sHorario = obj_Parametros_JS[5].ToString();

                //Tabla de información que vamos a devolver al js
                if (obj_Atracciones_DAL.bDisponibilidad == true)
                {
                    disponibilidad = "Operativa";
                }
                else
                {
                    disponibilidad = "Fuera de servicio";
                }

                _mensaje = "" +
                            "<table>" +
                                "<tr>" +
                                    "<th> Propiedad </th>" +
                                    "<th> Valor </th>" +
                                "</tr>" +
                                "<tr>" +
                                    "<td>Nombre</td>" +
                                    "<td>" + obj_Atracciones_DAL.sNombre + "</td>" +
                                "</tr>" +
                                "<tr>" +
                                    "<td>Tipo</td>" +
                                    "<td>" + obj_Atracciones_DAL.sTipo + "</td>" +
                                "</tr>" +
                                "<tr>" +
                                    "<td>Capacidad</td>" +
                                    "<td>" + obj_Atracciones_DAL.byCapacidad.ToString() + " Personas" + "</td>" +
                                "</tr>" +
                                "<tr>" +
                                    "<td>Duración</td>" +
                                    "<td>" + obj_Atracciones_DAL.byDuracion.ToString() + " Minutos" + "</td>" +
                                "</tr>" +
                                "<tr>" +
                                    "<td>Disponibilidad</td>" +
                                    "<td>" + disponibilidad + "</td>" +
                                "</tr>" +
                                "<tr>" +
                                    "<td>Año</td>" +
                                    "<td>" + obj_Atracciones_DAL.sHorario + "</td>" +
                                "</tr>" +
                            "</table>";

                return _mensaje;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}