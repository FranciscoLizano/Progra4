using DAL_VEHICULOS_HTML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_VEHICULOS_HTML.Vehiculos
{
    public class cls_vehiculos_BLL
    {
        /// <summary>
        /// Indicaciones de Encendido:
        ///• Al encender el vehículo, su velocidad se establece en 0 km/h y su estado pasa a ser "encendido".
        ///• Si el vehículo ya está encendido, no se puede volver a encender.
        /// </summary>
        /// <param name="obj_Vehiculo_DAL"></param>
        public void Encender(ref cls_Vehiculos_DAL obj_Vehiculo_DAL)
        {
            obj_Vehiculo_DAL.iVelocidad = 0;
            obj_Vehiculo_DAL.bEstado = true;
        }

        /// <summary>
        ///Indicaciones de Apagado:
        ///• Al apagar el vehículo, su velocidad se establece en 0 km/h y su estado pasa a ser "apagado".
        ///• Si el vehículo ya está apagado, no se puede volver a apagar.
        /// </summary>
        /// <param name="obj_Vehiculo_DAL"></param>
        public void Apagar(ref cls_Vehiculos_DAL obj_Vehiculo_DAL)
        {
            obj_Vehiculo_DAL.iVelocidad = 0;
            obj_Vehiculo_DAL.bEstado = false;
        }

        /// <summary>
        /// Indicaciones de Acelerado:
        ///• Al acelerar, la velocidad del vehículo aumenta en 10 km/h.
        ///• Además, los kilómetros recorridos aumentan en 15 km.
        /// </summary>
        /// <param name="obj_Vehiculo_DAL"></param>
        public void Acelerar(ref cls_Vehiculos_DAL obj_Vehiculo_DAL)
        {
            obj_Vehiculo_DAL.iVelocidad += 10;
            obj_Vehiculo_DAL.iKilometraje += 15;
        }


        /// <summary>
        /// Indicaciones de Acelerado:
        /// • Si la velocidad actual del vehículo es mayor o igual a 10 km/h:
        ///     La velocidad se reduce en 10 km/h.
        ///     Los kilómetros recorridos aumentan en 4 km. (Debido a la distancia de frenado).
        /// • Si la velocidad actual es menor a 10 km/h:
        ///     La velocidad se reduce a 0 km/h.
        ///     No se acumulan kilómetros recorridos.
        /// </summary>
        /// <param name="obj_Vehiculo_DAL"></param>
        public void Frenar(ref cls_Vehiculos_DAL obj_Vehiculo_DAL)
        {
            if (obj_Vehiculo_DAL.iVelocidad >= 10)
            {
                obj_Vehiculo_DAL.iVelocidad -= 10;
                obj_Vehiculo_DAL.iKilometraje += 4;
            }
            else
            {
                obj_Vehiculo_DAL.iVelocidad = 0;
            }
        }

        /// <summary>
        /// Indicaciones de Reversa:
        ///• La velocidad es igual a 10 km/h.
        ///• Los kilómetros recorridos aumentan en 4 km.
        /// </summary>
        /// <param name="obj_Vehiculo_DAL"></param>
        public void Reversa(ref cls_Vehiculos_DAL obj_Vehiculo_DAL)
        {

            obj_Vehiculo_DAL.iVelocidad = 10;
            obj_Vehiculo_DAL.iKilometraje += 4;

        }
    }
}
