namespace Jasr_Vehiculos
{
    partial class Form1
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
            this.btn_CrearCoche = new System.Windows.Forms.Button();
            this.btn_CrearBici = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_CrearCoche
            // 
            this.btn_CrearCoche.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CrearCoche.Location = new System.Drawing.Point(236, 12);
            this.btn_CrearCoche.Name = "btn_CrearCoche";
            this.btn_CrearCoche.Size = new System.Drawing.Size(105, 71);
            this.btn_CrearCoche.TabIndex = 0;
            this.btn_CrearCoche.Text = "Crea un Coche";
            this.btn_CrearCoche.UseVisualStyleBackColor = true;
            this.btn_CrearCoche.Click += new System.EventHandler(this.btn_CrearCoche_Click);
            // 
            // btn_CrearBici
            // 
            this.btn_CrearBici.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CrearBici.Location = new System.Drawing.Point(24, 12);
            this.btn_CrearBici.Name = "btn_CrearBici";
            this.btn_CrearBici.Size = new System.Drawing.Size(105, 71);
            this.btn_CrearBici.TabIndex = 1;
            this.btn_CrearBici.Text = "Crea una Bicicleta";
            this.btn_CrearBici.UseVisualStyleBackColor = true;
            this.btn_CrearBici.Click += new System.EventHandler(this.btn_CrearBici_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 105);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 71);
            this.button3.TabIndex = 3;
            this.button3.Text = "Haz el Caballito/Ve en coche";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(185, 105);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(180, 71);
            this.button4.TabIndex = 4;
            this.button4.Text = "Haz Maratón / Ve de vacaciones";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(12, 206);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(353, 156);
            this.listBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F);
            this.label1.Location = new System.Drawing.Point(13, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vehículo        KmRecorr   KmTotales";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(369, 383);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_CrearBici);
            this.Controls.Add(this.btn_CrearCoche);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CrearCoche;
        private System.Windows.Forms.Button btn_CrearBici;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
    }
}

