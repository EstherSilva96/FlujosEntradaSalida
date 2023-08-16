using System;
using System.Windows.Forms;
using BibliotecaBanco;
using System.IO;

namespace BusquedaArchivo
{
    public partial class ConsultaCreditoFrm : Form
    {
        private FileStream entrada;
        private StreamReader archivoreader;

        private String nombreArchivo;
        public ConsultaCreditoFrm()
        {
            InitializeComponent();
        }
        private void ConsultaCreditoFrm_Load(object sender, EventArgs e) { }
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectorArchivo = new OpenFileDialog();
            DialogResult result = selectorArchivo.ShowDialog();

            if (result == DialogResult.Cancel)
                return;

            nombreArchivo = selectorArchivo.FileName;
            if (nombreArchivo == "" || nombreArchivo == null)
                MessageBox.Show("Nombre del archivo invàlido", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                entrada = new FileStream(nombreArchivo, FileMode.Open, FileAccess.Read);
                archivoreader = new StreamReader(entrada);

                btnAbrir.Enabled = false;
                btnSaldoCredito.Enabled = true;
                btnSaldoDebito.Enabled = true;
                btnSaldoCero.Enabled = true;
            }
        }
        private void ObtenerSaldos_Click(object sender, System.EventArgs e)
        {
            Button emisorButton = (Button)sender;
            string tipoCuenta = emisorButton.Text;

            try
            {
                entrada.Seek(0, SeekOrigin.Begin);
                MostrarTexboxs.Text = "Las Cuentas son: \r\n";

                while (true)
                {
                    string[] camposEntrada;
                    Registro registro;
                    decimal saldo;

                    string registroEntrada = archivoreader.ReadLine();

                    if (registroEntrada == null)
                        return;
                    camposEntrada = registroEntrada.Split(',');
                    registro = new Registro(Convert.ToInt32(camposEntrada[0]), camposEntrada[1], camposEntrada[2], Convert.ToDecimal(camposEntrada[3]));

                    saldo = registro.Saldo;

                    if (DebeMostrar(saldo, tipoCuenta))
                    {
                        string salida = registro.Cuenta + "\t" +
                            registro.PrimerNombre + "\t" + registro.ApellidoPaterno + "\t";

                        salida += String.Format("{O:F}", saldo) + "\r\n";
                        MostrarTexboxs.Text += salida;
                    }
                }
            }
            catch (IOException)
            {
                MessageBox.Show("No se puede leer el archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool DebeMostrar(decimal saldo, string tipoCuenta)
        {
            throw new NotImplementedException();
            if (saldo > 0)
            {
                if (tipoCuenta == "Saldos con crèdito")
                    return true;
            }
            else
            {
                if (tipoCuenta == "Saldos en cero")
                    return true;
            }
            return false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (entrada != null)
            {
                try
                {
                    entrada.Close();
                    archivoreader.Close();
                }
                catch (IOException)
                {
                    MessageBox.Show("No se puede cerrar el archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Application.Exit();
        }
    }
}
