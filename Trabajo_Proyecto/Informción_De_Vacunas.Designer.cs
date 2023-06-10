namespace Trabajo_Proyecto
{
    partial class información_De_Vacunas
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
            tablavacunas = new DataGridView();
            bteliminar = new FontAwesome.Sharp.IconButton();
            btActualizar = new FontAwesome.Sharp.IconButton();
            btmostrar = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            Clm = new DataGridViewTextBoxColumn();
            Clmnumero = new DataGridViewTextBoxColumn();
            clmtipo = new DataGridViewTextBoxColumn();
            Clmdosis = new DataGridViewTextBoxColumn();
            clmfecha_de_vencimiento = new DataGridViewTextBoxColumn();
            ClmEdad = new DataGridViewTextBoxColumn();
            ClmDescripcion = new DataGridViewTextBoxColumn();
            Clmdirrecion = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)tablavacunas).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(218, 15);
            label1.TabIndex = 0;
            label1.Text = "Informacion de vacunas , admisnistradas";
            // 
            // tablavacunas
            // 
            tablavacunas.BackgroundColor = Color.WhiteSmoke;
            tablavacunas.BorderStyle = BorderStyle.None;
            tablavacunas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablavacunas.Columns.AddRange(new DataGridViewColumn[] { Clm, Clmnumero, clmtipo, Clmdosis, clmfecha_de_vencimiento, ClmEdad, ClmDescripcion, Clmdirrecion });
            tablavacunas.Location = new Point(29, 18);
            tablavacunas.Name = "tablavacunas";
            tablavacunas.RowTemplate.Height = 25;
            tablavacunas.Size = new Size(643, 328);
            tablavacunas.TabIndex = 17;
            // 
            // bteliminar
            // 
            bteliminar.Dock = DockStyle.Right;
            bteliminar.FlatAppearance.BorderSize = 0;
            bteliminar.FlatStyle = FlatStyle.Flat;
            bteliminar.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            bteliminar.ForeColor = Color.WhiteSmoke;
            bteliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            bteliminar.IconColor = Color.WhiteSmoke;
            bteliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bteliminar.IconSize = 35;
            bteliminar.ImageAlign = ContentAlignment.MiddleLeft;
            bteliminar.Location = new Point(0, 0);
            bteliminar.Name = "bteliminar";
            bteliminar.Size = new Size(103, 42);
            bteliminar.TabIndex = 18;
            bteliminar.Text = "Eliminar";
            bteliminar.TextAlign = ContentAlignment.MiddleLeft;
            bteliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            bteliminar.UseVisualStyleBackColor = true;
            // 
            // btActualizar
            // 
            btActualizar.Dock = DockStyle.Right;
            btActualizar.FlatAppearance.BorderSize = 0;
            btActualizar.FlatStyle = FlatStyle.Flat;
            btActualizar.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btActualizar.ForeColor = Color.WhiteSmoke;
            btActualizar.IconChar = FontAwesome.Sharp.IconChar.RotateForward;
            btActualizar.IconColor = Color.WhiteSmoke;
            btActualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btActualizar.IconSize = 35;
            btActualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btActualizar.Location = new Point(103, 0);
            btActualizar.Name = "btActualizar";
            btActualizar.Size = new Size(103, 42);
            btActualizar.TabIndex = 19;
            btActualizar.Text = "Actualizar";
            btActualizar.TextAlign = ContentAlignment.MiddleLeft;
            btActualizar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btActualizar.UseVisualStyleBackColor = true;
            // 
            // btmostrar
            // 
            btmostrar.Dock = DockStyle.Right;
            btmostrar.FlatAppearance.BorderSize = 0;
            btmostrar.FlatStyle = FlatStyle.Flat;
            btmostrar.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btmostrar.ForeColor = Color.WhiteSmoke;
            btmostrar.IconChar = FontAwesome.Sharp.IconChar.ShareFromSquare;
            btmostrar.IconColor = Color.WhiteSmoke;
            btmostrar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btmostrar.IconSize = 35;
            btmostrar.ImageAlign = ContentAlignment.MiddleLeft;
            btmostrar.Location = new Point(206, 0);
            btmostrar.Name = "btmostrar";
            btmostrar.Size = new Size(103, 42);
            btmostrar.TabIndex = 20;
            btmostrar.Text = "Mostrar";
            btmostrar.TextAlign = ContentAlignment.MiddleLeft;
            btmostrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btmostrar.UseVisualStyleBackColor = true;
            btmostrar.Click += btmostrar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(bteliminar);
            panel1.Controls.Add(btActualizar);
            panel1.Controls.Add(btmostrar);
            panel1.Location = new Point(192, 352);
            panel1.Name = "panel1";
            panel1.Size = new Size(309, 42);
            panel1.TabIndex = 22;
            panel1.Paint += panel1_Paint;
            // 
            // Clm
            // 
            Clm.HeaderText = "Nombre";
            Clm.Name = "Clm";
            // 
            // Clmnumero
            // 
            Clmnumero.HeaderText = "Numero";
            Clmnumero.Name = "Clmnumero";
            // 
            // clmtipo
            // 
            clmtipo.HeaderText = "Tipo";
            clmtipo.Name = "clmtipo";
            // 
            // Clmdosis
            // 
            Clmdosis.HeaderText = "Dosis";
            Clmdosis.Name = "Clmdosis";
            // 
            // clmfecha_de_vencimiento
            // 
            clmfecha_de_vencimiento.HeaderText = "Fecha De Vencimiento";
            clmfecha_de_vencimiento.Name = "clmfecha_de_vencimiento";
            // 
            // ClmEdad
            // 
            ClmEdad.HeaderText = "Edad";
            ClmEdad.Name = "ClmEdad";
            // 
            // ClmDescripcion
            // 
            ClmDescripcion.HeaderText = "Descripción";
            ClmDescripcion.Name = "ClmDescripcion";
            // 
            // Clmdirrecion
            // 
            Clmdirrecion.HeaderText = "Direccion";
            Clmdirrecion.Name = "Clmdirrecion";
            // 
            // información_De_Vacunas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            Controls.Add(panel1);
            Controls.Add(tablavacunas);
            Controls.Add(label1);
            Name = "información_De_Vacunas";
            Size = new Size(705, 413);
            Load += información_De_Vacunas_Load;
            ((System.ComponentModel.ISupportInitialize)tablavacunas).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView tablavacunas;
        private FontAwesome.Sharp.IconButton bteliminar;
        private FontAwesome.Sharp.IconButton btActualizar;
        private FontAwesome.Sharp.IconButton btmostrar;
        private Panel panel1;
        private DataGridViewTextBoxColumn Clm;
        private DataGridViewTextBoxColumn Clmnumero;
        private DataGridViewTextBoxColumn clmtipo;
        private DataGridViewTextBoxColumn Clmdosis;
        private DataGridViewTextBoxColumn clmfecha_de_vencimiento;
        private DataGridViewTextBoxColumn ClmEdad;
        private DataGridViewTextBoxColumn ClmDescripcion;
        private DataGridViewTextBoxColumn Clmdirrecion;
    }
}
