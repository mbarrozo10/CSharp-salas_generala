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
            this.lbljugador1 = new System.Windows.Forms.Label();
            this.lbljugador2 = new System.Windows.Forms.Label();
            this.lbldados = new System.Windows.Forms.Label();
            this.tmrTiempoPartida = new System.Windows.Forms.Timer(this.components);
            this.lblTiempoPartida = new System.Windows.Forms.Label();
            this.lblTurnoJugador = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puntajeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generalaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dobleGeneralaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fullDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pokerDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.escaleraDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.jugadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbljugador1
            // 
            this.lbljugador1.AutoSize = true;
            this.lbljugador1.Location = new System.Drawing.Point(57, 37);
            this.lbljugador1.Name = "lbljugador1";
            this.lbljugador1.Size = new System.Drawing.Size(38, 15);
            this.lbljugador1.TabIndex = 0;
            this.lbljugador1.Text = "label1";
            // 
            // lbljugador2
            // 
            this.lbljugador2.AutoSize = true;
            this.lbljugador2.Location = new System.Drawing.Point(57, 388);
            this.lbljugador2.Name = "lbljugador2";
            this.lbljugador2.Size = new System.Drawing.Size(38, 15);
            this.lbljugador2.TabIndex = 1;
            this.lbljugador2.Text = "label2";
            // 
            // lbldados
            // 
            this.lbldados.AutoSize = true;
            this.lbldados.Location = new System.Drawing.Point(322, 213);
            this.lbldados.Name = "lbldados";
            this.lbldados.Size = new System.Drawing.Size(38, 15);
            this.lbldados.TabIndex = 2;
            this.lbldados.Text = "label3";
            // 
            // tmrTiempoPartida
            // 
            this.tmrTiempoPartida.Interval = 1000;
            this.tmrTiempoPartida.Tick += new System.EventHandler(this.tmrTiempoPartida_Tick);
            // 
            // lblTiempoPartida
            // 
            this.lblTiempoPartida.AutoSize = true;
            this.lblTiempoPartida.Location = new System.Drawing.Point(408, 37);
            this.lblTiempoPartida.Name = "lblTiempoPartida";
            this.lblTiempoPartida.Size = new System.Drawing.Size(31, 15);
            this.lblTiempoPartida.TabIndex = 3;
            this.lblTiempoPartida.Text = "hora";
            // 
            // lblTurnoJugador
            // 
            this.lblTurnoJugador.AutoSize = true;
            this.lblTurnoJugador.Location = new System.Drawing.Point(57, 213);
            this.lblTurnoJugador.Name = "lblTurnoJugador";
            this.lblTurnoJugador.Size = new System.Drawing.Size(38, 15);
            this.lblTurnoJugador.TabIndex = 4;
            this.lblTurnoJugador.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.puntajeDataGridViewTextBoxColumn,
            this.generalaDataGridViewCheckBoxColumn,
            this.dobleGeneralaDataGridViewCheckBoxColumn,
            this.fullDataGridViewCheckBoxColumn,
            this.pokerDataGridViewCheckBoxColumn,
            this.escaleraDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.jugadorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(524, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(541, 366);
            this.dataGridView1.TabIndex = 5;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // puntajeDataGridViewTextBoxColumn
            // 
            this.puntajeDataGridViewTextBoxColumn.DataPropertyName = "Puntaje";
            this.puntajeDataGridViewTextBoxColumn.HeaderText = "Puntaje";
            this.puntajeDataGridViewTextBoxColumn.Name = "puntajeDataGridViewTextBoxColumn";
            // 
            // generalaDataGridViewCheckBoxColumn
            // 
            this.generalaDataGridViewCheckBoxColumn.DataPropertyName = "Generala";
            this.generalaDataGridViewCheckBoxColumn.HeaderText = "Generala";
            this.generalaDataGridViewCheckBoxColumn.Name = "generalaDataGridViewCheckBoxColumn";
            // 
            // dobleGeneralaDataGridViewCheckBoxColumn
            // 
            this.dobleGeneralaDataGridViewCheckBoxColumn.DataPropertyName = "DobleGenerala";
            this.dobleGeneralaDataGridViewCheckBoxColumn.HeaderText = "DobleGenerala";
            this.dobleGeneralaDataGridViewCheckBoxColumn.Name = "dobleGeneralaDataGridViewCheckBoxColumn";
            // 
            // fullDataGridViewCheckBoxColumn
            // 
            this.fullDataGridViewCheckBoxColumn.DataPropertyName = "Full";
            this.fullDataGridViewCheckBoxColumn.HeaderText = "Full";
            this.fullDataGridViewCheckBoxColumn.Name = "fullDataGridViewCheckBoxColumn";
            // 
            // pokerDataGridViewCheckBoxColumn
            // 
            this.pokerDataGridViewCheckBoxColumn.DataPropertyName = "Poker";
            this.pokerDataGridViewCheckBoxColumn.HeaderText = "Poker";
            this.pokerDataGridViewCheckBoxColumn.Name = "pokerDataGridViewCheckBoxColumn";
            // 
            // escaleraDataGridViewCheckBoxColumn
            // 
            this.escaleraDataGridViewCheckBoxColumn.DataPropertyName = "Escalera";
            this.escaleraDataGridViewCheckBoxColumn.HeaderText = "Escalera";
            this.escaleraDataGridViewCheckBoxColumn.Name = "escaleraDataGridViewCheckBoxColumn";
            // 
            // jugadorBindingSource
            // 
            this.jugadorBindingSource.DataSource = typeof(Funcionalidad.Jugador);
            // 
            // frmPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 454);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTurnoJugador);
            this.Controls.Add(this.lblTiempoPartida);
            this.Controls.Add(this.lbldados);
            this.Controls.Add(this.lbljugador2);
            this.Controls.Add(this.lbljugador1);
            this.Name = "frmPartida";
            this.Text = "frmPartida";
            this.Load += new System.EventHandler(this.frmPartida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbljugador1;
        private Label lbljugador2;
        private Label lbldados;
        private System.Windows.Forms.Timer tmrTiempoPartida;
        private Label lblTiempoPartida;
        private Label lblTurnoJugador;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn puntajeDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn generalaDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn dobleGeneralaDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn fullDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn pokerDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn escaleraDataGridViewCheckBoxColumn;
        private BindingSource jugadorBindingSource;
    }
}