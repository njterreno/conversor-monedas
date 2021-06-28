
namespace Ejercicio_1__Act_2____Terreno
{
    partial class frmCotizacion
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
            this.gbxCotizacion = new System.Windows.Forms.GroupBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.lblDolar = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
            this.txtEuro = new System.Windows.Forms.TextBox();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.gbxCotizacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCotizacion
            // 
            this.gbxCotizacion.Controls.Add(this.btnCargar);
            this.gbxCotizacion.Controls.Add(this.lblDolar);
            this.gbxCotizacion.Controls.Add(this.lblEuro);
            this.gbxCotizacion.Controls.Add(this.txtEuro);
            this.gbxCotizacion.Controls.Add(this.txtDolar);
            this.gbxCotizacion.Location = new System.Drawing.Point(12, 12);
            this.gbxCotizacion.Name = "gbxCotizacion";
            this.gbxCotizacion.Size = new System.Drawing.Size(253, 71);
            this.gbxCotizacion.TabIndex = 26;
            this.gbxCotizacion.TabStop = false;
            this.gbxCotizacion.Text = "Cotización:";
            // 
            // btnCargar
            // 
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(90, 41);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(70, 23);
            this.btnCargar.TabIndex = 24;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.Location = new System.Drawing.Point(15, 18);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(32, 13);
            this.lblDolar.TabIndex = 22;
            this.lblDolar.Text = "Dólar";
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Location = new System.Drawing.Point(131, 18);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(29, 13);
            this.lblEuro.TabIndex = 23;
            this.lblEuro.Text = "Euro";
            // 
            // txtEuro
            // 
            this.txtEuro.Location = new System.Drawing.Point(163, 14);
            this.txtEuro.MaxLength = 8;
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(67, 20);
            this.txtEuro.TabIndex = 21;
            this.txtEuro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDolar_KeyPress);
            // 
            // txtDolar
            // 
            this.txtDolar.Location = new System.Drawing.Point(50, 14);
            this.txtDolar.MaxLength = 8;
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(67, 20);
            this.txtDolar.TabIndex = 20;
            this.txtDolar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDolar_KeyPress);
            // 
            // frmCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 95);
            this.Controls.Add(this.gbxCotizacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCotizacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cotizacion";
            this.gbxCotizacion.ResumeLayout(false);
            this.gbxCotizacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCotizacion;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.TextBox txtEuro;
        private System.Windows.Forms.TextBox txtDolar;
    }
}