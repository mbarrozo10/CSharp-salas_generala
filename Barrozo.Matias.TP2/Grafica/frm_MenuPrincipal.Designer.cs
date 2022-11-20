using Funcionalidad.clases;

namespace Grafica
{
    partial class frm_MenuPrincipal
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
            this.btn_Salir = new System.Windows.Forms.Button();
            this.dgv_MenuPrincipal = new System.Windows.Forms.DataGridView();
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.btn_Estadisticas = new System.Windows.Forms.Button();
            this.pnl_Usuarios = new System.Windows.Forms.Panel();
            this.btn_VerUsuarios = new System.Windows.Forms.Button();
            this.btn_AltaUsuarios = new System.Windows.Forms.Button();
            this.btn_Usuarios = new System.Windows.Forms.Button();
            this.pnl_Partidas = new System.Windows.Forms.Panel();
            this.btn_Activas = new System.Windows.Forms.Button();
            this.btn_Partidas = new System.Windows.Forms.Button();
            this.pnl_Submenu = new System.Windows.Forms.Panel();
            this.btn_Full = new System.Windows.Forms.Button();
            this.btn_Demo = new System.Windows.Forms.Button();
            this.pnl_Superior = new System.Windows.Forms.Panel();
            this.btn_Configuracion = new System.Windows.Forms.Button();
            this.btn_Reglas = new System.Windows.Forms.Button();
            this.lbl_Jugadores = new System.Windows.Forms.Label();
            this.nud_CantidadJugadores = new System.Windows.Forms.NumericUpDown();
            this.btn_AceptarCantidad = new System.Windows.Forms.Button();
            this.rtx_Reglas = new System.Windows.Forms.RichTextBox();
            this.pnl_Jugar = new System.Windows.Forms.Panel();
            this.lbl_Seleccion = new System.Windows.Forms.Label();
            this.pnl_Estadisticas = new System.Windows.Forms.Panel();
            this.lbl_PartidasCanceladas = new System.Windows.Forms.Label();
            this.lbl_PartidasFinalizada = new System.Windows.Forms.Label();
            this.lbl_PartidasEmpatadas = new System.Windows.Forms.Label();
            this.dgv_Top = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partiasGanadasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_Top = new System.Windows.Forms.Label();
            this.lbl_CantidadPartidas = new System.Windows.Forms.Label();
            this.btn_CancelarPartida = new System.Windows.Forms.Button();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MenuPrincipal)).BeginInit();
            this.pnl_Menu.SuspendLayout();
            this.pnl_Usuarios.SuspendLayout();
            this.pnl_Partidas.SuspendLayout();
            this.pnl_Submenu.SuspendLayout();
            this.pnl_Superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CantidadJugadores)).BeginInit();
            this.pnl_Jugar.SuspendLayout();
            this.pnl_Estadisticas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
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
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.ForeColor = System.Drawing.Color.White;
            this.btn_Salir.Location = new System.Drawing.Point(0, 521);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Salir.Size = new System.Drawing.Size(172, 51);
            this.btn_Salir.TabIndex = 2;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgv_MenuPrincipal
            // 
            this.dgv_MenuPrincipal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_MenuPrincipal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.dgv_MenuPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MenuPrincipal.Location = new System.Drawing.Point(228, 107);
            this.dgv_MenuPrincipal.Name = "dgv_MenuPrincipal";
            this.dgv_MenuPrincipal.RowTemplate.Height = 25;
            this.dgv_MenuPrincipal.Size = new System.Drawing.Size(494, 459);
            this.dgv_MenuPrincipal.TabIndex = 3;
            this.dgv_MenuPrincipal.Visible = false;
            this.dgv_MenuPrincipal.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_MenuPrincipal_RowHeaderMouseClick);
            this.dgv_MenuPrincipal.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_MenuPrincipal_RowHeaderMouseDoubleClick);
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.pnl_Menu.Controls.Add(this.btn_Estadisticas);
            this.pnl_Menu.Controls.Add(this.pnl_Usuarios);
            this.pnl_Menu.Controls.Add(this.btn_Usuarios);
            this.pnl_Menu.Controls.Add(this.pnl_Partidas);
            this.pnl_Menu.Controls.Add(this.btn_Partidas);
            this.pnl_Menu.Controls.Add(this.pnl_Submenu);
            this.pnl_Menu.Controls.Add(this.btn_PartidaNueva);
            this.pnl_Menu.Controls.Add(this.btn_Salir);
            this.pnl_Menu.Location = new System.Drawing.Point(0, 37);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(172, 572);
            this.pnl_Menu.TabIndex = 4;
            // 
            // btn_Estadisticas
            // 
            this.btn_Estadisticas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_Estadisticas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Estadisticas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Estadisticas.FlatAppearance.BorderSize = 0;
            this.btn_Estadisticas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.btn_Estadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Estadisticas.ForeColor = System.Drawing.Color.White;
            this.btn_Estadisticas.Location = new System.Drawing.Point(0, 349);
            this.btn_Estadisticas.Name = "btn_Estadisticas";
            this.btn_Estadisticas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Estadisticas.Size = new System.Drawing.Size(172, 51);
            this.btn_Estadisticas.TabIndex = 11;
            this.btn_Estadisticas.Text = "Estadistica";
            this.btn_Estadisticas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Estadisticas.UseVisualStyleBackColor = false;
            this.btn_Estadisticas.Click += new System.EventHandler(this.btn_Estadisticas_Click);
            // 
            // pnl_Usuarios
            // 
            this.pnl_Usuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.pnl_Usuarios.Controls.Add(this.btn_VerUsuarios);
            this.pnl_Usuarios.Controls.Add(this.btn_AltaUsuarios);
            this.pnl_Usuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Usuarios.Location = new System.Drawing.Point(0, 270);
            this.pnl_Usuarios.Name = "pnl_Usuarios";
            this.pnl_Usuarios.Size = new System.Drawing.Size(172, 79);
            this.pnl_Usuarios.TabIndex = 10;
            this.pnl_Usuarios.Visible = false;
            // 
            // btn_VerUsuarios
            // 
            this.btn_VerUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_VerUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_VerUsuarios.FlatAppearance.BorderSize = 0;
            this.btn_VerUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.btn_VerUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VerUsuarios.ForeColor = System.Drawing.Color.White;
            this.btn_VerUsuarios.Location = new System.Drawing.Point(0, 40);
            this.btn_VerUsuarios.Name = "btn_VerUsuarios";
            this.btn_VerUsuarios.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn_VerUsuarios.Size = new System.Drawing.Size(172, 40);
            this.btn_VerUsuarios.TabIndex = 7;
            this.btn_VerUsuarios.Text = "Existentes";
            this.btn_VerUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_VerUsuarios.UseVisualStyleBackColor = true;
            this.btn_VerUsuarios.Click += new System.EventHandler(this.btn_Jugadores_Click);
            // 
            // btn_AltaUsuarios
            // 
            this.btn_AltaUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AltaUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_AltaUsuarios.FlatAppearance.BorderSize = 0;
            this.btn_AltaUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.btn_AltaUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AltaUsuarios.ForeColor = System.Drawing.Color.White;
            this.btn_AltaUsuarios.Location = new System.Drawing.Point(0, 0);
            this.btn_AltaUsuarios.Name = "btn_AltaUsuarios";
            this.btn_AltaUsuarios.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn_AltaUsuarios.Size = new System.Drawing.Size(172, 40);
            this.btn_AltaUsuarios.TabIndex = 6;
            this.btn_AltaUsuarios.Text = "Alta";
            this.btn_AltaUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AltaUsuarios.UseVisualStyleBackColor = true;
            this.btn_AltaUsuarios.Click += new System.EventHandler(this.btn_AltaUsuarios_Click);
            // 
            // btn_Usuarios
            // 
            this.btn_Usuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_Usuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Usuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Usuarios.FlatAppearance.BorderSize = 0;
            this.btn_Usuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.btn_Usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Usuarios.ForeColor = System.Drawing.Color.White;
            this.btn_Usuarios.Location = new System.Drawing.Point(0, 219);
            this.btn_Usuarios.Name = "btn_Usuarios";
            this.btn_Usuarios.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Usuarios.Size = new System.Drawing.Size(172, 51);
            this.btn_Usuarios.TabIndex = 9;
            this.btn_Usuarios.Text = "Usuarios";
            this.btn_Usuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Usuarios.UseVisualStyleBackColor = false;
            this.btn_Usuarios.Click += new System.EventHandler(this.btn_Usuarios_Click);
            // 
            // pnl_Partidas
            // 
            this.pnl_Partidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.pnl_Partidas.Controls.Add(this.btn_Activas);
            this.pnl_Partidas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Partidas.Location = new System.Drawing.Point(0, 182);
            this.pnl_Partidas.Name = "pnl_Partidas";
            this.pnl_Partidas.Size = new System.Drawing.Size(172, 37);
            this.pnl_Partidas.TabIndex = 8;
            this.pnl_Partidas.Visible = false;
            // 
            // btn_Activas
            // 
            this.btn_Activas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Activas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Activas.FlatAppearance.BorderSize = 0;
            this.btn_Activas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.btn_Activas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Activas.ForeColor = System.Drawing.Color.White;
            this.btn_Activas.Location = new System.Drawing.Point(0, 0);
            this.btn_Activas.Name = "btn_Activas";
            this.btn_Activas.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn_Activas.Size = new System.Drawing.Size(172, 40);
            this.btn_Activas.TabIndex = 6;
            this.btn_Activas.Text = "Activas";
            this.btn_Activas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Activas.UseVisualStyleBackColor = true;
            this.btn_Activas.Click += new System.EventHandler(this.btn_Activas_Click);
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
            this.btn_Partidas.Location = new System.Drawing.Point(0, 131);
            this.btn_Partidas.Name = "btn_Partidas";
            this.btn_Partidas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Partidas.Size = new System.Drawing.Size(172, 51);
            this.btn_Partidas.TabIndex = 7;
            this.btn_Partidas.Text = "Partidas";
            this.btn_Partidas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Partidas.UseVisualStyleBackColor = false;
            this.btn_Partidas.Click += new System.EventHandler(this.btn_Partidas_Click);
            // 
            // pnl_Submenu
            // 
            this.pnl_Submenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.pnl_Submenu.Controls.Add(this.btn_Full);
            this.pnl_Submenu.Controls.Add(this.btn_Demo);
            this.pnl_Submenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Submenu.Location = new System.Drawing.Point(0, 51);
            this.pnl_Submenu.Name = "pnl_Submenu";
            this.pnl_Submenu.Size = new System.Drawing.Size(172, 80);
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
            this.pnl_Superior.Controls.Add(this.btn_Configuracion);
            this.pnl_Superior.Controls.Add(this.btn_Reglas);
            this.pnl_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Superior.Location = new System.Drawing.Point(0, 0);
            this.pnl_Superior.Name = "pnl_Superior";
            this.pnl_Superior.Size = new System.Drawing.Size(1123, 37);
            this.pnl_Superior.TabIndex = 5;
            this.pnl_Superior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Superior_MouseDown);
            this.pnl_Superior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Superior_MouseMove);
            this.pnl_Superior.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Superior_MouseUp);
            // 
            // btn_Configuracion
            // 
            this.btn_Configuracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_Configuracion.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Configuracion.FlatAppearance.BorderSize = 0;
            this.btn_Configuracion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.btn_Configuracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Configuracion.ForeColor = System.Drawing.Color.White;
            this.btn_Configuracion.Location = new System.Drawing.Point(1035, 0);
            this.btn_Configuracion.Name = "btn_Configuracion";
            this.btn_Configuracion.Size = new System.Drawing.Size(44, 37);
            this.btn_Configuracion.TabIndex = 1;
            this.btn_Configuracion.Text = "C";
            this.btn_Configuracion.UseVisualStyleBackColor = false;
            this.btn_Configuracion.Click += new System.EventHandler(this.btn_Configuracion_Click);
            // 
            // btn_Reglas
            // 
            this.btn_Reglas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_Reglas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Reglas.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Reglas.FlatAppearance.BorderSize = 0;
            this.btn_Reglas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.btn_Reglas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reglas.ForeColor = System.Drawing.Color.White;
            this.btn_Reglas.Location = new System.Drawing.Point(1079, 0);
            this.btn_Reglas.Name = "btn_Reglas";
            this.btn_Reglas.Size = new System.Drawing.Size(44, 37);
            this.btn_Reglas.TabIndex = 0;
            this.btn_Reglas.Text = "?";
            this.btn_Reglas.UseVisualStyleBackColor = false;
            this.btn_Reglas.Click += new System.EventHandler(this.btn_Reglas_Click);
            // 
            // lbl_Jugadores
            // 
            this.lbl_Jugadores.AutoSize = true;
            this.lbl_Jugadores.ForeColor = System.Drawing.Color.White;
            this.lbl_Jugadores.Location = new System.Drawing.Point(3, 13);
            this.lbl_Jugadores.Name = "lbl_Jugadores";
            this.lbl_Jugadores.Size = new System.Drawing.Size(129, 15);
            this.lbl_Jugadores.TabIndex = 6;
            this.lbl_Jugadores.Text = "Cantidad de jugadores:";
            // 
            // nud_CantidadJugadores
            // 
            this.nud_CantidadJugadores.Location = new System.Drawing.Point(8, 40);
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
            // 
            // btn_AceptarCantidad
            // 
            this.btn_AceptarCantidad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.btn_AceptarCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AceptarCantidad.ForeColor = System.Drawing.Color.White;
            this.btn_AceptarCantidad.Location = new System.Drawing.Point(58, 40);
            this.btn_AceptarCantidad.Name = "btn_AceptarCantidad";
            this.btn_AceptarCantidad.Size = new System.Drawing.Size(75, 23);
            this.btn_AceptarCantidad.TabIndex = 8;
            this.btn_AceptarCantidad.Text = "Aceptar";
            this.btn_AceptarCantidad.UseVisualStyleBackColor = true;
            this.btn_AceptarCantidad.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // rtx_Reglas
            // 
            this.rtx_Reglas.Location = new System.Drawing.Point(225, 98);
            this.rtx_Reglas.Name = "rtx_Reglas";
            this.rtx_Reglas.ReadOnly = true;
            this.rtx_Reglas.Size = new System.Drawing.Size(823, 432);
            this.rtx_Reglas.TabIndex = 9;
            this.rtx_Reglas.Text = "";
            this.rtx_Reglas.Visible = false;
            // 
            // pnl_Jugar
            // 
            this.pnl_Jugar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.pnl_Jugar.Controls.Add(this.lbl_Seleccion);
            this.pnl_Jugar.Controls.Add(this.lbl_Jugadores);
            this.pnl_Jugar.Controls.Add(this.nud_CantidadJugadores);
            this.pnl_Jugar.Controls.Add(this.btn_AceptarCantidad);
            this.pnl_Jugar.Location = new System.Drawing.Point(728, 107);
            this.pnl_Jugar.Name = "pnl_Jugar";
            this.pnl_Jugar.Size = new System.Drawing.Size(154, 124);
            this.pnl_Jugar.TabIndex = 10;
            this.pnl_Jugar.Visible = false;
            // 
            // lbl_Seleccion
            // 
            this.lbl_Seleccion.AutoSize = true;
            this.lbl_Seleccion.ForeColor = System.Drawing.Color.White;
            this.lbl_Seleccion.Location = new System.Drawing.Point(8, 84);
            this.lbl_Seleccion.Name = "lbl_Seleccion";
            this.lbl_Seleccion.Size = new System.Drawing.Size(107, 30);
            this.lbl_Seleccion.TabIndex = 9;
            this.lbl_Seleccion.Text = "Dos click sobre \r\nel jugador deseado\r\n";
            this.lbl_Seleccion.Visible = false;
            // 
            // pnl_Estadisticas
            // 
            this.pnl_Estadisticas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.pnl_Estadisticas.Controls.Add(this.lbl_PartidasCanceladas);
            this.pnl_Estadisticas.Controls.Add(this.lbl_PartidasFinalizada);
            this.pnl_Estadisticas.Controls.Add(this.lbl_PartidasEmpatadas);
            this.pnl_Estadisticas.Controls.Add(this.dgv_Top);
            this.pnl_Estadisticas.Controls.Add(this.lbl_Top);
            this.pnl_Estadisticas.Controls.Add(this.lbl_CantidadPartidas);
            this.pnl_Estadisticas.Location = new System.Drawing.Point(725, 107);
            this.pnl_Estadisticas.Name = "pnl_Estadisticas";
            this.pnl_Estadisticas.Size = new System.Drawing.Size(323, 459);
            this.pnl_Estadisticas.TabIndex = 11;
            this.pnl_Estadisticas.Visible = false;
            // 
            // lbl_PartidasCanceladas
            // 
            this.lbl_PartidasCanceladas.AutoSize = true;
            this.lbl_PartidasCanceladas.ForeColor = System.Drawing.Color.White;
            this.lbl_PartidasCanceladas.Location = new System.Drawing.Point(28, 167);
            this.lbl_PartidasCanceladas.Name = "lbl_PartidasCanceladas";
            this.lbl_PartidasCanceladas.Size = new System.Drawing.Size(182, 15);
            this.lbl_PartidasCanceladas.TabIndex = 5;
            this.lbl_PartidasCanceladas.Text = "Cantidad de partidas Canceladas:";
            // 
            // lbl_PartidasFinalizada
            // 
            this.lbl_PartidasFinalizada.AutoSize = true;
            this.lbl_PartidasFinalizada.ForeColor = System.Drawing.Color.White;
            this.lbl_PartidasFinalizada.Location = new System.Drawing.Point(28, 127);
            this.lbl_PartidasFinalizada.Name = "lbl_PartidasFinalizada";
            this.lbl_PartidasFinalizada.Size = new System.Drawing.Size(179, 15);
            this.lbl_PartidasFinalizada.TabIndex = 4;
            this.lbl_PartidasFinalizada.Text = "Cantidad de partidas Finalizadas:";
            // 
            // lbl_PartidasEmpatadas
            // 
            this.lbl_PartidasEmpatadas.AutoSize = true;
            this.lbl_PartidasEmpatadas.ForeColor = System.Drawing.Color.White;
            this.lbl_PartidasEmpatadas.Location = new System.Drawing.Point(28, 86);
            this.lbl_PartidasEmpatadas.Name = "lbl_PartidasEmpatadas";
            this.lbl_PartidasEmpatadas.Size = new System.Drawing.Size(180, 15);
            this.lbl_PartidasEmpatadas.TabIndex = 3;
            this.lbl_PartidasEmpatadas.Text = "Cantidad de partidas Empatadas:";
            // 
            // dgv_Top
            // 
            this.dgv_Top.AutoGenerateColumns = false;
            this.dgv_Top.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.dgv_Top.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Top.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.userDataGridViewTextBoxColumn,
            this.partiasGanadasDataGridViewTextBoxColumn});
            this.dgv_Top.DataSource = this.usuarioBindingSource;
            this.dgv_Top.Location = new System.Drawing.Point(28, 297);
            this.dgv_Top.Name = "dgv_Top";
            this.dgv_Top.RowTemplate.Height = 25;
            this.dgv_Top.Size = new System.Drawing.Size(224, 150);
            this.dgv_Top.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // userDataGridViewTextBoxColumn
            // 
            this.userDataGridViewTextBoxColumn.DataPropertyName = "User";
            this.userDataGridViewTextBoxColumn.HeaderText = "User";
            this.userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            // 
            // partiasGanadasDataGridViewTextBoxColumn
            // 
            this.partiasGanadasDataGridViewTextBoxColumn.DataPropertyName = "PartiasGanadas";
            this.partiasGanadasDataGridViewTextBoxColumn.HeaderText = "PartiasGanadas";
            this.partiasGanadasDataGridViewTextBoxColumn.Name = "partiasGanadasDataGridViewTextBoxColumn";
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(Funcionalidad.clases.Usuario);
            // 
            // lbl_Top
            // 
            this.lbl_Top.AutoSize = true;
            this.lbl_Top.ForeColor = System.Drawing.Color.White;
            this.lbl_Top.Location = new System.Drawing.Point(28, 265);
            this.lbl_Top.Name = "lbl_Top";
            this.lbl_Top.Size = new System.Drawing.Size(82, 15);
            this.lbl_Top.TabIndex = 1;
            this.lbl_Top.Text = "Top Jugadores";
            // 
            // lbl_CantidadPartidas
            // 
            this.lbl_CantidadPartidas.AutoSize = true;
            this.lbl_CantidadPartidas.ForeColor = System.Drawing.Color.White;
            this.lbl_CantidadPartidas.Location = new System.Drawing.Point(28, 48);
            this.lbl_CantidadPartidas.Name = "lbl_CantidadPartidas";
            this.lbl_CantidadPartidas.Size = new System.Drawing.Size(119, 15);
            this.lbl_CantidadPartidas.TabIndex = 0;
            this.lbl_CantidadPartidas.Text = "Cantidad de partidas:";
            // 
            // btn_CancelarPartida
            // 
            this.btn_CancelarPartida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.btn_CancelarPartida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.btn_CancelarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelarPartida.ForeColor = System.Drawing.Color.White;
            this.btn_CancelarPartida.Location = new System.Drawing.Point(613, 572);
            this.btn_CancelarPartida.Name = "btn_CancelarPartida";
            this.btn_CancelarPartida.Size = new System.Drawing.Size(109, 23);
            this.btn_CancelarPartida.TabIndex = 10;
            this.btn_CancelarPartida.Text = "Cancelar Partida";
            this.btn_CancelarPartida.UseVisualStyleBackColor = false;
            this.btn_CancelarPartida.Visible = false;
            this.btn_CancelarPartida.Click += new System.EventHandler(this.btn_CancelarPartida_Click);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Titulo.Location = new System.Drawing.Point(206, 41);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(83, 32);
            this.lbl_Titulo.TabIndex = 12;
            this.lbl_Titulo.Text = "label1";
            // 
            // frm_MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1123, 607);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.btn_CancelarPartida);
            this.Controls.Add(this.pnl_Estadisticas);
            this.Controls.Add(this.pnl_Jugar);
            this.Controls.Add(this.dgv_MenuPrincipal);
            this.Controls.Add(this.rtx_Reglas);
            this.Controls.Add(this.pnl_Superior);
            this.Controls.Add(this.pnl_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenuPrincipal";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MenuPrincipal)).EndInit();
            this.pnl_Menu.ResumeLayout(false);
            this.pnl_Usuarios.ResumeLayout(false);
            this.pnl_Partidas.ResumeLayout(false);
            this.pnl_Submenu.ResumeLayout(false);
            this.pnl_Superior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_CantidadJugadores)).EndInit();
            this.pnl_Jugar.ResumeLayout(false);
            this.pnl_Jugar.PerformLayout();
            this.pnl_Estadisticas.ResumeLayout(false);
            this.pnl_Estadisticas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_PartidaNueva;
        private Button btn_Salir;
        private DataGridViewTextBoxColumn ganadorDataGridViewTextBoxColumn;
        private DataGridView dgv_MenuPrincipal;
        private Panel pnl_Menu;
        private Panel pnl_Superior;
        private Panel pnl_Submenu;
        private Button btn_Full;
        private Button btn_Demo;
        private Label lbl_Jugadores;
        private NumericUpDown nud_CantidadJugadores;
        private Button btn_AceptarCantidad;
        private Button btn_Reglas;
        private RichTextBox rtx_Reglas;
        private Button btn_Configuracion;
        private Panel pnl_Jugar;
        private Panel pnl_Partidas;
        private Button btn_Activas;
        private Button btn_Partidas;
        private Panel pnl_Usuarios;
        private Button btn_VerUsuarios;
        private Button btn_AltaUsuarios;
        private Button btn_Usuarios;
        private Label lbl_Seleccion;
        private Button btn_Estadisticas;
        private Panel pnl_Estadisticas;
        private DataGridView dgv_Top;
        private Label lbl_Top;
        private Label lbl_CantidadPartidas;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn partiasGanadasDataGridViewTextBoxColumn;
        private BindingSource usuarioBindingSource;
        private Label lbl_PartidasEmpatadas;
        private Label lbl_PartidasCanceladas;
        private Label lbl_PartidasFinalizada;
        private Button btn_CancelarPartida;
        private Label lbl_Titulo;
    }
}