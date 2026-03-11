using BLL_SPACEOPS.BD;
using DAL_SPACEOPS.BD;
using DAL_SPACEOPS.TaskPlanner;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_SPACEOPS.TaskPlanner
{
    public class cls_Usuarios_BLL
    {
        public void Inicio_Sesion_Usuarios(ref cls_Usuarios_DAL obj_Usuarios_DAL)
        {
			try
			{
				/*Objetos de comunicación al ámbito de base de datos (siempre va a ser necesario)*/
				cls_BD_DAL obj_BD_DAL = new cls_BD_DAL();
				cls_BD_BLL obj_BD_BLL = new cls_BD_BLL();

				/*Dar forma al atributo de DataTable de parámetros del objeto con el que estamos trabajando*/
				obj_Usuarios_DAL.dtParametros = null;
				obj_Usuarios_DAL.dtParametros = obj_BD_BLL.ObtieneDTParametros(obj_Usuarios_DAL.dtParametros);


				/*Agregar los parámetros que requiere el procedimiento almacenado*/
				/*Regla: Orden los valores de los parametros ==> Nombre del parámetro, Código de tipo de parámetro, Valor (atributo del objeto)*/
				obj_Usuarios_DAL.dtParametros.Rows.Add("@Correo", "6", obj_Usuarios_DAL.sCorreo);
                obj_Usuarios_DAL.dtParametros.Rows.Add("@Password", "6", obj_Usuarios_DAL.sPassword);

				/*Definir el nombre del KEY que contiene el nombre del procedimiento almacenado de la base de datos*/
				obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["SP_LogIn_Usuarios"];
				/*Definimos el tipo de acción que vamos a ejecutar (SCALAR / NORMAL)*/
				obj_BD_DAL.sIndAxn = "SCALAR";
				/*Le asignamos al DT Parametros del objeto de BD la misma estructura del DT Parametros de la entidad con la que estamos trabajando*/
				obj_BD_DAL.DT_Parametros = obj_Usuarios_DAL.dtParametros;

				/*Ejecutar en base de datos la sentencia o la instruccion de SQL*/
				obj_BD_BLL.EjecutaProcesosComando(ref obj_BD_DAL);

				/*Validar los resultados o la respuesta de bd*/
				/*Si el mensaje de error de base de datos es vacío..... entonces eso significa que todo salió de forma correcta y podemos recuperar los valores*/
				if (obj_BD_DAL.sMsjErrorBD == string.Empty)
				{
					obj_Usuarios_DAL.sMSJError = obj_BD_DAL.sMsjErrorBD;
					obj_Usuarios_DAL.sValorScalar = obj_BD_DAL.sValorScalar;
				}
                else
                {
                    obj_Usuarios_DAL.sMSJError = obj_BD_DAL.sMsjErrorBD;
					obj_Usuarios_DAL.sValorScalar = null;
                }
            }
			catch (Exception ex)
			{
				throw ex;
			}
        }


		public void Obitene_Informacion_Usuario(ref cls_Usuarios_DAL obj_Usuarios_DAL)
		{

            /*Objetos de comunicación al ámbito de base de datos (siempre va a ser necesario)*/
            cls_BD_DAL obj_BD_DAL = new cls_BD_DAL();
            cls_BD_BLL obj_BD_BLL = new cls_BD_BLL();

            /*Dar forma al atributo de DataTable de parámetros del objeto con el que estamos trabajando*/
            obj_Usuarios_DAL.dtParametros = null;
            obj_Usuarios_DAL.dtParametros = obj_BD_BLL.ObtieneDTParametros(obj_Usuarios_DAL.dtParametros);


            /*Agregar los parámetros que requiere el procedimiento almacenado*/
            /*Regla: Orden los valores de los parametros ==> Nombre del parámetro, Código de tipo de parámetro, Valor (atributo del objeto)*/
            obj_Usuarios_DAL.dtParametros.Rows.Add("@IdUsuario", "1", obj_Usuarios_DAL.sCorreo);

            /*Definir el nombre del KEY que contiene el nombre del procedimiento almacenado de la base de datos*/
            obj_BD_DAL.sNomSP = ConfigurationManager.AppSettings["SP_INFO_Usuarios"];

            /*Ejecutar en base de datos la sentencia o la instruccion de SQL*/
            obj_BD_BLL.EjecutaProcesosTabla(ref obj_BD_DAL);
        }
    }
}
