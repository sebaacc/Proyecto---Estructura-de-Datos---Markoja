namespace PryEdMarkoja
{
    partial class frmBaseDatosMostrarTabla
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
            this.dgvMostrarTabla = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.cmbTabla = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMostrarTabla
            // 
            this.dgvMostrarTabla.AllowUserToAddRows = false;
            this.dgvMostrarTabla.AllowUserToDeleteRows = false;
            this.dgvMostrarTabla.AllowUserToResizeColumns = false;
            this.dgvMostrarTabla.AllowUserToResizeRows = false;
            this.dgvMostrarTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarTabla.Location = new System.Drawing.Point(69, 28);
            this.dgvMostrarTabla.Name = "dgvMostrarTabla";
            this.dgvMostrarTabla.ReadOnly = true;
            this.dgvMostrarTabla.RowHeadersWidth = 51;
            this.dgvMostrarTabla.RowTemplate.Height = 24;
            this.dgvMostrarTabla.Size = new System.Drawing.Size(1113, 563);
            this.dgvMostrarTabla.TabIndex = 0;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(1021, 633);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(161, 42);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // cmbTabla
            // 
            this.cmbTabla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTabla.FormattingEnabled = true;
            this.cmbTabla.ItemHeight = 16;
            this.cmbTabla.Location = new System.Drawing.Point(786, 642);
            this.cmbTabla.Name = "cmbTabla";
            this.cmbTabla.Size = new System.Drawing.Size(175, 24);
            this.cmbTabla.TabIndex = 2;
            // 
            // frmBaseDatosMostrarTabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 726);
            this.Controls.Add(this.cmbTabla);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.dgvMostrarTabla);
            this.Name = "frmBaseDatosMostrarTabla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mostrar datos de una tabla";
            this.Load += new System.EventHandler(this.frmBaseDatosMostrarTabla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarTabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMostrarTabla;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.ComboBox cmbTabla;
    }
}