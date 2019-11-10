namespace Pico_Placa
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTN_VERIFICAR = new System.Windows.Forms.Button();
            this.GB_INFORMACION = new System.Windows.Forms.GroupBox();
            this.LBL_HORA = new System.Windows.Forms.Label();
            this.LBL_FECHA = new System.Windows.Forms.Label();
            this.LBL_PLACA = new System.Windows.Forms.Label();
            this.TB_HORA = new System.Windows.Forms.TextBox();
            this.TB_FECHA = new System.Windows.Forms.TextBox();
            this.TB_PLACA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_RESPUESTA = new System.Windows.Forms.TextBox();
            this.BTN_NUEVA_BUSQ = new System.Windows.Forms.Button();
            this.GB_INFORMACION.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_VERIFICAR
            // 
            this.BTN_VERIFICAR.Location = new System.Drawing.Point(34, 235);
            this.BTN_VERIFICAR.Name = "BTN_VERIFICAR";
            this.BTN_VERIFICAR.Size = new System.Drawing.Size(136, 37);
            this.BTN_VERIFICAR.TabIndex = 0;
            this.BTN_VERIFICAR.Text = "VERIFICAR";
            this.BTN_VERIFICAR.UseVisualStyleBackColor = true;
            this.BTN_VERIFICAR.Click += new System.EventHandler(this.BTN_VERIFICAR_Click);
            // 
            // GB_INFORMACION
            // 
            this.GB_INFORMACION.Controls.Add(this.LBL_HORA);
            this.GB_INFORMACION.Controls.Add(this.LBL_FECHA);
            this.GB_INFORMACION.Controls.Add(this.LBL_PLACA);
            this.GB_INFORMACION.Controls.Add(this.TB_HORA);
            this.GB_INFORMACION.Controls.Add(this.TB_FECHA);
            this.GB_INFORMACION.Controls.Add(this.TB_PLACA);
            this.GB_INFORMACION.Location = new System.Drawing.Point(22, 62);
            this.GB_INFORMACION.Name = "GB_INFORMACION";
            this.GB_INFORMACION.Size = new System.Drawing.Size(489, 152);
            this.GB_INFORMACION.TabIndex = 1;
            this.GB_INFORMACION.TabStop = false;
            this.GB_INFORMACION.Text = "INFORMACIÓN:";
            // 
            // LBL_HORA
            // 
            this.LBL_HORA.AutoSize = true;
            this.LBL_HORA.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LBL_HORA.Location = new System.Drawing.Point(164, 108);
            this.LBL_HORA.Name = "LBL_HORA";
            this.LBL_HORA.Size = new System.Drawing.Size(311, 13);
            this.LBL_HORA.TabIndex = 8;
            this.LBL_HORA.Text = "INGRESAR LA HORA (HH:MM) EJ: 08:45 o 15:25 (24 HORAS) ";
            // 
            // LBL_FECHA
            // 
            this.LBL_FECHA.AutoSize = true;
            this.LBL_FECHA.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LBL_FECHA.Location = new System.Drawing.Point(164, 66);
            this.LBL_FECHA.Name = "LBL_FECHA";
            this.LBL_FECHA.Size = new System.Drawing.Size(280, 13);
            this.LBL_FECHA.TabIndex = 7;
            this.LBL_FECHA.Text = "INGRESAR LA FECHA (DD/MM/AAAA). EJ: 11/11/2019";
            // 
            // LBL_PLACA
            // 
            this.LBL_PLACA.AutoSize = true;
            this.LBL_PLACA.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LBL_PLACA.Location = new System.Drawing.Point(164, 31);
            this.LBL_PLACA.Name = "LBL_PLACA";
            this.LBL_PLACA.Size = new System.Drawing.Size(245, 13);
            this.LBL_PLACA.TabIndex = 6;
            this.LBL_PLACA.Text = "INGRESAR LA PLACA (XXX-####). EJ: PIB-1904";
            // 
            // TB_HORA
            // 
            this.TB_HORA.Enabled = false;
            this.TB_HORA.Location = new System.Drawing.Point(21, 108);
            this.TB_HORA.Name = "TB_HORA";
            this.TB_HORA.Size = new System.Drawing.Size(115, 20);
            this.TB_HORA.TabIndex = 5;
            this.TB_HORA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_HORA_CheckKeys);
            // 
            // TB_FECHA
            // 
            this.TB_FECHA.Enabled = false;
            this.TB_FECHA.Location = new System.Drawing.Point(21, 66);
            this.TB_FECHA.Name = "TB_FECHA";
            this.TB_FECHA.Size = new System.Drawing.Size(115, 20);
            this.TB_FECHA.TabIndex = 4;
            this.TB_FECHA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_FECHA_CheckKeys);
            // 
            // TB_PLACA
            // 
            this.TB_PLACA.AcceptsReturn = true;
            this.TB_PLACA.Location = new System.Drawing.Point(21, 28);
            this.TB_PLACA.Name = "TB_PLACA";
            this.TB_PLACA.Size = new System.Drawing.Size(115, 20);
            this.TB_PLACA.TabIndex = 3;
            this.TB_PLACA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_PLACA_CheckKeys);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "VERIFIQUE SI SU VEHIICULO PUEDE CIRCULAR...";
            // 
            // TB_RESPUESTA
            // 
            this.TB_RESPUESTA.Location = new System.Drawing.Point(118, 298);
            this.TB_RESPUESTA.Name = "TB_RESPUESTA";
            this.TB_RESPUESTA.Size = new System.Drawing.Size(262, 20);
            this.TB_RESPUESTA.TabIndex = 9;
            this.TB_RESPUESTA.Visible = false;
            // 
            // BTN_NUEVA_BUSQ
            // 
            this.BTN_NUEVA_BUSQ.Location = new System.Drawing.Point(330, 235);
            this.BTN_NUEVA_BUSQ.Name = "BTN_NUEVA_BUSQ";
            this.BTN_NUEVA_BUSQ.Size = new System.Drawing.Size(136, 37);
            this.BTN_NUEVA_BUSQ.TabIndex = 10;
            this.BTN_NUEVA_BUSQ.Text = "NUEVA BUSQUEDA";
            this.BTN_NUEVA_BUSQ.UseVisualStyleBackColor = true;
            this.BTN_NUEVA_BUSQ.Visible = false;
            this.BTN_NUEVA_BUSQ.Click += new System.EventHandler(this.BTN_NUEVA_BUSQ_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 356);
            this.Controls.Add(this.BTN_NUEVA_BUSQ);
            this.Controls.Add(this.TB_RESPUESTA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GB_INFORMACION);
            this.Controls.Add(this.BTN_VERIFICAR);
            this.Name = "Inicio";
            this.Text = "PICO & PLACA";
            this.GB_INFORMACION.ResumeLayout(false);
            this.GB_INFORMACION.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_VERIFICAR;
        private System.Windows.Forms.GroupBox GB_INFORMACION;
        private System.Windows.Forms.TextBox TB_HORA;
        private System.Windows.Forms.TextBox TB_FECHA;
        private System.Windows.Forms.TextBox TB_PLACA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBL_HORA;
        private System.Windows.Forms.Label LBL_FECHA;
        private System.Windows.Forms.Label LBL_PLACA;
        private System.Windows.Forms.TextBox TB_RESPUESTA;
        public string error_placa= "Error al ingresar la placa, revise el formato." ;
        public string error_fecha = "Error al ingresar la fecha, revise el formato.";
        public string error_hora = "Error al ingresar la hora, revise el formato.";
        public string puede = "SI PUEDE CIRCULAR SU VEHICULO.";
        public string no_puede = "NO PUEDE CIRCULAR SU VEHICULO.";
        private System.Windows.Forms.Button BTN_NUEVA_BUSQ;
    }
}

