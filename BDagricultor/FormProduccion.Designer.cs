namespace BDagricultor
{
    partial class FormProduccion
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
            this.cmbCalidad = new System.Windows.Forms.ComboBox();
            this.txtCantidadProducida = new System.Windows.Forms.TextBox();
            this.dtpFechaProduccion = new System.Windows.Forms.DateTimePicker();
            this.btnGuardarProduccion = new System.Windows.Forms.Button();
            this.btnEliminarProduccion = new System.Windows.Forms.Button();
            this.dgvProduccion = new System.Windows.Forms.DataGridView();
            this.cmbIdCultivo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduccion)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCalidad
            // 
            this.cmbCalidad.FormattingEnabled = true;
            this.cmbCalidad.Location = new System.Drawing.Point(7, 72);
            this.cmbCalidad.Name = "cmbCalidad";
            this.cmbCalidad.Size = new System.Drawing.Size(121, 21);
            this.cmbCalidad.TabIndex = 0;
            this.cmbCalidad.SelectedIndexChanged += new System.EventHandler(this.cmbCalidad_SelectedIndexChanged);
            // 
            // txtCantidadProducida
            // 
            this.txtCantidadProducida.Location = new System.Drawing.Point(7, 33);
            this.txtCantidadProducida.Name = "txtCantidadProducida";
            this.txtCantidadProducida.Size = new System.Drawing.Size(116, 20);
            this.txtCantidadProducida.TabIndex = 1;
            // 
            // dtpFechaProduccion
            // 
            this.dtpFechaProduccion.Location = new System.Drawing.Point(7, 112);
            this.dtpFechaProduccion.Name = "dtpFechaProduccion";
            this.dtpFechaProduccion.Size = new System.Drawing.Size(146, 20);
            this.dtpFechaProduccion.TabIndex = 2;
            // 
            // btnGuardarProduccion
            // 
            this.btnGuardarProduccion.Location = new System.Drawing.Point(7, 205);
            this.btnGuardarProduccion.Name = "btnGuardarProduccion";
            this.btnGuardarProduccion.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarProduccion.TabIndex = 3;
            this.btnGuardarProduccion.Text = "Guardar";
            this.btnGuardarProduccion.UseVisualStyleBackColor = true;
            this.btnGuardarProduccion.Click += new System.EventHandler(this.btnGuardarProduccion_Click);
            // 
            // btnEliminarProduccion
            // 
            this.btnEliminarProduccion.Location = new System.Drawing.Point(148, 205);
            this.btnEliminarProduccion.Name = "btnEliminarProduccion";
            this.btnEliminarProduccion.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarProduccion.TabIndex = 4;
            this.btnEliminarProduccion.Text = "Eliminar";
            this.btnEliminarProduccion.UseVisualStyleBackColor = true;
            this.btnEliminarProduccion.Click += new System.EventHandler(this.btnEliminarProduccion_Click);
            // 
            // dgvProduccion
            // 
            this.dgvProduccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduccion.Location = new System.Drawing.Point(229, 12);
            this.dgvProduccion.Name = "dgvProduccion";
            this.dgvProduccion.Size = new System.Drawing.Size(559, 216);
            this.dgvProduccion.TabIndex = 5;
            // 
            // cmbIdCultivo
            // 
            this.cmbIdCultivo.FormattingEnabled = true;
            this.cmbIdCultivo.Location = new System.Drawing.Point(7, 160);
            this.cmbIdCultivo.Name = "cmbIdCultivo";
            this.cmbIdCultivo.Size = new System.Drawing.Size(121, 21);
            this.cmbIdCultivo.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cantidad Producida en Kg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Calidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fecha de Produccion";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "id Cultivo";
            // 
            // FormProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbIdCultivo);
            this.Controls.Add(this.dgvProduccion);
            this.Controls.Add(this.btnEliminarProduccion);
            this.Controls.Add(this.btnGuardarProduccion);
            this.Controls.Add(this.dtpFechaProduccion);
            this.Controls.Add(this.txtCantidadProducida);
            this.Controls.Add(this.cmbCalidad);
            this.Name = "FormProduccion";
            this.Text = "FormProduccion";
            this.Load += new System.EventHandler(this.FormProduccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCalidad;
        private System.Windows.Forms.TextBox txtCantidadProducida;
        private System.Windows.Forms.DateTimePicker dtpFechaProduccion;
        private System.Windows.Forms.Button btnGuardarProduccion;
        private System.Windows.Forms.Button btnEliminarProduccion;
        private System.Windows.Forms.DataGridView dgvProduccion;
        private System.Windows.Forms.ComboBox cmbIdCultivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}