namespace Nukkua
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBoxLiquidos;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TrackBar trackBarTemperatura;
        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.Panel panelSimulacion;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.comboBoxLiquidos = new System.Windows.Forms.ComboBox();
            this.btnSimular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.trackBarTemperatura = new System.Windows.Forms.TrackBar();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.panelSimulacion = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTemperatura)).BeginInit();
            this.SuspendLayout();
            
            // ComboBox para la selección de líquidos
            this.comboBoxLiquidos.FormattingEnabled = true;
            this.comboBoxLiquidos.Location = new System.Drawing.Point(12, 12);
            this.comboBoxLiquidos.Name = "comboBoxLiquidos";
            this.comboBoxLiquidos.Size = new System.Drawing.Size(260, 21);
            this.comboBoxLiquidos.TabIndex = 0;

            // Botón Simular
            this.btnSimular.Location = new System.Drawing.Point(12, 50);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(260, 23);
            this.btnSimular.TabIndex = 1;
            this.btnSimular.Text = "Simular Viscosidad";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);

            // TrackBar para ajustar la temperatura
            this.trackBarTemperatura.Location = new System.Drawing.Point(12, 90);
            this.trackBarTemperatura.Maximum = 100;
            this.trackBarTemperatura.Minimum = -20;
            this.trackBarTemperatura.Name = "trackBarTemperatura";
            this.trackBarTemperatura.Size = new System.Drawing.Size(260, 45);
            this.trackBarTemperatura.TabIndex = 2;
            this.trackBarTemperatura.Value = 25;

            // Label de temperatura
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Location = new System.Drawing.Point(12, 120);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(92, 13);
            this.lblTemperatura.TabIndex = 3;
            this.lblTemperatura.Text = "Temperatura (°C)";

            // Panel para simulación gráfica
            this.panelSimulacion.Location = new System.Drawing.Point(12, 150);
            this.panelSimulacion.Name = "panelSimulacion";
            this.panelSimulacion.Size = new System.Drawing.Size(260, 150);
            this.panelSimulacion.TabIndex = 4;
            this.panelSimulacion.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSimulacion_Paint);

            // Label para mostrar resultado
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(12, 320);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resultado";

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 351);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.panelSimulacion);
            this.Controls.Add(this.lblTemperatura);
            this.Controls.Add(this.trackBarTemperatura);
            this.Controls.Add(this.btnSimular);
            this.Controls.Add(this.comboBoxLiquidos);
            this.Name = "Form1";
            this.Text = "Nukkua - Simulador de Viscosidad";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTemperatura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
