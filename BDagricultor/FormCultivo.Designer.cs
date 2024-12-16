namespace BDagricultor
{
    partial class FormCultivo
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnEliminarCultivo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvCultivos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTemporada = new System.Windows.Forms.TextBox();
            this.txtNombreCultivo = new System.Windows.Forms.TextBox();
            this.cmbIdAgricultor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCultivos)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "ID Cultivo";
            // 
            // btnEliminarCultivo
            // 
            this.btnEliminarCultivo.Location = new System.Drawing.Point(178, 178);
            this.btnEliminarCultivo.Name = "btnEliminarCultivo";
            this.btnEliminarCultivo.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarCultivo.TabIndex = 19;
            this.btnEliminarCultivo.Text = "Eliminar";
            this.btnEliminarCultivo.UseVisualStyleBackColor = true;
            this.btnEliminarCultivo.Click += new System.EventHandler(this.btnEliminarCultivo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvCultivos
            // 
            this.dgvCultivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCultivos.Location = new System.Drawing.Point(279, 12);
            this.dgvCultivos.Name = "dgvCultivos";
            this.dgvCultivos.Size = new System.Drawing.Size(509, 220);
            this.dgvCultivos.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Temporada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nombre del Cultivo";
            // 
            // txtTemporada
            // 
            this.txtTemporada.Location = new System.Drawing.Point(100, 115);
            this.txtTemporada.Name = "txtTemporada";
            this.txtTemporada.Size = new System.Drawing.Size(153, 20);
            this.txtTemporada.TabIndex = 12;
            // 
            // txtNombreCultivo
            // 
            this.txtNombreCultivo.Location = new System.Drawing.Point(100, 76);
            this.txtNombreCultivo.Name = "txtNombreCultivo";
            this.txtNombreCultivo.Size = new System.Drawing.Size(153, 20);
            this.txtNombreCultivo.TabIndex = 11;
            // 
            // cmbIdAgricultor
            // 
            this.cmbIdAgricultor.FormattingEnabled = true;
            this.cmbIdAgricultor.Location = new System.Drawing.Point(104, 37);
            this.cmbIdAgricultor.Name = "cmbIdAgricultor";
            this.cmbIdAgricultor.Size = new System.Drawing.Size(121, 21);
            this.cmbIdAgricultor.TabIndex = 22;
            // 
            // FormCultivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbIdAgricultor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEliminarCultivo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvCultivos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTemporada);
            this.Controls.Add(this.txtNombreCultivo);
            this.Name = "FormCultivo";
            this.Text = "FormCultivo";
            this.Load += new System.EventHandler(this.FormCultivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCultivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEliminarCultivo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvCultivos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTemporada;
        private System.Windows.Forms.TextBox txtNombreCultivo;
        private System.Windows.Forms.ComboBox cmbIdAgricultor;
    }
}