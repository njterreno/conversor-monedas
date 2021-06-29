namespace Ejercicio_1__Act_2____Terreno
{
    partial class frmConvertir
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtImporteConvertir = new System.Windows.Forms.TextBox();
            this.btnReestablecer = new System.Windows.Forms.Button();
            this.pnlConvertido = new System.Windows.Forms.Panel();
            this.rdbEuroConvertido = new System.Windows.Forms.RadioButton();
            this.rdbDolarConvertido = new System.Windows.Forms.RadioButton();
            this.rdbPesoConvertido = new System.Windows.Forms.RadioButton();
            this.pnlConvertir = new System.Windows.Forms.Panel();
            this.rdbEuroConvertir = new System.Windows.Forms.RadioButton();
            this.rdbDolarConvertir = new System.Windows.Forms.RadioButton();
            this.rdbPesoConvertir = new System.Windows.Forms.RadioButton();
            this.txtImporteConvertido = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.lblDe = new System.Windows.Forms.Label();
            this.lblImporteConvertido = new System.Windows.Forms.Label();
            this.lblImporteConvertir = new System.Windows.Forms.Label();
            this.btnEditarCotizacion = new System.Windows.Forms.Button();
            this.pnlConvertido.SuspendLayout();
            this.pnlConvertir.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtImporteConvertir
            // 
            this.txtImporteConvertir.Location = new System.Drawing.Point(159, 8);
            this.txtImporteConvertir.MaxLength = 8;
            this.txtImporteConvertir.Name = "txtImporteConvertir";
            this.txtImporteConvertir.Size = new System.Drawing.Size(100, 20);
            this.txtImporteConvertir.TabIndex = 18;
            this.txtImporteConvertir.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtImporteConvertir.TextChanged += new System.EventHandler(this.txtImporteConvertir_TextChanged);
            this.txtImporteConvertir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporteConvertir_KeyPress);
            // 
            // btnReestablecer
            // 
            this.btnReestablecer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReestablecer.Location = new System.Drawing.Point(29, 196);
            this.btnReestablecer.Name = "btnReestablecer";
            this.btnReestablecer.Size = new System.Drawing.Size(107, 34);
            this.btnReestablecer.TabIndex = 17;
            this.btnReestablecer.Text = "Restablecer valores";
            this.btnReestablecer.UseVisualStyleBackColor = true;
            this.btnReestablecer.Click += new System.EventHandler(this.btnReestablecer_Click);
            // 
            // pnlConvertido
            // 
            this.pnlConvertido.Controls.Add(this.rdbEuroConvertido);
            this.pnlConvertido.Controls.Add(this.rdbDolarConvertido);
            this.pnlConvertido.Controls.Add(this.rdbPesoConvertido);
            this.pnlConvertido.Location = new System.Drawing.Point(159, 90);
            this.pnlConvertido.Name = "pnlConvertido";
            this.pnlConvertido.Size = new System.Drawing.Size(98, 100);
            this.pnlConvertido.TabIndex = 16;
            // 
            // rdbEuroConvertido
            // 
            this.rdbEuroConvertido.AutoSize = true;
            this.rdbEuroConvertido.Location = new System.Drawing.Point(4, 80);
            this.rdbEuroConvertido.Name = "rdbEuroConvertido";
            this.rdbEuroConvertido.Size = new System.Drawing.Size(52, 17);
            this.rdbEuroConvertido.TabIndex = 2;
            this.rdbEuroConvertido.Text = "Euros";
            this.rdbEuroConvertido.UseVisualStyleBackColor = true;
            // 
            // rdbDolarConvertido
            // 
            this.rdbDolarConvertido.AutoSize = true;
            this.rdbDolarConvertido.Checked = true;
            this.rdbDolarConvertido.Location = new System.Drawing.Point(4, 45);
            this.rdbDolarConvertido.Name = "rdbDolarConvertido";
            this.rdbDolarConvertido.Size = new System.Drawing.Size(61, 17);
            this.rdbDolarConvertido.TabIndex = 1;
            this.rdbDolarConvertido.TabStop = true;
            this.rdbDolarConvertido.Text = "Dólares";
            this.rdbDolarConvertido.UseVisualStyleBackColor = true;
            this.rdbDolarConvertido.CheckedChanged += new System.EventHandler(this.rdbDolarConvertido_CheckedChanged);
            // 
            // rdbPesoConvertido
            // 
            this.rdbPesoConvertido.AutoSize = true;
            this.rdbPesoConvertido.Location = new System.Drawing.Point(3, 13);
            this.rdbPesoConvertido.Name = "rdbPesoConvertido";
            this.rdbPesoConvertido.Size = new System.Drawing.Size(54, 17);
            this.rdbPesoConvertido.TabIndex = 0;
            this.rdbPesoConvertido.Text = "Pesos";
            this.rdbPesoConvertido.UseVisualStyleBackColor = true;
            this.rdbPesoConvertido.CheckedChanged += new System.EventHandler(this.rdbDolarConvertido_CheckedChanged);
            // 
            // pnlConvertir
            // 
            this.pnlConvertir.Controls.Add(this.rdbEuroConvertir);
            this.pnlConvertir.Controls.Add(this.rdbDolarConvertir);
            this.pnlConvertir.Controls.Add(this.rdbPesoConvertir);
            this.pnlConvertir.Location = new System.Drawing.Point(25, 90);
            this.pnlConvertir.Name = "pnlConvertir";
            this.pnlConvertir.Size = new System.Drawing.Size(91, 100);
            this.pnlConvertir.TabIndex = 15;
            // 
            // rdbEuroConvertir
            // 
            this.rdbEuroConvertir.AutoSize = true;
            this.rdbEuroConvertir.Location = new System.Drawing.Point(4, 80);
            this.rdbEuroConvertir.Name = "rdbEuroConvertir";
            this.rdbEuroConvertir.Size = new System.Drawing.Size(52, 17);
            this.rdbEuroConvertir.TabIndex = 2;
            this.rdbEuroConvertir.Text = "Euros";
            this.rdbEuroConvertir.UseVisualStyleBackColor = true;
            // 
            // rdbDolarConvertir
            // 
            this.rdbDolarConvertir.AutoSize = true;
            this.rdbDolarConvertir.Location = new System.Drawing.Point(3, 45);
            this.rdbDolarConvertir.Name = "rdbDolarConvertir";
            this.rdbDolarConvertir.Size = new System.Drawing.Size(61, 17);
            this.rdbDolarConvertir.TabIndex = 1;
            this.rdbDolarConvertir.Text = "Dólares";
            this.rdbDolarConvertir.UseVisualStyleBackColor = true;
            this.rdbDolarConvertir.CheckedChanged += new System.EventHandler(this.rdbDolarConvertido_CheckedChanged);
            // 
            // rdbPesoConvertir
            // 
            this.rdbPesoConvertir.AutoSize = true;
            this.rdbPesoConvertir.Checked = true;
            this.rdbPesoConvertir.Location = new System.Drawing.Point(3, 13);
            this.rdbPesoConvertir.Name = "rdbPesoConvertir";
            this.rdbPesoConvertir.Size = new System.Drawing.Size(54, 17);
            this.rdbPesoConvertir.TabIndex = 0;
            this.rdbPesoConvertir.TabStop = true;
            this.rdbPesoConvertir.Text = "Pesos";
            this.rdbPesoConvertir.UseVisualStyleBackColor = true;
            this.rdbPesoConvertir.CheckedChanged += new System.EventHandler(this.rdbDolarConvertido_CheckedChanged);
            // 
            // txtImporteConvertido
            // 
            this.txtImporteConvertido.Enabled = false;
            this.txtImporteConvertido.Location = new System.Drawing.Point(159, 37);
            this.txtImporteConvertido.MaxLength = 8;
            this.txtImporteConvertido.Name = "txtImporteConvertido";
            this.txtImporteConvertido.Size = new System.Drawing.Size(100, 20);
            this.txtImporteConvertido.TabIndex = 14;
            this.txtImporteConvertido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(159, 74);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(16, 13);
            this.lblA.TabIndex = 13;
            this.lblA.Text = "a:";
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Location = new System.Drawing.Point(20, 74);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(24, 13);
            this.lblDe.TabIndex = 12;
            this.lblDe.Text = "De:";
            // 
            // lblImporteConvertido
            // 
            this.lblImporteConvertido.AutoSize = true;
            this.lblImporteConvertido.Location = new System.Drawing.Point(22, 40);
            this.lblImporteConvertido.Name = "lblImporteConvertido";
            this.lblImporteConvertido.Size = new System.Drawing.Size(95, 13);
            this.lblImporteConvertido.TabIndex = 11;
            this.lblImporteConvertido.Text = "Importe convertido";
            // 
            // lblImporteConvertir
            // 
            this.lblImporteConvertir.AutoSize = true;
            this.lblImporteConvertir.Location = new System.Drawing.Point(21, 11);
            this.lblImporteConvertir.Name = "lblImporteConvertir";
            this.lblImporteConvertir.Size = new System.Drawing.Size(95, 13);
            this.lblImporteConvertir.TabIndex = 10;
            this.lblImporteConvertir.Text = "Importe a convertir";
            // 
            // btnEditarCotizacion
            // 
            this.btnEditarCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCotizacion.Location = new System.Drawing.Point(148, 196);
            this.btnEditarCotizacion.Name = "btnEditarCotizacion";
            this.btnEditarCotizacion.Size = new System.Drawing.Size(100, 34);
            this.btnEditarCotizacion.TabIndex = 19;
            this.btnEditarCotizacion.Text = "Editar cotización";
            this.btnEditarCotizacion.UseVisualStyleBackColor = true;
            this.btnEditarCotizacion.Click += new System.EventHandler(this.btnEditarCotizacion_Click);
            // 
            // frmConvertir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 242);
            this.Controls.Add(this.btnEditarCotizacion);
            this.Controls.Add(this.txtImporteConvertir);
            this.Controls.Add(this.btnReestablecer);
            this.Controls.Add(this.pnlConvertido);
            this.Controls.Add(this.pnlConvertir);
            this.Controls.Add(this.txtImporteConvertido);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblDe);
            this.Controls.Add(this.lblImporteConvertido);
            this.Controls.Add(this.lblImporteConvertir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmConvertir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmConvertir_FormClosed);
            this.Load += new System.EventHandler(this.frmConvertir_Load);
            this.pnlConvertido.ResumeLayout(false);
            this.pnlConvertido.PerformLayout();
            this.pnlConvertir.ResumeLayout(false);
            this.pnlConvertir.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReestablecer;
        private System.Windows.Forms.Panel pnlConvertido;
        private System.Windows.Forms.RadioButton rdbEuroConvertido;
        private System.Windows.Forms.RadioButton rdbDolarConvertido;
        private System.Windows.Forms.RadioButton rdbPesoConvertido;
        private System.Windows.Forms.Panel pnlConvertir;
        private System.Windows.Forms.RadioButton rdbEuroConvertir;
        private System.Windows.Forms.RadioButton rdbDolarConvertir;
        private System.Windows.Forms.RadioButton rdbPesoConvertir;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.Label lblImporteConvertido;
        private System.Windows.Forms.Label lblImporteConvertir;
        private System.Windows.Forms.Button btnEditarCotizacion;
        public System.Windows.Forms.TextBox txtImporteConvertir;
        public System.Windows.Forms.TextBox txtImporteConvertido;
    }
}

