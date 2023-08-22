using System;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using BibliotecaBanco;
using Serializacion_de_un_Archivo;

namespace Deserealizacion_de_un_Archivo
{
    public partial class FrmLecturaDeserializable : frmBancoUI
    {
        private BinaryFormatter lector = new BinaryFormatter();
        private FileStream entrada;

        public FrmLecturaDeserializable()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectorArchivo = new OpenFileDialog();
            DialogResult resultado = selectorArchivo.ShowDialog();

            string nombreArchivo;

            if (resultado == DialogResult.Cancel)
                return;

            nombreArchivo = selectorArchivo.FileName;
            LimpiarControlesTextBox();

            if (nombreArchivo == "" || nombreArchivo == null)
                MessageBox.Show("Nombre de Archivo Invalido", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                entrada = new FileStream(
                    nombreArchivo, FileMode.Open, FileAccess.Read);

                button1.Enabled = false;
                button2.Enabled = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                RegistroSerializable registro =
                    (RegistroSerializable)lector.Deserialize(entrada);

                string[] valores = new string[]
                {
                    registro.Cuenta.ToString(),
                    registro.PrimerNombre.ToString(),
                    registro.ApellidoPaterno.ToString(),
                    registro.Saldo.ToString()
                };
                EstablecerValoresControlesTextBox(valores);
            }
            catch (SerializationException)
            {
                entrada.Close();
                button1.Enabled = true;
                button2.Enabled = false;

                LimpiarControlesTextBox();

                MessageBox.Show("No hay mas registro en el Archivo", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}