using Funcionalidad.clases;

namespace Grafica
{
    partial class frm_Partida
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
            this.lbl_Jugador1 = new System.Windows.Forms.Label();
            this.lbl_Jugador2 = new System.Windows.Forms.Label();
            this.lbl_Dados = new System.Windows.Forms.Label();
            this.tmrTiempoPartida = new System.Windows.Forms.Timer(this.components);
            this.lblTiempoPartida = new System.Windows.Forms.Label();
            this.lblTurnoJugador = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jugador1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jugador2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jugadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnl_Superior = new System.Windows.Forms.Panel();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.lbl_Jugador3 = new System.Windows.Forms.Label();
            this.lbl_Jugador4 = new System.Windows.Forms.Label();
            this.pnl_GuardarPartida = new System.Windows.Forms.Panel();
            this.lbl_Guardar = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.pic_DadoUno = new System.Windows.Forms.PictureBox();
            this.pic_DadoDos = new System.Windows.Forms.PictureBox();
            this.pic_DadoTres = new System.Windows.Forms.PictureBox();
            this.pic_DadoCuatro = new System.Windows.Forms.PictureBox();
            this.pic_DadoCinco = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadorBindingSource)).BeginInit();
            this.pnl_Superior.SuspendLayout();
            this.pnl_GuardarPartida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_DadoUno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_DadoDos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_DadoTres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_DadoCuatro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_DadoCinco)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Jugador1
            // 
            this.lbl_Jugador1.AutoSize = true;
            this.lbl_Jugador1.ForeColor = System.Drawing.Color.White;
            this.lbl_Jugador1.Location = new System.Drawing.Point(57, 52);
            this.lbl_Jugador1.Name = "lbl_Jugador1";
            this.lbl_Jugador1.Size = new System.Drawing.Size(55, 15);
            this.lbl_Jugador1.TabIndex = 0;
            this.lbl_Jugador1.Text = "Jugador1";
            // 
            // lbl_Jugador2
            // 
            this.lbl_Jugador2.AutoSize = true;
            this.lbl_Jugador2.ForeColor = System.Drawing.Color.White;
            this.lbl_Jugador2.Location = new System.Drawing.Point(57, 388);
            this.lbl_Jugador2.Name = "lbl_Jugador2";
            this.lbl_Jugador2.Size = new System.Drawing.Size(55, 15);
            this.lbl_Jugador2.TabIndex = 1;
            this.lbl_Jugador2.Text = "Jugador2";
            // 
            // lbl_Dados
            // 
            this.lbl_Dados.AutoSize = true;
            this.lbl_Dados.ForeColor = System.Drawing.Color.White;
            this.lbl_Dados.Location = new System.Drawing.Point(241, 192);
            this.lbl_Dados.Name = "lbl_Dados";
            this.lbl_Dados.Size = new System.Drawing.Size(39, 15);
            this.lbl_Dados.TabIndex = 2;
            this.lbl_Dados.Text = "Tirada";
            // 
            // tmrTiempoPartida
            // 
            this.tmrTiempoPartida.Interval = 1000;
            this.tmrTiempoPartida.Tick += new System.EventHandler(this.tmrTiempoPartida_Tick);
            // 
            // lblTiempoPartida
            // 
            this.lblTiempoPartida.AutoSize = true;
            this.lblTiempoPartida.ForeColor = System.Drawing.Color.White;
            this.lblTiempoPartida.Location = new System.Drawing.Point(322, 52);
            this.lblTiempoPartida.Name = "lblTiempoPartida";
            this.lblTiempoPartida.Size = new System.Drawing.Size(31, 15);
            this.lblTiempoPartida.TabIndex = 3;
            this.lblTiempoPartida.Text = "hora";
            // 
            // lblTurnoJugador
            // 
            this.lblTurnoJugador.AutoSize = true;
            this.lblTurnoJugador.ForeColor = System.Drawing.Color.White;
            this.lblTurnoJugador.Location = new System.Drawing.Point(57, 213);
            this.lblTurnoJugador.Name = "lblTurnoJugador";
            this.lblTurnoJugador.Size = new System.Drawing.Size(38, 15);
            this.lblTurnoJugador.TabIndex = 4;
            this.lblTurnoJugador.Text = "Turno";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo,
            this.Jugador1,
            this.Jugador2});
            this.dataGridView1.Location = new System.Drawing.Point(646, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(399, 366);
            this.dataGridView1.TabIndex = 5;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = " ";
            this.Tipo.Name = "Tipo";
            // 
            // Jugador1
            // 
            this.Jugador1.HeaderText = "Jugador1";
            this.Jugador1.Name = "Jugador1";
            // 
            // Jugador2
            // 
            this.Jugador2.HeaderText = "jugador2";
            this.Jugador2.Name = "Jugador2";
            // 
            // jugadorBindingSource
            // 
            this.jugadorBindingSource.DataSource = typeof(Funcionalidad.clases.Jugador);
            // 
            // pnl_Superior
            // 
            this.pnl_Superior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.pnl_Superior.Controls.Add(this.btn_Volver);
            this.pnl_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Superior.Location = new System.Drawing.Point(0, 0);
            this.pnl_Superior.Name = "pnl_Superior";
            this.pnl_Superior.Size = new System.Drawing.Size(1119, 37);
            this.pnl_Superior.TabIndex = 6;
            this.pnl_Superior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Superior_MouseDown);
            this.pnl_Superior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Superior_MouseMove);
            this.pnl_Superior.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Superior_MouseUp);
            // 
            // btn_Volver
            // 
            this.btn_Volver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_Volver.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Volver.FlatAppearance.BorderSize = 0;
            this.btn_Volver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.btn_Volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Volver.ForeColor = System.Drawing.Color.White;
            this.btn_Volver.Location = new System.Drawing.Point(0, 0);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(75, 37);
            this.btn_Volver.TabIndex = 0;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = false;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // lbl_Jugador3
            // 
            this.lbl_Jugador3.AutoSize = true;
            this.lbl_Jugador3.ForeColor = System.Drawing.Color.White;
            this.lbl_Jugador3.Location = new System.Drawing.Point(463, 52);
            this.lbl_Jugador3.Name = "lbl_Jugador3";
            this.lbl_Jugador3.Size = new System.Drawing.Size(55, 15);
            this.lbl_Jugador3.TabIndex = 7;
            this.lbl_Jugador3.Text = "Jugador3";
            this.lbl_Jugador3.Visible = false;
            // 
            // lbl_Jugador4
            // 
            this.lbl_Jugador4.AutoSize = true;
            this.lbl_Jugador4.ForeColor = System.Drawing.Color.White;
            this.lbl_Jugador4.Location = new System.Drawing.Point(463, 388);
            this.lbl_Jugador4.Name = "lbl_Jugador4";
            this.lbl_Jugador4.Size = new System.Drawing.Size(55, 15);
            this.lbl_Jugador4.TabIndex = 8;
            this.lbl_Jugador4.Text = "Jugador4";
            this.lbl_Jugador4.Visible = false;
            // 
            // pnl_GuardarPartida
            // 
            this.pnl_GuardarPartida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.pnl_GuardarPartida.Controls.Add(this.lbl_Guardar);
            this.pnl_GuardarPartida.Controls.Add(this.btn_Cancelar);
            this.pnl_GuardarPartida.Controls.Add(this.btn_Aceptar);
            this.pnl_GuardarPartida.Location = new System.Drawing.Point(442, 154);
            this.pnl_GuardarPartida.Name = "pnl_GuardarPartida";
            this.pnl_GuardarPartida.Size = new System.Drawing.Size(200, 100);
            this.pnl_GuardarPartida.TabIndex = 9;
            this.pnl_GuardarPartida.Visible = false;
            // 
            // lbl_Guardar
            // 
            this.lbl_Guardar.AutoSize = true;
            this.lbl_Guardar.ForeColor = System.Drawing.Color.White;
            this.lbl_Guardar.Location = new System.Drawing.Point(30, 24);
            this.lbl_Guardar.Name = "lbl_Guardar";
            this.lbl_Guardar.Size = new System.Drawing.Size(143, 15);
            this.lbl_Guardar.TabIndex = 2;
            this.lbl_Guardar.Text = "Quiere guardar la partida?";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.btn_Cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_Cancelar.Location = new System.Drawing.Point(97, 75);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(100, 23);
            this.btn_Cancelar.TabIndex = 1;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Aceptar.FlatAppearance.BorderSize = 0;
            this.btn_Aceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.btn_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Aceptar.ForeColor = System.Drawing.Color.White;
            this.btn_Aceptar.Location = new System.Drawing.Point(1, 75);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(100, 23);
            this.btn_Aceptar.TabIndex = 0;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // pic_DadoUno
            // 
            this.pic_DadoUno.Image = global::Grafica.Res.dado6;
            this.pic_DadoUno.Location = new System.Drawing.Point(286, 214);
            this.pic_DadoUno.Name = "pic_DadoUno";
            this.pic_DadoUno.Size = new System.Drawing.Size(46, 40);
            this.pic_DadoUno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_DadoUno.TabIndex = 10;
            this.pic_DadoUno.TabStop = false;
            // 
            // pic_DadoDos
            // 
            this.pic_DadoDos.Image = global::Grafica.Res.dado6;
            this.pic_DadoDos.Location = new System.Drawing.Point(338, 214);
            this.pic_DadoDos.Name = "pic_DadoDos";
            this.pic_DadoDos.Size = new System.Drawing.Size(46, 40);
            this.pic_DadoDos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_DadoDos.TabIndex = 11;
            this.pic_DadoDos.TabStop = false;
            // 
            // pic_DadoTres
            // 
            this.pic_DadoTres.Image = global::Grafica.Res.dado6;
            this.pic_DadoTres.Location = new System.Drawing.Point(390, 214);
            this.pic_DadoTres.Name = "pic_DadoTres";
            this.pic_DadoTres.Size = new System.Drawing.Size(46, 40);
            this.pic_DadoTres.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_DadoTres.TabIndex = 12;
            this.pic_DadoTres.TabStop = false;
            // 
            // pic_DadoCuatro
            // 
            this.pic_DadoCuatro.Image = global::Grafica.Res.dado6;
            this.pic_DadoCuatro.Location = new System.Drawing.Point(442, 214);
            this.pic_DadoCuatro.Name = "pic_DadoCuatro";
            this.pic_DadoCuatro.Size = new System.Drawing.Size(46, 40);
            this.pic_DadoCuatro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_DadoCuatro.TabIndex = 13;
            this.pic_DadoCuatro.TabStop = false;
            // 
            // pic_DadoCinco
            // 
            this.pic_DadoCinco.Image = global::Grafica.Res.dado6;
            this.pic_DadoCinco.Location = new System.Drawing.Point(494, 214);
            this.pic_DadoCinco.Name = "pic_DadoCinco";
            this.pic_DadoCinco.Size = new System.Drawing.Size(46, 40);
            this.pic_DadoCinco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_DadoCinco.TabIndex = 14;
            this.pic_DadoCinco.TabStop = false;
            // 
            // frm_Partida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1119, 454);
            this.Controls.Add(this.pnl_GuardarPartida);
            this.Controls.Add(this.pic_DadoCinco);
            this.Controls.Add(this.pic_DadoCuatro);
            this.Controls.Add(this.pic_DadoTres);
            this.Controls.Add(this.pic_DadoDos);
            this.Controls.Add(this.pic_DadoUno);
            this.Controls.Add(this.lbl_Jugador4);
            this.Controls.Add(this.lbl_Jugador3);
            this.Controls.Add(this.pnl_Superior);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTurnoJugador);
            this.Controls.Add(this.lblTiempoPartida);
            this.Controls.Add(this.lbl_Dados);
            this.Controls.Add(this.lbl_Jugador2);
            this.Controls.Add(this.lbl_Jugador1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Partida";
            this.Text = "frmPartida";
            this.Load += new System.EventHandler(this.frmPartida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadorBindingSource)).EndInit();
            this.pnl_Superior.ResumeLayout(false);
            this.pnl_GuardarPartida.ResumeLayout(false);
            this.pnl_GuardarPartida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_DadoUno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_DadoDos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_DadoTres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_DadoCuatro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_DadoCinco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_Jugador1;
        private Label lbl_Jugador2;
        private Label lbl_Dados;
        private System.Windows.Forms.Timer tmrTiempoPartida;
        private Label lblTiempoPartida;
        private Label lblTurnoJugador;
        private DataGridView dataGridView1;
        private BindingSource jugadorBindingSource;
        private Panel pnl_Superior;
        private Button btn_Volver;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Jugador1;
        private DataGridViewTextBoxColumn Jugador2;
        private Label lbl_Jugador3;
        private Label lbl_Jugador4;
        private Panel pnl_GuardarPartida;
        private Button btn_Cancelar;
        private Button btn_Aceptar;
        private Label lbl_Guardar;
        private PictureBox pic_DadoUno;
        private PictureBox pic_DadoDos;
        private PictureBox pic_DadoTres;
        private PictureBox pic_DadoCuatro;
        private PictureBox pic_DadoCinco;
    }
}