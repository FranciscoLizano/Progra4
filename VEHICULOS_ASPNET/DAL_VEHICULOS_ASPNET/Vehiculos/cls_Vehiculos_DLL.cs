using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_VEHICULOS_ASPNET.Vehiculos
{
    public class cls_Vehiculos_DLL
    {
        #region Variables Privadas
        private string _sMarca, _sModelo;
        private int _iVelocidad, _iKilometraje;
        private bool _bTransmicion, _bEstado;

        #endregion
        #region Variables publicas o constructores
        /// <summary>
        /// Esto representa al atributo de marca del vehiculo
        /// </summary>        
        public string sMarca { get => _sMarca; set => _sMarca = value; }
        /// <summary>
        /// Esto representa al atributo de modelo del vehiculo
        /// </summary>
        public string sModelo { get => _sModelo; set => _sModelo = value; }
        /// <summary>
        /// Esto representa al atributo de velocidad del vehiculo
        /// </summary>
        public int iVelocidad { get => _iVelocidad; set => _iVelocidad = value; }
        /// <summary>
        /// Esto representa al atributo de velocidad del vehiculo
        /// </summary>
        public int iKilometraje { get => _iKilometraje; set => _iKilometraje = value; }
        /// <summary>
        /// Esto representa al atributo de transmicion 1 automatica 0 manual del vehiculo
        /// </summary>
        public bool bTransmicion { get => _bTransmicion; set => _bTransmicion = value; }
        /// <summary>
        /// Esto representa al atributo de estado 1 encendido 0 apagado del vehiculo
        /// </summary>
        public bool bEstado { get => _bEstado; set => _bEstado = value; }
        #endregion
    }

}
