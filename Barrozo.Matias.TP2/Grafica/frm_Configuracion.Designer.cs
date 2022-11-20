namespace Grafica
{
    partial class frm_Configuracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Configuracion));
            this.grp_Color = new System.Windows.Forms.GroupBox();
            this.rdb_Inverso = new System.Windows.Forms.RadioButton();
            this.rdb_Oscuro = new System.Windows.Forms.RadioButton();
            this.rdb_Claro = new System.Windows.Forms.RadioButton();
            this.grp_Idioma = new System.Windows.Forms.GroupBox();
            this.rdb_Portugues = new System.Windows.Forms.RadioButton();
            this.rdb_Japones = new System.Windows.Forms.RadioButton();
            this.rdb_Ingles = new System.Windows.Forms.RadioButton();
            this.rdb_Español = new System.Windows.Forms.RadioButton();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.pnl_Superior = new System.Windows.Forms.Panel();
            this.grp_Color.SuspendLayout();
            this.grp_Idioma.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_Color
            // 
            this.grp_Color.Controls.Add(this.rdb_Inverso);
            this.grp_Color.Controls.Add(this.rdb_Oscuro);
            this.grp_Color.Controls.Add(this.rdb_Claro);
            this.grp_Color.Location = new System.Drawing.Point(101, 112);
            this.grp_Color.Name = "grp_Color";
            this.grp_Color.Size = new System.Drawing.Size(200, 144);
            this.grp_Color.TabIndex = 0;
            this.grp_Color.TabStop = false;
            this.grp_Color.Text = "Color";
            // 
            // rdb_Inverso
            // 
            this.rdb_Inverso.AutoSize = true;
            this.rdb_Inverso.Location = new System.Drawing.Point(31, 108);
            this.rdb_Inverso.Name = "rdb_Inverso";
            this.rdb_Inverso.Size = new System.Drawing.Size(63, 19);
            this.rdb_Inverso.TabIndex = 4;
            this.rdb_Inverso.TabStop = true;
            this.rdb_Inverso.Text = "Inverso";
            this.rdb_Inverso.UseVisualStyleBackColor = true;
            this.rdb_Inverso.CheckedChanged += new System.EventHandler(this.rdb_Claro_CheckedChanged);
            // 
            // rdb_Oscuro
            // 
            this.rdb_Oscuro.AutoSize = true;
            this.rdb_Oscuro.Location = new System.Drawing.Point(31, 72);
            this.rdb_Oscuro.Name = "rdb_Oscuro";
            this.rdb_Oscuro.Size = new System.Drawing.Size(63, 19);
            this.rdb_Oscuro.TabIndex = 3;
            this.rdb_Oscuro.TabStop = true;
            this.rdb_Oscuro.Text = "Oscuro";
            this.rdb_Oscuro.UseVisualStyleBackColor = true;
            this.rdb_Oscuro.CheckedChanged += new System.EventHandler(this.rdb_Claro_CheckedChanged);
            // 
            // rdb_Claro
            // 
            this.rdb_Claro.AutoSize = true;
            this.rdb_Claro.Location = new System.Drawing.Point(31, 35);
            this.rdb_Claro.Name = "rdb_Claro";
            this.rdb_Claro.Size = new System.Drawing.Size(53, 19);
            this.rdb_Claro.TabIndex = 2;
            this.rdb_Claro.TabStop = true;
            this.rdb_Claro.Text = "Claro";
            this.rdb_Claro.UseVisualStyleBackColor = true;
            this.rdb_Claro.CheckedChanged += new System.EventHandler(this.rdb_Claro_CheckedChanged);
            // 
            // grp_Idioma
            // 
            this.grp_Idioma.Controls.Add(this.rdb_Portugues);
            this.grp_Idioma.Controls.Add(this.rdb_Japones);
            this.grp_Idioma.Controls.Add(this.rdb_Ingles);
            this.grp_Idioma.Controls.Add(this.rdb_Español);
            this.grp_Idioma.Location = new System.Drawing.Point(466, 112);
            this.grp_Idioma.Name = "grp_Idioma";
            this.grp_Idioma.Size = new System.Drawing.Size(200, 187);
            this.grp_Idioma.TabIndex = 1;
            this.grp_Idioma.TabStop = false;
            this.grp_Idioma.Text = "Idioma";
            // 
            // rdb_Portugues
            // 
            this.rdb_Portugues.AutoSize = true;
            this.rdb_Portugues.Location = new System.Drawing.Point(29, 144);
            this.rdb_Portugues.Name = "rdb_Portugues";
            this.rdb_Portugues.Size = new System.Drawing.Size(79, 19);
            this.rdb_Portugues.TabIndex = 8;
            this.rdb_Portugues.TabStop = true;
            this.rdb_Portugues.Text = "Portugues";
            this.rdb_Portugues.UseVisualStyleBackColor = true;
            this.rdb_Portugues.CheckedChanged += new System.EventHandler(this.rdb_Español_CheckedChanged);
            // 
            // rdb_Japones
            // 
            this.rdb_Japones.AutoSize = true;
            this.rdb_Japones.Location = new System.Drawing.Point(29, 108);
            this.rdb_Japones.Name = "rdb_Japones";
            this.rdb_Japones.Size = new System.Drawing.Size(67, 19);
            this.rdb_Japones.TabIndex = 7;
            this.rdb_Japones.TabStop = true;
            this.rdb_Japones.Text = "Japones";
            this.rdb_Japones.UseVisualStyleBackColor = true;
            this.rdb_Japones.CheckedChanged += new System.EventHandler(this.rdb_Español_CheckedChanged);
            // 
            // rdb_Ingles
            // 
            this.rdb_Ingles.AutoSize = true;
            this.rdb_Ingles.Location = new System.Drawing.Point(29, 72);
            this.rdb_Ingles.Name = "rdb_Ingles";
            this.rdb_Ingles.Size = new System.Drawing.Size(56, 19);
            this.rdb_Ingles.TabIndex = 6;
            this.rdb_Ingles.TabStop = true;
            this.rdb_Ingles.Text = "Ingles";
            this.rdb_Ingles.UseVisualStyleBackColor = true;
            this.rdb_Ingles.CheckedChanged += new System.EventHandler(this.rdb_Español_CheckedChanged);
            // 
            // rdb_Español
            // 
            this.rdb_Español.AutoSize = true;
            this.rdb_Español.Location = new System.Drawing.Point(29, 35);
            this.rdb_Español.Name = "rdb_Español";
            this.rdb_Español.Size = new System.Drawing.Size(66, 19);
            this.rdb_Español.TabIndex = 5;
            this.rdb_Español.TabStop = true;
            this.rdb_Español.Text = "Español";
            this.rdb_Español.UseVisualStyleBackColor = true;
            this.rdb_Español.CheckedChanged += new System.EventHandler(this.rdb_Español_CheckedChanged);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(591, 415);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_Guardar.TabIndex = 2;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Volver
            // 
            this.btn_Volver.Location = new System.Drawing.Point(499, 415);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(75, 23);
            this.btn_Volver.TabIndex = 3;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // pnl_Superior
            // 
            this.pnl_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Superior.Location = new System.Drawing.Point(0, 0);
            this.pnl_Superior.Name = "pnl_Superior";
            this.pnl_Superior.Size = new System.Drawing.Size(800, 37);
            this.pnl_Superior.TabIndex = 4;
            this.pnl_Superior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Superior_MouseDown);
            this.pnl_Superior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Superior_MouseMove);
            this.pnl_Superior.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Superior_MouseUp);
            // 
            // frm_Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_Superior);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.grp_Idioma);
            this.Controls.Add(this.grp_Color);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Configuracion";
            this.Text = "frm_Configuracion";
            this.Load += new System.EventHandler(this.frm_Configuracion_Load);
            this.grp_Color.ResumeLayout(false);
            this.grp_Color.PerformLayout();
            this.grp_Idioma.ResumeLayout(false);
            this.grp_Idioma.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grp_Color;
        private RadioButton rdb_Inverso;
        private RadioButton rdb_Oscuro;
        private RadioButton rdb_Claro;
        private GroupBox grp_Idioma;
        private RadioButton rdb_Portugues;
        private RadioButton rdb_Japones;
        private RadioButton rdb_Ingles;
        private RadioButton rdb_Español;
        private Button btn_Guardar;
        private Button btn_Volver;
        private Panel pnl_Superior;
    }
}