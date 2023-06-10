namespace Trabajo_Proyecto
{
    partial class eventos_de_vacunacion
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
            lbejecutada = new Label();
            txtfecha = new TextBox();
            lbfecha = new Label();
            txtRangoDeEdades = new TextBox();
            lbRangoDeEdades = new Label();
            txttipodevacuna = new TextBox();
            lbtipodevacuna = new Label();
            txtZonaDondeSeAplico = new TextBox();
            lbZonaDondeSeAplico = new Label();
            label6 = new Label();
            btActualizar = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            BtModificar = new FontAwesome.Sharp.IconButton();
            btMostrar = new FontAwesome.Sharp.IconButton();
            btEliminar = new FontAwesome.Sharp.IconButton();
            btGuardar = new FontAwesome.Sharp.IconButton();
            btSeleccion = new FontAwesome.Sharp.IconButton();
            rdbSi = new RadioButton();
            rdbNo = new RadioButton();
            tabla = new DataGridView();
            Clmejecutada = new DataGridViewTextBoxColumn();
            ClmFecha = new DataGridViewTextBoxColumn();
            ClmTipodevacuna = new DataGridViewTextBoxColumn();
            ClmRangodeedades = new DataGridViewTextBoxColumn();
            ClmZona_donde_se_aplico = new DataGridViewTextBoxColumn();
            Clmparticipacion = new DataGridViewTextBoxColumn();
            txtseleccion = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabla).BeginInit();
            SuspendLayout();
            // 
            // lbejecutada
            // 
            lbejecutada.AutoSize = true;
            lbejecutada.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbejecutada.ForeColor = Color.WhiteSmoke;
            lbejecutada.Location = new Point(42, 37);
            lbejecutada.Name = "lbejecutada";
            lbejecutada.Size = new Size(80, 19);
            lbejecutada.TabIndex = 0;
            lbejecutada.Text = "Ejecutada:";
            // 
            // txtfecha
            // 
            txtfecha.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtfecha.Location = new Point(128, 75);
            txtfecha.Name = "txtfecha";
            txtfecha.Size = new Size(105, 26);
            txtfecha.TabIndex = 3;
            // 
            // lbfecha
            // 
            lbfecha.AutoSize = true;
            lbfecha.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbfecha.ForeColor = Color.WhiteSmoke;
            lbfecha.Location = new Point(73, 78);
            lbfecha.Name = "lbfecha";
            lbfecha.Size = new Size(54, 19);
            lbfecha.TabIndex = 2;
            lbfecha.Text = "Fecha:";
            // 
            // txtRangoDeEdades
            // 
            txtRangoDeEdades.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtRangoDeEdades.Location = new Point(433, 23);
            txtRangoDeEdades.Name = "txtRangoDeEdades";
            txtRangoDeEdades.Size = new Size(121, 26);
            txtRangoDeEdades.TabIndex = 5;
            // 
            // lbRangoDeEdades
            // 
            lbRangoDeEdades.AutoSize = true;
            lbRangoDeEdades.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbRangoDeEdades.ForeColor = Color.WhiteSmoke;
            lbRangoDeEdades.Location = new Point(297, 30);
            lbRangoDeEdades.Name = "lbRangoDeEdades";
            lbRangoDeEdades.Size = new Size(135, 19);
            lbRangoDeEdades.TabIndex = 4;
            lbRangoDeEdades.Text = "Rango De Edades:";
            // 
            // txttipodevacuna
            // 
            txttipodevacuna.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txttipodevacuna.Location = new Point(128, 124);
            txttipodevacuna.Name = "txttipodevacuna";
            txttipodevacuna.Size = new Size(145, 26);
            txttipodevacuna.TabIndex = 7;
            // 
            // lbtipodevacuna
            // 
            lbtipodevacuna.AutoSize = true;
            lbtipodevacuna.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbtipodevacuna.ForeColor = Color.WhiteSmoke;
            lbtipodevacuna.Location = new Point(6, 127);
            lbtipodevacuna.Name = "lbtipodevacuna";
            lbtipodevacuna.Size = new Size(121, 19);
            lbtipodevacuna.TabIndex = 6;
            lbtipodevacuna.Text = "Tipo De Vacuna:";
            // 
            // txtZonaDondeSeAplico
            // 
            txtZonaDondeSeAplico.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtZonaDondeSeAplico.Location = new Point(433, 68);
            txtZonaDondeSeAplico.Name = "txtZonaDondeSeAplico";
            txtZonaDondeSeAplico.Size = new Size(121, 26);
            txtZonaDondeSeAplico.TabIndex = 9;
            // 
            // lbZonaDondeSeAplico
            // 
            lbZonaDondeSeAplico.AutoSize = true;
            lbZonaDondeSeAplico.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbZonaDondeSeAplico.ForeColor = Color.WhiteSmoke;
            lbZonaDondeSeAplico.Location = new Point(271, 75);
            lbZonaDondeSeAplico.Name = "lbZonaDondeSeAplico";
            lbZonaDondeSeAplico.Size = new Size(161, 19);
            lbZonaDondeSeAplico.TabIndex = 8;
            lbZonaDondeSeAplico.Text = "Zona Donde Se Aplico:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(176, 19);
            label6.TabIndex = 10;
            label6.Text = "Campaña De Vacunacion";
            // 
            // btActualizar
            // 
            btActualizar.Dock = DockStyle.Top;
            btActualizar.FlatAppearance.BorderSize = 0;
            btActualizar.FlatStyle = FlatStyle.Flat;
            btActualizar.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btActualizar.ForeColor = Color.WhiteSmoke;
            btActualizar.IconChar = FontAwesome.Sharp.IconChar.RotateForward;
            btActualizar.IconColor = Color.WhiteSmoke;
            btActualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btActualizar.IconSize = 25;
            btActualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btActualizar.Location = new Point(0, 172);
            btActualizar.Name = "btActualizar";
            btActualizar.Size = new Size(123, 29);
            btActualizar.TabIndex = 11;
            btActualizar.Text = "Actualizar";
            btActualizar.TextAlign = ContentAlignment.MiddleLeft;
            btActualizar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btActualizar.UseVisualStyleBackColor = true;
            btActualizar.Click += btActualizar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btActualizar);
            panel1.Controls.Add(BtModificar);
            panel1.Controls.Add(btMostrar);
            panel1.Controls.Add(btEliminar);
            panel1.Controls.Add(btGuardar);
            panel1.Location = new Point(560, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(123, 204);
            panel1.TabIndex = 12;
            // 
            // BtModificar
            // 
            BtModificar.Dock = DockStyle.Top;
            BtModificar.FlatAppearance.BorderSize = 0;
            BtModificar.FlatStyle = FlatStyle.Flat;
            BtModificar.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtModificar.ForeColor = Color.WhiteSmoke;
            BtModificar.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            BtModificar.IconColor = Color.WhiteSmoke;
            BtModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtModificar.IconSize = 25;
            BtModificar.ImageAlign = ContentAlignment.MiddleLeft;
            BtModificar.Location = new Point(0, 129);
            BtModificar.Name = "BtModificar";
            BtModificar.Size = new Size(123, 43);
            BtModificar.TabIndex = 13;
            BtModificar.Text = "Modificar";
            BtModificar.TextAlign = ContentAlignment.MiddleLeft;
            BtModificar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtModificar.UseVisualStyleBackColor = true;
            BtModificar.Click += BtModificar_Click;
            // 
            // btMostrar
            // 
            btMostrar.Dock = DockStyle.Top;
            btMostrar.FlatAppearance.BorderSize = 0;
            btMostrar.FlatStyle = FlatStyle.Flat;
            btMostrar.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btMostrar.ForeColor = Color.WhiteSmoke;
            btMostrar.IconChar = FontAwesome.Sharp.IconChar.ShareFromSquare;
            btMostrar.IconColor = Color.WhiteSmoke;
            btMostrar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btMostrar.IconSize = 25;
            btMostrar.ImageAlign = ContentAlignment.MiddleLeft;
            btMostrar.Location = new Point(0, 86);
            btMostrar.Name = "btMostrar";
            btMostrar.Size = new Size(123, 43);
            btMostrar.TabIndex = 14;
            btMostrar.Text = "Mostrar";
            btMostrar.TextAlign = ContentAlignment.MiddleLeft;
            btMostrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btMostrar.UseVisualStyleBackColor = true;
            btMostrar.Click += btMostrar_Click;
            // 
            // btEliminar
            // 
            btEliminar.Dock = DockStyle.Top;
            btEliminar.FlatAppearance.BorderSize = 0;
            btEliminar.FlatStyle = FlatStyle.Flat;
            btEliminar.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btEliminar.ForeColor = Color.WhiteSmoke;
            btEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btEliminar.IconColor = Color.WhiteSmoke;
            btEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btEliminar.IconSize = 25;
            btEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btEliminar.Location = new Point(0, 43);
            btEliminar.Name = "btEliminar";
            btEliminar.Size = new Size(123, 43);
            btEliminar.TabIndex = 15;
            btEliminar.Text = "Eliminar";
            btEliminar.TextAlign = ContentAlignment.MiddleLeft;
            btEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btEliminar.UseVisualStyleBackColor = true;
            btEliminar.Click += btEliminar_Click;
            // 
            // btGuardar
            // 
            btGuardar.Dock = DockStyle.Top;
            btGuardar.FlatAppearance.BorderSize = 0;
            btGuardar.FlatStyle = FlatStyle.Flat;
            btGuardar.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btGuardar.ForeColor = Color.WhiteSmoke;
            btGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            btGuardar.IconColor = Color.WhiteSmoke;
            btGuardar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btGuardar.IconSize = 25;
            btGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btGuardar.Location = new Point(0, 0);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(123, 43);
            btGuardar.TabIndex = 16;
            btGuardar.Text = "Guardar";
            btGuardar.TextAlign = ContentAlignment.MiddleLeft;
            btGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btGuardar.UseVisualStyleBackColor = true;
            btGuardar.Click += btGuardar_Click;
            // 
            // btSeleccion
            // 
            btSeleccion.FlatAppearance.BorderSize = 0;
            btSeleccion.FlatStyle = FlatStyle.Flat;
            btSeleccion.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btSeleccion.ForeColor = Color.WhiteSmoke;
            btSeleccion.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            btSeleccion.IconColor = Color.WhiteSmoke;
            btSeleccion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btSeleccion.IconSize = 30;
            btSeleccion.ImageAlign = ContentAlignment.MiddleLeft;
            btSeleccion.Location = new Point(299, 115);
            btSeleccion.Name = "btSeleccion";
            btSeleccion.Size = new Size(224, 43);
            btSeleccion.TabIndex = 15;
            btSeleccion.Text = "Seleccione El Personal que Participo en la Campaña";
            btSeleccion.TextAlign = ContentAlignment.MiddleLeft;
            btSeleccion.TextImageRelation = TextImageRelation.ImageBeforeText;
            btSeleccion.UseVisualStyleBackColor = true;
            btSeleccion.Click += btSeleccion_Click;
            // 
            // rdbSi
            // 
            rdbSi.AutoSize = true;
            rdbSi.Checked = true;
            rdbSi.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            rdbSi.ForeColor = Color.WhiteSmoke;
            rdbSi.Location = new Point(128, 36);
            rdbSi.Name = "rdbSi";
            rdbSi.Size = new Size(38, 21);
            rdbSi.TabIndex = 16;
            rdbSi.TabStop = true;
            rdbSi.Text = "Si";
            rdbSi.UseVisualStyleBackColor = true;
            // 
            // rdbNo
            // 
            rdbNo.AutoSize = true;
            rdbNo.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            rdbNo.ForeColor = Color.WhiteSmoke;
            rdbNo.Location = new Point(178, 36);
            rdbNo.Name = "rdbNo";
            rdbNo.Size = new Size(45, 21);
            rdbNo.TabIndex = 17;
            rdbNo.Text = "No";
            rdbNo.UseVisualStyleBackColor = true;
            // 
            // tabla
            // 
            tabla.BackgroundColor = Color.WhiteSmoke;
            tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabla.Columns.AddRange(new DataGridViewColumn[] { Clmejecutada, ClmFecha, ClmTipodevacuna, ClmRangodeedades, ClmZona_donde_se_aplico, Clmparticipacion });
            tabla.Location = new Point(26, 213);
            tabla.Name = "tabla";
            tabla.RowTemplate.Height = 25;
            tabla.Size = new Size(642, 165);
            tabla.TabIndex = 18;
            // 
            // Clmejecutada
            // 
            Clmejecutada.HeaderText = "Ejecutada";
            Clmejecutada.Name = "Clmejecutada";
            // 
            // ClmFecha
            // 
            ClmFecha.HeaderText = "Fecha";
            ClmFecha.Name = "ClmFecha";
            // 
            // ClmTipodevacuna
            // 
            ClmTipodevacuna.HeaderText = "Tipo de Vacuna";
            ClmTipodevacuna.Name = "ClmTipodevacuna";
            // 
            // ClmRangodeedades
            // 
            ClmRangodeedades.HeaderText = "Rango De Edades";
            ClmRangodeedades.Name = "ClmRangodeedades";
            // 
            // ClmZona_donde_se_aplico
            // 
            ClmZona_donde_se_aplico.HeaderText = "Zona Donde Se Aplico";
            ClmZona_donde_se_aplico.Name = "ClmZona_donde_se_aplico";
            // 
            // Clmparticipacion
            // 
            Clmparticipacion.HeaderText = "Empleados Que Participaron";
            Clmparticipacion.Name = "Clmparticipacion";
            // 
            // txtseleccion
            // 
            txtseleccion.Enabled = false;
            txtseleccion.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtseleccion.Location = new Point(297, 164);
            txtseleccion.Multiline = true;
            txtseleccion.Name = "txtseleccion";
            txtseleccion.Size = new Size(257, 40);
            txtseleccion.TabIndex = 19;
            // 
            // eventos_de_vacunacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            Controls.Add(txtseleccion);
            Controls.Add(tabla);
            Controls.Add(rdbNo);
            Controls.Add(rdbSi);
            Controls.Add(btSeleccion);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(txtZonaDondeSeAplico);
            Controls.Add(lbZonaDondeSeAplico);
            Controls.Add(txttipodevacuna);
            Controls.Add(lbtipodevacuna);
            Controls.Add(txtRangoDeEdades);
            Controls.Add(lbRangoDeEdades);
            Controls.Add(txtfecha);
            Controls.Add(lbfecha);
            Controls.Add(lbejecutada);
            Name = "eventos_de_vacunacion";
            Size = new Size(705, 413);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tabla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbejecutada;
        private TextBox txtfecha;
        private Label lbfecha;
        private TextBox txtRangoDeEdades;
        private Label lbRangoDeEdades;
        private TextBox txttipodevacuna;
        private Label lbtipodevacuna;
        private TextBox txtZonaDondeSeAplico;
        private Label lbZonaDondeSeAplico;
        private Label label6;
        private FontAwesome.Sharp.IconButton btActualizar;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton BtModificar;
        private FontAwesome.Sharp.IconButton btMostrar;
        private FontAwesome.Sharp.IconButton btEliminar;
        private FontAwesome.Sharp.IconButton btGuardar;
        private FontAwesome.Sharp.IconButton btSeleccion;
        private RadioButton rdbSi;
        private RadioButton rdbNo;
        private DataGridView tabla;
        private DataGridViewTextBoxColumn Clmejecutada;
        private DataGridViewTextBoxColumn ClmFecha;
        private DataGridViewTextBoxColumn ClmTipodevacuna;
        private DataGridViewTextBoxColumn ClmRangodeedades;
        private DataGridViewTextBoxColumn ClmZona_donde_se_aplico;
        private DataGridViewTextBoxColumn Clmparticipacion;
        public TextBox txtseleccion;
    }
}
