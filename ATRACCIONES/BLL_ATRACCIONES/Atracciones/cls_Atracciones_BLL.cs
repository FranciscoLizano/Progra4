using DLL_ATRACCIONES.Atracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_ATRACCIONES.Atracciones
{
    public class cls_Atracciones_BLL
    {

        /// <summary>
        /// Se inicia la atracción y coloca el estado en abierta
        /// </summary>
        /// <param name="obj_Atracciones_DAL"></param>
        public void Iniciar(ref cls_Atracciones_DAL obj_Atracciones_DAL)
        {
            obj_Atracciones_DAL.iEstado = 3;
        }

        /// <summary>
        /// Se abre la atracción y se coloca en estado abierta
        /// </summary>
        /// <param name="obj_Atracciones_DAL"></param>
        public void Abrir(ref cls_Atracciones_DAL obj_Atracciones_DAL)
        {
            obj_Atracciones_DAL.iEstado = 3;
        }

        /// <summary>
        /// Se detiene la atracción y se coloca en estado apagada
        /// </summary>
        /// <param name="obj_Atracciones_DAL"></param>
        public void Detener(ref cls_Atracciones_DAL obj_Atracciones_DAL)
        {
            obj_Atracciones_DAL.iEstado = 2;
        }

        /// <summary>
        /// Se cierra la atracción y se coloca en estado cerrada
        /// </summary>
        /// <param name="obj_Atracciones_DAL"></param>
        public void Cerrar(ref cls_Atracciones_DAL obj_Atracciones_DAL)
        {
            obj_Atracciones_DAL.iEstado = 4;
        }

        /// <summary>
        /// Se coloca la atracción en mantenimiento y se coloca en estado en mantenimiento
        /// </summary>
        /// <param name="obj_Atracciones_DAL"></param>
        public void Mantenimiento(ref cls_Atracciones_DAL obj_Atracciones_DAL)
        {
            obj_Atracciones_DAL.iEstado = 5;
        }

    }
}
