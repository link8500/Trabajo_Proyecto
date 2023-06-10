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
            txtdepartamento = new TextBox();
            txtcargo = new TextBox();
            txtnombre = new TextBox();
            lbnombre = new Label();
            label2 = new Label();
            label3 = new Label();
            iconBtmostrar = new FontAwesome.Sharp.IconButton();
            iconBtActualizar = new FontAwesome.Sharp.IconButton();
            tabla = new DataGridView();
            ClmNombre = new DataGridViewTextBoxColumn();
            ClmCargo = new DataGridViewTextBoxColumn();
            Clmdepartamento = new DataGridViewTextBoxColumn();
            Clmedad = new DataGridViewTextBoxColumn();
            Clmsexo = new DataGridViewTextBoxColumn();
            Clmnumero = new DataGridViewTextBoxColumn();
            label4 = new Label();
            btmodificar = new FontAwesome.Sharp.IconButton();
            rdbhombre = new RadioButton();
            rdbmujer = new RadioButton();
            label5 = new Label();
            label6 = new Label();
            txtedad = new TextBox();
            panel1 = new Panel();
            lbnumero = new Label();
            txtnumero = new TextBox();
            ((System.ComponentModel.ISupportInitialize)tabla).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // iconBtguardar
            // 
            iconBtguardar.BackColor = Color.FromArgb(0, 0, 64);
            iconBtguardar.Dock = DockStyle.Top;
            iconBtguardar.FlatAppearance.BorderSize = 0;
            iconBtguardar.FlatStyle = FlatStyle.Flat;
            iconBtguardar.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            iconBtguardar.ForeColor = Color.WhiteSmoke;
            iconBtguardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            iconBtguardar.IconColor = Color.WhiteSmoke;
            iconBtguardar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconBtguardar.IconSize = 23;
            iconBtguardar.ImageAlign = ContentAlignment.MiddleLeft;
            iconBtguardar.Location = new Point(0, 80);
            iconBtguardar.Name = "iconBtguardar";
            iconBtguardar.Size = new Size(140, 40);
            iconBtguardar.TabIndex = 0;
            iconBtguardar.Text = "Guardar";
            iconBtguardar.TextAlign = ContentAlignment.MiddleLeft;
            iconBtguardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtguardar.UseVisualStyleBackColor = false;
            iconBtguardar.Click += iconBtguardar_Click;
            // 
            // iconBteliminar
            // 
            iconBteliminar.BackColor = Color.FromArgb(0, 0, 64);
            iconBteliminar.Dock = DockStyle.Top;
            iconBteliminar.FlatAppearance.BorderSize = 0;
            iconBteliminar.FlatStyle = FlatStyle.Flat;
            iconBteliminar.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            iconBteliminar.ForeColor = Color.WhiteSmoke;
            iconBteliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            iconBteliminar.IconColor = Color.WhiteSmoke;
            iconBteliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBteliminar.IconSize = 23;
            iconBteliminar.ImageAlign = ContentAlignment.MiddleLeft;
            iconBteliminar.Location = new Point(0, 160);
            iconBteliminar.Name = "iconBteliminar";
            iconBteliminar.Size = new Size(140, 40);
            iconBteliminar.TabIndex = 1;
            iconBteliminar.Text = "Eliminar";
            iconBteliminar.TextAlign = ContentAlignment.MiddleLeft;
            iconBteliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBteliminar.UseVisualStyleBackColor = false;
            iconBteliminar.Click += iconBteliminar_Click;
            // 
            // txtdepartamento
            // 
            txtdepartamento.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtdepartamento.Location = new Point(133, 129);
            txtdepartamento.Multiline = true;
            txtdepartamento.Name = "txtdepartamento";
            txtdepartamento.Size = new Size(158, 26);
            txtdepartamento.TabIndex = 2;
            // 
            // txtcargo
            // 
            txtcargo.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtcargo.Location = new Point(133, 73);
            txtcargo.Multiline = true;
            txtcargo.Name = "txtcargo";
            txtcargo.Size = new Size(158, 26);
            txtcargo.TabIndex = 3;
            // 
            // txtnombre
            // 
            txtnombre.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtnombre.Location = new Point(133, 24);
            txtnombre.Multiline = true;
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(158, 26);
            txtnombre.TabIndex = 4;
            // 
            // lbnombre
            // 
            lbnombre.AutoSize = true;
            lbnombre.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbnombre.ForeColor = Color.WhiteSmoke;
            lbnombre.Location = new Point(55, 31);
            lbnombre.Name = "lbnombre";
            lbnombre.Size = new Size(68, 19);
            lbnombre.TabIndex = 6;
            lbnombre.Text = "Nombre:";
            lbnombre.Click += label1_Click;
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
            iconBtmostrar.Dock = DockStyle.Top;
            iconBtmostrar.FlatAppearance.BorderSize = 0;
            iconBtmostrar.FlatStyle = FlatStyle.Flat;
            iconBtmostrar.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            iconBtmostrar.ForeColor = Color.WhiteSmoke;
            iconBtmostrar.IconChar = FontAwesome.Sharp.IconChar.ShareFromSquare;
            iconBtmostrar.IconColor = Color.WhiteSmoke;
            iconBtmostrar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconBtmostrar.IconSize = 23;
            iconBtmostrar.ImageAlign = ContentAlignment.MiddleLeft;
            iconBtmostrar.Location = new Point(0, 120);
            iconBtmostrar.Name = "iconBtmostrar";
            iconBtmostrar.Size = new Size(140, 40);
            iconBtmostrar.TabIndex = 11;
            iconBtmostrar.Text = "Mostrar";
            iconBtmostrar.TextAlign = ContentAlignment.MiddleLeft;
            iconBtmostrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtmostrar.UseVisualStyleBackColor = false;
            iconBtmostrar.Click += iconBtmostrar_Click;
            // 
            // iconBtActualizar
            // 
            iconBtActualizar.BackColor = Color.FromArgb(0, 0, 64);
            iconBtActualizar.Dock = DockStyle.Top;
            iconBtActualizar.FlatAppearance.BorderSize = 0;
            iconBtActualizar.FlatStyle = FlatStyle.Flat;
            iconBtActualizar.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            iconBtActualizar.ForeColor = Color.WhiteSmoke;
            iconBtActualizar.IconChar = FontAwesome.Sharp.IconChar.RotateForward;
            iconBtActualizar.IconColor = Color.WhiteSmoke;
            iconBtActualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtActualizar.IconSize = 23;
            iconBtActualizar.ImageAlign = ContentAlignment.MiddleLeft;
            iconBtActualizar.Location = new Point(0, 0);
            iconBtActualizar.Name = "iconBtActualizar";
            iconBtActualizar.Size = new Size(140, 40);
            iconBtActualizar.TabIndex = 10;
            iconBtActualizar.Text = "Actualizar";
            iconBtActualizar.TextAlign = ContentAlignment.MiddleLeft;
            iconBtActualizar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtActualizar.UseVisualStyleBackColor = false;
            iconBtActualizar.Click += iconBtActualizar_Click;
            // 
            // tabla
            // 
            tabla.BackgroundColor = Color.White;
            tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabla.Columns.AddRange(new DataGridViewColumn[] { ClmNombre, ClmCargo, Clmdepartamento, Clmedad, Clmsexo, Clmnumero });
            tabla.Location = new Point(17, 222);
            tabla.Name = "tabla";
            tabla.RowTemplate.Height = 25;
            tabla.Size = new Size(680, 164);
            tabla.TabIndex = 12;
            tabla.CellContentClick += tabla_CellContentClick;
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
            // Clmnumero
            // 
            Clmnumero.HeaderText = "Numero";
            Clmnumero.Name = "Clmnumero";
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
            btmodificar.Dock = DockStyle.Top;
            btmodificar.FlatAppearance.BorderSize = 0;
            btmodificar.FlatStyle = FlatStyle.Flat;
            btmodificar.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btmodificar.ForeColor = Color.WhiteSmoke;
            btmodificar.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            btmodificar.IconColor = Color.WhiteSmoke;
            btmodificar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btmodificar.IconSize = 23;
            btmodificar.ImageAlign = ContentAlignment.MiddleLeft;
            btmodificar.Location = new Point(0, 40);
            btmodificar.Name = "btmodificar";
            btmodificar.Size = new Size(140, 40);
            btmodificar.TabIndex = 14;
            btmodificar.Text = "Modificar";
            btmodificar.TextAlign = ContentAlignment.MiddleLeft;
            btmodificar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btmodificar.UseVisualStyleBackColor = false;
            btmodificar.Click += btmodificar_Click;
            // 
            // rdbhombre
            // 
            rdbhombre.AutoSize = true;
            rdbhombre.Checked = true;
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
            label6.Location = new Point(330, 31);
            label6.Name = "label6";
            label6.Size = new Size(48, 19);
            label6.TabIndex = 19;
            label6.Text = "Edad:";
            // 
            // txtedad
            // 
            txtedad.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtedad.Location = new Point(397, 24);
            txtedad.Multiline = true;
            txtedad.Name = "txtedad";
            txtedad.Size = new Size(104, 26);
            txtedad.TabIndex = 18;
            // 
            // panel1
            // 
            panel1.Controls.Add(iconBteliminar);
            panel1.Controls.Add(iconBtmostrar);
            panel1.Controls.Add(iconBtguardar);
            panel1.Controls.Add(btmodificar);
            panel1.Controls.Add(iconBtActualizar);
            panel1.Location = new Point(562, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(140, 199);
            panel1.TabIndex = 20;
            // 
            // lbnumero
            // 
            lbnumero.AutoSize = true;
            lbnumero.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbnumero.ForeColor = Color.WhiteSmoke;
            lbnumero.Location = new Point(310, 80);
            lbnumero.Name = "lbnumero";
            lbnumero.Size = new Size(68, 19);
            lbnumero.TabIndex = 22;
            lbnumero.Text = "Numero:";
            // 
            // txtnumero
            // 
            txtnumero.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtnumero.Location = new Point(397, 73);
            txtnumero.Multiline = true;
            txtnumero.Name = "txtnumero";
            txtnumero.Size = new Size(104, 26);
            txtnumero.TabIndex = 21;
            // 
            // Empleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            Controls.Add(lbnumero);
            Controls.Add(txtnumero);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(txtedad);
            Controls.Add(label5);
            Controls.Add(rdbmujer);
            Controls.Add(rdbhombre);
            Controls.Add(label4);
            Controls.Add(tabla);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbnombre);
            Controls.Add(txtnombre);
            Controls.Add(txtcargo);
            Controls.Add(txtdepartamento);
            Name = "Empleados";
            Size = new Size(705, 413);
            ((System.ComponentModel.ISupportInitialize)tabla).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton iconBtguardar;
        private FontAwesome.Sharp.IconButton iconBteliminar;
        private TextBox txtdepartamento;
        private TextBox txtcargo;
        private TextBox txtnombre;
        private Label lbnombre;
        private Label label2;
        private Label label3;
        private FontAwesome.Sharp.IconButton iconBtmostrar;
        private FontAwesome.Sharp.IconButton iconBtActualizar;
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
        private TextBox txtedad;
        public DataGridView tabla;
        private DataGridViewTextBoxColumn Clmnumero;
        private Panel panel1;
        private Label lbnumero;
        private TextBox txtnumero;
    }
}
