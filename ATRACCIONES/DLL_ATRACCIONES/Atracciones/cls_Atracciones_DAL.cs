using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_ATRACCIONES.Atracciones
{
    public class cls_Atracciones_DAL
    {
        // Se definen los atributos de las atracciones
        // Se defina la región para las variables privadas
        #region Variables Privadas
        private string _sNombre, _sTipo, _sHorario;
        private byte _byCapacidad, _byDuracion;
        private bool _bDisponibilidad, _bCondicion;
        private int _iEstado; // Los estados pueden ser 1 = Encendida, 2 = Detenida, 3 = En Mantenimiento

        #endregion

        // Se defina la región para las variables públicas o constructores
        #region Variables Públias o Constructores
        /// <summary>
        /// Esto representa el nombre de la atracción
        /// </summary>
        public string sNombre { get => _sNombre; set => _sNombre = value; }
        /// <summary>
        /// Esto representa de que tipo es la atracción ejemplo (montaña rusa, carrusel, rueda de la fortuna) 
        /// </summary>
        public string sTipo { get => _sTipo; set => _sTipo = value; }
        /// <summary>
        /// Esto representa el horario en que funciona la atracción
        /// </summary>
        public string sHorario { get => _sHorario; set => _sHorario = value; }
        /// <summary>
        /// Esto representa la capacidad que soporta la atracción ejemplo 50 personas 
        /// </summary>
        public byte byCapacidad { get => _byCapacidad; set => _byCapacidad = value; }
        /// <summary>
        /// Esto representa la duración del viaje de la atracción ejemplo 1,2,3,4 
        /// </summary>
        public byte byDuracion { get => _byDuracion; set => _byDuracion = value; }
        /// <summary>
        /// Esto representa si la atracción se puede utilizar si esta operativa true y fuera de servicio false
        /// </summary>
        public bool bDisponibilidad { get => _bDisponibilidad; set => _bDisponibilidad = value; }
        /// <summary>
        /// Esto representa el estado de la atraccion los cuales pueden ser  
        /// (1= Encendida, 2 = Detenida, 3 = En Mantenimiento)
        /// </summary>
        public int iEstado { get => _iEstado; set => _iEstado = value; }
        /// <summary>
        /// Esto representa si la atracción abierta true o cerrada false
        /// </summary>
        public bool bCondicion { get => _bCondicion; set => _bCondicion = value; }

        #endregion

    }
}
