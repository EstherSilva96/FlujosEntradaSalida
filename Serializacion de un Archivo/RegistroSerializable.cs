using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializacion_de_un_Archivo
{
    [Serializable]
    public class RegistroSerializable
    {
        private int cuenta;
        private string primerNombre;
        private string apellidoPaterno;
        private decimal saldo;
        public RegistroSerializable()
            : this(0, "", "", 0.0M)
        {
        }

        public RegistroSerializable(int valorCuenta, string valorPrimerNombre,
            string valorApellidoPaterno, decimal valorSaldo)
        {
            Cuenta = valorCuenta;
            PrimerNombre = valorPrimerNombre;
            ApellidoPaterno = valorApellidoPaterno;
            Saldo = valorSaldo;
        }
        public int Cuenta
        {
            get
            {
                return cuenta;
            }
            set
            {
                cuenta = value;
            }
        }
        public string PrimerNombre
        {
            get
            {
                return primerNombre;
            }
            set
            {
                primerNombre = value;
            }
        }
        public string ApellidoPaterno
        {
            get
            {
                return apellidoPaterno;
            }
            set
            {
                apellidoPaterno = value;
            }
        }
        public decimal Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                saldo = value;
            }
        }
    }
}
