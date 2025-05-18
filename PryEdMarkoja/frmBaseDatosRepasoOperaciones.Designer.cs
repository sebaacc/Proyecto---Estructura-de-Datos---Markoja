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
            this.txtOperacionResultado = new System.Windows.Forms.TextBox();
            this.dgvOperaciones = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(1085, 26);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(103, 25);
            this.btnListar.TabIndex = 0;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // cmbOperacion
            // 
            this.cmbOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperacion.FormattingEnabled = true;
            this.cmbOperacion.Location = new System.Drawing.Point(507, 26);
            this.cmbOperacion.Name = "cmbOperacion";
            this.cmbOperacion.Size = new System.Drawing.Size(524, 24);
            this.cmbOperacion.TabIndex = 1;
            // 
            // lblOperaciones
            // 
            this.lblOperaciones.AutoSize = true;
            this.lblOperaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperaciones.Location = new System.Drawing.Point(68, 26);
            this.lblOperaciones.Name = "lblOperaciones";
            this.lblOperaciones.Size = new System.Drawing.Size(368, 25);
            this.lblOperaciones.TabIndex = 2;
            this.lblOperaciones.Text = "Operación a realizar en la base de datos:";
            // 
            // txtOperacionResultado
            // 
            this.txtOperacionResultado.Location = new System.Drawing.Point(73, 73);
            this.txtOperacionResultado.Multiline = true;
            this.txtOperacionResultado.Name = "txtOperacionResultado";
            this.txtOperacionResultado.ReadOnly = true;
            this.txtOperacionResultado.Size = new System.Drawing.Size(1115, 162);
            this.txtOperacionResultado.TabIndex = 3;
            // 
            // dgvOperaciones
            // 
            this.dgvOperaciones.AllowUserToAddRows = false;
            this.dgvOperaciones.AllowUserToDeleteRows = false;
            this.dgvOperaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperaciones.Location = new System.Drawing.Point(73, 260);
            this.dgvOperaciones.Name = "dgvOperaciones";
            this.dgvOperaciones.ReadOnly = true;
            this.dgvOperaciones.RowHeadersWidth = 51;
            this.dgvOperaciones.RowTemplate.Height = 24;
            this.dgvOperaciones.Size = new System.Drawing.Size(1115, 397);
            this.dgvOperaciones.TabIndex = 4;
            // 
            // frmBaseDatosRepasoOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 726);
            this.Controls.Add(this.dgvOperaciones);
            this.Controls.Add(this.txtOperacionResultado);
            this.Controls.Add(this.lblOperaciones);
            this.Controls.Add(this.cmbOperacion);
            this.Controls.Add(this.btnListar);
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
        private System.Windows.Forms.TextBox txtOperacionResultado;
        private System.Windows.Forms.DataGridView dgvOperaciones;
    }
}