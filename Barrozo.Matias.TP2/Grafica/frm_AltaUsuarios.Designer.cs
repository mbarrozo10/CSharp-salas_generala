namespace Grafica
{
    partial class frm_AltaUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AltaUsuarios));
            this.pnl_Superior = new System.Windows.Forms.Panel();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.txt_Contraseña = new System.Windows.Forms.TextBox();
            this.lbl_Alta = new System.Windows.Forms.Label();
            this.pnl_Fondo = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_SubrrayadoUno = new System.Windows.Forms.Panel();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.pnl_Fondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Superior
            // 
            this.pnl_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Superior.Location = new System.Drawing.Point(0, 0);
            this.pnl_Superior.Name = "pnl_Superior";
            this.pnl_Superior.Size = new System.Drawing.Size(448, 37);
            this.pnl_Superior.TabIndex = 0;
            this.pnl_Superior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Superior_MouseDown);
            this.pnl_Superior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Superior_MouseMove);
            this.pnl_Superior.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Superior_MouseUp);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Aceptar.ForeColor = System.Drawing.Color.White;
            this.btn_Aceptar.Location = new System.Drawing.Point(62, 268);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 1;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_Cancelar.Location = new System.Drawing.Point(62, 299);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 2;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.txt_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Nombre.ForeColor = System.Drawing.Color.White;
            this.txt_Nombre.Location = new System.Drawing.Point(50, 63);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.PlaceholderText = "Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 16);
            this.txt_Nombre.TabIndex = 3;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.txt_Apellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Apellido.ForeColor = System.Drawing.Color.White;
            this.txt_Apellido.Location = new System.Drawing.Point(50, 114);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.PlaceholderText = "Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(100, 16);
            this.txt_Apellido.TabIndex = 4;
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.txt_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Usuario.ForeColor = System.Drawing.Color.White;
            this.txt_Usuario.Location = new System.Drawing.Point(50, 165);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.PlaceholderText = "Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(100, 16);
            this.txt_Usuario.TabIndex = 5;
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.txt_Contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Contraseña.ForeColor = System.Drawing.Color.White;
            this.txt_Contraseña.Location = new System.Drawing.Point(50, 220);
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.PlaceholderText = "Contraseña";
            this.txt_Contraseña.Size = new System.Drawing.Size(100, 16);
            this.txt_Contraseña.TabIndex = 6;
            // 
            // lbl_Alta
            // 
            this.lbl_Alta.AutoSize = true;
            this.lbl_Alta.ForeColor = System.Drawing.Color.White;
            this.lbl_Alta.Location = new System.Drawing.Point(77, 12);
            this.lbl_Alta.Name = "lbl_Alta";
            this.lbl_Alta.Size = new System.Drawing.Size(28, 15);
            this.lbl_Alta.TabIndex = 7;
            this.lbl_Alta.Text = "Alta";
            // 
            // pnl_Fondo
            // 
            this.pnl_Fondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.pnl_Fondo.Controls.Add(this.panel3);
            this.pnl_Fondo.Controls.Add(this.panel2);
            this.pnl_Fondo.Controls.Add(this.panel1);
            this.pnl_Fondo.Controls.Add(this.pnl_SubrrayadoUno);
            this.pnl_Fondo.Controls.Add(this.lbl_Error);
            this.pnl_Fondo.Controls.Add(this.txt_Usuario);
            this.pnl_Fondo.Controls.Add(this.btn_Cancelar);
            this.pnl_Fondo.Controls.Add(this.lbl_Alta);
            this.pnl_Fondo.Controls.Add(this.btn_Aceptar);
            this.pnl_Fondo.Controls.Add(this.txt_Nombre);
            this.pnl_Fondo.Controls.Add(this.txt_Contraseña);
            this.pnl_Fondo.Controls.Add(this.txt_Apellido);
            this.pnl_Fondo.Location = new System.Drawing.Point(120, 75);
            this.pnl_Fondo.Name = "pnl_Fondo";
            this.pnl_Fondo.Size = new System.Drawing.Size(200, 325);
            this.pnl_Fondo.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(50, 238);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(96, 2);
            this.panel3.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(50, 183);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(96, 2);
            this.panel2.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(50, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(96, 2);
            this.panel1.TabIndex = 10;
            // 
            // pnl_SubrrayadoUno
            // 
            this.pnl_SubrrayadoUno.BackColor = System.Drawing.Color.White;
            this.pnl_SubrrayadoUno.Location = new System.Drawing.Point(50, 81);
            this.pnl_SubrrayadoUno.Name = "pnl_SubrrayadoUno";
            this.pnl_SubrrayadoUno.Size = new System.Drawing.Size(96, 2);
            this.pnl_SubrrayadoUno.TabIndex = 9;
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.ForeColor = System.Drawing.Color.White;
            this.lbl_Error.Location = new System.Drawing.Point(34, 45);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(137, 15);
            this.lbl_Error.TabIndex = 9;
            this.lbl_Error.Text = "Algun dato es incorrecto";
            this.lbl_Error.Visible = false;
            // 
            // frm_AltaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 450);
            this.Controls.Add(this.pnl_Fondo);
            this.Controls.Add(this.pnl_Superior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_AltaUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_AltaUsuarios";
            this.Load += new System.EventHandler(this.frm_AltaUsuarios_Load);
            this.pnl_Fondo.ResumeLayout(false);
            this.pnl_Fondo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnl_Superior;
        private Button btn_Aceptar;
        private Button btn_Cancelar;
        private TextBox txt_Nombre;
        private TextBox txt_Apellido;
        private TextBox txt_Usuario;
        private TextBox txt_Contraseña;
        private Label lbl_Alta;
        private Panel pnl_Fondo;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Panel pnl_SubrrayadoUno;
        private Label lbl_Error;
    }
}