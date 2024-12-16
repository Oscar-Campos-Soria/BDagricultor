namespace BDagricultor
{
    partial class FormProveedor
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminarProvedor = new System.Windows.Forms.Button();
            this.btnGuardarProvedor = new System.Windows.Forms.Button();
            this.dgvProveedor = new System.Windows.Forms.DataGridView();
            this.txtTelefonoProvedor = new System.Windows.Forms.TextBox();
            this.txtDireccionProvedor = new System.Windows.Forms.TextBox();
            this.txtNombreProvedor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Telefono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Direccion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nombre Provedor";
            // 
            // btnEliminarProvedor
            // 
            this.btnEliminarProvedor.Location = new System.Drawing.Point(138, 189);
            this.btnEliminarProvedor.Name = "btnEliminarProvedor";
            this.btnEliminarProvedor.Size = new System.Drawing.Size(104, 23);
            this.btnEliminarProvedor.TabIndex = 14;
            this.btnEliminarProvedor.Text = "Eliminar Provedor";
            this.btnEliminarProvedor.UseVisualStyleBackColor = true;
            this.btnEliminarProvedor.Click += new System.EventHandler(this.btnEliminarProvedor_Click);
            // 
            // btnGuardarProvedor
            // 
            this.btnGuardarProvedor.Location = new System.Drawing.Point(18, 189);
            this.btnGuardarProvedor.Name = "btnGuardarProvedor";
            this.btnGuardarProvedor.Size = new System.Drawing.Size(114, 23);
            this.btnGuardarProvedor.TabIndex = 13;
            this.btnGuardarProvedor.Text = "Guardar Provedor";
            this.btnGuardarProvedor.UseVisualStyleBackColor = true;
            this.btnGuardarProvedor.Click += new System.EventHandler(this.btnGuardarProvedor_Click);
            // 
            // dgvProveedor
            // 
            this.dgvProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedor.Location = new System.Drawing.Point(271, 12);
            this.dgvProveedor.Name = "dgvProveedor";
            this.dgvProveedor.Size = new System.Drawing.Size(517, 200);
            this.dgvProveedor.TabIndex = 12;
            // 
            // txtTelefonoProvedor
            // 
            this.txtTelefonoProvedor.Location = new System.Drawing.Point(107, 118);
            this.txtTelefonoProvedor.Name = "txtTelefonoProvedor";
            this.txtTelefonoProvedor.Size = new System.Drawing.Size(147, 20);
            this.txtTelefonoProvedor.TabIndex = 11;
            // 
            // txtDireccionProvedor
            // 
            this.txtDireccionProvedor.Location = new System.Drawing.Point(69, 65);
            this.txtDireccionProvedor.Name = "txtDireccionProvedor";
            this.txtDireccionProvedor.Size = new System.Drawing.Size(185, 20);
            this.txtDireccionProvedor.TabIndex = 10;
            // 
            // txtNombreProvedor
            // 
            this.txtNombreProvedor.Location = new System.Drawing.Point(107, 12);
            this.txtNombreProvedor.Name = "txtNombreProvedor";
            this.txtNombreProvedor.Size = new System.Drawing.Size(147, 20);
            this.txtNombreProvedor.TabIndex = 9;
            this.txtNombreProvedor.TextChanged += new System.EventHandler(this.txtNombreProvedor_TextChanged);
            // 
            // FormProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminarProvedor);
            this.Controls.Add(this.btnGuardarProvedor);
            this.Controls.Add(this.dgvProveedor);
            this.Controls.Add(this.txtTelefonoProvedor);
            this.Controls.Add(this.txtDireccionProvedor);
            this.Controls.Add(this.txtNombreProvedor);
            this.Name = "FormProveedor";
            this.Text = "FormProveedor";
            this.Load += new System.EventHandler(this.FormProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminarProvedor;
        private System.Windows.Forms.Button btnGuardarProvedor;
        private System.Windows.Forms.DataGridView dgvProveedor;
        private System.Windows.Forms.TextBox txtTelefonoProvedor;
        private System.Windows.Forms.TextBox txtDireccionProvedor;
        private System.Windows.Forms.TextBox txtNombreProvedor;
    }
}