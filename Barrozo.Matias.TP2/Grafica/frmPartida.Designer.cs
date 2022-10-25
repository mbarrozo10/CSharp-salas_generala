﻿using Funcionalidad.clases;

namespace Grafica
{
    partial class frmPartida
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.lbl_Jugador3 = new System.Windows.Forms.Label();
            this.lbl_Jugador4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadorBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.lbl_Dados.Location = new System.Drawing.Point(322, 213);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btn_Volver);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1119, 37);
            this.panel1.TabIndex = 6;
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
            // frmPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1119, 454);
            this.Controls.Add(this.lbl_Jugador4);
            this.Controls.Add(this.lbl_Jugador3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTurnoJugador);
            this.Controls.Add(this.lblTiempoPartida);
            this.Controls.Add(this.lbl_Dados);
            this.Controls.Add(this.lbl_Jugador2);
            this.Controls.Add(this.lbl_Jugador1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPartida";
            this.Text = "frmPartida";
            this.Load += new System.EventHandler(this.frmPartida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadorBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
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
        private Panel panel1;
        private Button btn_Volver;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Jugador1;
        private DataGridViewTextBoxColumn Jugador2;
        private Label lbl_Jugador3;
        private Label lbl_Jugador4;
    }
}