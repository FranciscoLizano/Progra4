using DAL_VEHICULOS_HTML.Vehiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_VEHICULOS_HTML.Vehiculos
{
    public class cls_Vehiculos_BLL
    {
        /// <summary>
        /// Es el método para encender el vehículo
        /// </summary>
        /// <param name="obj_Vehiculos_DAL">Este es el objeto de vehiculos</param>
        public void encenderVehiculo(ref cls_Vehiculos_DAL obj_Vehiculos_DAL)
        {
            obj_Vehiculos_DAL.bEstado = true;
            obj_Vehiculos_DAL.iVelocidad = 0;
        }
        /// <summary>
        /// Es el método para apagar el vehículo
        /// </summary>
        /// <param name="obj_Vehiculos_DAL">Este es el objeto de vehiculos</param>
        public void apagarVehiculo(ref cls_Vehiculos_DAL obj_Vehiculos_DAL)
        {
            obj_Vehiculos_DAL.bEstado = false;
            obj_Vehiculos_DAL.iVelocidad = 0;
        }
        /// <summary>
        /// Es el método para acelerar el vehículo
        /// </summary>
        /// <param name="obj_Vehiculos_DAL">Este es el objeto de vehiculos</param>
        public void acelerarVehiculo(ref cls_Vehiculos_DAL obj_Vehiculos_DAL)
        {
            obj_Vehiculos_DAL.iVelocidad += 10;
            obj_Vehiculos_DAL.iKilometraje += 15;
        }
        /// <summary>
        /// Es el método para frenar el vehículo
        /// </summary>
        /// <param name="obj_Vehiculos_DAL">Este es el objeto de vehiculos</param>
        public void frenarVehiculo(ref cls_Vehiculos_DAL obj_Vehiculos_DAL)
        {
            if (obj_Vehiculos_DAL.iVelocidad >= 10)
            {
                obj_Vehiculos_DAL.iVelocidad -= 10;
                obj_Vehiculos_DAL.iKilometraje += 4;
            }
            else
            {
                obj_Vehiculos_DAL.iVelocidad = 0;
            }
        }
        /// <summary>
        /// Es el método para activar la reversa del vehículo
        /// La velocidad debe ser constante a 10 km/h
        /// El kilometraje acumulado solamente aumenta en 4
        /// </summary>
        /// <param name="obj_Vehiculos_DAL">Este es el objeto de vehiculos</param>
        public void reversaVehiculo(ref cls_Vehiculos_DAL obj_Vehiculos_DAL)
        {
            obj_Vehiculos_DAL.iVelocidad = 10;
            obj_Vehiculos_DAL.iKilometraje += 4;
        }
    }
}
