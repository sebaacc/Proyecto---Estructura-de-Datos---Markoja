namespace PryEdMarkoja
{
    partial class frmBaseDatosConsultasSQL
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
            this.lblConsultas = new System.Windows.Forms.Label();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvMostrarConsulta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConsultas
            // 
            this.lblConsultas.AutoSize = true;
            this.lblConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultas.Location = new System.Drawing.Point(58, 28);
            this.lblConsultas.Name = "lblConsultas";
            this.lblConsultas.Size = new System.Drawing.Size(251, 39);
            this.lblConsultas.TabIndex = 0;
            this.lblConsultas.Text = "Consulta SQL:";
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(65, 75);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(1111, 203);
            this.txtQuery.TabIndex = 1;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(1101, 284);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 32);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dgvMostrarConsulta
            // 
            this.dgvMostrarConsulta.AllowUserToAddRows = false;
            this.dgvMostrarConsulta.AllowUserToDeleteRows = false;
            this.dgvMostrarConsulta.AllowUserToResizeColumns = false;
            this.dgvMostrarConsulta.AllowUserToResizeRows = false;
            this.dgvMostrarConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarConsulta.Location = new System.Drawing.Point(65, 336);
            this.dgvMostrarConsulta.Name = "dgvMostrarConsulta";
            this.dgvMostrarConsulta.ReadOnly = true;
            this.dgvMostrarConsulta.RowHeadersWidth = 51;
            this.dgvMostrarConsulta.RowTemplate.Height = 24;
            this.dgvMostrarConsulta.Size = new System.Drawing.Size(1113, 378);
            this.dgvMostrarConsulta.TabIndex = 3;
            // 
            // frmBaseDatosConsultasSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 726);
            this.Controls.Add(this.dgvMostrarConsulta);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.lblConsultas);
            this.Name = "frmBaseDatosConsultasSQL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas en base de datos";
            this.Load += new System.EventHandler(this.frmBaseDatosConsultasSQL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConsultas;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dgvMostrarConsulta;
    }
}