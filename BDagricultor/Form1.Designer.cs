namespace BDagricultor
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtExperiencia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCultivos = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnProvedor = new System.Windows.Forms.Button();
            this.btnProduccion = new System.Windows.Forms.Button();
            this.btnPlagas = new System.Windows.Forms.Button();
            this.btnPedido = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnGastos = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(100, 76);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(153, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(100, 115);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(153, 20);
            this.txtEdad.TabIndex = 1;
            // 
            // txtExperiencia
            // 
            this.txtExperiencia.Location = new System.Drawing.Point(100, 158);
            this.txtExperiencia.Name = "txtExperiencia";
            this.txtExperiencia.Size = new System.Drawing.Size(153, 20);
            this.txtExperiencia.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Edad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Experiencia";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(298, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(490, 220);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(178, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(100, 37);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(67, 20);
            this.txtID.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "ID";
            // 
            // btnCultivos
            // 
            this.btnCultivos.Location = new System.Drawing.Point(298, 238);
            this.btnCultivos.Name = "btnCultivos";
            this.btnCultivos.Size = new System.Drawing.Size(102, 23);
            this.btnCultivos.TabIndex = 11;
            this.btnCultivos.Text = "Gestionar Cultivos";
            this.btnCultivos.UseVisualStyleBackColor = true;
            this.btnCultivos.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(406, 238);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(102, 23);
            this.btnCliente.TabIndex = 12;
            this.btnCliente.Text = "Gestionar Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnProvedor
            // 
            this.btnProvedor.Location = new System.Drawing.Point(514, 238);
            this.btnProvedor.Name = "btnProvedor";
            this.btnProvedor.Size = new System.Drawing.Size(107, 23);
            this.btnProvedor.TabIndex = 13;
            this.btnProvedor.Text = "Gestionar provedor";
            this.btnProvedor.UseVisualStyleBackColor = true;
            this.btnProvedor.Click += new System.EventHandler(this.btnProvedor_Click);
            // 
            // btnProduccion
            // 
            this.btnProduccion.Location = new System.Drawing.Point(627, 238);
            this.btnProduccion.Name = "btnProduccion";
            this.btnProduccion.Size = new System.Drawing.Size(117, 23);
            this.btnProduccion.TabIndex = 14;
            this.btnProduccion.Text = "Gestionar Produccion";
            this.btnProduccion.UseVisualStyleBackColor = true;
            this.btnProduccion.Click += new System.EventHandler(this.btnProduccion_Click);
            // 
            // btnPlagas
            // 
            this.btnPlagas.Location = new System.Drawing.Point(298, 292);
            this.btnPlagas.Name = "btnPlagas";
            this.btnPlagas.Size = new System.Drawing.Size(102, 23);
            this.btnPlagas.TabIndex = 15;
            this.btnPlagas.Text = "Gestionar Plagas";
            this.btnPlagas.UseVisualStyleBackColor = true;
            this.btnPlagas.Click += new System.EventHandler(this.btnPlagas_Click);
            // 
            // btnPedido
            // 
            this.btnPedido.Location = new System.Drawing.Point(406, 292);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(102, 23);
            this.btnPedido.TabIndex = 16;
            this.btnPedido.Text = "Gestionar Pedido";
            this.btnPedido.UseVisualStyleBackColor = true;
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Location = new System.Drawing.Point(514, 292);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(102, 23);
            this.btnVentas.TabIndex = 17;
            this.btnVentas.Text = "Gestionar Ventas";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnGastos
            // 
            this.btnGastos.Location = new System.Drawing.Point(622, 292);
            this.btnGastos.Name = "btnGastos";
            this.btnGastos.Size = new System.Drawing.Size(102, 23);
            this.btnGastos.TabIndex = 18;
            this.btnGastos.Text = "Gestionar Gastos";
            this.btnGastos.UseVisualStyleBackColor = true;
            this.btnGastos.Click += new System.EventHandler(this.btnGastos_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Location = new System.Drawing.Point(298, 344);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(118, 23);
            this.btnEmpleados.TabIndex = 19;
            this.btnEmpleados.Text = "Gestionar Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEmpleados);
            this.Controls.Add(this.btnGastos);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.btnPedido);
            this.Controls.Add(this.btnPlagas);
            this.Controls.Add(this.btnProduccion);
            this.Controls.Add(this.btnProvedor);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnCultivos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtExperiencia);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtExperiencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCultivos;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnProvedor;
        private System.Windows.Forms.Button btnProduccion;
        private System.Windows.Forms.Button btnPlagas;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnGastos;
        private System.Windows.Forms.Button btnEmpleados;
    }
}

