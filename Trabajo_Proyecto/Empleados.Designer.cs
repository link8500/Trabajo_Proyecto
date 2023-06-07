namespace Trabajo_Proyecto
{
    partial class Empleados
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            iconBtguardar = new FontAwesome.Sharp.IconButton();
            iconBteliminar = new FontAwesome.Sharp.IconButton();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            iconBtmostrar = new FontAwesome.Sharp.IconButton();
            iconBtActualizar = new FontAwesome.Sharp.IconButton();
            dataGridView1 = new DataGridView();
            ClmNombre = new DataGridViewTextBoxColumn();
            ClmCargo = new DataGridViewTextBoxColumn();
            Clmdepartamento = new DataGridViewTextBoxColumn();
            Clmedad = new DataGridViewTextBoxColumn();
            Clmsexo = new DataGridViewTextBoxColumn();
            label4 = new Label();
            btmodificar = new FontAwesome.Sharp.IconButton();
            rdbhombre = new RadioButton();
            rdbmujer = new RadioButton();
            label5 = new Label();
            label6 = new Label();
            textBox4 = new TextBox();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // iconBtguardar
            // 
            iconBtguardar.BackColor = Color.FromArgb(0, 0, 64);
            iconBtguardar.FlatAppearance.BorderSize = 0;
            iconBtguardar.FlatStyle = FlatStyle.Flat;
            iconBtguardar.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            iconBtguardar.ForeColor = Color.WhiteSmoke;
            iconBtguardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            iconBtguardar.IconColor = Color.WhiteSmoke;
            iconBtguardar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconBtguardar.IconSize = 23;
            iconBtguardar.ImageAlign = ContentAlignment.MiddleLeft;
            iconBtguardar.Location = new Point(339, 77);
            iconBtguardar.Name = "iconBtguardar";
            iconBtguardar.Size = new Size(88, 26);
            iconBtguardar.TabIndex = 0;
            iconBtguardar.Text = "Guardar";
            iconBtguardar.TextAlign = ContentAlignment.MiddleLeft;
            iconBtguardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtguardar.UseVisualStyleBackColor = false;
            // 
            // iconBteliminar
            // 
            iconBteliminar.BackColor = Color.FromArgb(0, 0, 64);
            iconBteliminar.FlatAppearance.BorderSize = 0;
            iconBteliminar.FlatStyle = FlatStyle.Flat;
            iconBteliminar.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            iconBteliminar.ForeColor = Color.WhiteSmoke;
            iconBteliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            iconBteliminar.IconColor = Color.WhiteSmoke;
            iconBteliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBteliminar.IconSize = 23;
            iconBteliminar.ImageAlign = ContentAlignment.MiddleLeft;
            iconBteliminar.Location = new Point(447, 80);
            iconBteliminar.Name = "iconBteliminar";
            iconBteliminar.Size = new Size(88, 26);
            iconBteliminar.TabIndex = 1;
            iconBteliminar.Text = "Eliminar";
            iconBteliminar.TextAlign = ContentAlignment.MiddleLeft;
            iconBteliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBteliminar.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(133, 129);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(158, 26);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(133, 73);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(158, 26);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(133, 24);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(158, 26);
            textBox3.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(55, 31);
            label1.Name = "label1";
            label1.Size = new Size(68, 19);
            label1.TabIndex = 6;
            label1.Text = "Nombre:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(68, 80);
            label2.Name = "label2";
            label2.Size = new Size(55, 19);
            label2.TabIndex = 7;
            label2.Text = "Cargo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(17, 133);
            label3.Name = "label3";
            label3.Size = new Size(110, 19);
            label3.TabIndex = 8;
            label3.Text = "Departamento:";
            // 
            // iconBtmostrar
            // 
            iconBtmostrar.BackColor = Color.FromArgb(0, 0, 64);
            iconBtmostrar.FlatAppearance.BorderSize = 0;
            iconBtmostrar.FlatStyle = FlatStyle.Flat;
            iconBtmostrar.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            iconBtmostrar.ForeColor = Color.WhiteSmoke;
            iconBtmostrar.IconChar = FontAwesome.Sharp.IconChar.ShareFromSquare;
            iconBtmostrar.IconColor = Color.WhiteSmoke;
            iconBtmostrar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconBtmostrar.IconSize = 23;
            iconBtmostrar.ImageAlign = ContentAlignment.MiddleLeft;
            iconBtmostrar.Location = new Point(391, 158);
            iconBtmostrar.Name = "iconBtmostrar";
            iconBtmostrar.Size = new Size(88, 26);
            iconBtmostrar.TabIndex = 11;
            iconBtmostrar.Text = "Mostrar";
            iconBtmostrar.TextAlign = ContentAlignment.MiddleLeft;
            iconBtmostrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtmostrar.UseVisualStyleBackColor = false;
            // 
            // iconBtActualizar
            // 
            iconBtActualizar.BackColor = Color.FromArgb(0, 0, 64);
            iconBtActualizar.FlatAppearance.BorderSize = 0;
            iconBtActualizar.FlatStyle = FlatStyle.Flat;
            iconBtActualizar.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            iconBtActualizar.ForeColor = Color.WhiteSmoke;
            iconBtActualizar.IconChar = FontAwesome.Sharp.IconChar.RotateForward;
            iconBtActualizar.IconColor = Color.WhiteSmoke;
            iconBtActualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtActualizar.IconSize = 23;
            iconBtActualizar.ImageAlign = ContentAlignment.MiddleLeft;
            iconBtActualizar.Location = new Point(447, 126);
            iconBtActualizar.Name = "iconBtActualizar";
            iconBtActualizar.Size = new Size(88, 26);
            iconBtActualizar.TabIndex = 10;
            iconBtActualizar.Text = "Actualizar";
            iconBtActualizar.TextAlign = ContentAlignment.MiddleLeft;
            iconBtActualizar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtActualizar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ClmNombre, ClmCargo, Clmdepartamento, Clmedad, Clmsexo });
            dataGridView1.Location = new Point(17, 222);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(680, 164);
            dataGridView1.TabIndex = 12;
            // 
            // ClmNombre
            // 
            ClmNombre.HeaderText = "Nombre";
            ClmNombre.Name = "ClmNombre";
            ClmNombre.Width = 150;
            // 
            // ClmCargo
            // 
            ClmCargo.HeaderText = "Cargo";
            ClmCargo.Name = "ClmCargo";
            ClmCargo.Width = 150;
            // 
            // Clmdepartamento
            // 
            Clmdepartamento.HeaderText = "Departamento";
            Clmdepartamento.Name = "Clmdepartamento";
            Clmdepartamento.Width = 150;
            // 
            // Clmedad
            // 
            Clmedad.HeaderText = "Edad";
            Clmedad.Name = "Clmedad";
            // 
            // Clmsexo
            // 
            Clmsexo.HeaderText = "Sexo";
            Clmsexo.Name = "Clmsexo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(146, 15);
            label4.TabIndex = 13;
            label4.Text = "Empleados De Este Centro";
            // 
            // btmodificar
            // 
            btmodificar.BackColor = Color.FromArgb(0, 0, 64);
            btmodificar.FlatAppearance.BorderSize = 0;
            btmodificar.FlatStyle = FlatStyle.Flat;
            btmodificar.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btmodificar.ForeColor = Color.WhiteSmoke;
            btmodificar.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            btmodificar.IconColor = Color.WhiteSmoke;
            btmodificar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btmodificar.IconSize = 23;
            btmodificar.ImageAlign = ContentAlignment.MiddleLeft;
            btmodificar.Location = new Point(339, 126);
            btmodificar.Name = "btmodificar";
            btmodificar.Size = new Size(88, 26);
            btmodificar.TabIndex = 14;
            btmodificar.Text = "Modificar";
            btmodificar.TextAlign = ContentAlignment.MiddleLeft;
            btmodificar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btmodificar.UseVisualStyleBackColor = false;
            // 
            // rdbhombre
            // 
            rdbhombre.AutoSize = true;
            rdbhombre.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rdbhombre.ForeColor = Color.WhiteSmoke;
            rdbhombre.Location = new Point(133, 180);
            rdbhombre.Name = "rdbhombre";
            rdbhombre.Size = new Size(81, 23);
            rdbhombre.TabIndex = 15;
            rdbhombre.TabStop = true;
            rdbhombre.Text = "Hombre";
            rdbhombre.UseVisualStyleBackColor = true;
            // 
            // rdbmujer
            // 
            rdbmujer.AutoSize = true;
            rdbmujer.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rdbmujer.ForeColor = Color.WhiteSmoke;
            rdbmujer.Location = new Point(222, 180);
            rdbmujer.Name = "rdbmujer";
            rdbmujer.Size = new Size(69, 23);
            rdbmujer.TabIndex = 16;
            rdbmujer.TabStop = true;
            rdbmujer.Text = "Mujer";
            rdbmujer.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(76, 180);
            label5.Name = "label5";
            label5.Size = new Size(47, 19);
            label5.TabIndex = 17;
            label5.Text = "Sexo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(310, 31);
            label6.Name = "label6";
            label6.Size = new Size(48, 19);
            label6.TabIndex = 19;
            label6.Text = "Edad:";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.Location = new Point(364, 24);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(104, 26);
            textBox4.TabIndex = 18;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(559, 24);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 20;
            // 
            // Empleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            Controls.Add(listBox1);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(rdbmujer);
            Controls.Add(rdbhombre);
            Controls.Add(btmodificar);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(iconBtmostrar);
            Controls.Add(iconBtActualizar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(iconBteliminar);
            Controls.Add(iconBtguardar);
            Name = "Empleados";
            Size = new Size(705, 413);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton iconBtguardar;
        private FontAwesome.Sharp.IconButton iconBteliminar;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private FontAwesome.Sharp.IconButton iconBtmostrar;
        private FontAwesome.Sharp.IconButton iconBtActualizar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ClmNombre;
        private DataGridViewTextBoxColumn ClmCargo;
        private DataGridViewTextBoxColumn Clmdepartamento;
        private Label label4;
        private FontAwesome.Sharp.IconButton btmodificar;
        private RadioButton rdbhombre;
        private RadioButton rdbmujer;
        private Label label5;
        private DataGridViewTextBoxColumn Clmedad;
        private DataGridViewTextBoxColumn Clmsexo;
        private Label label6;
        private TextBox textBox4;
        private ListBox listBox1;
    }
}
