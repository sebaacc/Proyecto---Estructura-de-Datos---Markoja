namespace PryEdMarkoja
{
    partial class frmListaDoble
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
            this.gbNuevoElemento = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.gbElementoEliminar = new System.Windows.Forms.GroupBox();
            this.cmbEliminar = new System.Windows.Forms.ComboBox();
            this.lblCodigoElim = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gbListarDatos = new System.Windows.Forms.GroupBox();
            this.optDesc = new System.Windows.Forms.RadioButton();
            this.optAsc = new System.Windows.Forms.RadioButton();
            this.ImgListaDoble = new System.Windows.Forms.PictureBox();
            this.gbListadoYGrilla = new System.Windows.Forms.GroupBox();
            this.dgvListaDoble = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstLista = new System.Windows.Forms.ListBox();
            this.gbNuevoElemento.SuspendLayout();
            this.gbElementoEliminar.SuspendLayout();
            this.gbListarDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgListaDoble)).BeginInit();
            this.gbListadoYGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDoble)).BeginInit();
            this.SuspendLayout();
            // 
            // gbNuevoElemento
            // 
            this.gbNuevoElemento.Controls.Add(this.btnAgregar);
            this.gbNuevoElemento.Controls.Add(this.txtTramite);
            this.gbNuevoElemento.Controls.Add(this.txtNombre);
            this.gbNuevoElemento.Controls.Add(this.txtCodigo);
            this.gbNuevoElemento.Controls.Add(this.lblTramite);
            this.gbNuevoElemento.Controls.Add(this.lblNombre);
            this.gbNuevoElemento.Controls.Add(this.lblCodigo);
            this.gbNuevoElemento.Location = new System.Drawing.Point(305, 25);
            this.gbNuevoElemento.Name = "gbNuevoElemento";
            this.gbNuevoElemento.Size = new System.Drawing.Size(217, 185);
            this.gbNuevoElemento.TabIndex = 0;
            this.gbNuevoElemento.TabStop = false;
            this.gbNuevoElemento.Text = "Nuevo Elemento";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(9, 135);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(202, 37);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(73, 101);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(138, 22);
            this.txtTramite.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(73, 64);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(138, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(73, 27);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(138, 22);
            this.txtCodigo.TabIndex = 3;
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Location = new System.Drawing.Point(6, 104);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(56, 16);
            this.lblTramite.TabIndex = 2;
            this.lblTramite.Text = "Trámite:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 64);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(6, 27);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(54, 16);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // gbElementoEliminar
            // 
            this.gbElementoEliminar.Controls.Add(this.cmbEliminar);
            this.gbElementoEliminar.Controls.Add(this.lblCodigoElim);
            this.gbElementoEliminar.Controls.Add(this.btnEliminar);
            this.gbElementoEliminar.Location = new System.Drawing.Point(552, 25);
            this.gbElementoEliminar.Name = "gbElementoEliminar";
            this.gbElementoEliminar.Size = new System.Drawing.Size(224, 107);
            this.gbElementoEliminar.TabIndex = 1;
            this.gbElementoEliminar.TabStop = false;
            this.gbElementoEliminar.Text = "Elemento a Eliminar";
            // 
            // cmbEliminar
            // 
            this.cmbEliminar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEliminar.FormattingEnabled = true;
            this.cmbEliminar.Location = new System.Drawing.Point(79, 27);
            this.cmbEliminar.Name = "cmbEliminar";
            this.cmbEliminar.Size = new System.Drawing.Size(121, 24);
            this.cmbEliminar.TabIndex = 9;
            // 
            // lblCodigoElim
            // 
            this.lblCodigoElim.AutoSize = true;
            this.lblCodigoElim.Location = new System.Drawing.Point(19, 27);
            this.lblCodigoElim.Name = "lblCodigoElim";
            this.lblCodigoElim.Size = new System.Drawing.Size(54, 16);
            this.lblCodigoElim.TabIndex = 8;
            this.lblCodigoElim.Text = "Código:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(22, 64);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(178, 36);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // gbListarDatos
            // 
            this.gbListarDatos.Controls.Add(this.optDesc);
            this.gbListarDatos.Controls.Add(this.optAsc);
            this.gbListarDatos.Location = new System.Drawing.Point(552, 138);
            this.gbListarDatos.Name = "gbListarDatos";
            this.gbListarDatos.Size = new System.Drawing.Size(224, 72);
            this.gbListarDatos.TabIndex = 2;
            this.gbListarDatos.TabStop = false;
            this.gbListarDatos.Text = "Listar Datos";
            // 
            // optDesc
            // 
            this.optDesc.AutoSize = true;
            this.optDesc.Location = new System.Drawing.Point(22, 40);
            this.optDesc.Name = "optDesc";
            this.optDesc.Size = new System.Drawing.Size(109, 20);
            this.optDesc.TabIndex = 1;
            this.optDesc.TabStop = true;
            this.optDesc.Text = "Descendente";
            this.optDesc.UseVisualStyleBackColor = true;
            this.optDesc.CheckedChanged += new System.EventHandler(this.optDesc_CheckedChanged);
            // 
            // optAsc
            // 
            this.optAsc.AutoSize = true;
            this.optAsc.Location = new System.Drawing.Point(22, 18);
            this.optAsc.Name = "optAsc";
            this.optAsc.Size = new System.Drawing.Size(100, 20);
            this.optAsc.TabIndex = 0;
            this.optAsc.TabStop = true;
            this.optAsc.Text = "Ascendente";
            this.optAsc.UseVisualStyleBackColor = true;
            this.optAsc.CheckedChanged += new System.EventHandler(this.optAsc_CheckedChanged);
            // 
            // ImgListaDoble
            // 
            this.ImgListaDoble.Location = new System.Drawing.Point(38, 25);
            this.ImgListaDoble.Margin = new System.Windows.Forms.Padding(4);
            this.ImgListaDoble.Name = "ImgListaDoble";
            this.ImgListaDoble.Size = new System.Drawing.Size(243, 185);
            this.ImgListaDoble.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgListaDoble.TabIndex = 15;
            this.ImgListaDoble.TabStop = false;
            // 
            // gbListadoYGrilla
            // 
            this.gbListadoYGrilla.Controls.Add(this.dgvListaDoble);
            this.gbListadoYGrilla.Controls.Add(this.lstLista);
            this.gbListadoYGrilla.Location = new System.Drawing.Point(38, 233);
            this.gbListadoYGrilla.Name = "gbListadoYGrilla";
            this.gbListadoYGrilla.Size = new System.Drawing.Size(738, 317);
            this.gbListadoYGrilla.TabIndex = 16;
            this.gbListadoYGrilla.TabStop = false;
            this.gbListadoYGrilla.Text = "Listado en una Lista y una Grilla";
            // 
            // dgvListaDoble
            // 
            this.dgvListaDoble.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaDoble.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Tramite});
            this.dgvListaDoble.Location = new System.Drawing.Point(276, 22);
            this.dgvListaDoble.Name = "dgvListaDoble";
            this.dgvListaDoble.RowHeadersWidth = 51;
            this.dgvListaDoble.RowTemplate.Height = 24;
            this.dgvListaDoble.Size = new System.Drawing.Size(438, 276);
            this.dgvListaDoble.TabIndex = 1;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 180;
            // 
            // Tramite
            // 
            this.Tramite.HeaderText = "Trámite";
            this.Tramite.MinimumWidth = 6;
            this.Tramite.Name = "Tramite";
            this.Tramite.Width = 125;
            // 
            // lstLista
            // 
            this.lstLista.FormattingEnabled = true;
            this.lstLista.ItemHeight = 16;
            this.lstLista.Location = new System.Drawing.Point(7, 22);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(236, 276);
            this.lstLista.TabIndex = 0;
            // 
            // frmListaDoble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.gbListadoYGrilla);
            this.Controls.Add(this.ImgListaDoble);
            this.Controls.Add(this.gbListarDatos);
            this.Controls.Add(this.gbElementoEliminar);
            this.Controls.Add(this.gbNuevoElemento);
            this.Name = "frmListaDoble";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Doblemente Enlazada";
            this.Load += new System.EventHandler(this.frmListaDoble_Load);
            this.gbNuevoElemento.ResumeLayout(false);
            this.gbNuevoElemento.PerformLayout();
            this.gbElementoEliminar.ResumeLayout(false);
            this.gbElementoEliminar.PerformLayout();
            this.gbListarDatos.ResumeLayout(false);
            this.gbListarDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgListaDoble)).EndInit();
            this.gbListadoYGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDoble)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNuevoElemento;
        private System.Windows.Forms.GroupBox gbElementoEliminar;
        private System.Windows.Forms.GroupBox gbListarDatos;
        private System.Windows.Forms.PictureBox ImgListaDoble;
        private System.Windows.Forms.GroupBox gbListadoYGrilla;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ComboBox cmbEliminar;
        private System.Windows.Forms.Label lblCodigoElim;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.RadioButton optDesc;
        private System.Windows.Forms.RadioButton optAsc;
        private System.Windows.Forms.DataGridView dgvListaDoble;
        private System.Windows.Forms.ListBox lstLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tramite;
    }
}