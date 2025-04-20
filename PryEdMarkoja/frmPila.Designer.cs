namespace PryEdMarkoja
{
    partial class frmPila
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPila));
            this.gbElementoEliminar = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvPila = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstPila = new System.Windows.Forms.ListBox();
            this.gbElementoNuevo = new System.Windows.Forms.GroupBox();
            this.lblNombr = new System.Windows.Forms.Label();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtTramiteCaja = new System.Windows.Forms.TextBox();
            this.txtNombreCaja = new System.Windows.Forms.TextBox();
            this.txtCodigoCaja = new System.Windows.Forms.TextBox();
            this.gbElementoEliminar.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPila)).BeginInit();
            this.gbElementoNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbElementoEliminar
            // 
            this.gbElementoEliminar.Controls.Add(this.txtTramiteCaja);
            this.gbElementoEliminar.Controls.Add(this.txtNombreCaja);
            this.gbElementoEliminar.Controls.Add(this.txtCodigoCaja);
            this.gbElementoEliminar.Controls.Add(this.label1);
            this.gbElementoEliminar.Controls.Add(this.label2);
            this.gbElementoEliminar.Controls.Add(this.label3);
            this.gbElementoEliminar.Controls.Add(this.btnEliminar);
            this.gbElementoEliminar.Location = new System.Drawing.Point(577, 39);
            this.gbElementoEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.gbElementoEliminar.Name = "gbElementoEliminar";
            this.gbElementoEliminar.Padding = new System.Windows.Forms.Padding(4);
            this.gbElementoEliminar.Size = new System.Drawing.Size(267, 220);
            this.gbElementoEliminar.TabIndex = 15;
            this.gbElementoEliminar.TabStop = false;
            this.gbElementoEliminar.Text = "Elemento Eliminado ";
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
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvPila);
            this.groupBox3.Controls.Add(this.lstPila);
            this.groupBox3.Location = new System.Drawing.Point(32, 263);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(809, 220);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listado en una Lista y una Grilla";
            // 
            // dgvPila
            // 
            this.dgvPila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPila.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvPila.Location = new System.Drawing.Point(268, 20);
            this.dgvPila.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPila.Name = "dgvPila";
            this.dgvPila.RowHeadersWidth = 51;
            this.dgvPila.Size = new System.Drawing.Size(519, 185);
            this.dgvPila.TabIndex = 1;
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
            // lstPila
            // 
            this.lstPila.FormattingEnabled = true;
            this.lstPila.ItemHeight = 16;
            this.lstPila.Location = new System.Drawing.Point(8, 23);
            this.lstPila.Margin = new System.Windows.Forms.Padding(4);
            this.lstPila.Name = "lstPila";
            this.lstPila.Size = new System.Drawing.Size(233, 180);
            this.lstPila.TabIndex = 0;
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
            this.gbElementoNuevo.Location = new System.Drawing.Point(300, 35);
            this.gbElementoNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.gbElementoNuevo.Name = "gbElementoNuevo";
            this.gbElementoNuevo.Padding = new System.Windows.Forms.Padding(4);
            this.gbElementoNuevo.Size = new System.Drawing.Size(267, 220);
            this.gbElementoNuevo.TabIndex = 12;
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
            this.txtNombre.Location = new System.Drawing.Point(108, 85);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PryEdMarkoja.Properties.Resources.representacionPila;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // txtTramiteCaja
            // 
            this.txtTramiteCaja.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTramiteCaja.Location = new System.Drawing.Point(108, 132);
            this.txtTramiteCaja.Margin = new System.Windows.Forms.Padding(4);
            this.txtTramiteCaja.Name = "txtTramiteCaja";
            this.txtTramiteCaja.ReadOnly = true;
            this.txtTramiteCaja.Size = new System.Drawing.Size(134, 22);
            this.txtTramiteCaja.TabIndex = 14;
            // 
            // txtNombreCaja
            // 
            this.txtNombreCaja.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtNombreCaja.Location = new System.Drawing.Point(108, 91);
            this.txtNombreCaja.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreCaja.Name = "txtNombreCaja";
            this.txtNombreCaja.ReadOnly = true;
            this.txtNombreCaja.Size = new System.Drawing.Size(134, 22);
            this.txtNombreCaja.TabIndex = 13;
            // 
            // txtCodigoCaja
            // 
            this.txtCodigoCaja.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtCodigoCaja.Location = new System.Drawing.Point(108, 44);
            this.txtCodigoCaja.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoCaja.Name = "txtCodigoCaja";
            this.txtCodigoCaja.ReadOnly = true;
            this.txtCodigoCaja.Size = new System.Drawing.Size(134, 22);
            this.txtCodigoCaja.TabIndex = 12;
            // 
            // frmPila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 505);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbElementoEliminar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbElementoNuevo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura de datos: Pila";
            this.Load += new System.EventHandler(this.frmPila_Load);
            this.gbElementoEliminar.ResumeLayout(false);
            this.gbElementoEliminar.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPila)).EndInit();
            this.gbElementoNuevo.ResumeLayout(false);
            this.gbElementoNuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbElementoEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvPila;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ListBox lstPila;
        private System.Windows.Forms.GroupBox gbElementoNuevo;
        private System.Windows.Forms.Label lblNombr;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtTramiteCaja;
        private System.Windows.Forms.TextBox txtNombreCaja;
        private System.Windows.Forms.TextBox txtCodigoCaja;
    }
}