using DAL_VEHICULOS_HTML.Vehiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PL_VEHICULOS_HTML
{
    public partial class frmVehiculosHTML : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static string seleccionVehiculo(List<string> obj_Parametros_JS)
        {
            try
            {
                #region Variables Globales o de sesión (objeto de la entidad vehiculos)
                cls_Vehiculos_DAL obj_Vehiculos_DAL = new cls_Vehiculos_DAL();
                #endregion

                string _mensaje = string.Empty;
                string transmision = string.Empty;

                //Obtener los datos del objeto que nos va a estar el JavaScript y lo vamos a descomponer para
                //asignar los valores a nuestro objeto de vehiculos
                obj_Vehiculos_DAL.sMarca = obj_Parametros_JS[0].ToString();
                obj_Vehiculos_DAL.sModelo = obj_Parametros_JS[1].ToString();
                obj_Vehiculos_DAL.bTransmision = Convert.ToBoolean(obj_Parametros_JS[2].ToString());
                obj_Vehiculos_DAL.iVelocidad = Convert.ToInt32(obj_Parametros_JS[3].ToString());
                obj_Vehiculos_DAL.iKilometraje = Convert.ToInt32(obj_Parametros_JS[4].ToString());
                obj_Vehiculos_DAL.bEstado = Convert.ToBoolean(obj_Parametros_JS[5].ToString());
                obj_Vehiculos_DAL.iAno = Convert.ToInt32(obj_Parametros_JS[6].ToString());


                //Tabla de información que vamos a devolver al js
                if (obj_Vehiculos_DAL.bTransmision == true)
                {
                    transmision = "AT";
                }
                else
                {
                    transmision = "False";
                }

                _mensaje = "" +
                            "<table>" +
                                "<tr>" +
                                    "<th> Propiedad </th>" +
                                    "<th> Valor </th>" +
                                "</tr>" +
                                "<tr>" +
                                    "<td>Marca</td>" +
                                    "<td>" + obj_Vehiculos_DAL.sMarca + "</td>" +
                                "</tr>" +
                                "<tr>" +
                                    "<td>Modelo</td>" +
                                    "<td>" + obj_Vehiculos_DAL.sModelo + "</td>" +
                                "</tr>" +
                                "<tr>" +
                                    "<td>Transmisión</td>" +
                                    "<td>" + transmision + "</td>" +
                                "</tr>" +
                                "<tr>" +
                                    "<td>Año</td>" +
                                    "<td>" + obj_Vehiculos_DAL.iAno.ToString() + "</td>" +
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