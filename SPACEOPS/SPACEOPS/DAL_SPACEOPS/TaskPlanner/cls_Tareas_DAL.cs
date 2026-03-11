using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_SPACEOPS.TaskPlanner
{
    public class cls_Tareas_DAL
    {
        #region Variables Privadas
        /*Sección de campos de la tabla*/
        private int _iId_Tarea, _iId_Usuario, _iId_Estado, _iId_Prioridad, _iId_Actividad;
        private string _sTitulo, _sDescripcion;
        private DateTime _dFecha_Registro, _dFecha_Inicio, _dFecha_Finalizacion;
        /*Sección de campos de la tabla*/

        /*Sección presente en todas las clases*/
        private string _sValorScalar, _sAXN, _sMSJError;
        private DataTable _dtDatos, _dtParametros;
        /*Sección presente en todas las clases*/
        #endregion

        #region Variables Públicas o Constructores
        public int iId_Tarea { get => _iId_Tarea; set => _iId_Tarea = value; }
        public int iId_Usuario { get => _iId_Usuario; set => _iId_Usuario = value; }
        public int iId_Estado { get => _iId_Estado; set => _iId_Estado = value; }
        public int iId_Prioridad { get => _iId_Prioridad; set => _iId_Prioridad = value; }
        public int iId_Actividad { get => _iId_Actividad; set => _iId_Actividad = value; }
        public string sTitulo { get => _sTitulo; set => _sTitulo = value; }
        public string sDescripcion { get => _sDescripcion; set => _sDescripcion = value; }
        public DateTime dFecha_Registro { get => _dFecha_Registro; set => _dFecha_Registro = value; }
        public DateTime dFecha_Inicio { get => _dFecha_Inicio; set => _dFecha_Inicio = value; }
        public DateTime dFecha_Finalizacion { get => _dFecha_Finalizacion; set => _dFecha_Finalizacion = value; }
        public string sValorScalar { get => _sValorScalar; set => _sValorScalar = value; }
        public string sAXN { get => _sAXN; set => _sAXN = value; }
        public string sMSJError { get => _sMSJError; set => _sMSJError = value; }
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable dtParametros { get => _dtParametros; set => _dtParametros = value; }
        #endregion

    }
}
