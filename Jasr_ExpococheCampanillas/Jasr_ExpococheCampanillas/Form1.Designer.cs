﻿namespace Jasr_ExpococheCampanillas
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
            this.button1 = new System.Windows.Forms.Button();
            this.cbx_Zona = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Vip = new System.Windows.Forms.Label();
            this.lbl_ConVen = new System.Windows.Forms.Label();
            this.lbl_Prin = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_Entradas = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(313, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "Comprar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbx_Zona
            // 
            this.cbx_Zona.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Zona.FormattingEnabled = true;
            this.cbx_Zona.Items.AddRange(new object[] {
            "Principal",
            "Compra - Venta",
            "Vip"});
            this.cbx_Zona.Location = new System.Drawing.Point(243, 24);
            this.cbx_Zona.Name = "cbx_Zona";
            this.cbx_Zona.Size = new System.Drawing.Size(181, 30);
            this.cbx_Zona.TabIndex = 1;
            this.cbx_Zona.Text = "Elige Zona";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Elige la Zona";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_Vip);
            this.groupBox1.Controls.Add(this.lbl_ConVen);
            this.groupBox1.Controls.Add(this.lbl_Prin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 124);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entradas Disponibles";
            // 
            // lbl_Vip
            // 
            this.lbl_Vip.AutoSize = true;
            this.lbl_Vip.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Vip.Location = new System.Drawing.Point(172, 83);
            this.lbl_Vip.Name = "lbl_Vip";
            this.lbl_Vip.Size = new System.Drawing.Size(60, 22);
            this.lbl_Vip.TabIndex = 8;
            this.lbl_Vip.Text = "nºvip";
            // 
            // lbl_ConVen
            // 
            this.lbl_ConVen.AutoSize = true;
            this.lbl_ConVen.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ConVen.Location = new System.Drawing.Point(172, 52);
            this.lbl_ConVen.Name = "lbl_ConVen";
            this.lbl_ConVen.Size = new System.Drawing.Size(50, 22);
            this.lbl_ConVen.TabIndex = 7;
            this.lbl_ConVen.Text = "nºcv";
            // 
            // lbl_Prin
            // 
            this.lbl_Prin.AutoSize = true;
            this.lbl_Prin.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Prin.Location = new System.Drawing.Point(172, 26);
            this.lbl_Prin.Name = "lbl_Prin";
            this.lbl_Prin.Size = new System.Drawing.Size(70, 22);
            this.lbl_Prin.TabIndex = 6;
            this.lbl_Prin.Text = "nºPrin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Vip :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Compra-Venta :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Principal :";
            // 
            // cbx_Entradas
            // 
            this.cbx_Entradas.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Entradas.FormattingEnabled = true;
            this.cbx_Entradas.Location = new System.Drawing.Point(243, 76);
            this.cbx_Entradas.Name = "cbx_Entradas";
            this.cbx_Entradas.Size = new System.Drawing.Size(124, 30);
            this.cbx_Entradas.TabIndex = 5;
            this.cbx_Entradas.Text = "Entradas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(210, 22);
            this.label8.TabIndex = 6;
            this.label8.Text = "Elige nº de Entradas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(458, 282);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbx_Entradas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_Zona);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbx_Zona;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_Vip;
        private System.Windows.Forms.Label lbl_ConVen;
        private System.Windows.Forms.Label lbl_Prin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_Entradas;
        private System.Windows.Forms.Label label8;
    }
}

