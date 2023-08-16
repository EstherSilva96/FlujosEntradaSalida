namespace BusquedaArchivo
{
    partial class ConsultaCreditoFrm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MostrarTexboxs = new System.Windows.Forms.RichTextBox();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnSaldoCredito = new System.Windows.Forms.Button();
            this.btnSaldoDebito = new System.Windows.Forms.Button();
            this.btnSaldoCero = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MostrarTexboxs
            // 
            this.MostrarTexboxs.Location = new System.Drawing.Point(31, 12);
            this.MostrarTexboxs.Name = "MostrarTexboxs";
            this.MostrarTexboxs.Size = new System.Drawing.Size(674, 301);
            this.MostrarTexboxs.TabIndex = 0;
            this.MostrarTexboxs.Text = "";
            // 
            // btnAbrir
            // 
            this.btnAbrir.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnAbrir.Location = new System.Drawing.Point(31, 356);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(131, 51);
            this.btnAbrir.TabIndex = 1;
            this.btnAbrir.Text = "Abrir Archivo";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnSaldoCredito
            // 
            this.btnSaldoCredito.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnSaldoCredito.Location = new System.Drawing.Point(168, 356);
            this.btnSaldoCredito.Name = "btnSaldoCredito";
            this.btnSaldoCredito.Size = new System.Drawing.Size(131, 51);
            this.btnSaldoCredito.TabIndex = 2;
            this.btnSaldoCredito.Text = "Saldos Con Créditos";
            this.btnSaldoCredito.UseVisualStyleBackColor = true;
            // 
            // btnSaldoDebito
            // 
            this.btnSaldoDebito.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnSaldoDebito.Location = new System.Drawing.Point(300, 356);
            this.btnSaldoDebito.Name = "btnSaldoDebito";
            this.btnSaldoDebito.Size = new System.Drawing.Size(131, 51);
            this.btnSaldoDebito.TabIndex = 3;
            this.btnSaldoDebito.Text = "Saldos Con Débitos";
            this.btnSaldoDebito.UseVisualStyleBackColor = true;
            // 
            // btnSaldoCero
            // 
            this.btnSaldoCero.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnSaldoCero.Location = new System.Drawing.Point(437, 356);
            this.btnSaldoCero.Name = "btnSaldoCero";
            this.btnSaldoCero.Size = new System.Drawing.Size(131, 51);
            this.btnSaldoCero.TabIndex = 4;
            this.btnSaldoCero.Text = "Saldos en Cero";
            this.btnSaldoCero.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Location = new System.Drawing.Point(574, 356);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(131, 51);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ConsultaCreditoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 461);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnSaldoCero);
            this.Controls.Add(this.btnSaldoDebito);
            this.Controls.Add(this.btnSaldoCredito);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.MostrarTexboxs);
            this.Name = "ConsultaCreditoFrm";
            this.Text = "Consulta de Archivos";
            this.Load += new System.EventHandler(this.ConsultaCreditoFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox MostrarTexboxs;
        private Button btnAbrir;
        private Button btnSaldoCredito;
        private Button btnSaldoDebito;
        private Button btnSaldoCero;
        private Button btnSalir;
    }
}