namespace PryEdMarkoja
{
    partial class frmArbolBinario
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
            this.gbListadoArbol = new System.Windows.Forms.GroupBox();
            this.optPostOrden = new System.Windows.Forms.RadioButton();
            this.optPreOrden = new System.Windows.Forms.RadioButton();
            this.optInOrden = new System.Windows.Forms.RadioButton();
            this.dgvArbol = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbElementoEliminar = new System.Windows.Forms.GroupBox();
            this.cmbEliminar = new System.Windows.Forms.ComboBox();
            this.lblCodigoElim = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gbNuevoElemento = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.tvArbol = new System.Windows.Forms.TreeView();
            this.btnEquilibrar = new System.Windows.Forms.Button();
            this.gbListadoArbol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArbol)).BeginInit();
            this.gbElementoEliminar.SuspendLayout();
            this.gbNuevoElemento.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbListadoArbol
            // 
            this.gbListadoArbol.Controls.Add(this.optPostOrden);
            this.gbListadoArbol.Controls.Add(this.optPreOrden);
            this.gbListadoArbol.Controls.Add(this.optInOrden);
            this.gbListadoArbol.Controls.Add(this.dgvArbol);
            this.gbListadoArbol.Location = new System.Drawing.Point(32, 222);
            this.gbListadoArbol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbListadoArbol.Name = "gbListadoArbol";
            this.gbListadoArbol.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbListadoArbol.Size = new System.Drawing.Size(739, 318);
            this.gbListadoArbol.TabIndex = 21;
            this.gbListadoArbol.TabStop = false;
            this.gbListadoArbol.Text = "Listado del árbol";
            // 
            // optPostOrden
            // 
            this.optPostOrden.AutoSize = true;
            this.optPostOrden.Location = new System.Drawing.Point(28, 128);
            this.optPostOrden.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.optPostOrden.Name = "optPostOrden";
            this.optPostOrden.Size = new System.Drawing.Size(96, 20);
            this.optPostOrden.TabIndex = 4;
            this.optPostOrden.TabStop = true;
            this.optPostOrden.Text = "Post-Orden";
            this.optPostOrden.UseVisualStyleBackColor = true;
            this.optPostOrden.CheckedChanged += new System.EventHandler(this.optPostOrden_CheckedChanged);
            // 
            // optPreOrden
            // 
            this.optPreOrden.AutoSize = true;
            this.optPreOrden.Location = new System.Drawing.Point(28, 89);
            this.optPreOrden.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.optPreOrden.Name = "optPreOrden";
            this.optPreOrden.Size = new System.Drawing.Size(90, 20);
            this.optPreOrden.TabIndex = 3;
            this.optPreOrden.TabStop = true;
            this.optPreOrden.Text = "Pre-Orden";
            this.optPreOrden.UseVisualStyleBackColor = true;
            this.optPreOrden.CheckedChanged += new System.EventHandler(this.optPreOrden_CheckedChanged);
            // 
            // optInOrden
            // 
            this.optInOrden.AutoSize = true;
            this.optInOrden.Location = new System.Drawing.Point(28, 49);
            this.optInOrden.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.optInOrden.Name = "optInOrden";
            this.optInOrden.Size = new System.Drawing.Size(79, 20);
            this.optInOrden.TabIndex = 2;
            this.optInOrden.TabStop = true;
            this.optInOrden.Text = "In-Orden";
            this.optInOrden.UseVisualStyleBackColor = true;
            this.optInOrden.CheckedChanged += new System.EventHandler(this.optInOrden_CheckedChanged);
            // 
            // dgvArbol
            // 
            this.dgvArbol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArbol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Tramite});
            this.dgvArbol.Location = new System.Drawing.Point(276, 22);
            this.dgvArbol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvArbol.Name = "dgvArbol";
            this.dgvArbol.RowHeadersWidth = 51;
            this.dgvArbol.RowTemplate.Height = 24;
            this.dgvArbol.Size = new System.Drawing.Size(437, 276);
            this.dgvArbol.TabIndex = 1;
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
            // gbElementoEliminar
            // 
            this.gbElementoEliminar.Controls.Add(this.cmbEliminar);
            this.gbElementoEliminar.Controls.Add(this.lblCodigoElim);
            this.gbElementoEliminar.Controls.Add(this.btnEliminar);
            this.gbElementoEliminar.Location = new System.Drawing.Point(547, 14);
            this.gbElementoEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbElementoEliminar.Name = "gbElementoEliminar";
            this.gbElementoEliminar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbElementoEliminar.Size = new System.Drawing.Size(224, 107);
            this.gbElementoEliminar.TabIndex = 18;
            this.gbElementoEliminar.TabStop = false;
            this.gbElementoEliminar.Text = "Elemento a Eliminar";
            // 
            // cmbEliminar
            // 
            this.cmbEliminar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEliminar.FormattingEnabled = true;
            this.cmbEliminar.Location = new System.Drawing.Point(79, 27);
            this.cmbEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEliminar.Name = "cmbEliminar";
            this.cmbEliminar.Size = new System.Drawing.Size(121, 24);
            this.cmbEliminar.TabIndex = 9;
            this.cmbEliminar.SelectedIndexChanged += new System.EventHandler(this.cmbEliminar_SelectedIndexChanged);
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
            this.btnEliminar.Location = new System.Drawing.Point(21, 64);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(179, 36);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.gbNuevoElemento.Location = new System.Drawing.Point(308, 14);
            this.gbNuevoElemento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbNuevoElemento.Name = "gbNuevoElemento";
            this.gbNuevoElemento.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbNuevoElemento.Size = new System.Drawing.Size(217, 185);
            this.gbNuevoElemento.TabIndex = 17;
            this.gbNuevoElemento.TabStop = false;
            this.gbNuevoElemento.Text = "Nuevo Elemento";
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
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(73, 101);
            this.txtTramite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(137, 22);
            this.txtTramite.TabIndex = 5;
            this.txtTramite.TextChanged += new System.EventHandler(this.txtTramite_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(73, 64);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(137, 22);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(73, 27);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(137, 22);
            this.txtCodigo.TabIndex = 3;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Location = new System.Drawing.Point(5, 103);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(56, 16);
            this.lblTramite.TabIndex = 2;
            this.lblTramite.Text = "Trámite:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(5, 64);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(5, 27);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(54, 16);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // tvArbol
            // 
            this.tvArbol.Location = new System.Drawing.Point(32, 14);
            this.tvArbol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tvArbol.Name = "tvArbol";
            this.tvArbol.Size = new System.Drawing.Size(261, 185);
            this.tvArbol.TabIndex = 22;
            // 
            // btnEquilibrar
            // 
            this.btnEquilibrar.Location = new System.Drawing.Point(569, 149);
            this.btnEquilibrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEquilibrar.Name = "btnEquilibrar";
            this.btnEquilibrar.Size = new System.Drawing.Size(179, 37);
            this.btnEquilibrar.TabIndex = 23;
            this.btnEquilibrar.Text = "Equilibrar";
            this.btnEquilibrar.UseVisualStyleBackColor = true;
            this.btnEquilibrar.Click += new System.EventHandler(this.btnEquilibrar_Click);
            // 
            // frmArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 553);
            this.Controls.Add(this.btnEquilibrar);
            this.Controls.Add(this.tvArbol);
            this.Controls.Add(this.gbListadoArbol);
            this.Controls.Add(this.gbElementoEliminar);
            this.Controls.Add(this.gbNuevoElemento);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmArbolBinario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructuras Ramificadas - Arbol Binario";
            this.Load += new System.EventHandler(this.frmArbolBinario_Load);
            this.gbListadoArbol.ResumeLayout(false);
            this.gbListadoArbol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArbol)).EndInit();
            this.gbElementoEliminar.ResumeLayout(false);
            this.gbElementoEliminar.PerformLayout();
            this.gbNuevoElemento.ResumeLayout(false);
            this.gbNuevoElemento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbListadoArbol;
        private System.Windows.Forms.DataGridView dgvArbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tramite;
        private System.Windows.Forms.GroupBox gbElementoEliminar;
        private System.Windows.Forms.ComboBox cmbEliminar;
        private System.Windows.Forms.Label lblCodigoElim;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox gbNuevoElemento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.RadioButton optPostOrden;
        private System.Windows.Forms.RadioButton optPreOrden;
        private System.Windows.Forms.RadioButton optInOrden;
        private System.Windows.Forms.TreeView tvArbol;
        private System.Windows.Forms.Button btnEquilibrar;
    }
}