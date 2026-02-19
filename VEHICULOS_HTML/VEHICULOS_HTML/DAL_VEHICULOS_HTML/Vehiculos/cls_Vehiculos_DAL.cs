using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_VEHICULOS_HTML.Vehiculos
{
    public class cls_Vehiculos_DAL
    {
        #region Variables Privadas
        private string _sMarca, _sModelo;
        private int _iAno, _iVelocidad, _iKilometraje;
        private bool _bTransmision, _bEstado;
        #endregion

        #region Variables Públicas o Constructores
        //Este atributo representa la marca del vehículo
        public string sMarca { get => _sMarca; set => _sMarca = value; }
        /// <summary>
        /// Representa el modelo del vehículo
        /// </summary>
        public string sModelo { get => _sModelo; set => _sModelo = value; }
        /// <summary>
        /// Representa el año del vehículo
        /// </summary>
        public int iAno { get => _iAno; set => _iAno = value; }
        /// <summary>
        /// Representa la velocidad del vehículo
        /// </summary>
        public int iVelocidad { get => _iVelocidad; set => _iVelocidad = value; }
        /// <summary>
        /// Representa el kilometraje del vehículo
        /// </summary>
        public int iKilometraje { get => _iKilometraje; set => _iKilometraje = value; }
        /// <summary>
        /// Representa la transmisión del vehículo (1:True - Automático / 0:False - Manual)
        /// </summary>
        public bool bTransmision { get => _bTransmision; set => _bTransmision = value; }
        /// <summary>
        /// Representa el estado del vehículo (1:True - Encendido / 0:False - Apagado)
        /// </summary>
        public bool bEstado { get => _bEstado; set => _bEstado = value; }
        #endregion
    }
}
