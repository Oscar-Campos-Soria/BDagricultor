namespace BDagricultor
{
    partial class FormGasto
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
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechadeGasto = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbIdCultivos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvGastos = new System.Windows.Forms.DataGridView();
            this.btnEliminarGasto = new System.Windows.Forms.Button();
            this.btnGuardarGasto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGastos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(81, 6);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(144, 20);
            this.txtDescripcion.TabIndex = 0;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(81, 43);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(144, 20);
            this.txtMonto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Monto";
            // 
            // dtpFechadeGasto
            // 
            this.dtpFechadeGasto.Location = new System.Drawing.Point(101, 76);
            this.dtpFechadeGasto.Name = "dtpFechadeGasto";
            this.dtpFechadeGasto.Size = new System.Drawing.Size(202, 20);
            this.dtpFechadeGasto.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha de Gasto";
            // 
            // cmbIdCultivos
            // 
            this.cmbIdCultivos.FormattingEnabled = true;
            this.cmbIdCultivos.Location = new System.Drawing.Point(81, 117);
            this.cmbIdCultivos.Name = "cmbIdCultivos";
            this.cmbIdCultivos.Size = new System.Drawing.Size(144, 21);
            this.cmbIdCultivos.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Id Cultivos";
            // 
            // dgvGastos
            // 
            this.dgvGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGastos.Location = new System.Drawing.Point(319, 4);
            this.dgvGastos.Name = "dgvGastos";
            this.dgvGastos.Size = new System.Drawing.Size(469, 263);
            this.dgvGastos.TabIndex = 8;
            // 
            // btnEliminarGasto
            // 
            this.btnEliminarGasto.Location = new System.Drawing.Point(150, 162);
            this.btnEliminarGasto.Name = "btnEliminarGasto";
            this.btnEliminarGasto.Size = new System.Drawing.Size(104, 23);
            this.btnEliminarGasto.TabIndex = 10;
            this.btnEliminarGasto.Text = "Eliminar Gasto";
            this.btnEliminarGasto.UseVisualStyleBackColor = true;
            this.btnEliminarGasto.Click += new System.EventHandler(this.btnEliminarGasto_Click);
            // 
            // btnGuardarGasto
            // 
            this.btnGuardarGasto.Location = new System.Drawing.Point(12, 162);
            this.btnGuardarGasto.Name = "btnGuardarGasto";
            this.btnGuardarGasto.Size = new System.Drawing.Size(114, 23);
            this.btnGuardarGasto.TabIndex = 9;
            this.btnGuardarGasto.Text = "Guardar Gasto";
            this.btnGuardarGasto.UseVisualStyleBackColor = true;
            this.btnGuardarGasto.Click += new System.EventHandler(this.btnGuardarGasto_Click);
            // 
            // FormGasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminarGasto);
            this.Controls.Add(this.btnGuardarGasto);
            this.Controls.Add(this.dgvGastos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbIdCultivos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFechadeGasto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtDescripcion);
            this.Name = "FormGasto";
            this.Text = "FormGasto";
            this.Load += new System.EventHandler(this.FormGasto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGastos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechadeGasto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbIdCultivos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvGastos;
        private System.Windows.Forms.Button btnEliminarGasto;
        private System.Windows.Forms.Button btnGuardarGasto;
    }
}