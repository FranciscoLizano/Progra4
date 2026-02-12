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
        /// Indicaciones de Reversa:
        ///• La velocidad es igual a 10 km/h.
        ///• Los kilómetros recorridos aumentan en 4 km.
        /// </summary>
        /// <param name="obj_Vehiculo_DAL"></param>
        public void Reversa(ref cls_ParqueAtrac_DAL obj_ParqueAtrac_DAL)
        {

            obj_ParqueAtrac_DAL.sEstado = "Encendida";
            //obj_ParqueAtrac_DAL.iKilometraje += 4;

        }
    }
}
