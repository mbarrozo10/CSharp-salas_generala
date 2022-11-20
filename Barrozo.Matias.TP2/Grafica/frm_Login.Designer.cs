namespace Grafica
{
    partial class frm_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.btn_Login = new System.Windows.Forms.Button();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.txt_Contraseña = new System.Windows.Forms.TextBox();
            this.pnl_MenuPrincipal = new System.Windows.Forms.Panel();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.pnl_Superior = new System.Windows.Forms.Panel();
            this.pnl_MenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(60, 219);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.txt_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Usuario.ForeColor = System.Drawing.Color.White;
            this.txt_Usuario.Location = new System.Drawing.Point(49, 95);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.PlaceholderText = "user";
            this.txt_Usuario.Size = new System.Drawing.Size(100, 16);
            this.txt_Usuario.TabIndex = 1;
            this.txt_Usuario.Text = "pepe";
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.txt_Contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Contraseña.ForeColor = System.Drawing.Color.White;
            this.txt_Contraseña.Location = new System.Drawing.Point(49, 149);
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.PasswordChar = '*';
            this.txt_Contraseña.PlaceholderText = "pass";
            this.txt_Contraseña.Size = new System.Drawing.Size(100, 16);
            this.txt_Contraseña.TabIndex = 2;
            this.txt_Contraseña.Text = "pepe";
            // 
            // pnl_MenuPrincipal
            // 
            this.pnl_MenuPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.pnl_MenuPrincipal.Controls.Add(this.btn_Salir);
            this.pnl_MenuPrincipal.Controls.Add(this.panel2);
            this.pnl_MenuPrincipal.Controls.Add(this.panel1);
            this.pnl_MenuPrincipal.Controls.Add(this.lbl_Login);
            this.pnl_MenuPrincipal.Controls.Add(this.lbl_Error);
            this.pnl_MenuPrincipal.Controls.Add(this.txt_Usuario);
            this.pnl_MenuPrincipal.Controls.Add(this.btn_Login);
            this.pnl_MenuPrincipal.Controls.Add(this.txt_Contraseña);
            this.pnl_MenuPrincipal.Location = new System.Drawing.Point(136, 105);
            this.pnl_MenuPrincipal.Name = "pnl_MenuPrincipal";
            this.pnl_MenuPrincipal.Size = new System.Drawing.Size(200, 294);
            this.pnl_MenuPrincipal.TabIndex = 3;
            // 
            // btn_Salir
            // 
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.ForeColor = System.Drawing.Color.White;
            this.btn_Salir.Location = new System.Drawing.Point(60, 253);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 7;
            this.btn_Salir.Text = "Login";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(49, 166);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 2);
            this.panel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(49, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 2);
            this.panel1.TabIndex = 5;
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Login.Location = new System.Drawing.Point(60, 24);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(73, 32);
            this.lbl_Login.TabIndex = 4;
            this.lbl_Login.Text = "Login";
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Location = new System.Drawing.Point(30, 187);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(137, 15);
            this.lbl_Error.TabIndex = 3;
            this.lbl_Error.Text = "Algun dato es incorrecto";
            this.lbl_Error.Visible = false;
            // 
            // pnl_Superior
            // 
            this.pnl_Superior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.pnl_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Superior.Location = new System.Drawing.Point(0, 0);
            this.pnl_Superior.Name = "pnl_Superior";
            this.pnl_Superior.Size = new System.Drawing.Size(471, 37);
            this.pnl_Superior.TabIndex = 4;
            this.pnl_Superior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Superior_MouseDown);
            this.pnl_Superior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Superior_MouseMove);
            this.pnl_Superior.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Superior_MouseUp);
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(471, 474);
            this.Controls.Add(this.pnl_Superior);
            this.Controls.Add(this.pnl_MenuPrincipal);
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_Login_Load);
            this.pnl_MenuPrincipal.ResumeLayout(false);
            this.pnl_MenuPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_Login;
        private TextBox txt_Usuario;
        private TextBox txt_Contraseña;
        private Panel pnl_MenuPrincipal;
        private Label lbl_Error;
        private Label lbl_Login;
        private Panel pnl_Superior;
        private Panel panel2;
        private Panel panel1;
        private Button btn_Salir;
    }
}