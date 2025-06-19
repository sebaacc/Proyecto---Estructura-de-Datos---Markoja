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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGrafo));
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
            this.cmbDestinoConsulta = new System.Windows.Forms.ComboBox();
            this.cmbOrigenConsulta = new System.Windows.Forms.ComboBox();
            this.btnConsultarViaje = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecioConsultado = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbListadoViajes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrafo)).BeginInit();
            this.gbNuevoElemento.SuspendLayout();
            this.gbConsultaViaje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.gbListadoViajes.Location = new System.Drawing.Point(83, 212);
            this.gbListadoViajes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbListadoViajes.Name = "gbListadoViajes";
            this.gbListadoViajes.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbListadoViajes.Size = new System.Drawing.Size(742, 349);
            this.gbListadoViajes.TabIndex = 26;
            this.gbListadoViajes.TabStop = false;
            this.gbListadoViajes.Text = "Listado de viajes";
            // 
            // btnVerTodosLosViajes
            // 
            this.btnVerTodosLosViajes.Location = new System.Drawing.Point(602, 32);
            this.btnVerTodosLosViajes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVerTodosLosViajes.Name = "btnVerTodosLosViajes";
            this.btnVerTodosLosViajes.Size = new System.Drawing.Size(118, 20);
            this.btnVerTodosLosViajes.TabIndex = 18;
            this.btnVerTodosLosViajes.Text = "Ver todos los viajes";
            this.btnVerTodosLosViajes.UseVisualStyleBackColor = true;
            this.btnVerTodosLosViajes.Click += new System.EventHandler(this.btnVerTodosLosViajes_Click);
            // 
            // btnListarOrigenes
            // 
            this.btnListarOrigenes.Location = new System.Drawing.Point(182, 32);
            this.btnListarOrigenes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnListarOrigenes.Name = "btnListarOrigenes";
            this.btnListarOrigenes.Size = new System.Drawing.Size(90, 20);
            this.btnListarOrigenes.TabIndex = 17;
            this.btnListarOrigenes.Text = "Listar Orígenes";
            this.btnListarOrigenes.UseVisualStyleBackColor = true;
            this.btnListarOrigenes.Click += new System.EventHandler(this.btnListarOrigenes_Click);
            // 
            // btnListarDestinos
            // 
            this.btnListarDestinos.Location = new System.Drawing.Point(473, 32);
            this.btnListarDestinos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnListarDestinos.Name = "btnListarDestinos";
            this.btnListarDestinos.Size = new System.Drawing.Size(90, 20);
            this.btnListarDestinos.TabIndex = 16;
            this.btnListarDestinos.Text = "Listar Destinos";
            this.btnListarDestinos.UseVisualStyleBackColor = true;
            this.btnListarDestinos.Click += new System.EventHandler(this.btnListarDestinos_Click);
            // 
            // cmbDestinoListar
            // 
            this.cmbDestinoListar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestinoListar.FormattingEnabled = true;
            this.cmbDestinoListar.Location = new System.Drawing.Point(355, 32);
            this.cmbDestinoListar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbDestinoListar.Name = "cmbDestinoListar";
            this.cmbDestinoListar.Size = new System.Drawing.Size(104, 21);
            this.cmbDestinoListar.TabIndex = 15;
            // 
            // cmbOrigenListar
            // 
            this.cmbOrigenListar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigenListar.FormattingEnabled = true;
            this.cmbOrigenListar.Location = new System.Drawing.Point(64, 32);
            this.cmbOrigenListar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbOrigenListar.Name = "cmbOrigenListar";
            this.cmbOrigenListar.Size = new System.Drawing.Size(104, 21);
            this.cmbOrigenListar.TabIndex = 14;
            // 
            // lblOrigenListar
            // 
            this.lblOrigenListar.AutoSize = true;
            this.lblOrigenListar.Location = new System.Drawing.Point(19, 35);
            this.lblOrigenListar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrigenListar.Name = "lblOrigenListar";
            this.lblOrigenListar.Size = new System.Drawing.Size(41, 13);
            this.lblOrigenListar.TabIndex = 13;
            this.lblOrigenListar.Text = "Origen:";
            // 
            // lblDestinoListar
            // 
            this.lblDestinoListar.AutoSize = true;
            this.lblDestinoListar.Location = new System.Drawing.Point(309, 35);
            this.lblDestinoListar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDestinoListar.Name = "lblDestinoListar";
            this.lblDestinoListar.Size = new System.Drawing.Size(46, 13);
            this.lblDestinoListar.TabIndex = 12;
            this.lblDestinoListar.Text = "Destino:";
            // 
            // dgvGrafo
            // 
            this.dgvGrafo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrafo.Location = new System.Drawing.Point(8, 63);
            this.dgvGrafo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvGrafo.Name = "dgvGrafo";
            this.dgvGrafo.RowHeadersWidth = 51;
            this.dgvGrafo.RowTemplate.Height = 24;
            this.dgvGrafo.Size = new System.Drawing.Size(711, 275);
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
            this.gbNuevoElemento.Location = new System.Drawing.Point(83, 35);
            this.gbNuevoElemento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbNuevoElemento.Name = "gbNuevoElemento";
            this.gbNuevoElemento.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbNuevoElemento.Size = new System.Drawing.Size(163, 150);
            this.gbNuevoElemento.TabIndex = 24;
            this.gbNuevoElemento.TabStop = false;
            this.gbNuevoElemento.Text = "Agregar viaje";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(56, 87);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(104, 20);
            this.txtPrecio.TabIndex = 13;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(7, 88);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 12;
            this.lblPrecio.Text = "Precio:";
            // 
            // cmbDestinoCarga
            // 
            this.cmbDestinoCarga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestinoCarga.FormattingEnabled = true;
            this.cmbDestinoCarga.Location = new System.Drawing.Point(56, 54);
            this.cmbDestinoCarga.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbDestinoCarga.Name = "cmbDestinoCarga";
            this.cmbDestinoCarga.Size = new System.Drawing.Size(104, 21);
            this.cmbDestinoCarga.TabIndex = 11;
            // 
            // cmbOrigenCarga
            // 
            this.cmbOrigenCarga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigenCarga.FormattingEnabled = true;
            this.cmbOrigenCarga.Location = new System.Drawing.Point(56, 22);
            this.cmbOrigenCarga.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbOrigenCarga.Name = "cmbOrigenCarga";
            this.cmbOrigenCarga.Size = new System.Drawing.Size(104, 21);
            this.cmbOrigenCarga.TabIndex = 10;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(7, 110);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(152, 30);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(6, 24);
            this.lblOrigen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(41, 13);
            this.lblOrigen.TabIndex = 1;
            this.lblOrigen.Text = "Origen:";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(6, 57);
            this.lblDestino.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(46, 13);
            this.lblDestino.TabIndex = 0;
            this.lblDestino.Text = "Destino:";
            // 
            // gbConsultaViaje
            // 
            this.gbConsultaViaje.Controls.Add(this.txtPrecioConsultado);
            this.gbConsultaViaje.Controls.Add(this.label3);
            this.gbConsultaViaje.Controls.Add(this.cmbDestinoConsulta);
            this.gbConsultaViaje.Controls.Add(this.cmbOrigenConsulta);
            this.gbConsultaViaje.Controls.Add(this.btnConsultarViaje);
            this.gbConsultaViaje.Controls.Add(this.label1);
            this.gbConsultaViaje.Controls.Add(this.label2);
            this.gbConsultaViaje.Location = new System.Drawing.Point(373, 35);
            this.gbConsultaViaje.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbConsultaViaje.Name = "gbConsultaViaje";
            this.gbConsultaViaje.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbConsultaViaje.Size = new System.Drawing.Size(163, 150);
            this.gbConsultaViaje.TabIndex = 27;
            this.gbConsultaViaje.TabStop = false;
            this.gbConsultaViaje.Text = "Consultar viaje";
            // 
            // cmbDestinoConsulta
            // 
            this.cmbDestinoConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestinoConsulta.FormattingEnabled = true;
            this.cmbDestinoConsulta.Location = new System.Drawing.Point(56, 52);
            this.cmbDestinoConsulta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbDestinoConsulta.Name = "cmbDestinoConsulta";
            this.cmbDestinoConsulta.Size = new System.Drawing.Size(104, 21);
            this.cmbDestinoConsulta.TabIndex = 11;
            // 
            // cmbOrigenConsulta
            // 
            this.cmbOrigenConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigenConsulta.FormattingEnabled = true;
            this.cmbOrigenConsulta.Location = new System.Drawing.Point(56, 22);
            this.cmbOrigenConsulta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbOrigenConsulta.Name = "cmbOrigenConsulta";
            this.cmbOrigenConsulta.Size = new System.Drawing.Size(104, 21);
            this.cmbOrigenConsulta.TabIndex = 10;
            // 
            // btnConsultarViaje
            // 
            this.btnConsultarViaje.Location = new System.Drawing.Point(7, 110);
            this.btnConsultarViaje.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConsultarViaje.Name = "btnConsultarViaje";
            this.btnConsultarViaje.Size = new System.Drawing.Size(152, 30);
            this.btnConsultarViaje.TabIndex = 6;
            this.btnConsultarViaje.Text = "Consultar";
            this.btnConsultarViaje.UseVisualStyleBackColor = true;
            this.btnConsultarViaje.Click += new System.EventHandler(this.btnConsultarViaje_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Origen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Destino:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Precio:";
            // 
            // txtPrecioConsultado
            // 
            this.txtPrecioConsultado.Enabled = false;
            this.txtPrecioConsultado.Location = new System.Drawing.Point(56, 82);
            this.txtPrecioConsultado.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecioConsultado.Name = "txtPrecioConsultado";
            this.txtPrecioConsultado.Size = new System.Drawing.Size(104, 20);
            this.txtPrecioConsultado.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(598, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // frmGrafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 590);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbConsultaViaje);
            this.Controls.Add(this.gbListadoViajes);
            this.Controls.Add(this.gbNuevoElemento);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.TextBox txtPrecioConsultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}