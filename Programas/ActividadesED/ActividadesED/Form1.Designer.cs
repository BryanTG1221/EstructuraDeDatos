namespace ActividadesED
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreAgrupacion = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.cbo = new System.Windows.Forms.ComboBox();
            this.dtpFundacion = new System.Windows.Forms.DateTimePicker();
            this.chk = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rdbClasificacionA = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMonetizacionHora = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidadIntegrantes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreDueño = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rdbClasificacionB = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pic = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnVaciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Agrupacion:";
            // 
            // txtNombreAgrupacion
            // 
            this.txtNombreAgrupacion.Location = new System.Drawing.Point(173, 34);
            this.txtNombreAgrupacion.Name = "txtNombreAgrupacion";
            this.txtNombreAgrupacion.Size = new System.Drawing.Size(202, 22);
            this.txtNombreAgrupacion.TabIndex = 1;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(561, 296);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(105, 41);
            this.btnIngresar.TabIndex = 13;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // cbo
            // 
            this.cbo.FormattingEnabled = true;
            this.cbo.Items.AddRange(new object[] {
            "Banda",
            "Rock",
            "Cumbia",
            "Bachata"});
            this.cbo.Location = new System.Drawing.Point(78, 209);
            this.cbo.Name = "cbo";
            this.cbo.Size = new System.Drawing.Size(157, 24);
            this.cbo.TabIndex = 5;
            // 
            // dtpFundacion
            // 
            this.dtpFundacion.Location = new System.Drawing.Point(588, 37);
            this.dtpFundacion.Name = "dtpFundacion";
            this.dtpFundacion.Size = new System.Drawing.Size(200, 22);
            this.dtpFundacion.TabIndex = 8;
            // 
            // chk
            // 
            this.chk.AutoSize = true;
            this.chk.Location = new System.Drawing.Point(551, 80);
            this.chk.Name = "chk";
            this.chk.Size = new System.Drawing.Size(68, 21);
            this.chk.TabIndex = 9;
            this.chk.Text = "Activo";
            this.chk.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 355);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(884, 201);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // rdbClasificacionA
            // 
            this.rdbClasificacionA.AutoSize = true;
            this.rdbClasificacionA.Checked = true;
            this.rdbClasificacionA.Location = new System.Drawing.Point(125, 239);
            this.rdbClasificacionA.Name = "rdbClasificacionA";
            this.rdbClasificacionA.Size = new System.Drawing.Size(38, 21);
            this.rdbClasificacionA.TabIndex = 6;
            this.rdbClasificacionA.TabStop = true;
            this.rdbClasificacionA.Text = "A";
            this.rdbClasificacionA.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Monetizacion por hora:";
            // 
            // txtMonetizacionHora
            // 
            this.txtMonetizacionHora.Location = new System.Drawing.Point(173, 78);
            this.txtMonetizacionHora.Name = "txtMonetizacionHora";
            this.txtMonetizacionHora.Size = new System.Drawing.Size(107, 22);
            this.txtMonetizacionHora.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Numero de Integrantes:";
            // 
            // txtCantidadIntegrantes
            // 
            this.txtCantidadIntegrantes.Location = new System.Drawing.Point(173, 118);
            this.txtCantidadIntegrantes.Name = "txtCantidadIntegrantes";
            this.txtCantidadIntegrantes.Size = new System.Drawing.Size(107, 22);
            this.txtCantidadIntegrantes.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nombre del Dueño:";
            // 
            // txtNombreDueño
            // 
            this.txtNombreDueño.Location = new System.Drawing.Point(149, 167);
            this.txtNombreDueño.Name = "txtNombreDueño";
            this.txtNombreDueño.Size = new System.Drawing.Size(202, 22);
            this.txtNombreDueño.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Genero:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Clasificacion:";
            // 
            // rdbClasificacionB
            // 
            this.rdbClasificacionB.AutoSize = true;
            this.rdbClasificacionB.Location = new System.Drawing.Point(125, 274);
            this.rdbClasificacionB.Name = "rdbClasificacionB";
            this.rdbClasificacionB.Size = new System.Drawing.Size(38, 21);
            this.rdbClasificacionB.TabIndex = 7;
            this.rdbClasificacionB.TabStop = true;
            this.rdbClasificacionB.Text = "B";
            this.rdbClasificacionB.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(437, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Fundacion del Grupo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(446, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Estado Actual:";
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(672, 123);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(224, 192);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 19;
            this.pic.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(612, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Logo:";
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(561, 249);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(105, 41);
            this.btneliminar.TabIndex = 12;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(561, 158);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(105, 41);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnVaciar
            // 
            this.btnVaciar.Location = new System.Drawing.Point(561, 205);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(105, 41);
            this.btnVaciar.TabIndex = 11;
            this.btnVaciar.Text = "Vaciar";
            this.btnVaciar.UseVisualStyleBackColor = true;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 568);
            this.Controls.Add(this.btnVaciar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rdbClasificacionB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNombreDueño);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCantidadIntegrantes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMonetizacionHora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdbClasificacionA);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chk);
            this.Controls.Add(this.dtpFundacion);
            this.Controls.Add(this.cbo);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtNombreAgrupacion);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreAgrupacion;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.ComboBox cbo;
        private System.Windows.Forms.DateTimePicker dtpFundacion;
        private System.Windows.Forms.CheckBox chk;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rdbClasificacionA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMonetizacionHora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantidadIntegrantes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreDueño;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdbClasificacionB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnVaciar;
    }
}

