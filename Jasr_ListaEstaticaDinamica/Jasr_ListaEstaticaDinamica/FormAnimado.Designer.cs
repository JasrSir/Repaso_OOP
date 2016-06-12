namespace Jasr_ListaEstaticaDinamica
{
    partial class FormAnimado
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.btn_Listar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Aniadir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_Anime = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_borrar);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Listar);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Guardar);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Aniadir);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.tbx_Anime);
            this.splitContainer1.Panel2.Controls.Add(this.listBox1);
            this.splitContainer1.Size = new System.Drawing.Size(639, 446);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_borrar
            // 
            this.btn_borrar.AutoSize = true;
            this.btn_borrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_borrar.Location = new System.Drawing.Point(0, 168);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(200, 56);
            this.btn_borrar.TabIndex = 4;
            this.btn_borrar.Text = "Borrar";
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // btn_Listar
            // 
            this.btn_Listar.AutoSize = true;
            this.btn_Listar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Listar.Location = new System.Drawing.Point(0, 112);
            this.btn_Listar.Name = "btn_Listar";
            this.btn_Listar.Size = new System.Drawing.Size(200, 56);
            this.btn_Listar.TabIndex = 3;
            this.btn_Listar.Text = "Listar Diccionario";
            this.btn_Listar.UseVisualStyleBackColor = true;
            this.btn_Listar.Click += new System.EventHandler(this.btn_Listar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.AutoSize = true;
            this.btn_Guardar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Guardar.Location = new System.Drawing.Point(0, 56);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(200, 56);
            this.btn_Guardar.TabIndex = 1;
            this.btn_Guardar.Text = "Guardar en Fichero";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Aniadir
            // 
            this.btn_Aniadir.AutoSize = true;
            this.btn_Aniadir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Aniadir.Location = new System.Drawing.Point(0, 0);
            this.btn_Aniadir.Name = "btn_Aniadir";
            this.btn_Aniadir.Size = new System.Drawing.Size(200, 56);
            this.btn_Aniadir.TabIndex = 0;
            this.btn_Aniadir.Text = "Añadir Anime";
            this.btn_Aniadir.UseVisualStyleBackColor = true;
            this.btn_Aniadir.Click += new System.EventHandler(this.btn_Aniadir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Título Anime Visto";
            // 
            // tbx_Anime
            // 
            this.tbx_Anime.Location = new System.Drawing.Point(40, 38);
            this.tbx_Anime.Name = "tbx_Anime";
            this.tbx_Anime.Size = new System.Drawing.Size(220, 20);
            this.tbx_Anime.TabIndex = 1;
            this.tbx_Anime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbx_Anime_KeyDown);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(17, 187);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(406, 251);
            this.listBox1.TabIndex = 0;
            // 
            // FormAnimado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(639, 446);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormAnimado";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Button btn_Listar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Aniadir;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_Anime;
    }
}

