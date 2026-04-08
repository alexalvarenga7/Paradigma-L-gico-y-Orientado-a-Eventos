namespace PROGRAMACIÓN_ORIENTADA_A_EVENTOS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lstLogFacturacion = new System.Windows.Forms.ListBox();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lstLogSensor = new System.Windows.Forms.ListBox();
            this.lblValorTemp = new System.Windows.Forms.Label();
            this.tkbTemperatura = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lstLogEmpresarial = new System.Windows.Forms.ListBox();
            this.btnRegistrarPago = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnCrearOrden = new System.Windows.Forms.Button();
            this.lstLogEmpresarial_1 = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbTemperatura)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1016, 531);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lstLogFacturacion);
            this.tabPage1.Controls.Add(this.btnFacturar);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1008, 502);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Programa 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lstLogFacturacion
            // 
            this.lstLogFacturacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstLogFacturacion.FormattingEnabled = true;
            this.lstLogFacturacion.ItemHeight = 16;
            this.lstLogFacturacion.Location = new System.Drawing.Point(3, 3);
            this.lstLogFacturacion.Name = "lstLogFacturacion";
            this.lstLogFacturacion.Size = new System.Drawing.Size(1002, 84);
            this.lstLogFacturacion.TabIndex = 1;
            // 
            // btnFacturar
            // 
            this.btnFacturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturar.Location = new System.Drawing.Point(402, 123);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(125, 39);
            this.btnFacturar.TabIndex = 0;
            this.btnFacturar.Text = "Realizar Venta";
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lstLogSensor);
            this.tabPage2.Controls.Add(this.lblValorTemp);
            this.tabPage2.Controls.Add(this.tkbTemperatura);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1008, 502);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Programa 2 y 3";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstLogSensor
            // 
            this.lstLogSensor.Dock = System.Windows.Forms.DockStyle.Right;
            this.lstLogSensor.FormattingEnabled = true;
            this.lstLogSensor.ItemHeight = 16;
            this.lstLogSensor.Location = new System.Drawing.Point(885, 3);
            this.lstLogSensor.Name = "lstLogSensor";
            this.lstLogSensor.Size = new System.Drawing.Size(120, 496);
            this.lstLogSensor.TabIndex = 3;
            // 
            // lblValorTemp
            // 
            this.lblValorTemp.AutoSize = true;
            this.lblValorTemp.Location = new System.Drawing.Point(341, 207);
            this.lblValorTemp.Name = "lblValorTemp";
            this.lblValorTemp.Size = new System.Drawing.Size(44, 16);
            this.lblValorTemp.TabIndex = 2;
            this.lblValorTemp.Text = "label2";
            // 
            // tkbTemperatura
            // 
            this.tkbTemperatura.Location = new System.Drawing.Point(305, 135);
            this.tkbTemperatura.Maximum = 100;
            this.tkbTemperatura.Name = "tkbTemperatura";
            this.tkbTemperatura.Size = new System.Drawing.Size(104, 56);
            this.tkbTemperatura.TabIndex = 1;
            this.tkbTemperatura.Scroll += new System.EventHandler(this.tkbTemperatura_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sensor de Temperatura (IoT) y Alerta Crítica";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lstLogEmpresarial);
            this.tabPage3.Controls.Add(this.btnRegistrarPago);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1008, 502);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Programa 4";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lstLogEmpresarial
            // 
            this.lstLogEmpresarial.Dock = System.Windows.Forms.DockStyle.Right;
            this.lstLogEmpresarial.FormattingEnabled = true;
            this.lstLogEmpresarial.ItemHeight = 16;
            this.lstLogEmpresarial.Location = new System.Drawing.Point(747, 3);
            this.lstLogEmpresarial.Name = "lstLogEmpresarial";
            this.lstLogEmpresarial.Size = new System.Drawing.Size(258, 496);
            this.lstLogEmpresarial.TabIndex = 2;
            // 
            // btnRegistrarPago
            // 
            this.btnRegistrarPago.Location = new System.Drawing.Point(395, 194);
            this.btnRegistrarPago.Name = "btnRegistrarPago";
            this.btnRegistrarPago.Size = new System.Drawing.Size(128, 49);
            this.btnRegistrarPago.TabIndex = 0;
            this.btnRegistrarPago.Text = "Registrar pago";
            this.btnRegistrarPago.UseVisualStyleBackColor = true;
            this.btnRegistrarPago.Click += new System.EventHandler(this.btnRegistrarPago_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lstLogEmpresarial_1);
            this.tabPage4.Controls.Add(this.btnCrearOrden);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1008, 502);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Programa 5";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnCrearOrden
            // 
            this.btnCrearOrden.Location = new System.Drawing.Point(422, 183);
            this.btnCrearOrden.Name = "btnCrearOrden";
            this.btnCrearOrden.Size = new System.Drawing.Size(131, 79);
            this.btnCrearOrden.TabIndex = 0;
            this.btnCrearOrden.Text = "Crear Orden";
            this.btnCrearOrden.UseVisualStyleBackColor = true;
            this.btnCrearOrden.Click += new System.EventHandler(this.btnCrearOrden_Click);
            // 
            // lstLogEmpresarial_1
            // 
            this.lstLogEmpresarial_1.Dock = System.Windows.Forms.DockStyle.Right;
            this.lstLogEmpresarial_1.FormattingEnabled = true;
            this.lstLogEmpresarial_1.ItemHeight = 16;
            this.lstLogEmpresarial_1.Location = new System.Drawing.Point(747, 3);
            this.lstLogEmpresarial_1.Name = "lstLogEmpresarial_1";
            this.lstLogEmpresarial_1.Size = new System.Drawing.Size(258, 496);
            this.lstLogEmpresarial_1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 531);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbTemperatura)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox lstLogFacturacion;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lstLogSensor;
        private System.Windows.Forms.Label lblValorTemp;
        private System.Windows.Forms.TrackBar tkbTemperatura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox lstLogEmpresarial;
        private System.Windows.Forms.Button btnRegistrarPago;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnCrearOrden;
        private System.Windows.Forms.ListBox lstLogEmpresarial_1;
    }
}

