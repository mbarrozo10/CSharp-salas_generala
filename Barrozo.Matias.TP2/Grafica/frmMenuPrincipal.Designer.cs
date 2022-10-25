using Funcionalidad.clases;

namespace Grafica
{
    partial class frmMenuPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.ganadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_PartidaNueva = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgv_MenuPrincipal = new System.Windows.Forms.DataGridView();
            this.partidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.btn_Jugadores = new System.Windows.Forms.Button();
            this.btn_Partidas = new System.Windows.Forms.Button();
            this.pnl_Submenu = new System.Windows.Forms.Panel();
            this.btn_Full = new System.Windows.Forms.Button();
            this.btn_Demo = new System.Windows.Forms.Button();
            this.pnl_Superior = new System.Windows.Forms.Panel();
            this.lbl_Jugadores = new System.Windows.Forms.Label();
            this.nud_CantidadJugadores = new System.Windows.Forms.NumericUpDown();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MenuPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidaBindingSource)).BeginInit();
            this.pnl_Menu.SuspendLayout();
            this.pnl_Submenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CantidadJugadores)).BeginInit();
            this.SuspendLayout();
            // 
            // ganadorDataGridViewTextBoxColumn
            // 
            this.ganadorDataGridViewTextBoxColumn.DataPropertyName = "Ganador";
            this.ganadorDataGridViewTextBoxColumn.HeaderText = "Ganador";
            this.ganadorDataGridViewTextBoxColumn.Name = "ganadorDataGridViewTextBoxColumn";
            // 
            // btn_PartidaNueva
            // 
            this.btn_PartidaNueva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_PartidaNueva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PartidaNueva.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_PartidaNueva.FlatAppearance.BorderSize = 0;
            this.btn_PartidaNueva.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.btn_PartidaNueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PartidaNueva.ForeColor = System.Drawing.Color.White;
            this.btn_PartidaNueva.Location = new System.Drawing.Point(0, 0);
            this.btn_PartidaNueva.Name = "btn_PartidaNueva";
            this.btn_PartidaNueva.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_PartidaNueva.Size = new System.Drawing.Size(172, 51);
            this.btn_PartidaNueva.TabIndex = 1;
            this.btn_PartidaNueva.Text = "Nueva Partida";
            this.btn_PartidaNueva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PartidaNueva.UseVisualStyleBackColor = false;
            this.btn_PartidaNueva.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 474);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(172, 56);
            this.button2.TabIndex = 2;
            this.button2.Text = "Salir";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgv_MenuPrincipal
            // 
            this.dgv_MenuPrincipal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_MenuPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MenuPrincipal.Location = new System.Drawing.Point(228, 82);
            this.dgv_MenuPrincipal.Name = "dgv_MenuPrincipal";
            this.dgv_MenuPrincipal.RowTemplate.Height = 25;
            this.dgv_MenuPrincipal.Size = new System.Drawing.Size(494, 459);
            this.dgv_MenuPrincipal.TabIndex = 3;
            this.dgv_MenuPrincipal.Visible = false;
            this.dgv_MenuPrincipal.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_MenuPrincipal_RowHeaderMouseClick);
            // 
            // partidaBindingSource
            // 
            this.partidaBindingSource.DataSource = typeof(Funcionalidad.clases.Partida);
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.pnl_Menu.Controls.Add(this.btn_Jugadores);
            this.pnl_Menu.Controls.Add(this.btn_Partidas);
            this.pnl_Menu.Controls.Add(this.pnl_Submenu);
            this.pnl_Menu.Controls.Add(this.btn_PartidaNueva);
            this.pnl_Menu.Controls.Add(this.button2);
            this.pnl_Menu.Location = new System.Drawing.Point(0, 37);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(172, 530);
            this.pnl_Menu.TabIndex = 4;
            // 
            // btn_Jugadores
            // 
            this.btn_Jugadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_Jugadores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Jugadores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Jugadores.FlatAppearance.BorderSize = 0;
            this.btn_Jugadores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.btn_Jugadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Jugadores.ForeColor = System.Drawing.Color.White;
            this.btn_Jugadores.Location = new System.Drawing.Point(0, 188);
            this.btn_Jugadores.Name = "btn_Jugadores";
            this.btn_Jugadores.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Jugadores.Size = new System.Drawing.Size(172, 51);
            this.btn_Jugadores.TabIndex = 8;
            this.btn_Jugadores.Text = "Jugadores";
            this.btn_Jugadores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Jugadores.UseVisualStyleBackColor = false;
            this.btn_Jugadores.Click += new System.EventHandler(this.btn_Jugadores_Click);
            // 
            // btn_Partidas
            // 
            this.btn_Partidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_Partidas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Partidas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Partidas.FlatAppearance.BorderSize = 0;
            this.btn_Partidas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.btn_Partidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Partidas.ForeColor = System.Drawing.Color.White;
            this.btn_Partidas.Location = new System.Drawing.Point(0, 137);
            this.btn_Partidas.Name = "btn_Partidas";
            this.btn_Partidas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Partidas.Size = new System.Drawing.Size(172, 51);
            this.btn_Partidas.TabIndex = 7;
            this.btn_Partidas.Text = "Partidas";
            this.btn_Partidas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Partidas.UseVisualStyleBackColor = false;
            this.btn_Partidas.Click += new System.EventHandler(this.btn_MostrarPartidas_Click);
            // 
            // pnl_Submenu
            // 
            this.pnl_Submenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.pnl_Submenu.Controls.Add(this.btn_Full);
            this.pnl_Submenu.Controls.Add(this.btn_Demo);
            this.pnl_Submenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Submenu.Location = new System.Drawing.Point(0, 51);
            this.pnl_Submenu.Name = "pnl_Submenu";
            this.pnl_Submenu.Size = new System.Drawing.Size(172, 86);
            this.pnl_Submenu.TabIndex = 6;
            this.pnl_Submenu.Visible = false;
            // 
            // btn_Full
            // 
            this.btn_Full.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Full.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Full.FlatAppearance.BorderSize = 0;
            this.btn_Full.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.btn_Full.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Full.ForeColor = System.Drawing.Color.White;
            this.btn_Full.Location = new System.Drawing.Point(0, 40);
            this.btn_Full.Name = "btn_Full";
            this.btn_Full.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn_Full.Size = new System.Drawing.Size(172, 40);
            this.btn_Full.TabIndex = 7;
            this.btn_Full.Text = "Juego Completo";
            this.btn_Full.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Full.UseVisualStyleBackColor = true;
            this.btn_Full.Click += new System.EventHandler(this.btn_Full_Click);
            // 
            // btn_Demo
            // 
            this.btn_Demo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Demo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Demo.FlatAppearance.BorderSize = 0;
            this.btn_Demo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.btn_Demo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Demo.ForeColor = System.Drawing.Color.White;
            this.btn_Demo.Location = new System.Drawing.Point(0, 0);
            this.btn_Demo.Name = "btn_Demo";
            this.btn_Demo.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn_Demo.Size = new System.Drawing.Size(172, 40);
            this.btn_Demo.TabIndex = 6;
            this.btn_Demo.Text = "Demo";
            this.btn_Demo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Demo.UseVisualStyleBackColor = true;
            this.btn_Demo.Click += new System.EventHandler(this.btn_Demo_Click);
            // 
            // pnl_Superior
            // 
            this.pnl_Superior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.pnl_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Superior.Location = new System.Drawing.Point(0, 0);
            this.pnl_Superior.Name = "pnl_Superior";
            this.pnl_Superior.Size = new System.Drawing.Size(1110, 37);
            this.pnl_Superior.TabIndex = 5;
            // 
            // lbl_Jugadores
            // 
            this.lbl_Jugadores.AutoSize = true;
            this.lbl_Jugadores.ForeColor = System.Drawing.Color.White;
            this.lbl_Jugadores.Location = new System.Drawing.Point(228, 55);
            this.lbl_Jugadores.Name = "lbl_Jugadores";
            this.lbl_Jugadores.Size = new System.Drawing.Size(129, 15);
            this.lbl_Jugadores.TabIndex = 6;
            this.lbl_Jugadores.Text = "Cantidad de jugadores:";
            this.lbl_Jugadores.Visible = false;
            // 
            // nud_CantidadJugadores
            // 
            this.nud_CantidadJugadores.Location = new System.Drawing.Point(376, 53);
            this.nud_CantidadJugadores.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nud_CantidadJugadores.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nud_CantidadJugadores.Name = "nud_CantidadJugadores";
            this.nud_CantidadJugadores.Size = new System.Drawing.Size(40, 23);
            this.nud_CantidadJugadores.TabIndex = 7;
            this.nud_CantidadJugadores.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nud_CantidadJugadores.Visible = false;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(436, 53);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 8;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Visible = false;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1110, 567);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.nud_CantidadJugadores);
            this.Controls.Add(this.lbl_Jugadores);
            this.Controls.Add(this.pnl_Superior);
            this.Controls.Add(this.pnl_Menu);
            this.Controls.Add(this.dgv_MenuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenuPrincipal";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MenuPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidaBindingSource)).EndInit();
            this.pnl_Menu.ResumeLayout(false);
            this.pnl_Submenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_CantidadJugadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_PartidaNueva;
        private Button button2;
        private DataGridViewTextBoxColumn ganadorDataGridViewTextBoxColumn;
        private DataGridView dgv_MenuPrincipal;
        private Panel pnl_Menu;
        private BindingSource partidaBindingSource;
        private Panel pnl_Superior;
        private Panel pnl_Submenu;
        private Button btn_Full;
        private Button btn_Demo;
        private Button btn_Partidas;
        private Button btn_Jugadores;
        private Label lbl_Jugadores;
        private NumericUpDown nud_CantidadJugadores;
        private Button btn_Aceptar;
    }
}