using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_PARQUE_ATRAC.ParqueAtrac;

namespace BLL_PARQUE_ATRAC.ParqueAtrac
{
    public class cls_ParqueAtrac_BLL
    {

        /// <summary>
        /// Se inicia la atracción y coloca el estado en encendida
        /// </summary>
        /// <param name="obj_Vehiculo_DAL"></param>
        public void Iniciar(ref cls_ParqueAtrac_DAL obj_ParqueAtrac_DAL)
        {
            obj_ParqueAtrac_DAL.iEstado = 3;
        }

        /// <summary>
        /// Se abre la atracción y se coloca en estado abierta
        /// </summary>
        /// <param name="obj_Vehiculo_DAL"></param>
        public void Abrir(ref cls_ParqueAtrac_DAL obj_ParqueAtrac_DAL)
        {
            obj_ParqueAtrac_DAL.iEstado = 3;
        }

        /// <summary>
        /// Se detiene la atracción y se coloca en estado apagada
        /// </summary>
        /// <param name="obj_Vehiculo_DAL"></param>
        public void Detener(ref cls_ParqueAtrac_DAL obj_ParqueAtrac_DAL)
        {
            obj_ParqueAtrac_DAL.iEstado = 2;
        }

        /// <summary>
        /// Se cierra la atracción y se coloca en estado cerrada
        /// </summary>
        /// <param name="obj_Vehiculo_DAL"></param>
        public void Cerrar(ref cls_ParqueAtrac_DAL obj_ParqueAtrac_DAL)
        {
            obj_ParqueAtrac_DAL.iEstado = 4;
        }

        /// <summary>
        /// Se cierra la atracción y se coloca en estado cerrada
        /// </summary>
        /// <param name="obj_Vehiculo_DAL"></param>
        public void Mantenimiento(ref cls_ParqueAtrac_DAL obj_ParqueAtrac_DAL)
        {
            obj_ParqueAtrac_DAL.iEstado = 5;
        }
    }
}
