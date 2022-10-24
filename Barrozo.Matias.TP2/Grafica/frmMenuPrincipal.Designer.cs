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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.partidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_MostrarPartidas = new System.Windows.Forms.Button();
            this.pnl_Superior = new System.Windows.Forms.Panel();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ganadorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadJugadoresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidaBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.btn_PartidaNueva.FlatAppearance.BorderSize = 0;
            this.btn_PartidaNueva.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.btn_PartidaNueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PartidaNueva.ForeColor = System.Drawing.Color.White;
            this.btn_PartidaNueva.Location = new System.Drawing.Point(0, 37);
            this.btn_PartidaNueva.Name = "btn_PartidaNueva";
            this.btn_PartidaNueva.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_PartidaNueva.Size = new System.Drawing.Size(175, 51);
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
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 511);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(174, 56);
            this.button2.TabIndex = 2;
            this.button2.Text = "Salir";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.ganadorDataGridViewTextBoxColumn1,
            this.cantidadJugadoresDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.partidaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(250, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(494, 459);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.Visible = false;
            // 
            // partidaBindingSource
            // 
            this.partidaBindingSource.DataSource = typeof(Partida);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btn_MostrarPartidas);
            this.panel1.Controls.Add(this.btn_PartidaNueva);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 567);
            this.panel1.TabIndex = 4;
            // 
            // btn_MostrarPartidas
            // 
            this.btn_MostrarPartidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_MostrarPartidas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_MostrarPartidas.FlatAppearance.BorderSize = 0;
            this.btn_MostrarPartidas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.btn_MostrarPartidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MostrarPartidas.ForeColor = System.Drawing.Color.White;
            this.btn_MostrarPartidas.Location = new System.Drawing.Point(-1, 87);
            this.btn_MostrarPartidas.Name = "btn_MostrarPartidas";
            this.btn_MostrarPartidas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_MostrarPartidas.Size = new System.Drawing.Size(175, 51);
            this.btn_MostrarPartidas.TabIndex = 3;
            this.btn_MostrarPartidas.Text = "Partidas";
            this.btn_MostrarPartidas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MostrarPartidas.UseVisualStyleBackColor = false;
            this.btn_MostrarPartidas.Click += new System.EventHandler(this.btn_MostrarPartidas_Click);
            // 
            // pnl_Superior
            // 
            this.pnl_Superior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.pnl_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Superior.Location = new System.Drawing.Point(172, 0);
            this.pnl_Superior.Name = "pnl_Superior";
            this.pnl_Superior.Size = new System.Drawing.Size(938, 37);
            this.pnl_Superior.TabIndex = 5;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ganadorDataGridViewTextBoxColumn1
            // 
            this.ganadorDataGridViewTextBoxColumn1.DataPropertyName = "Ganador";
            this.ganadorDataGridViewTextBoxColumn1.HeaderText = "Ganador";
            this.ganadorDataGridViewTextBoxColumn1.Name = "ganadorDataGridViewTextBoxColumn1";
            // 
            // cantidadJugadoresDataGridViewTextBoxColumn
            // 
            this.cantidadJugadoresDataGridViewTextBoxColumn.DataPropertyName = "CantidadJugadores";
            this.cantidadJugadoresDataGridViewTextBoxColumn.HeaderText = "Cantidad de Jugadores";
            this.cantidadJugadoresDataGridViewTextBoxColumn.Name = "cantidadJugadoresDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Fecha jugada";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1110, 567);
            this.Controls.Add(this.pnl_Superior);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenuPrincipal";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidaBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button btn_PartidaNueva;
        private Button button2;
        private DataGridViewTextBoxColumn ganadorDataGridViewTextBoxColumn;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Button btn_MostrarPartidas;
        private BindingSource partidaBindingSource;
        private Panel pnl_Superior;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ganadorDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn cantidadJugadoresDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}