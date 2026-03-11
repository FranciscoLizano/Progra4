using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_SPACEOPS.TaskPlanner
{
    public class cls_Actividades_Tareas_DAL
    {
        #region Variables Privadas
        /*Sección de campos de la tabla*/
        private int _iId_Actividad;
        private string _sActividad;
        /*Sección de campos de la tabla*/

        /*Sección presente en todas las clases*/
        private string _sValorScalar, _sAXN, _sMSJError;
        private DataTable _dtDatos, _dtParametros;
        /*Sección presente en todas las clases*/
        #endregion
        #region Variables Públicas o Constructores
        public int iId_Actividad { get => _iId_Actividad; set => _iId_Actividad = value; }
        public string sSActividad { get => _sActividad; set => _sActividad = value; }
        public string sValorScalar { get => _sValorScalar; set => _sValorScalar = value; }
        public string sAXN { get => _sAXN; set => _sAXN = value; }
        public string sMSJError { get => _sMSJError; set => _sMSJError = value; }
        public DataTable dtDatos { get => _dtDatos; set => _dtDatos = value; }
        public DataTable dtParametros { get => _dtParametros; set => _dtParametros = value; }
        #endregion
    }
}
