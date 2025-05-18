namespace PryEdMarkoja
{
    partial class frmGrafo
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
            this.gbListadoViajes = new System.Windows.Forms.GroupBox();
            this.btnVerTodosLosViajes = new System.Windows.Forms.Button();
            this.btnListarOrigenes = new System.Windows.Forms.Button();
            this.btnListarDestinos = new System.Windows.Forms.Button();
            this.cmbDestinoListar = new System.Windows.Forms.ComboBox();
            this.cmbOrigenListar = new System.Windows.Forms.ComboBox();
            this.lblOrigenListar = new System.Windows.Forms.Label();
            this.lblDestinoListar = new System.Windows.Forms.Label();
            this.dgvGrafo = new System.Windows.Forms.DataGridView();
            this.gbNuevoElemento = new System.Windows.Forms.GroupBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.cmbDestinoCarga = new System.Windows.Forms.ComboBox();
            this.cmbOrigenCarga = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.gbConsultaViaje = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDestinoConsulta = new System.Windows.Forms.ComboBox();
            this.cmbOrigenConsulta = new System.Windows.Forms.ComboBox();
            this.btnConsultarViaje = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbListadoViajes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrafo)).BeginInit();
            this.gbNuevoElemento.SuspendLayout();
            this.gbConsultaViaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbListadoViajes
            // 
            this.gbListadoViajes.Controls.Add(this.btnVerTodosLosViajes);
            this.gbListadoViajes.Controls.Add(this.btnListarOrigenes);
            this.gbListadoViajes.Controls.Add(this.btnListarDestinos);
            this.gbListadoViajes.Controls.Add(this.cmbDestinoListar);
            this.gbListadoViajes.Controls.Add(this.cmbOrigenListar);
            this.gbListadoViajes.Controls.Add(this.lblOrigenListar);
            this.gbListadoViajes.Controls.Add(this.lblDestinoListar);
            this.gbListadoViajes.Controls.Add(this.dgvGrafo);
            this.gbListadoViajes.Location = new System.Drawing.Point(111, 261);
            this.gbListadoViajes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbListadoViajes.Name = "gbListadoViajes";
            this.gbListadoViajes.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbListadoViajes.Size = new System.Drawing.Size(989, 429);
            this.gbListadoViajes.TabIndex = 26;
            this.gbListadoViajes.TabStop = false;
            this.gbListadoViajes.Text = "Listado de viajes";
            // 
            // btnVerTodosLosViajes
            // 
            this.btnVerTodosLosViajes.Location = new System.Drawing.Point(802, 39);
            this.btnVerTodosLosViajes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVerTodosLosViajes.Name = "btnVerTodosLosViajes";
            this.btnVerTodosLosViajes.Size = new System.Drawing.Size(157, 24);
            this.btnVerTodosLosViajes.TabIndex = 18;
            this.btnVerTodosLosViajes.Text = "Ver todos los viajes";
            this.btnVerTodosLosViajes.UseVisualStyleBackColor = true;
            // 
            // btnListarOrigenes
            // 
            this.btnListarOrigenes.Location = new System.Drawing.Point(243, 39);
            this.btnListarOrigenes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListarOrigenes.Name = "btnListarOrigenes";
            this.btnListarOrigenes.Size = new System.Drawing.Size(120, 24);
            this.btnListarOrigenes.TabIndex = 17;
            this.btnListarOrigenes.Text = "Listar Orígenes";
            this.btnListarOrigenes.UseVisualStyleBackColor = true;
            // 
            // btnListarDestinos
            // 
            this.btnListarDestinos.Location = new System.Drawing.Point(631, 39);
            this.btnListarDestinos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListarDestinos.Name = "btnListarDestinos";
            this.btnListarDestinos.Size = new System.Drawing.Size(120, 24);
            this.btnListarDestinos.TabIndex = 16;
            this.btnListarDestinos.Text = "Listar Destinos";
            this.btnListarDestinos.UseVisualStyleBackColor = true;
            // 
            // cmbDestinoListar
            // 
            this.cmbDestinoListar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestinoListar.FormattingEnabled = true;
            this.cmbDestinoListar.Location = new System.Drawing.Point(473, 39);
            this.cmbDestinoListar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDestinoListar.Name = "cmbDestinoListar";
            this.cmbDestinoListar.Size = new System.Drawing.Size(137, 24);
            this.cmbDestinoListar.TabIndex = 15;
            // 
            // cmbOrigenListar
            // 
            this.cmbOrigenListar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigenListar.FormattingEnabled = true;
            this.cmbOrigenListar.Location = new System.Drawing.Point(86, 39);
            this.cmbOrigenListar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbOrigenListar.Name = "cmbOrigenListar";
            this.cmbOrigenListar.Size = new System.Drawing.Size(137, 24);
            this.cmbOrigenListar.TabIndex = 14;
            // 
            // lblOrigenListar
            // 
            this.lblOrigenListar.AutoSize = true;
            this.lblOrigenListar.Location = new System.Drawing.Point(25, 43);
            this.lblOrigenListar.Name = "lblOrigenListar";
            this.lblOrigenListar.Size = new System.Drawing.Size(50, 16);
            this.lblOrigenListar.TabIndex = 13;
            this.lblOrigenListar.Text = "Origen:";
            // 
            // lblDestinoListar
            // 
            this.lblDestinoListar.AutoSize = true;
            this.lblDestinoListar.Location = new System.Drawing.Point(412, 43);
            this.lblDestinoListar.Name = "lblDestinoListar";
            this.lblDestinoListar.Size = new System.Drawing.Size(56, 16);
            this.lblDestinoListar.TabIndex = 12;
            this.lblDestinoListar.Text = "Destino:";
            // 
            // dgvGrafo
            // 
            this.dgvGrafo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrafo.Location = new System.Drawing.Point(11, 78);
            this.dgvGrafo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvGrafo.Name = "dgvGrafo";
            this.dgvGrafo.RowHeadersWidth = 51;
            this.dgvGrafo.RowTemplate.Height = 24;
            this.dgvGrafo.Size = new System.Drawing.Size(948, 338);
            this.dgvGrafo.TabIndex = 1;
            // 
            // gbNuevoElemento
            // 
            this.gbNuevoElemento.Controls.Add(this.txtPrecio);
            this.gbNuevoElemento.Controls.Add(this.lblPrecio);
            this.gbNuevoElemento.Controls.Add(this.cmbDestinoCarga);
            this.gbNuevoElemento.Controls.Add(this.cmbOrigenCarga);
            this.gbNuevoElemento.Controls.Add(this.btnAgregar);
            this.gbNuevoElemento.Controls.Add(this.lblOrigen);
            this.gbNuevoElemento.Controls.Add(this.lblDestino);
            this.gbNuevoElemento.Location = new System.Drawing.Point(111, 43);
            this.gbNuevoElemento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbNuevoElemento.Name = "gbNuevoElemento";
            this.gbNuevoElemento.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbNuevoElemento.Size = new System.Drawing.Size(217, 185);
            this.gbNuevoElemento.TabIndex = 24;
            this.gbNuevoElemento.TabStop = false;
            this.gbNuevoElemento.Text = "Agregar viaje";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(75, 107);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(137, 22);
            this.txtPrecio.TabIndex = 13;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(9, 108);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(49, 16);
            this.lblPrecio.TabIndex = 12;
            this.lblPrecio.Text = "Precio:";
            // 
            // cmbDestinoCarga
            // 
            this.cmbDestinoCarga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestinoCarga.FormattingEnabled = true;
            this.cmbDestinoCarga.Location = new System.Drawing.Point(75, 67);
            this.cmbDestinoCarga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDestinoCarga.Name = "cmbDestinoCarga";
            this.cmbDestinoCarga.Size = new System.Drawing.Size(137, 24);
            this.cmbDestinoCarga.TabIndex = 11;
            // 
            // cmbOrigenCarga
            // 
            this.cmbOrigenCarga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigenCarga.FormattingEnabled = true;
            this.cmbOrigenCarga.Location = new System.Drawing.Point(75, 27);
            this.cmbOrigenCarga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbOrigenCarga.Name = "cmbOrigenCarga";
            this.cmbOrigenCarga.Size = new System.Drawing.Size(137, 24);
            this.cmbOrigenCarga.TabIndex = 10;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(9, 135);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(203, 37);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(8, 30);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(50, 16);
            this.lblOrigen.TabIndex = 1;
            this.lblOrigen.Text = "Origen:";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(8, 70);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(56, 16);
            this.lblDestino.TabIndex = 0;
            this.lblDestino.Text = "Destino:";
            // 
            // gbConsultaViaje
            // 
            this.gbConsultaViaje.Controls.Add(this.textBox1);
            this.gbConsultaViaje.Controls.Add(this.label3);
            this.gbConsultaViaje.Controls.Add(this.cmbDestinoConsulta);
            this.gbConsultaViaje.Controls.Add(this.cmbOrigenConsulta);
            this.gbConsultaViaje.Controls.Add(this.btnConsultarViaje);
            this.gbConsultaViaje.Controls.Add(this.label1);
            this.gbConsultaViaje.Controls.Add(this.label2);
            this.gbConsultaViaje.Location = new System.Drawing.Point(497, 43);
            this.gbConsultaViaje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbConsultaViaje.Name = "gbConsultaViaje";
            this.gbConsultaViaje.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbConsultaViaje.Size = new System.Drawing.Size(217, 185);
            this.gbConsultaViaje.TabIndex = 27;
            this.gbConsultaViaje.TabStop = false;
            this.gbConsultaViaje.Text = "Consultar viaje";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 22);
            this.textBox1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Precio:";
            // 
            // cmbDestinoConsulta
            // 
            this.cmbDestinoConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestinoConsulta.FormattingEnabled = true;
            this.cmbDestinoConsulta.Location = new System.Drawing.Point(75, 64);
            this.cmbDestinoConsulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDestinoConsulta.Name = "cmbDestinoConsulta";
            this.cmbDestinoConsulta.Size = new System.Drawing.Size(137, 24);
            this.cmbDestinoConsulta.TabIndex = 11;
            // 
            // cmbOrigenConsulta
            // 
            this.cmbOrigenConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigenConsulta.FormattingEnabled = true;
            this.cmbOrigenConsulta.Location = new System.Drawing.Point(75, 27);
            this.cmbOrigenConsulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbOrigenConsulta.Name = "cmbOrigenConsulta";
            this.cmbOrigenConsulta.Size = new System.Drawing.Size(137, 24);
            this.cmbOrigenConsulta.TabIndex = 10;
            // 
            // btnConsultarViaje
            // 
            this.btnConsultarViaje.Location = new System.Drawing.Point(9, 135);
            this.btnConsultarViaje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsultarViaje.Name = "btnConsultarViaje";
            this.btnConsultarViaje.Size = new System.Drawing.Size(203, 37);
            this.btnConsultarViaje.TabIndex = 6;
            this.btnConsultarViaje.Text = "Consultar";
            this.btnConsultarViaje.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Origen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Destino:";
            // 
            // frmGrafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 726);
            this.Controls.Add(this.gbConsultaViaje);
            this.Controls.Add(this.gbListadoViajes);
            this.Controls.Add(this.gbNuevoElemento);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGrafo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grafo Matricial";
            this.Load += new System.EventHandler(this.frmGrafo_Load);
            this.gbListadoViajes.ResumeLayout(false);
            this.gbListadoViajes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrafo)).EndInit();
            this.gbNuevoElemento.ResumeLayout(false);
            this.gbNuevoElemento.PerformLayout();
            this.gbConsultaViaje.ResumeLayout(false);
            this.gbConsultaViaje.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbListadoViajes;
        private System.Windows.Forms.DataGridView dgvGrafo;
        private System.Windows.Forms.GroupBox gbNuevoElemento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.ComboBox cmbDestinoCarga;
        private System.Windows.Forms.ComboBox cmbOrigenCarga;
        private System.Windows.Forms.ComboBox cmbDestinoListar;
        private System.Windows.Forms.ComboBox cmbOrigenListar;
        private System.Windows.Forms.Label lblOrigenListar;
        private System.Windows.Forms.Label lblDestinoListar;
        private System.Windows.Forms.Button btnVerTodosLosViajes;
        private System.Windows.Forms.Button btnListarOrigenes;
        private System.Windows.Forms.Button btnListarDestinos;
        private System.Windows.Forms.GroupBox gbConsultaViaje;
        private System.Windows.Forms.ComboBox cmbDestinoConsulta;
        private System.Windows.Forms.ComboBox cmbOrigenConsulta;
        private System.Windows.Forms.Button btnConsultarViaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}