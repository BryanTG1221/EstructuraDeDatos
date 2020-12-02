namespace ArbolBinarioBusqueda
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
            this.txtInt = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnEliminarNodo = new System.Windows.Forms.Button();
            this.btnBuscarNodo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.chkHomeOffice = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpbRadioButtons = new System.Windows.Forms.GroupBox();
            this.rdbPostOrden = new System.Windows.Forms.RadioButton();
            this.rdbInOrden = new System.Windows.Forms.RadioButton();
            this.rdbPreOrden = new System.Windows.Forms.RadioButton();
            this.gpbDatos = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDibujar = new System.Windows.Forms.Button();
            this.btnGenerarNodos = new System.Windows.Forms.Button();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.dtgMenores = new System.Windows.Forms.DataGridView();
            this.btnLlenarMenore = new System.Windows.Forms.Button();
            this.txtSalario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpbRadioButtons.SuspendLayout();
            this.gpbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMenores)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInt
            // 
            this.txtInt.Location = new System.Drawing.Point(75, 36);
            this.txtInt.Name = "txtInt";
            this.txtInt.Size = new System.Drawing.Size(121, 22);
            this.txtInt.TabIndex = 0;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(775, 18);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(115, 40);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "Ingresar Nodo";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnEliminarNodo
            // 
            this.btnEliminarNodo.Location = new System.Drawing.Point(775, 115);
            this.btnEliminarNodo.Name = "btnEliminarNodo";
            this.btnEliminarNodo.Size = new System.Drawing.Size(115, 40);
            this.btnEliminarNodo.TabIndex = 4;
            this.btnEliminarNodo.Text = "Eliminar Nodo";
            this.btnEliminarNodo.UseVisualStyleBackColor = true;
            this.btnEliminarNodo.Click += new System.EventHandler(this.btnEliminarNodo_Click);
            // 
            // btnBuscarNodo
            // 
            this.btnBuscarNodo.Location = new System.Drawing.Point(775, 64);
            this.btnBuscarNodo.Name = "btnBuscarNodo";
            this.btnBuscarNodo.Size = new System.Drawing.Size(115, 40);
            this.btnBuscarNodo.TabIndex = 5;
            this.btnBuscarNodo.Text = "Buscar Nodo";
            this.btnBuscarNodo.UseVisualStyleBackColor = true;
            this.btnBuscarNodo.Click += new System.EventHandler(this.btnBuscarNodo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 354);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(883, 213);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Jefe",
            "Operador",
            "Supervisor",
            "Pasante"});
            this.comboBox1.Location = new System.Drawing.Point(69, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // chkHomeOffice
            // 
            this.chkHomeOffice.AutoSize = true;
            this.chkHomeOffice.Location = new System.Drawing.Point(24, 148);
            this.chkHomeOffice.Name = "chkHomeOffice";
            this.chkHomeOffice.Size = new System.Drawing.Size(108, 21);
            this.chkHomeOffice.TabIndex = 9;
            this.chkHomeOffice.Text = "Home Office";
            this.chkHomeOffice.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(522, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 234);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // gpbRadioButtons
            // 
            this.gpbRadioButtons.Controls.Add(this.rdbPostOrden);
            this.gpbRadioButtons.Controls.Add(this.rdbInOrden);
            this.gpbRadioButtons.Controls.Add(this.rdbPreOrden);
            this.gpbRadioButtons.Location = new System.Drawing.Point(13, 13);
            this.gpbRadioButtons.Name = "gpbRadioButtons";
            this.gpbRadioButtons.Size = new System.Drawing.Size(200, 234);
            this.gpbRadioButtons.TabIndex = 11;
            this.gpbRadioButtons.TabStop = false;
            this.gpbRadioButtons.Text = "Recorridos";
            // 
            // rdbPostOrden
            // 
            this.rdbPostOrden.AutoSize = true;
            this.rdbPostOrden.Location = new System.Drawing.Point(7, 137);
            this.rdbPostOrden.Name = "rdbPostOrden";
            this.rdbPostOrden.Size = new System.Drawing.Size(97, 21);
            this.rdbPostOrden.TabIndex = 2;
            this.rdbPostOrden.TabStop = true;
            this.rdbPostOrden.Text = "PostOrden";
            this.rdbPostOrden.UseVisualStyleBackColor = true;
            this.rdbPostOrden.CheckedChanged += new System.EventHandler(this.rdbPostOrden_CheckedChanged);
            // 
            // rdbInOrden
            // 
            this.rdbInOrden.AutoSize = true;
            this.rdbInOrden.Location = new System.Drawing.Point(7, 93);
            this.rdbInOrden.Name = "rdbInOrden";
            this.rdbInOrden.Size = new System.Drawing.Size(80, 21);
            this.rdbInOrden.TabIndex = 1;
            this.rdbInOrden.TabStop = true;
            this.rdbInOrden.Text = "InOrden";
            this.rdbInOrden.UseVisualStyleBackColor = true;
            this.rdbInOrden.CheckedChanged += new System.EventHandler(this.rdbInOrden_CheckedChanged);
            // 
            // rdbPreOrden
            // 
            this.rdbPreOrden.AutoSize = true;
            this.rdbPreOrden.Location = new System.Drawing.Point(7, 43);
            this.rdbPreOrden.Name = "rdbPreOrden";
            this.rdbPreOrden.Size = new System.Drawing.Size(91, 21);
            this.rdbPreOrden.TabIndex = 0;
            this.rdbPreOrden.TabStop = true;
            this.rdbPreOrden.Text = "PreOrden";
            this.rdbPreOrden.UseVisualStyleBackColor = true;
            this.rdbPreOrden.CheckedChanged += new System.EventHandler(this.rdbPreOrden_CheckedChanged);
            // 
            // gpbDatos
            // 
            this.gpbDatos.Controls.Add(this.txtSalario);
            this.gpbDatos.Controls.Add(this.label3);
            this.gpbDatos.Controls.Add(this.label2);
            this.gpbDatos.Controls.Add(this.label1);
            this.gpbDatos.Controls.Add(this.txtInt);
            this.gpbDatos.Controls.Add(this.comboBox1);
            this.gpbDatos.Controls.Add(this.chkHomeOffice);
            this.gpbDatos.Location = new System.Drawing.Point(234, 13);
            this.gpbDatos.Name = "gpbDatos";
            this.gpbDatos.Size = new System.Drawing.Size(282, 234);
            this.gpbDatos.TabIndex = 12;
            this.gpbDatos.TabStop = false;
            this.gpbDatos.Text = "Datos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Salario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Puesto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Edad:";
            // 
            // btnDibujar
            // 
            this.btnDibujar.Location = new System.Drawing.Point(775, 161);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(115, 40);
            this.btnDibujar.TabIndex = 13;
            this.btnDibujar.Text = "Dibujar";
            this.btnDibujar.UseVisualStyleBackColor = true;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // btnGenerarNodos
            // 
            this.btnGenerarNodos.Location = new System.Drawing.Point(775, 208);
            this.btnGenerarNodos.Name = "btnGenerarNodos";
            this.btnGenerarNodos.Size = new System.Drawing.Size(115, 49);
            this.btnGenerarNodos.TabIndex = 14;
            this.btnGenerarNodos.Text = "Generar Nodos";
            this.btnGenerarNodos.UseVisualStyleBackColor = true;
            this.btnGenerarNodos.Click += new System.EventHandler(this.btnGenerarNodos_Click);
            // 
            // btnVaciar
            // 
            this.btnVaciar.Location = new System.Drawing.Point(775, 263);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(115, 40);
            this.btnVaciar.TabIndex = 15;
            this.btnVaciar.Text = "Vaciar";
            this.btnVaciar.UseVisualStyleBackColor = true;
            this.btnVaciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtgMenores
            // 
            this.dtgMenores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMenores.Location = new System.Drawing.Point(12, 611);
            this.dtgMenores.Name = "dtgMenores";
            this.dtgMenores.RowHeadersWidth = 51;
            this.dtgMenores.RowTemplate.Height = 24;
            this.dtgMenores.Size = new System.Drawing.Size(883, 213);
            this.dtgMenores.TabIndex = 16;
            this.dtgMenores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMenores_CellContentClick);
            // 
            // btnLlenarMenore
            // 
            this.btnLlenarMenore.Location = new System.Drawing.Point(774, 309);
            this.btnLlenarMenore.Name = "btnLlenarMenore";
            this.btnLlenarMenore.Size = new System.Drawing.Size(116, 38);
            this.btnLlenarMenore.TabIndex = 17;
            this.btnLlenarMenore.Text = "Filtro Menores";
            this.btnLlenarMenore.UseVisualStyleBackColor = true;
            this.btnLlenarMenore.Click += new System.EventHandler(this.btnLlenarMenore_Click);
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(65, 111);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(121, 22);
            this.txtSalario.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 836);
            this.Controls.Add(this.btnLlenarMenore);
            this.Controls.Add(this.dtgMenores);
            this.Controls.Add(this.btnVaciar);
            this.Controls.Add(this.btnGenerarNodos);
            this.Controls.Add(this.btnDibujar);
            this.Controls.Add(this.gpbDatos);
            this.Controls.Add(this.gpbRadioButtons);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBuscarNodo);
            this.Controls.Add(this.btnEliminarNodo);
            this.Controls.Add(this.btnIngresar);
            this.Name = "Form1";
            this.Text = "Arbol BInario de Busqueda";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpbRadioButtons.ResumeLayout(false);
            this.gpbRadioButtons.PerformLayout();
            this.gpbDatos.ResumeLayout(false);
            this.gpbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMenores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtInt;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnEliminarNodo;
        private System.Windows.Forms.Button btnBuscarNodo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox chkHomeOffice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gpbRadioButtons;
        private System.Windows.Forms.RadioButton rdbPostOrden;
        private System.Windows.Forms.RadioButton rdbInOrden;
        private System.Windows.Forms.RadioButton rdbPreOrden;
        private System.Windows.Forms.GroupBox gpbDatos;
        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerarNodos;
        private System.Windows.Forms.Button btnVaciar;
        private System.Windows.Forms.DataGridView dtgMenores;
        private System.Windows.Forms.Button btnLlenarMenore;
        private System.Windows.Forms.TextBox txtSalario;
    }
}

