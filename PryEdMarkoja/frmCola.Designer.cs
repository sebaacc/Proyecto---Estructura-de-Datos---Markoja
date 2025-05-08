namespace PryEdMarkoja
{
    partial class frmCola
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
            this.gbElementoEliminar = new System.Windows.Forms.GroupBox();
            this.lblTramiteCaja = new System.Windows.Forms.TextBox();
            this.lblNombreCaja = new System.Windows.Forms.TextBox();
            this.lblCodigoCaja = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gbMuestras = new System.Windows.Forms.GroupBox();
            this.dgvCola = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstCola = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbElementoNuevo = new System.Windows.Forms.GroupBox();
            this.lblNombr = new System.Windows.Forms.Label();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gbElementoEliminar.SuspendLayout();
            this.gbMuestras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbElementoNuevo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbElementoEliminar
            // 
            this.gbElementoEliminar.Controls.Add(this.lblTramiteCaja);
            this.gbElementoEliminar.Controls.Add(this.lblNombreCaja);
            this.gbElementoEliminar.Controls.Add(this.lblCodigoCaja);
            this.gbElementoEliminar.Controls.Add(this.label1);
            this.gbElementoEliminar.Controls.Add(this.label2);
            this.gbElementoEliminar.Controls.Add(this.label3);
            this.gbElementoEliminar.Controls.Add(this.btnEliminar);
            this.gbElementoEliminar.Location = new System.Drawing.Point(583, 39);
            this.gbElementoEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.gbElementoEliminar.Name = "gbElementoEliminar";
            this.gbElementoEliminar.Padding = new System.Windows.Forms.Padding(4);
            this.gbElementoEliminar.Size = new System.Drawing.Size(267, 224);
            this.gbElementoEliminar.TabIndex = 11;
            this.gbElementoEliminar.TabStop = false;
            this.gbElementoEliminar.Text = "Elemento Eliminado ";
            this.gbElementoEliminar.Enter += new System.EventHandler(this.gbElementoEliminar_Enter);
            // 
            // lblTramiteCaja
            // 
            this.lblTramiteCaja.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblTramiteCaja.Enabled = false;
            this.lblTramiteCaja.Location = new System.Drawing.Point(108, 132);
            this.lblTramiteCaja.Margin = new System.Windows.Forms.Padding(4);
            this.lblTramiteCaja.Name = "lblTramiteCaja";
            this.lblTramiteCaja.ReadOnly = true;
            this.lblTramiteCaja.Size = new System.Drawing.Size(134, 22);
            this.lblTramiteCaja.TabIndex = 11;
            // 
            // lblNombreCaja
            // 
            this.lblNombreCaja.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblNombreCaja.Enabled = false;
            this.lblNombreCaja.Location = new System.Drawing.Point(108, 91);
            this.lblNombreCaja.Margin = new System.Windows.Forms.Padding(4);
            this.lblNombreCaja.Name = "lblNombreCaja";
            this.lblNombreCaja.ReadOnly = true;
            this.lblNombreCaja.Size = new System.Drawing.Size(134, 22);
            this.lblNombreCaja.TabIndex = 10;
            // 
            // lblCodigoCaja
            // 
            this.lblCodigoCaja.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblCodigoCaja.Enabled = false;
            this.lblCodigoCaja.Location = new System.Drawing.Point(108, 44);
            this.lblCodigoCaja.Margin = new System.Windows.Forms.Padding(4);
            this.lblCodigoCaja.Name = "lblCodigoCaja";
            this.lblCodigoCaja.ReadOnly = true;
            this.lblCodigoCaja.Size = new System.Drawing.Size(134, 22);
            this.lblCodigoCaja.TabIndex = 7;
            this.lblCodigoCaja.TextChanged += new System.EventHandler(this.lblCodigoCaja_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tramite";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Codigo:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(31, 178);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(211, 34);
            this.btnEliminar.TabIndex = 0;
            this.btnEliminar.Text = "Eliminar ";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // gbMuestras
            // 
            this.gbMuestras.Controls.Add(this.dgvCola);
            this.gbMuestras.Controls.Add(this.lstCola);
            this.gbMuestras.Location = new System.Drawing.Point(38, 267);
            this.gbMuestras.Margin = new System.Windows.Forms.Padding(4);
            this.gbMuestras.Name = "gbMuestras";
            this.gbMuestras.Padding = new System.Windows.Forms.Padding(4);
            this.gbMuestras.Size = new System.Drawing.Size(812, 220);
            this.gbMuestras.TabIndex = 9;
            this.gbMuestras.TabStop = false;
            this.gbMuestras.Text = "Listado en una Lista y una Grilla";
            // 
            // dgvCola
            // 
            this.dgvCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCola.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvCola.Location = new System.Drawing.Point(268, 20);
            this.dgvCola.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCola.Name = "dgvCola";
            this.dgvCola.RowHeadersWidth = 51;
            this.dgvCola.Size = new System.Drawing.Size(519, 185);
            this.dgvCola.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tramite";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // lstCola
            // 
            this.lstCola.FormattingEnabled = true;
            this.lstCola.ItemHeight = 16;
            this.lstCola.Location = new System.Drawing.Point(8, 23);
            this.lstCola.Margin = new System.Windows.Forms.Padding(4);
            this.lstCola.Name = "lstCola";
            this.lstCola.Size = new System.Drawing.Size(233, 180);
            this.lstCola.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PryEdMarkoja.Properties.Resources.representacionCola;
            this.pictureBox1.Location = new System.Drawing.Point(38, 39);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // gbElementoNuevo
            // 
            this.gbElementoNuevo.Controls.Add(this.lblNombr);
            this.gbElementoNuevo.Controls.Add(this.lblTramite);
            this.gbElementoNuevo.Controls.Add(this.lblCodigo);
            this.gbElementoNuevo.Controls.Add(this.txtNombre);
            this.gbElementoNuevo.Controls.Add(this.txtTramite);
            this.gbElementoNuevo.Controls.Add(this.txtCodigo);
            this.gbElementoNuevo.Controls.Add(this.btnAgregar);
            this.gbElementoNuevo.Location = new System.Drawing.Point(306, 39);
            this.gbElementoNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.gbElementoNuevo.Name = "gbElementoNuevo";
            this.gbElementoNuevo.Padding = new System.Windows.Forms.Padding(4);
            this.gbElementoNuevo.Size = new System.Drawing.Size(267, 224);
            this.gbElementoNuevo.TabIndex = 8;
            this.gbElementoNuevo.TabStop = false;
            this.gbElementoNuevo.Text = "Nuevo Elemento";
            // 
            // lblNombr
            // 
            this.lblNombr.AutoSize = true;
            this.lblNombr.Location = new System.Drawing.Point(28, 94);
            this.lblNombr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombr.Name = "lblNombr";
            this.lblNombr.Size = new System.Drawing.Size(59, 16);
            this.lblNombr.TabIndex = 6;
            this.lblNombr.Text = "Nombre:";
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Location = new System.Drawing.Point(28, 138);
            this.lblTramite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(53, 16);
            this.lblTramite.TabIndex = 5;
            this.lblTramite.Text = "Tramite";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(28, 47);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(54, 16);
            this.lblCodigo.TabIndex = 4;
            this.lblCodigo.Text = "Codigo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(108, 88);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 22);
            this.txtNombre.TabIndex = 3;
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(108, 134);
            this.txtTramite.Margin = new System.Windows.Forms.Padding(4);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(132, 22);
            this.txtTramite.TabIndex = 2;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(108, 39);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(132, 22);
            this.txtCodigo.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(31, 178);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(209, 34);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 554);
            this.Controls.Add(this.gbElementoEliminar);
            this.Controls.Add(this.gbMuestras);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbElementoNuevo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCola";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura dinámica lineal: Cola";
            this.Load += new System.EventHandler(this.frmCola_Load);
            this.gbElementoEliminar.ResumeLayout(false);
            this.gbElementoEliminar.PerformLayout();
            this.gbMuestras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbElementoNuevo.ResumeLayout(false);
            this.gbElementoNuevo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbElementoEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox gbMuestras;
        private System.Windows.Forms.DataGridView dgvCola;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ListBox lstCola;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbElementoNuevo;
        private System.Windows.Forms.Label lblNombr;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox lblTramiteCaja;
        private System.Windows.Forms.TextBox lblNombreCaja;
        private System.Windows.Forms.TextBox lblCodigoCaja;
    }
}