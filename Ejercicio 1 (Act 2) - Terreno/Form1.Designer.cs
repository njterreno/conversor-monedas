namespace Ejercicio_1__Act_2____Terreno
{
    partial class Form1
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
            this.txbimpconvertir = new System.Windows.Forms.TextBox();
            this.btnrestab = new System.Windows.Forms.Button();
            this.pnl_convertido = new System.Windows.Forms.Panel();
            this.rdbeuroconvertido = new System.Windows.Forms.RadioButton();
            this.rdbdolarconvertido = new System.Windows.Forms.RadioButton();
            this.rdbpesoconvertido = new System.Windows.Forms.RadioButton();
            this.pnl_convertir = new System.Windows.Forms.Panel();
            this.rdbeuroconvertir = new System.Windows.Forms.RadioButton();
            this.rdbdolarconvertir = new System.Windows.Forms.RadioButton();
            this.rdbpesoconvertir = new System.Windows.Forms.RadioButton();
            this.txbimpconvertido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_convertido.SuspendLayout();
            this.pnl_convertir.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbimpconvertir
            // 
            this.txbimpconvertir.Location = new System.Drawing.Point(136, 33);
            this.txbimpconvertir.Name = "txbimpconvertir";
            this.txbimpconvertir.Size = new System.Drawing.Size(100, 20);
            this.txbimpconvertir.TabIndex = 18;
            this.txbimpconvertir.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbimpconvertir.TextChanged += new System.EventHandler(this.txbimpconvertir_TextChanged);
            this.txbimpconvertir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_impconvertir_KeyPress);
            // 
            // btnrestab
            // 
            this.btnrestab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrestab.Location = new System.Drawing.Point(71, 226);
            this.btnrestab.Name = "btnrestab";
            this.btnrestab.Size = new System.Drawing.Size(129, 23);
            this.btnrestab.TabIndex = 17;
            this.btnrestab.Text = "Restablecer valores";
            this.btnrestab.UseVisualStyleBackColor = true;
            this.btnrestab.Click += new System.EventHandler(this.btnrestab_Click);
            // 
            // pnl_convertido
            // 
            this.pnl_convertido.Controls.Add(this.rdbeuroconvertido);
            this.pnl_convertido.Controls.Add(this.rdbdolarconvertido);
            this.pnl_convertido.Controls.Add(this.rdbpesoconvertido);
            this.pnl_convertido.Location = new System.Drawing.Point(159, 115);
            this.pnl_convertido.Name = "pnl_convertido";
            this.pnl_convertido.Size = new System.Drawing.Size(98, 100);
            this.pnl_convertido.TabIndex = 16;
            // 
            // rdbeuroconvertido
            // 
            this.rdbeuroconvertido.AutoSize = true;
            this.rdbeuroconvertido.Location = new System.Drawing.Point(4, 80);
            this.rdbeuroconvertido.Name = "rdbeuroconvertido";
            this.rdbeuroconvertido.Size = new System.Drawing.Size(52, 17);
            this.rdbeuroconvertido.TabIndex = 2;
            this.rdbeuroconvertido.Text = "Euros";
            this.rdbeuroconvertido.UseVisualStyleBackColor = true;
            // 
            // rdbdolarconvertido
            // 
            this.rdbdolarconvertido.AutoSize = true;
            this.rdbdolarconvertido.Checked = true;
            this.rdbdolarconvertido.Location = new System.Drawing.Point(4, 45);
            this.rdbdolarconvertido.Name = "rdbdolarconvertido";
            this.rdbdolarconvertido.Size = new System.Drawing.Size(61, 17);
            this.rdbdolarconvertido.TabIndex = 1;
            this.rdbdolarconvertido.TabStop = true;
            this.rdbdolarconvertido.Text = "Dolares";
            this.rdbdolarconvertido.UseVisualStyleBackColor = true;
            this.rdbdolarconvertido.CheckedChanged += new System.EventHandler(this.rdbdolarconvertido_CheckedChanged);
            // 
            // rdbpesoconvertido
            // 
            this.rdbpesoconvertido.AutoSize = true;
            this.rdbpesoconvertido.Location = new System.Drawing.Point(3, 13);
            this.rdbpesoconvertido.Name = "rdbpesoconvertido";
            this.rdbpesoconvertido.Size = new System.Drawing.Size(54, 17);
            this.rdbpesoconvertido.TabIndex = 0;
            this.rdbpesoconvertido.Text = "Pesos";
            this.rdbpesoconvertido.UseVisualStyleBackColor = true;
            this.rdbpesoconvertido.CheckedChanged += new System.EventHandler(this.rdbpesoconvertido_CheckedChanged);
            // 
            // pnl_convertir
            // 
            this.pnl_convertir.Controls.Add(this.rdbeuroconvertir);
            this.pnl_convertir.Controls.Add(this.rdbdolarconvertir);
            this.pnl_convertir.Controls.Add(this.rdbpesoconvertir);
            this.pnl_convertir.Location = new System.Drawing.Point(25, 115);
            this.pnl_convertir.Name = "pnl_convertir";
            this.pnl_convertir.Size = new System.Drawing.Size(91, 100);
            this.pnl_convertir.TabIndex = 15;
            // 
            // rdbeuroconvertir
            // 
            this.rdbeuroconvertir.AutoSize = true;
            this.rdbeuroconvertir.Location = new System.Drawing.Point(4, 80);
            this.rdbeuroconvertir.Name = "rdbeuroconvertir";
            this.rdbeuroconvertir.Size = new System.Drawing.Size(52, 17);
            this.rdbeuroconvertir.TabIndex = 2;
            this.rdbeuroconvertir.Text = "Euros";
            this.rdbeuroconvertir.UseVisualStyleBackColor = true;
            // 
            // rdbdolarconvertir
            // 
            this.rdbdolarconvertir.AutoSize = true;
            this.rdbdolarconvertir.Location = new System.Drawing.Point(3, 45);
            this.rdbdolarconvertir.Name = "rdbdolarconvertir";
            this.rdbdolarconvertir.Size = new System.Drawing.Size(61, 17);
            this.rdbdolarconvertir.TabIndex = 1;
            this.rdbdolarconvertir.Text = "Dolares";
            this.rdbdolarconvertir.UseVisualStyleBackColor = true;
            this.rdbdolarconvertir.CheckedChanged += new System.EventHandler(this.rdbdolarconvertir_CheckedChanged);
            // 
            // rdbpesoconvertir
            // 
            this.rdbpesoconvertir.AutoSize = true;
            this.rdbpesoconvertir.Checked = true;
            this.rdbpesoconvertir.Location = new System.Drawing.Point(3, 13);
            this.rdbpesoconvertir.Name = "rdbpesoconvertir";
            this.rdbpesoconvertir.Size = new System.Drawing.Size(54, 17);
            this.rdbpesoconvertir.TabIndex = 0;
            this.rdbpesoconvertir.TabStop = true;
            this.rdbpesoconvertir.Text = "Pesos";
            this.rdbpesoconvertir.UseVisualStyleBackColor = true;
            this.rdbpesoconvertir.CheckedChanged += new System.EventHandler(this.rdbpesoconvertir_CheckedChanged);
            // 
            // txbimpconvertido
            // 
            this.txbimpconvertido.Enabled = false;
            this.txbimpconvertido.Location = new System.Drawing.Point(135, 62);
            this.txbimpconvertido.Name = "txbimpconvertido";
            this.txbimpconvertido.Size = new System.Drawing.Size(100, 20);
            this.txbimpconvertido.TabIndex = 14;
            this.txbimpconvertido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "a:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "De:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Importe convertido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Importe a convertir";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 261);
            this.Controls.Add(this.txbimpconvertir);
            this.Controls.Add(this.btnrestab);
            this.Controls.Add(this.pnl_convertido);
            this.Controls.Add(this.pnl_convertir);
            this.Controls.Add(this.txbimpconvertido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Conversor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_convertido.ResumeLayout(false);
            this.pnl_convertido.PerformLayout();
            this.pnl_convertir.ResumeLayout(false);
            this.pnl_convertir.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbimpconvertir;
        private System.Windows.Forms.Button btnrestab;
        private System.Windows.Forms.Panel pnl_convertido;
        private System.Windows.Forms.RadioButton rdbeuroconvertido;
        private System.Windows.Forms.RadioButton rdbdolarconvertido;
        private System.Windows.Forms.RadioButton rdbpesoconvertido;
        private System.Windows.Forms.Panel pnl_convertir;
        private System.Windows.Forms.RadioButton rdbeuroconvertir;
        private System.Windows.Forms.RadioButton rdbdolarconvertir;
        private System.Windows.Forms.RadioButton rdbpesoconvertir;
        private System.Windows.Forms.TextBox txbimpconvertido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

