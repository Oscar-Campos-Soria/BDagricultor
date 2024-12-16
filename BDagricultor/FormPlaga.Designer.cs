namespace BDagricultor
{
    partial class FormPlaga
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
            this.txtNombrePlaga = new System.Windows.Forms.TextBox();
            this.cmbTipoPlaga = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbNivelDaño = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbIdCultivo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvPlagas = new System.Windows.Forms.DataGridView();
            this.btnGuardarPlaga = new System.Windows.Forms.Button();
            this.btnEliminarPlaga = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlagas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombrePlaga
            // 
            this.txtNombrePlaga.Location = new System.Drawing.Point(118, 9);
            this.txtNombrePlaga.Name = "txtNombrePlaga";
            this.txtNombrePlaga.Size = new System.Drawing.Size(121, 20);
            this.txtNombrePlaga.TabIndex = 0;
            // 
            // cmbTipoPlaga
            // 
            this.cmbTipoPlaga.FormattingEnabled = true;
            this.cmbTipoPlaga.Location = new System.Drawing.Point(118, 39);
            this.cmbTipoPlaga.Name = "cmbTipoPlaga";
            this.cmbTipoPlaga.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoPlaga.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de la Plaga ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo de Plaga";
            // 
            // cmbNivelDaño
            // 
            this.cmbNivelDaño.FormattingEnabled = true;
            this.cmbNivelDaño.Location = new System.Drawing.Point(118, 71);
            this.cmbNivelDaño.Name = "cmbNivelDaño";
            this.cmbNivelDaño.Size = new System.Drawing.Size(121, 21);
            this.cmbNivelDaño.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nivel de Daño";
            // 
            // cmbIdCultivo
            // 
            this.cmbIdCultivo.FormattingEnabled = true;
            this.cmbIdCultivo.Location = new System.Drawing.Point(118, 100);
            this.cmbIdCultivo.Name = "cmbIdCultivo";
            this.cmbIdCultivo.Size = new System.Drawing.Size(121, 21);
            this.cmbIdCultivo.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Id Cultivo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dgvPlagas
            // 
            this.dgvPlagas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlagas.Location = new System.Drawing.Point(245, 9);
            this.dgvPlagas.Name = "dgvPlagas";
            this.dgvPlagas.Size = new System.Drawing.Size(543, 207);
            this.dgvPlagas.TabIndex = 8;
            // 
            // btnGuardarPlaga
            // 
            this.btnGuardarPlaga.Location = new System.Drawing.Point(12, 140);
            this.btnGuardarPlaga.Name = "btnGuardarPlaga";
            this.btnGuardarPlaga.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarPlaga.TabIndex = 9;
            this.btnGuardarPlaga.Text = "Guardar";
            this.btnGuardarPlaga.UseVisualStyleBackColor = true;
            this.btnGuardarPlaga.Click += new System.EventHandler(this.btnGuardarPlaga_Click);
            // 
            // btnEliminarPlaga
            // 
            this.btnEliminarPlaga.Location = new System.Drawing.Point(118, 140);
            this.btnEliminarPlaga.Name = "btnEliminarPlaga";
            this.btnEliminarPlaga.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarPlaga.TabIndex = 10;
            this.btnEliminarPlaga.Text = "Eliminar";
            this.btnEliminarPlaga.UseVisualStyleBackColor = true;
            this.btnEliminarPlaga.Click += new System.EventHandler(this.btnEliminarPlaga_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(713, 248);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 11;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // FormPlaga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminarPlaga);
            this.Controls.Add(this.btnGuardarPlaga);
            this.Controls.Add(this.dgvPlagas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbIdCultivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbNivelDaño);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTipoPlaga);
            this.Controls.Add(this.txtNombrePlaga);
            this.Name = "FormPlaga";
            this.Text = "FormPlaga";
            this.Load += new System.EventHandler(this.FormPlaga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlagas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombrePlaga;
        private System.Windows.Forms.ComboBox cmbTipoPlaga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbNivelDaño;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbIdCultivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvPlagas;
        private System.Windows.Forms.Button btnGuardarPlaga;
        private System.Windows.Forms.Button btnEliminarPlaga;
        private System.Windows.Forms.Button btnActualizar;
    }
}