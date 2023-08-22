using System;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using BibliotecaBanco;

namespace Serializacion_de_un_Archivo
{
    public partial class SerializacionFrm : frmBancoUI
    {

        private BinaryFormatter aplicadorFormato = new BinaryFormatter();
        private FileStream salida;

        public SerializacionFrm()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog selectorArchivo = new SaveFileDialog();
            DialogResult resultado = selectorArchivo.ShowDialog();

            string nombreArchivo;

            selectorArchivo.CheckFileExists = false;

            if (resultado == DialogResult.Cancel)
                return;

            nombreArchivo = selectorArchivo.FileName;

            if (nombreArchivo == "" || nombreArchivo == null)
                MessageBox.Show("Nombre de Archivo invalido", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                try
                {
                    salida = new FileStream(nombreArchivo,
                        FileMode.OpenOrCreate, FileAccess.Write);

                    btnGuardar.Enabled = false;
                    btnIntroducir.Enabled = true;

                }
                catch (IOException)
                {
                    MessageBox.Show("Error al Abrir el Archvo", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btnIntroducir_Click(object sender, EventArgs e)
        {
            string[] valores = ObtenerValoresControlesTextBox();

            RegistroSerializable registro = new RegistroSerializable();

            if (valores[(int)IndicesTextBox.CUENTA] != "")
            {
                try
                {
                    int numeroCuenta = Int32.Parse(
                        valores[(int)IndicesTextBox.CUENTA]);

                    if (numeroCuenta > 0)
                    {
                        registro.Cuenta = numeroCuenta;
                        registro.PrimerNombre = valores[(int)IndicesTextBox.NOMBRE];
                        registro.ApellidoPaterno = valores[(int)IndicesTextBox.APELLIDO];
                        registro.Saldo = Decimal.Parse(valores[(int)IndicesTextBox.SALDO]);

                        aplicadorFormato.Serialize(salida, registro);
                    }
                    else
                    {
                        MessageBox.Show("Numero de Cuenta Invalido", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SerializationException)
                {
                    MessageBox.Show("Error al Escribir el Archivo", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                catch (FormatException)
                {
                    MessageBox.Show("Formato Invalido", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            LimpiarControlesTextBox();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (salida != null)
            {
                try
                {
                    salida.Close();
                }
                catch (IOException)
                {

                    MessageBox.Show("No se puede cerrar el Archivo", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Application.Exit();
        }
    }
}
