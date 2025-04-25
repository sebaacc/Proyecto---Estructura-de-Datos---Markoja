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
            this.dgvListaDoble = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbListarDatos = new System.Windows.Forms.GroupBox();
            this.optDesc = new System.Windows.Forms.RadioButton();
            this.optAsc = new System.Windows.Forms.RadioButton();
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
            this.gbListadoArbol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDoble)).BeginInit();
            this.gbListarDatos.SuspendLayout();
            this.gbElementoEliminar.SuspendLayout();
            this.gbNuevoElemento.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbListadoArbol
            // 
            this.gbListadoArbol.Controls.Add(this.optPostOrden);
            this.gbListadoArbol.Controls.Add(this.optPreOrden);
            this.gbListadoArbol.Controls.Add(this.optInOrden);
            this.gbListadoArbol.Controls.Add(this.dgvListaDoble);
            this.gbListadoArbol.Location = new System.Drawing.Point(24, 180);
            this.gbListadoArbol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbListadoArbol.Name = "gbListadoArbol";
            this.gbListadoArbol.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbListadoArbol.Size = new System.Drawing.Size(554, 258);
            this.gbListadoArbol.TabIndex = 21;
            this.gbListadoArbol.TabStop = false;
            this.gbListadoArbol.Text = "Listado del árbol";
            // 
            // optPostOrden
            // 
            this.optPostOrden.AutoSize = true;
            this.optPostOrden.Location = new System.Drawing.Point(21, 104);
            this.optPostOrden.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.optPostOrden.Name = "optPostOrden";
            this.optPostOrden.Size = new System.Drawing.Size(78, 17);
            this.optPostOrden.TabIndex = 4;
            this.optPostOrden.TabStop = true;
            this.optPostOrden.Text = "Post-Orden";
            this.optPostOrden.UseVisualStyleBackColor = true;
            // 
            // optPreOrden
            // 
            this.optPreOrden.AutoSize = true;
            this.optPreOrden.Location = new System.Drawing.Point(21, 72);
            this.optPreOrden.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.optPreOrden.Name = "optPreOrden";
            this.optPreOrden.Size = new System.Drawing.Size(73, 17);
            this.optPreOrden.TabIndex = 3;
            this.optPreOrden.TabStop = true;
            this.optPreOrden.Text = "Pre-Orden";
            this.optPreOrden.UseVisualStyleBackColor = true;
            // 
            // optInOrden
            // 
            this.optInOrden.AutoSize = true;
            this.optInOrden.Location = new System.Drawing.Point(21, 40);
            this.optInOrden.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.optInOrden.Name = "optInOrden";
            this.optInOrden.Size = new System.Drawing.Size(66, 17);
            this.optInOrden.TabIndex = 2;
            this.optInOrden.TabStop = true;
            this.optInOrden.Text = "In-Orden";
            this.optInOrden.UseVisualStyleBackColor = true;
            // 
            // dgvListaDoble
            // 
            this.dgvListaDoble.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaDoble.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Tramite});
            this.dgvListaDoble.Location = new System.Drawing.Point(207, 18);
            this.dgvListaDoble.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvListaDoble.Name = "dgvListaDoble";
            this.dgvListaDoble.RowHeadersWidth = 51;
            this.dgvListaDoble.RowTemplate.Height = 24;
            this.dgvListaDoble.Size = new System.Drawing.Size(328, 224);
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
            // gbListarDatos
            // 
            this.gbListarDatos.Controls.Add(this.optDesc);
            this.gbListarDatos.Controls.Add(this.optAsc);
            this.gbListarDatos.Location = new System.Drawing.Point(410, 102);
            this.gbListarDatos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbListarDatos.Name = "gbListarDatos";
            this.gbListarDatos.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbListarDatos.Size = new System.Drawing.Size(168, 58);
            this.gbListarDatos.TabIndex = 19;
            this.gbListarDatos.TabStop = false;
            this.gbListarDatos.Text = "Listar Datos";
            // 
            // optDesc
            // 
            this.optDesc.AutoSize = true;
            this.optDesc.Location = new System.Drawing.Point(16, 32);
            this.optDesc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.optDesc.Name = "optDesc";
            this.optDesc.Size = new System.Drawing.Size(89, 17);
            this.optDesc.TabIndex = 1;
            this.optDesc.TabStop = true;
            this.optDesc.Text = "Descendente";
            this.optDesc.UseVisualStyleBackColor = true;
            // 
            // optAsc
            // 
            this.optAsc.AutoSize = true;
            this.optAsc.Location = new System.Drawing.Point(16, 15);
            this.optAsc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.optAsc.Name = "optAsc";
            this.optAsc.Size = new System.Drawing.Size(82, 17);
            this.optAsc.TabIndex = 0;
            this.optAsc.TabStop = true;
            this.optAsc.Text = "Ascendente";
            this.optAsc.UseVisualStyleBackColor = true;
            // 
            // gbElementoEliminar
            // 
            this.gbElementoEliminar.Controls.Add(this.cmbEliminar);
            this.gbElementoEliminar.Controls.Add(this.lblCodigoElim);
            this.gbElementoEliminar.Controls.Add(this.btnEliminar);
            this.gbElementoEliminar.Location = new System.Drawing.Point(410, 11);
            this.gbElementoEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbElementoEliminar.Name = "gbElementoEliminar";
            this.gbElementoEliminar.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbElementoEliminar.Size = new System.Drawing.Size(168, 87);
            this.gbElementoEliminar.TabIndex = 18;
            this.gbElementoEliminar.TabStop = false;
            this.gbElementoEliminar.Text = "Elemento a Eliminar";
            // 
            // cmbEliminar
            // 
            this.cmbEliminar.FormattingEnabled = true;
            this.cmbEliminar.Location = new System.Drawing.Point(59, 22);
            this.cmbEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbEliminar.Name = "cmbEliminar";
            this.cmbEliminar.Size = new System.Drawing.Size(92, 21);
            this.cmbEliminar.TabIndex = 9;
            // 
            // lblCodigoElim
            // 
            this.lblCodigoElim.AutoSize = true;
            this.lblCodigoElim.Location = new System.Drawing.Point(14, 22);
            this.lblCodigoElim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoElim.Name = "lblCodigoElim";
            this.lblCodigoElim.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoElim.TabIndex = 8;
            this.lblCodigoElim.Text = "Código:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(16, 52);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(134, 29);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
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
            this.gbNuevoElemento.Location = new System.Drawing.Point(231, 11);
            this.gbNuevoElemento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbNuevoElemento.Name = "gbNuevoElemento";
            this.gbNuevoElemento.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbNuevoElemento.Size = new System.Drawing.Size(163, 150);
            this.gbNuevoElemento.TabIndex = 17;
            this.gbNuevoElemento.TabStop = false;
            this.gbNuevoElemento.Text = "Nuevo Elemento";
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
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(55, 82);
            this.txtTramite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(104, 20);
            this.txtTramite.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(55, 52);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(104, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(55, 22);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(104, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Location = new System.Drawing.Point(4, 84);
            this.lblTramite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(45, 13);
            this.lblTramite.TabIndex = 2;
            this.lblTramite.Text = "Trámite:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(4, 52);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(4, 22);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // tvArbol
            // 
            this.tvArbol.Location = new System.Drawing.Point(24, 11);
            this.tvArbol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tvArbol.Name = "tvArbol";
            this.tvArbol.Size = new System.Drawing.Size(197, 151);
            this.tvArbol.TabIndex = 22;
            // 
            // frmArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 449);
            this.Controls.Add(this.tvArbol);
            this.Controls.Add(this.gbListadoArbol);
            this.Controls.Add(this.gbListarDatos);
            this.Controls.Add(this.gbElementoEliminar);
            this.Controls.Add(this.gbNuevoElemento);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmArbolBinario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructuras Ramificadas - Arbol Binario";
            this.Load += new System.EventHandler(this.frmArbolBinario_Load);
            this.gbListadoArbol.ResumeLayout(false);
            this.gbListadoArbol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDoble)).EndInit();
            this.gbListarDatos.ResumeLayout(false);
            this.gbListarDatos.PerformLayout();
            this.gbElementoEliminar.ResumeLayout(false);
            this.gbElementoEliminar.PerformLayout();
            this.gbNuevoElemento.ResumeLayout(false);
            this.gbNuevoElemento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbListadoArbol;
        private System.Windows.Forms.DataGridView dgvListaDoble;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tramite;
        private System.Windows.Forms.GroupBox gbListarDatos;
        private System.Windows.Forms.RadioButton optDesc;
        private System.Windows.Forms.RadioButton optAsc;
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
    }
}