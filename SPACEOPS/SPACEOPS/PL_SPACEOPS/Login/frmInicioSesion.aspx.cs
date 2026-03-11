using BLL_SPACEOPS.TaskPlanner;
using DAL_SPACEOPS.TaskPlanner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PL_SPACEOPS.Login
{
    public partial class frmInicioSesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static string InicioSesionUsuarios(List<string> obj_Parametros_JS)
        {
            try
            {
                string _mensaje = string.Empty;

                /*Objetos de la entidad con la que estamos trabajando*/
                cls_Usuarios_DAL obj_Usuarios_DAL = new cls_Usuarios_DAL();
                cls_Usuarios_BLL obj_Usuarios_BLL = new cls_Usuarios_BLL();


                /*Descomponer el objeto de parametros de JS y lo asignamos a los atributos de nuestra entidad*/
                obj_Usuarios_DAL.sCorreo = obj_Parametros_JS[0].ToString();
                obj_Usuarios_DAL.sPassword = obj_Parametros_JS[1].ToString();

                /*Ejecutar la lógica de negocio correspondiente*/
                obj_Usuarios_BLL.Inicio_Sesion_Usuarios(ref obj_Usuarios_DAL);

                /*Recuperamos los valores y los evaluamos (VALORES SCALARES / TABLAS DE DATOS)*/
                if (obj_Usuarios_DAL.sValorScalar == "-1")
                {
                    _mensaje = "-1" + "<SPLITER>" + "El usuario se encuentra inactivo. Por favor contacte al administrador del sistema.";
                }
                else if (obj_Usuarios_DAL.sValorScalar == "0")
                {
                    _mensaje = "0" + "<SPLITER>" + "Las credenciales no son válidas. Verifique!!!";
                }
                else
                {
                    obj_Usuarios_DAL.iId_Usuario = Convert.ToInt32(obj_Usuarios_DAL.sValorScalar);

                    _mensaje = obj_Usuarios_DAL.sValorScalar + "<SPLITER>" + "Bienvenido de nuevo" + "<SPLITER>" +"email" + "<SPLITER>" + "nombre usuario";
                }

                return _mensaje;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}