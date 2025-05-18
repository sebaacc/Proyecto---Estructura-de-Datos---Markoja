namespace PryEdMarkoja
{
    partial class frmBaseDatosOperaciones
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
            this.mOpWhere = new System.Windows.Forms.GroupBox();
            this.btnSConvol = new System.Windows.Forms.Button();
            this.btnSMulti = new System.Windows.Forms.Button();
            this.btnSSimple = new System.Windows.Forms.Button();
            this.mOpAlgebra = new System.Windows.Forms.GroupBox();
            this.btnDiferencia = new System.Windows.Forms.Button();
            this.btnInterseccion = new System.Windows.Forms.Button();
            this.btnUnion = new System.Windows.Forms.Button();
            this.mOpSelect = new System.Windows.Forms.GroupBox();
            this.btnPJuntar = new System.Windows.Forms.Button();
            this.btnPMulti = new System.Windows.Forms.Button();
            this.btnPSimple = new System.Windows.Forms.Button();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.mOpWhere.SuspendLayout();
            this.mOpAlgebra.SuspendLayout();
            this.mOpSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // mOpWhere
            // 
            this.mOpWhere.Controls.Add(this.btnSConvol);
            this.mOpWhere.Controls.Add(this.btnSMulti);
            this.mOpWhere.Controls.Add(this.btnSSimple);
            this.mOpWhere.Location = new System.Drawing.Point(442, 460);
            this.mOpWhere.Margin = new System.Windows.Forms.Padding(4);
            this.mOpWhere.Name = "mOpWhere";
            this.mOpWhere.Padding = new System.Windows.Forms.Padding(4);
            this.mOpWhere.Size = new System.Drawing.Size(329, 135);
            this.mOpWhere.TabIndex = 6;
            this.mOpWhere.TabStop = false;
            this.mOpWhere.Text = "Operaciones de selección - WHERE";
            // 
            // btnSConvol
            // 
            this.btnSConvol.Location = new System.Drawing.Point(8, 95);
            this.btnSConvol.Margin = new System.Windows.Forms.Padding(4);
            this.btnSConvol.Name = "btnSConvol";
            this.btnSConvol.Size = new System.Drawing.Size(313, 28);
            this.btnSConvol.TabIndex = 2;
            this.btnSConvol.Text = "Selección por convolución";
            this.btnSConvol.UseVisualStyleBackColor = true;
            // 
            // btnSMulti
            // 
            this.btnSMulti.Location = new System.Drawing.Point(8, 59);
            this.btnSMulti.Margin = new System.Windows.Forms.Padding(4);
            this.btnSMulti.Name = "btnSMulti";
            this.btnSMulti.Size = new System.Drawing.Size(313, 28);
            this.btnSMulti.TabIndex = 1;
            this.btnSMulti.Text = "Selección multiatributo";
            this.btnSMulti.UseVisualStyleBackColor = true;
            // 
            // btnSSimple
            // 
            this.btnSSimple.Location = new System.Drawing.Point(8, 23);
            this.btnSSimple.Margin = new System.Windows.Forms.Padding(4);
            this.btnSSimple.Name = "btnSSimple";
            this.btnSSimple.Size = new System.Drawing.Size(313, 28);
            this.btnSSimple.TabIndex = 0;
            this.btnSSimple.Text = "Selección simple";
            this.btnSSimple.UseVisualStyleBackColor = true;
            // 
            // mOpAlgebra
            // 
            this.mOpAlgebra.Controls.Add(this.btnDiferencia);
            this.mOpAlgebra.Controls.Add(this.btnInterseccion);
            this.mOpAlgebra.Controls.Add(this.btnUnion);
            this.mOpAlgebra.Location = new System.Drawing.Point(779, 460);
            this.mOpAlgebra.Margin = new System.Windows.Forms.Padding(4);
            this.mOpAlgebra.Name = "mOpAlgebra";
            this.mOpAlgebra.Padding = new System.Windows.Forms.Padding(4);
            this.mOpAlgebra.Size = new System.Drawing.Size(329, 135);
            this.mOpAlgebra.TabIndex = 7;
            this.mOpAlgebra.TabStop = false;
            this.mOpAlgebra.Text = "Operaciones algebraicas";
            // 
            // btnDiferencia
            // 
            this.btnDiferencia.Location = new System.Drawing.Point(8, 95);
            this.btnDiferencia.Margin = new System.Windows.Forms.Padding(4);
            this.btnDiferencia.Name = "btnDiferencia";
            this.btnDiferencia.Size = new System.Drawing.Size(313, 28);
            this.btnDiferencia.TabIndex = 2;
            this.btnDiferencia.Text = "Diferencia";
            this.btnDiferencia.UseVisualStyleBackColor = true;
            // 
            // btnInterseccion
            // 
            this.btnInterseccion.Location = new System.Drawing.Point(8, 59);
            this.btnInterseccion.Margin = new System.Windows.Forms.Padding(4);
            this.btnInterseccion.Name = "btnInterseccion";
            this.btnInterseccion.Size = new System.Drawing.Size(313, 28);
            this.btnInterseccion.TabIndex = 1;
            this.btnInterseccion.Text = "Intersección";
            this.btnInterseccion.UseVisualStyleBackColor = true;
            // 
            // btnUnion
            // 
            this.btnUnion.Location = new System.Drawing.Point(8, 23);
            this.btnUnion.Margin = new System.Windows.Forms.Padding(4);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(313, 28);
            this.btnUnion.TabIndex = 0;
            this.btnUnion.Text = "Unión";
            this.btnUnion.UseVisualStyleBackColor = true;
            // 
            // mOpSelect
            // 
            this.mOpSelect.Controls.Add(this.btnPJuntar);
            this.mOpSelect.Controls.Add(this.btnPMulti);
            this.mOpSelect.Controls.Add(this.btnPSimple);
            this.mOpSelect.Location = new System.Drawing.Point(105, 460);
            this.mOpSelect.Margin = new System.Windows.Forms.Padding(4);
            this.mOpSelect.Name = "mOpSelect";
            this.mOpSelect.Padding = new System.Windows.Forms.Padding(4);
            this.mOpSelect.Size = new System.Drawing.Size(329, 135);
            this.mOpSelect.TabIndex = 5;
            this.mOpSelect.TabStop = false;
            this.mOpSelect.Text = "Operaciones de proyección - SELECT";
            // 
            // btnPJuntar
            // 
            this.btnPJuntar.Location = new System.Drawing.Point(8, 95);
            this.btnPJuntar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPJuntar.Name = "btnPJuntar";
            this.btnPJuntar.Size = new System.Drawing.Size(313, 28);
            this.btnPJuntar.TabIndex = 2;
            this.btnPJuntar.Text = "Juntar";
            this.btnPJuntar.UseVisualStyleBackColor = true;
            // 
            // btnPMulti
            // 
            this.btnPMulti.Location = new System.Drawing.Point(8, 59);
            this.btnPMulti.Margin = new System.Windows.Forms.Padding(4);
            this.btnPMulti.Name = "btnPMulti";
            this.btnPMulti.Size = new System.Drawing.Size(313, 28);
            this.btnPMulti.TabIndex = 1;
            this.btnPMulti.Text = "Proyección multiatributo";
            this.btnPMulti.UseVisualStyleBackColor = true;
            // 
            // btnPSimple
            // 
            this.btnPSimple.Location = new System.Drawing.Point(8, 23);
            this.btnPSimple.Margin = new System.Windows.Forms.Padding(4);
            this.btnPSimple.Name = "btnPSimple";
            this.btnPSimple.Size = new System.Drawing.Size(313, 28);
            this.btnPSimple.TabIndex = 0;
            this.btnPSimple.Text = "Proyección simple";
            this.btnPSimple.UseVisualStyleBackColor = true;
            // 
            // dgvResultado
            // 
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Location = new System.Drawing.Point(102, 117);
            this.dgvResultado.Margin = new System.Windows.Forms.Padding(4);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.RowHeadersWidth = 51;
            this.dgvResultado.Size = new System.Drawing.Size(1007, 324);
            this.dgvResultado.TabIndex = 4;
            // 
            // frmBaseDatosOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 726);
            this.Controls.Add(this.mOpWhere);
            this.Controls.Add(this.mOpAlgebra);
            this.Controls.Add(this.mOpSelect);
            this.Controls.Add(this.dgvResultado);
            this.Name = "frmBaseDatosOperaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base de datos";
            this.Load += new System.EventHandler(this.frmBaseDatosOperaciones_Load);
            this.mOpWhere.ResumeLayout(false);
            this.mOpAlgebra.ResumeLayout(false);
            this.mOpSelect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mOpWhere;
        private System.Windows.Forms.Button btnSConvol;
        private System.Windows.Forms.Button btnSMulti;
        private System.Windows.Forms.Button btnSSimple;
        private System.Windows.Forms.GroupBox mOpAlgebra;
        private System.Windows.Forms.Button btnDiferencia;
        private System.Windows.Forms.Button btnInterseccion;
        private System.Windows.Forms.Button btnUnion;
        private System.Windows.Forms.GroupBox mOpSelect;
        private System.Windows.Forms.Button btnPJuntar;
        private System.Windows.Forms.Button btnPMulti;
        private System.Windows.Forms.Button btnPSimple;
        private System.Windows.Forms.DataGridView dgvResultado;
    }
}