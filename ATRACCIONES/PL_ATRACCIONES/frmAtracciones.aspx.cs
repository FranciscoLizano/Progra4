using BLL_ATRACCIONES.Atracciones;
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
        public static string seleccionarAtraccion(List<string> obj_Parametros_JS)
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
                                    "<td>Horario</td>" +
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



        [WebMethod]
        public static string accionaAtraccion(List<string> obj_Parametros_JS)
        {
            try
            {

                #region Variable global o de sesion (objeto de la entidad Atracciones)
                cls_Atracciones_DAL obj_Atracciones_DAL = new cls_Atracciones_DAL();
                cls_Atracciones_BLL obj_Atracciones_BLL = new cls_Atracciones_BLL();
                #endregion

                string _mensaje = string.Empty;
                string estado, condicion = string.Empty;

                // Se asignan los valores del obj_Parametros_JS 
                //--obj_Parametros_JS[0].ToString(); => Corresponde a la acción ejecutada
                obj_Atracciones_DAL.sNombre = obj_Parametros_JS[1].ToString();
                obj_Atracciones_DAL.sTipo = obj_Parametros_JS[2].ToString();
                obj_Atracciones_DAL.byCapacidad = Convert.ToByte(obj_Parametros_JS[3].ToString());
                obj_Atracciones_DAL.byDuracion = Convert.ToByte(obj_Parametros_JS[4].ToString());
                obj_Atracciones_DAL.bDisponibilidad = Convert.ToBoolean(obj_Parametros_JS[5].ToString());
                obj_Atracciones_DAL.sHorario = obj_Parametros_JS[6].ToString();
                obj_Atracciones_DAL.iEstado = Convert.ToInt32(obj_Parametros_JS[7].ToString());
                obj_Atracciones_DAL.bCondicion = Convert.ToBoolean(obj_Parametros_JS[8].ToString());


                /*Evaluamos la acción que ejecutó el usuario para llamar la lógica de negocio correspondiente*/
                if (obj_Parametros_JS[0] == "Iniciar")
                {
                    obj_Atracciones_BLL.Iniciar(ref obj_Atracciones_DAL);
                }
                else if (obj_Parametros_JS[0] == "Detener")
                {
                    obj_Atracciones_BLL.Detener(ref obj_Atracciones_DAL);
                }
                else if (obj_Parametros_JS[0] == "Mantenimiento")
                {
                    obj_Atracciones_BLL.Mantenimiento(ref obj_Atracciones_DAL);
                }
                else if (obj_Parametros_JS[0] == "Abrir")
                {
                    obj_Atracciones_BLL.Abrir(ref obj_Atracciones_DAL);
                }
                else
                {
                    obj_Atracciones_BLL.Cerrar(ref obj_Atracciones_DAL);
                }

                //Se determina si la condición es abierta o cerrada
                if (obj_Atracciones_DAL.bCondicion == true)
                {
                    condicion = "Abierta";
                }
                else
                {
                    condicion = "Cerrada";
                }

                //Se determina si el estado es 1 iniciada 2 detenida y 3 en mantenimiento 
                if (obj_Atracciones_DAL.iEstado == 1)
                {
                    estado = "Iniciada";
                }
                else if (obj_Atracciones_DAL.iEstado == 2)
                {
                    estado = "Detenida";
                }
                else
                {
                    estado = "En Mantenimiento";
                }

                //La siguiente es la tabla con la información que se la a devolver al js
                _mensaje = "" +
                            "<table>" +
                                "<tr>" +
                                    "<th> Acción </th>" +
                                    "<th> Tipo </th>" +
                                    "<th> Nombre </th>" +
                                    "<th> Estado </th>" +
                                "</tr>" +
                                "<tr>" +
                                    "<td>" + obj_Parametros_JS[0].ToString() + "</td>" +
                                    "<td>" + obj_Atracciones_DAL.sTipo.ToString() + "</td>" +
                                    "<td>" + obj_Atracciones_DAL.sNombre.ToString() + "</td>" +
                                    "<td>" + estado+ "</td>" +
                                "</tr>" +
                            "</table>";

                _mensaje = _mensaje + "<SPLITER>" +
                            obj_Atracciones_DAL.iEstado.ToString() + "<SPLITER>" +
                            obj_Atracciones_DAL.bCondicion.ToString() + "<SPLITER>";

                return _mensaje;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}