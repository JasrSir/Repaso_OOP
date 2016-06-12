namespace Jasr_Fracciones
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
            this.fr1_Num = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fr1_Den = new System.Windows.Forms.TextBox();
            this.fr2_Den = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fr2_Num = new System.Windows.Forms.TextBox();
            this.btn_Simplif = new System.Windows.Forms.Button();
            this.btn_Suma = new System.Windows.Forms.Button();
            this.btn_Resta = new System.Windows.Forms.Button();
            this.btn_Multipli = new System.Windows.Forms.Button();
            this.btn_Divi = new System.Windows.Forms.Button();
            this.btn_Invi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fr1_Num
            // 
            this.fr1_Num.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fr1_Num.Location = new System.Drawing.Point(57, 12);
            this.fr1_Num.MaxLength = 4;
            this.fr1_Num.Name = "fr1_Num";
            this.fr1_Num.Size = new System.Drawing.Size(136, 48);
            this.fr1_Num.TabIndex = 0;
            this.fr1_Num.Text = "0";
            this.fr1_Num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fr1_Num.TextChanged += new System.EventHandler(this.fr1_Den_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(54, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 10);
            this.label1.TabIndex = 1;
            this.label1.Text = "                          ";
            // 
            // fr1_Den
            // 
            this.fr1_Den.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fr1_Den.Location = new System.Drawing.Point(57, 96);
            this.fr1_Den.MaxLength = 4;
            this.fr1_Den.Name = "fr1_Den";
            this.fr1_Den.Size = new System.Drawing.Size(136, 48);
            this.fr1_Den.TabIndex = 2;
            this.fr1_Den.Text = "0";
            this.fr1_Den.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fr1_Den.TextChanged += new System.EventHandler(this.fr1_Den_TextChanged);
            // 
            // fr2_Den
            // 
            this.fr2_Den.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fr2_Den.Location = new System.Drawing.Point(268, 96);
            this.fr2_Den.MaxLength = 4;
            this.fr2_Den.Name = "fr2_Den";
            this.fr2_Den.Size = new System.Drawing.Size(136, 48);
            this.fr2_Den.TabIndex = 5;
            this.fr2_Den.Text = "0";
            this.fr2_Den.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fr2_Den.TextChanged += new System.EventHandler(this.fr1_Den_TextChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(265, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 10);
            this.label2.TabIndex = 4;
            this.label2.Text = "                          ";
            // 
            // fr2_Num
            // 
            this.fr2_Num.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fr2_Num.Location = new System.Drawing.Point(268, 12);
            this.fr2_Num.MaxLength = 4;
            this.fr2_Num.Name = "fr2_Num";
            this.fr2_Num.Size = new System.Drawing.Size(136, 48);
            this.fr2_Num.TabIndex = 3;
            this.fr2_Num.Text = "0";
            this.fr2_Num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fr2_Num.TextChanged += new System.EventHandler(this.fr1_Den_TextChanged);
            // 
            // btn_Simplif
            // 
            this.btn_Simplif.Font = new System.Drawing.Font("Consolas", 20F);
            this.btn_Simplif.Location = new System.Drawing.Point(36, 163);
            this.btn_Simplif.Name = "btn_Simplif";
            this.btn_Simplif.Size = new System.Drawing.Size(182, 43);
            this.btn_Simplif.TabIndex = 6;
            this.btn_Simplif.Text = "Simplifica";
            this.btn_Simplif.UseVisualStyleBackColor = true;
            this.btn_Simplif.Click += new System.EventHandler(this.btn_Simplif_Click);
            // 
            // btn_Suma
            // 
            this.btn_Suma.Font = new System.Drawing.Font("Consolas", 20F);
            this.btn_Suma.Location = new System.Drawing.Point(268, 163);
            this.btn_Suma.Name = "btn_Suma";
            this.btn_Suma.Size = new System.Drawing.Size(123, 43);
            this.btn_Suma.TabIndex = 7;
            this.btn_Suma.Text = "Suma";
            this.btn_Suma.UseVisualStyleBackColor = true;
            this.btn_Suma.Click += new System.EventHandler(this.btn_Suma_Click);
            // 
            // btn_Resta
            // 
            this.btn_Resta.Font = new System.Drawing.Font("Consolas", 20F);
            this.btn_Resta.Location = new System.Drawing.Point(268, 225);
            this.btn_Resta.Name = "btn_Resta";
            this.btn_Resta.Size = new System.Drawing.Size(123, 43);
            this.btn_Resta.TabIndex = 8;
            this.btn_Resta.Text = "Resta";
            this.btn_Resta.UseVisualStyleBackColor = true;
            this.btn_Resta.Click += new System.EventHandler(this.btn_Resta_Click);
            // 
            // btn_Multipli
            // 
            this.btn_Multipli.Font = new System.Drawing.Font("Consolas", 20F);
            this.btn_Multipli.Location = new System.Drawing.Point(36, 279);
            this.btn_Multipli.Name = "btn_Multipli";
            this.btn_Multipli.Size = new System.Drawing.Size(174, 43);
            this.btn_Multipli.TabIndex = 9;
            this.btn_Multipli.Text = "Multiplica";
            this.btn_Multipli.UseVisualStyleBackColor = true;
            this.btn_Multipli.Click += new System.EventHandler(this.btn_Multipli_Click);
            // 
            // btn_Divi
            // 
            this.btn_Divi.Font = new System.Drawing.Font("Consolas", 20F);
            this.btn_Divi.Location = new System.Drawing.Point(268, 279);
            this.btn_Divi.Name = "btn_Divi";
            this.btn_Divi.Size = new System.Drawing.Size(123, 43);
            this.btn_Divi.TabIndex = 10;
            this.btn_Divi.Text = "Divide";
            this.btn_Divi.UseVisualStyleBackColor = true;
            this.btn_Divi.Click += new System.EventHandler(this.btn_Divi_Click);
            // 
            // btn_Invi
            // 
            this.btn_Invi.Font = new System.Drawing.Font("Consolas", 20F);
            this.btn_Invi.Location = new System.Drawing.Point(45, 225);
            this.btn_Invi.Name = "btn_Invi";
            this.btn_Invi.Size = new System.Drawing.Size(148, 43);
            this.btn_Invi.TabIndex = 11;
            this.btn_Invi.Text = "Invierte";
            this.btn_Invi.UseVisualStyleBackColor = true;
            this.btn_Invi.Click += new System.EventHandler(this.btn_Invi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 334);
            this.Controls.Add(this.btn_Invi);
            this.Controls.Add(this.btn_Divi);
            this.Controls.Add(this.btn_Multipli);
            this.Controls.Add(this.btn_Resta);
            this.Controls.Add(this.btn_Suma);
            this.Controls.Add(this.btn_Simplif);
            this.Controls.Add(this.fr2_Den);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fr2_Num);
            this.Controls.Add(this.fr1_Den);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fr1_Num);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fr1_Num;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fr1_Den;
        private System.Windows.Forms.TextBox fr2_Den;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fr2_Num;
        private System.Windows.Forms.Button btn_Simplif;
        private System.Windows.Forms.Button btn_Suma;
        private System.Windows.Forms.Button btn_Resta;
        private System.Windows.Forms.Button btn_Multipli;
        private System.Windows.Forms.Button btn_Divi;
        private System.Windows.Forms.Button btn_Invi;
    }
}

