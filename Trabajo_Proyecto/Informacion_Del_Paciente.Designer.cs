namespace Trabajo_Proyecto
{
    partial class Informacion_Del_Paciente
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
            label1 = new Label();
            label2 = new Label();
            txtnombre = new TextBox();
            txtDirrecion = new TextBox();
            label3 = new Label();
            txttelefono = new TextBox();
            label4 = new Label();
            txtedad = new TextBox();
            label5 = new Label();
            txtenfermedades = new TextBox();
            label6 = new Label();
            bteliminar = new FontAwesome.Sharp.IconButton();
            btActualizar = new FontAwesome.Sharp.IconButton();
            btmodificar = new FontAwesome.Sharp.IconButton();
            btGuardar = new FontAwesome.Sharp.IconButton();
            tabla = new DataGridView();
            Clmnombre = new DataGridViewTextBoxColumn();
            Clmedad = new DataGridViewTextBoxColumn();
            ClmDireccion = new DataGridViewTextBoxColumn();
            ClmTelefono = new DataGridViewTextBoxColumn();
            ClmEnfermeades_del_paciente = new DataGridViewTextBoxColumn();
            btmostrar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)tabla).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(141, 15);
            label1.TabIndex = 0;
            label1.Text = "Informacion Del Paciente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(48, 38);
            label2.Name = "label2";
            label2.Size = new Size(68, 19);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // txtnombre
            // 
            txtnombre.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtnombre.Location = new Point(122, 34);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(154, 25);
            txtnombre.TabIndex = 2;
            // 
            // txtDirrecion
            // 
            txtDirrecion.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtDirrecion.Location = new Point(122, 105);
            txtDirrecion.Name = "txtDirrecion";
            txtDirrecion.Size = new Size(154, 25);
            txtDirrecion.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(32, 109);
            label3.Name = "label3";
            label3.Size = new Size(84, 19);
            label3.TabIndex = 3;
            label3.Text = "Dirreccion:";
            // 
            // txttelefono
            // 
            txttelefono.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txttelefono.Location = new Point(122, 141);
            txttelefono.Name = "txttelefono";
            txttelefono.Size = new Size(154, 25);
            txttelefono.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(44, 145);
            label4.Name = "label4";
            label4.Size = new Size(72, 19);
            label4.TabIndex = 5;
            label4.Text = "Telefono:";
            // 
            // txtedad
            // 
            txtedad.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtedad.Location = new Point(122, 71);
            txtedad.Name = "txtedad";
            txtedad.Size = new Size(154, 25);
            txtedad.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(68, 75);
            label5.Name = "label5";
            label5.Size = new Size(48, 19);
            label5.TabIndex = 7;
            label5.Text = "Edad:";
            // 
            // txtenfermedades
            // 
            txtenfermedades.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtenfermedades.Location = new Point(303, 34);
            txtenfermedades.Name = "txtenfermedades";
            txtenfermedades.Size = new Size(243, 25);
            txtenfermedades.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(303, 12);
            label6.Name = "label6";
            label6.Size = new Size(199, 19);
            label6.TabIndex = 9;
            label6.Text = "Enfermedades Del Paciente:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bteliminar
            // 
            bteliminar.FlatAppearance.BorderSize = 0;
            bteliminar.FlatStyle = FlatStyle.Flat;
            bteliminar.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bteliminar.ForeColor = Color.WhiteSmoke;
            bteliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            bteliminar.IconColor = Color.WhiteSmoke;
            bteliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bteliminar.IconSize = 25;
            bteliminar.ImageAlign = ContentAlignment.MiddleLeft;
            bteliminar.Location = new Point(440, 75);
            bteliminar.Name = "bteliminar";
            bteliminar.Size = new Size(102, 39);
            bteliminar.TabIndex = 11;
            bteliminar.Text = "Eliminar";
            bteliminar.TextAlign = ContentAlignment.MiddleLeft;
            bteliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            bteliminar.UseVisualStyleBackColor = true;
            // 
            // btActualizar
            // 
            btActualizar.FlatAppearance.BorderSize = 0;
            btActualizar.FlatStyle = FlatStyle.Flat;
            btActualizar.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btActualizar.ForeColor = Color.WhiteSmoke;
            btActualizar.IconChar = FontAwesome.Sharp.IconChar.RotateForward;
            btActualizar.IconColor = Color.WhiteSmoke;
            btActualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btActualizar.IconSize = 25;
            btActualizar.Location = new Point(328, 75);
            btActualizar.Name = "btActualizar";
            btActualizar.Size = new Size(102, 39);
            btActualizar.TabIndex = 12;
            btActualizar.Text = "Actualizar";
            btActualizar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btActualizar.UseVisualStyleBackColor = true;
            // 
            // btmodificar
            // 
            btmodificar.FlatAppearance.BorderSize = 0;
            btmodificar.FlatStyle = FlatStyle.Flat;
            btmodificar.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btmodificar.ForeColor = Color.WhiteSmoke;
            btmodificar.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            btmodificar.IconColor = Color.WhiteSmoke;
            btmodificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btmodificar.IconSize = 25;
            btmodificar.ImageAlign = ContentAlignment.MiddleLeft;
            btmodificar.Location = new Point(328, 120);
            btmodificar.Name = "btmodificar";
            btmodificar.Size = new Size(102, 39);
            btmodificar.TabIndex = 13;
            btmodificar.Text = "Modificar";
            btmodificar.TextAlign = ContentAlignment.MiddleLeft;
            btmodificar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btmodificar.UseVisualStyleBackColor = true;
            // 
            // btGuardar
            // 
            btGuardar.FlatAppearance.BorderSize = 0;
            btGuardar.FlatStyle = FlatStyle.Flat;
            btGuardar.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btGuardar.ForeColor = Color.WhiteSmoke;
            btGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            btGuardar.IconColor = Color.WhiteSmoke;
            btGuardar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btGuardar.IconSize = 25;
            btGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btGuardar.Location = new Point(444, 120);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(102, 39);
            btGuardar.TabIndex = 14;
            btGuardar.Text = "Guardar";
            btGuardar.TextAlign = ContentAlignment.MiddleLeft;
            btGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btGuardar.UseVisualStyleBackColor = true;
            // 
            // tabla
            // 
            tabla.BackgroundColor = Color.WhiteSmoke;
            tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabla.Columns.AddRange(new DataGridViewColumn[] { Clmnombre, Clmedad, ClmDireccion, ClmTelefono, ClmEnfermeades_del_paciente });
            tabla.Location = new Point(32, 189);
            tabla.Name = "tabla";
            tabla.RowTemplate.Height = 25;
            tabla.Size = new Size(539, 183);
            tabla.TabIndex = 15;
            // 
            // Clmnombre
            // 
            Clmnombre.HeaderText = "Nombre";
            Clmnombre.Name = "Clmnombre";
            // 
            // Clmedad
            // 
            Clmedad.HeaderText = "Edad";
            Clmedad.Name = "Clmedad";
            // 
            // ClmDireccion
            // 
            ClmDireccion.HeaderText = "Dirrecion";
            ClmDireccion.Name = "ClmDireccion";
            // 
            // ClmTelefono
            // 
            ClmTelefono.HeaderText = "Telefono";
            ClmTelefono.Name = "ClmTelefono";
            // 
            // ClmEnfermeades_del_paciente
            // 
            ClmEnfermeades_del_paciente.HeaderText = "Enfermedades";
            ClmEnfermeades_del_paciente.Name = "ClmEnfermeades_del_paciente";
            // 
            // btmostrar
            // 
            btmostrar.FlatAppearance.BorderSize = 0;
            btmostrar.FlatStyle = FlatStyle.Flat;
            btmostrar.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btmostrar.ForeColor = Color.WhiteSmoke;
            btmostrar.IconChar = FontAwesome.Sharp.IconChar.ShareFromSquare;
            btmostrar.IconColor = Color.WhiteSmoke;
            btmostrar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btmostrar.IconSize = 25;
            btmostrar.ImageAlign = ContentAlignment.MiddleLeft;
            btmostrar.Location = new Point(552, 98);
            btmostrar.Name = "btmostrar";
            btmostrar.Size = new Size(102, 39);
            btmostrar.TabIndex = 16;
            btmostrar.Text = "Mostrar";
            btmostrar.TextAlign = ContentAlignment.MiddleLeft;
            btmostrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btmostrar.UseVisualStyleBackColor = true;
            // 
            // Informacion_Del_Paciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            Controls.Add(btmostrar);
            Controls.Add(tabla);
            Controls.Add(btGuardar);
            Controls.Add(btmodificar);
            Controls.Add(btActualizar);
            Controls.Add(bteliminar);
            Controls.Add(txtenfermedades);
            Controls.Add(label6);
            Controls.Add(txtedad);
            Controls.Add(label5);
            Controls.Add(txttelefono);
            Controls.Add(label4);
            Controls.Add(txtDirrecion);
            Controls.Add(label3);
            Controls.Add(txtnombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Informacion_Del_Paciente";
            Size = new Size(705, 413);
            ((System.ComponentModel.ISupportInitialize)tabla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtnombre;
        private TextBox txtDirrecion;
        private Label label3;
        private TextBox txttelefono;
        private Label label4;
        private TextBox txtedad;
        private Label label5;
        private TextBox txtenfermedades;
        private Label label6;
        private FontAwesome.Sharp.IconButton bteliminar;
        private FontAwesome.Sharp.IconButton btActualizar;
        private FontAwesome.Sharp.IconButton btmodificar;
        private FontAwesome.Sharp.IconButton btGuardar;
        private DataGridView tabla;
        private DataGridViewTextBoxColumn Clmnombre;
        private DataGridViewTextBoxColumn Clmedad;
        private DataGridViewTextBoxColumn ClmDireccion;
        private DataGridViewTextBoxColumn ClmTelefono;
        private DataGridViewTextBoxColumn ClmEnfermeades_del_paciente;
        private FontAwesome.Sharp.IconButton btmostrar;
    }
}
