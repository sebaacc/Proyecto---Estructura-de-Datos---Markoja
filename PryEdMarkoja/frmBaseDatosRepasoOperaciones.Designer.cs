namespace PryEdMarkoja
{
    partial class frmBaseDatosRepasoOperaciones
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
            this.btnListar = new System.Windows.Forms.Button();
            this.cmbOperacion = new System.Windows.Forms.ComboBox();
            this.lblOperaciones = new System.Windows.Forms.Label();
            this.txtOperacionDescripcion = new System.Windows.Forms.TextBox();
            this.dgvOperaciones = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(814, 21);
            this.btnListar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(77, 21);
            this.btnListar.TabIndex = 0;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // cmbOperacion
            // 
            this.cmbOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperacion.FormattingEnabled = true;
            this.cmbOperacion.Location = new System.Drawing.Point(380, 21);
            this.cmbOperacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbOperacion.Name = "cmbOperacion";
            this.cmbOperacion.Size = new System.Drawing.Size(394, 21);
            this.cmbOperacion.TabIndex = 1;
            this.cmbOperacion.SelectedIndexChanged += new System.EventHandler(this.cmbOperacion_SelectedIndexChanged);
            // 
            // lblOperaciones
            // 
            this.lblOperaciones.AutoSize = true;
            this.lblOperaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperaciones.Location = new System.Drawing.Point(51, 21);
            this.lblOperaciones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOperaciones.Name = "lblOperaciones";
            this.lblOperaciones.Size = new System.Drawing.Size(297, 20);
            this.lblOperaciones.TabIndex = 2;
            this.lblOperaciones.Text = "Operación a realizar en la base de datos:";
            // 
            // txtOperacionDescripcion
            // 
            this.txtOperacionDescripcion.Enabled = false;
            this.txtOperacionDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOperacionDescripcion.Location = new System.Drawing.Point(55, 59);
            this.txtOperacionDescripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOperacionDescripcion.Multiline = true;
            this.txtOperacionDescripcion.Name = "txtOperacionDescripcion";
            this.txtOperacionDescripcion.ReadOnly = true;
            this.txtOperacionDescripcion.Size = new System.Drawing.Size(837, 132);
            this.txtOperacionDescripcion.TabIndex = 3;
            // 
            // dgvOperaciones
            // 
            this.dgvOperaciones.AllowUserToAddRows = false;
            this.dgvOperaciones.AllowUserToDeleteRows = false;
            this.dgvOperaciones.AllowUserToResizeColumns = false;
            this.dgvOperaciones.AllowUserToResizeRows = false;
            this.dgvOperaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvOperaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOperaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperaciones.Location = new System.Drawing.Point(55, 211);
            this.dgvOperaciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvOperaciones.MultiSelect = false;
            this.dgvOperaciones.Name = "dgvOperaciones";
            this.dgvOperaciones.ReadOnly = true;
            this.dgvOperaciones.RowHeadersVisible = false;
            this.dgvOperaciones.RowHeadersWidth = 51;
            this.dgvOperaciones.RowTemplate.Height = 24;
            this.dgvOperaciones.Size = new System.Drawing.Size(836, 323);
            this.dgvOperaciones.TabIndex = 4;
            // 
            // frmBaseDatosRepasoOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 590);
            this.Controls.Add(this.dgvOperaciones);
            this.Controls.Add(this.txtOperacionDescripcion);
            this.Controls.Add(this.lblOperaciones);
            this.Controls.Add(this.cmbOperacion);
            this.Controls.Add(this.btnListar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmBaseDatosRepasoOperaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repaso de operaciones de base de datos";
            this.Load += new System.EventHandler(this.frmBaseDatosRepasoOperaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.ComboBox cmbOperacion;
        private System.Windows.Forms.Label lblOperaciones;
        private System.Windows.Forms.TextBox txtOperacionDescripcion;
        private System.Windows.Forms.DataGridView dgvOperaciones;
    }
}