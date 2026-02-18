using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_VEHICULOS_HTML
{
    public class cls_Vehiculos_DAL
    {
        #region Variables Privadas
        private string _sMarca, _sModelo;
        private int _iVelocidad, _iKilometraje, _iAnio;
        private bool _bTransmision, _bEstado;
        #endregion

        #region Variables Públicas o Constructores
        /// <summary>
        /// Esto representa al atributo de marca del vehículo
        /// </summary>
        public string sMarca { get => _sMarca; set => _sMarca = value; }
        /// <summary>
        /// Esto representa al atributo de modelo del vehículo
        /// </summary>
        public string sModelo { get => _sModelo; set => _sModelo = value; }
        /// <summary>
        /// Esto representa al atributo de velocidad del vehículo
        /// </summary>
        public int iVelocidad { get => _iVelocidad; set => _iVelocidad = value; }
        /// <summary>
        /// Esto representa al atributo de kilometraje del vehículo
        /// </summary>
        public int iKilometraje { get => _iKilometraje; set => _iKilometraje = value; }

        /// <summary>
        /// Esto representa al atributo de año del vehículo
        /// </summary>
        public int iAnio { get => _iAnio; set => _iAnio = value; }

        /// <summary>
        /// Esto representa al atributo de transmisión del vehículo (True: Automático / False: Manual)
        /// </summary>
        public bool bTransmision { get => _bTransmision; set => _bTransmision = value; }
        /// <summary>
        /// Esto representa al atributo de estado del vehículo (True: Encendido / False: Apagado)
        /// </summary>
        public bool bEstado { get => _bEstado; set => _bEstado = value; }
        #endregion
    }
}
