namespace BDagricultor
{
    partial class FormVenta
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
            this.dtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidadVendida = new System.Windows.Forms.TextBox();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbIdProduccion = new System.Windows.Forms.ComboBox();
            this.cmbIdCliente = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.btnActualizarVenta = new System.Windows.Forms.Button();
            this.bntEliminarVenta = new System.Windows.Forms.Button();
            this.btnGuardarVenta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFechaVenta
            // 
            this.dtpFechaVenta.Location = new System.Drawing.Point(118, 26);
            this.dtpFechaVenta.Name = "dtpFechaVenta";
            this.dtpFechaVenta.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaVenta.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha de Venta";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad Vendida";
            // 
            // txtCantidadVendida
            // 
            this.txtCantidadVendida.Location = new System.Drawing.Point(118, 52);
            this.txtCantidadVendida.Name = "txtCantidadVendida";
            this.txtCantidadVendida.Size = new System.Drawing.Size(162, 20);
            this.txtCantidadVendida.TabIndex = 3;
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Location = new System.Drawing.Point(118, 81);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(162, 20);
            this.txtPrecioUnitario.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio Unitario";
            // 
            // cmbIdProduccion
            // 
            this.cmbIdProduccion.FormattingEnabled = true;
            this.cmbIdProduccion.Location = new System.Drawing.Point(118, 118);
            this.cmbIdProduccion.Name = "cmbIdProduccion";
            this.cmbIdProduccion.Size = new System.Drawing.Size(162, 21);
            this.cmbIdProduccion.TabIndex = 6;
            // 
            // cmbIdCliente
            // 
            this.cmbIdCliente.FormattingEnabled = true;
            this.cmbIdCliente.Location = new System.Drawing.Point(118, 149);
            this.cmbIdCliente.Name = "cmbIdCliente";
            this.cmbIdCliente.Size = new System.Drawing.Size(162, 21);
            this.cmbIdCliente.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Id Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Id Produccion";
            // 
            // dgvVentas
            // 
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(338, 12);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.Size = new System.Drawing.Size(450, 221);
            this.dgvVentas.TabIndex = 10;
            // 
            // btnActualizarVenta
            // 
            this.btnActualizarVenta.Location = new System.Drawing.Point(205, 222);
            this.btnActualizarVenta.Name = "btnActualizarVenta";
            this.btnActualizarVenta.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarVenta.TabIndex = 13;
            this.btnActualizarVenta.Text = "Actualizar";
            this.btnActualizarVenta.UseVisualStyleBackColor = true;
            // 
            // bntEliminarVenta
            // 
            this.bntEliminarVenta.Location = new System.Drawing.Point(106, 222);
            this.bntEliminarVenta.Name = "bntEliminarVenta";
            this.bntEliminarVenta.Size = new System.Drawing.Size(75, 23);
            this.bntEliminarVenta.TabIndex = 12;
            this.bntEliminarVenta.Text = "Eliminar";
            this.bntEliminarVenta.UseVisualStyleBackColor = true;
            this.bntEliminarVenta.Click += new System.EventHandler(this.bntEliminarVenta_Click);
            // 
            // btnGuardarVenta
            // 
            this.btnGuardarVenta.Location = new System.Drawing.Point(12, 222);
            this.btnGuardarVenta.Name = "btnGuardarVenta";
            this.btnGuardarVenta.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarVenta.TabIndex = 11;
            this.btnGuardarVenta.Text = "Guardar";
            this.btnGuardarVenta.UseVisualStyleBackColor = true;
            this.btnGuardarVenta.Click += new System.EventHandler(this.btnGuardarVenta_Click);
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnActualizarVenta);
            this.Controls.Add(this.bntEliminarVenta);
            this.Controls.Add(this.btnGuardarVenta);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbIdCliente);
            this.Controls.Add(this.cmbIdProduccion);
            this.Controls.Add(this.txtPrecioUnitario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCantidadVendida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaVenta);
            this.Name = "FormVenta";
            this.Text = "FormVenta";
            this.Load += new System.EventHandler(this.FormVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCantidadVendida;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbIdProduccion;
        private System.Windows.Forms.ComboBox cmbIdCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Button btnActualizarVenta;
        private System.Windows.Forms.Button bntEliminarVenta;
        private System.Windows.Forms.Button btnGuardarVenta;
    }
}