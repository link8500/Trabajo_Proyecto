namespace Trabajo_Proyecto
{
    partial class Registro_de_administración_de_vacunas
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
            txtfecha = new TextBox();
            txt_tipo_de_vacuna = new TextBox();
            label2 = new Label();
            txt_rangode_edades = new TextBox();
            label3 = new Label();
            txtfechadeadministracion = new TextBox();
            label4 = new Label();
            txtfechadeprimeravacuna = new TextBox();
            label5 = new Label();
            label6 = new Label();
            btpaciente = new FontAwesome.Sharp.IconButton();
            tabla = new DataGridView();
            Clmfecha = new DataGridViewTextBoxColumn();
            Clmtipodevacuna = new DataGridViewTextBoxColumn();
            Clmrango_de_edades = new DataGridViewTextBoxColumn();
            ClmFecha_De_Administracion = new DataGridViewTextBoxColumn();
            Clmfecha_de_próxima_vacuda = new DataGridViewTextBoxColumn();
            label7 = new Label();
            btmodificar = new FontAwesome.Sharp.IconButton();
            bteliminar = new FontAwesome.Sharp.IconButton();
            btactualizar = new FontAwesome.Sharp.IconButton();
            btguardar = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)tabla).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(99, 46);
            label1.Name = "label1";
            label1.Size = new Size(52, 17);
            label1.TabIndex = 0;
            label1.Text = "Fecha:";
            // 
            // txtfecha
            // 
            txtfecha.BackColor = Color.WhiteSmoke;
            txtfecha.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtfecha.Location = new Point(155, 40);
            txtfecha.Name = "txtfecha";
            txtfecha.Size = new Size(100, 25);
            txtfecha.TabIndex = 1;
            // 
            // txt_tipo_de_vacuna
            // 
            txt_tipo_de_vacuna.BackColor = Color.WhiteSmoke;
            txt_tipo_de_vacuna.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_tipo_de_vacuna.Location = new Point(155, 84);
            txt_tipo_de_vacuna.Name = "txt_tipo_de_vacuna";
            txt_tipo_de_vacuna.Size = new Size(100, 25);
            txt_tipo_de_vacuna.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(40, 90);
            label2.Name = "label2";
            label2.Size = new Size(116, 17);
            label2.TabIndex = 2;
            label2.Text = "Tipo De Vacuna:";
            // 
            // txt_rangode_edades
            // 
            txt_rangode_edades.BackColor = Color.WhiteSmoke;
            txt_rangode_edades.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_rangode_edades.Location = new Point(155, 126);
            txt_rangode_edades.Name = "txt_rangode_edades";
            txt_rangode_edades.Size = new Size(100, 25);
            txt_rangode_edades.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(28, 132);
            label3.Name = "label3";
            label3.Size = new Size(130, 17);
            label3.TabIndex = 4;
            label3.Text = "Rango De Edades:";
            // 
            // txtfechadeadministracion
            // 
            txtfechadeadministracion.BackColor = Color.WhiteSmoke;
            txtfechadeadministracion.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtfechadeadministracion.Location = new Point(452, 36);
            txtfechadeadministracion.Name = "txtfechadeadministracion";
            txtfechadeadministracion.Size = new Size(124, 25);
            txtfechadeadministracion.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(266, 39);
            label4.Name = "label4";
            label4.Size = new Size(177, 17);
            label4.TabIndex = 6;
            label4.Text = "Fecha De Administración:";
            label4.Click += label4_Click;
            // 
            // txtfechadeprimeravacuna
            // 
            txtfechadeprimeravacuna.BackColor = Color.WhiteSmoke;
            txtfechadeprimeravacuna.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtfechadeprimeravacuna.Location = new Point(452, 84);
            txtfechadeprimeravacuna.Name = "txtfechadeprimeravacuna";
            txtfechadeprimeravacuna.Size = new Size(124, 25);
            txtfechadeprimeravacuna.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(260, 90);
            label5.Name = "label5";
            label5.Size = new Size(183, 17);
            label5.TabIndex = 8;
            label5.Text = "Fecha De Próxima Vacuna:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(268, 132);
            label6.Name = "label6";
            label6.Size = new Size(178, 17);
            label6.TabIndex = 10;
            label6.Text = "Informacion Del Paciente:";
            // 
            // btpaciente
            // 
            btpaciente.FlatAppearance.BorderSize = 0;
            btpaciente.FlatStyle = FlatStyle.Flat;
            btpaciente.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btpaciente.ForeColor = Color.WhiteSmoke;
            btpaciente.IconChar = FontAwesome.Sharp.IconChar.File;
            btpaciente.IconColor = Color.Bisque;
            btpaciente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btpaciente.IconSize = 30;
            btpaciente.ImageAlign = ContentAlignment.MiddleLeft;
            btpaciente.Location = new Point(452, 121);
            btpaciente.Name = "btpaciente";
            btpaciente.Size = new Size(103, 38);
            btpaciente.TabIndex = 11;
            btpaciente.Text = "View";
            btpaciente.TextAlign = ContentAlignment.MiddleLeft;
            btpaciente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btpaciente.UseVisualStyleBackColor = true;
            // 
            // tabla
            // 
            tabla.BackgroundColor = Color.WhiteSmoke;
            tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabla.Columns.AddRange(new DataGridViewColumn[] { Clmfecha, Clmtipodevacuna, Clmrango_de_edades, ClmFecha_De_Administracion, Clmfecha_de_próxima_vacuda });
            tabla.Location = new Point(40, 170);
            tabla.Name = "tabla";
            tabla.RowTemplate.Height = 25;
            tabla.Size = new Size(536, 178);
            tabla.TabIndex = 12;
            // 
            // Clmfecha
            // 
            Clmfecha.HeaderText = "Fecha";
            Clmfecha.Name = "Clmfecha";
            // 
            // Clmtipodevacuna
            // 
            Clmtipodevacuna.HeaderText = "Tipo De Vacuna";
            Clmtipodevacuna.Name = "Clmtipodevacuna";
            // 
            // Clmrango_de_edades
            // 
            Clmrango_de_edades.HeaderText = "Rango De Edades";
            Clmrango_de_edades.Name = "Clmrango_de_edades";
            // 
            // ClmFecha_De_Administracion
            // 
            ClmFecha_De_Administracion.HeaderText = "Fecha De Administración";
            ClmFecha_De_Administracion.Name = "ClmFecha_De_Administracion";
            // 
            // Clmfecha_de_próxima_vacuda
            // 
            Clmfecha_de_próxima_vacuda.HeaderText = "Fecha De Próxima Vacuna";
            Clmfecha_de_próxima_vacuda.Name = "Clmfecha_de_próxima_vacuda";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(199, 15);
            label7.TabIndex = 13;
            label7.Text = "Registro De Administracion De Vacunas";
            // 
            // btmodificar
            // 
            btmodificar.Dock = DockStyle.Right;
            btmodificar.FlatAppearance.BorderSize = 0;
            btmodificar.FlatStyle = FlatStyle.Flat;
            btmodificar.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btmodificar.ForeColor = Color.WhiteSmoke;
            btmodificar.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            btmodificar.IconColor = Color.WhiteSmoke;
            btmodificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btmodificar.IconSize = 20;
            btmodificar.ImageAlign = ContentAlignment.MiddleLeft;
            btmodificar.Location = new Point(126, 0);
            btmodificar.Name = "btmodificar";
            btmodificar.Size = new Size(129, 46);
            btmodificar.TabIndex = 14;
            btmodificar.Text = "Modificar";
            btmodificar.TextAlign = ContentAlignment.MiddleLeft;
            btmodificar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btmodificar.UseVisualStyleBackColor = true;
            // 
            // bteliminar
            // 
            bteliminar.Dock = DockStyle.Right;
            bteliminar.FlatAppearance.BorderSize = 0;
            bteliminar.FlatStyle = FlatStyle.Flat;
            bteliminar.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bteliminar.ForeColor = Color.WhiteSmoke;
            bteliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            bteliminar.IconColor = Color.WhiteSmoke;
            bteliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            bteliminar.IconSize = 20;
            bteliminar.ImageAlign = ContentAlignment.MiddleLeft;
            bteliminar.Location = new Point(255, 0);
            bteliminar.Name = "bteliminar";
            bteliminar.Size = new Size(129, 46);
            bteliminar.TabIndex = 15;
            bteliminar.Text = "Eliminar";
            bteliminar.TextAlign = ContentAlignment.MiddleLeft;
            bteliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            bteliminar.UseVisualStyleBackColor = true;
            // 
            // btactualizar
            // 
            btactualizar.Dock = DockStyle.Right;
            btactualizar.FlatAppearance.BorderSize = 0;
            btactualizar.FlatStyle = FlatStyle.Flat;
            btactualizar.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btactualizar.ForeColor = Color.WhiteSmoke;
            btactualizar.IconChar = FontAwesome.Sharp.IconChar.RotateForward;
            btactualizar.IconColor = Color.WhiteSmoke;
            btactualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btactualizar.IconSize = 20;
            btactualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btactualizar.Location = new Point(-3, 0);
            btactualizar.Name = "btactualizar";
            btactualizar.Size = new Size(129, 46);
            btactualizar.TabIndex = 17;
            btactualizar.Text = "Actualizar";
            btactualizar.TextAlign = ContentAlignment.MiddleLeft;
            btactualizar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btactualizar.UseVisualStyleBackColor = true;
            // 
            // btguardar
            // 
            btguardar.Dock = DockStyle.Right;
            btguardar.FlatAppearance.BorderSize = 0;
            btguardar.FlatStyle = FlatStyle.Flat;
            btguardar.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btguardar.ForeColor = Color.WhiteSmoke;
            btguardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            btguardar.IconColor = Color.WhiteSmoke;
            btguardar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btguardar.IconSize = 20;
            btguardar.ImageAlign = ContentAlignment.MiddleLeft;
            btguardar.Location = new Point(384, 0);
            btguardar.Name = "btguardar";
            btguardar.Size = new Size(129, 46);
            btguardar.TabIndex = 16;
            btguardar.Text = "Guardar";
            btguardar.TextAlign = ContentAlignment.MiddleLeft;
            btguardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btguardar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btactualizar);
            panel1.Controls.Add(btmodificar);
            panel1.Controls.Add(bteliminar);
            panel1.Controls.Add(btguardar);
            panel1.Location = new Point(88, 354);
            panel1.Name = "panel1";
            panel1.Size = new Size(513, 46);
            panel1.TabIndex = 18;
            // 
            // Registro_de_administración_de_vacunas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            Controls.Add(panel1);
            Controls.Add(label7);
            Controls.Add(tabla);
            Controls.Add(btpaciente);
            Controls.Add(label6);
            Controls.Add(txtfechadeprimeravacuna);
            Controls.Add(label5);
            Controls.Add(txtfechadeadministracion);
            Controls.Add(label4);
            Controls.Add(txt_rangode_edades);
            Controls.Add(label3);
            Controls.Add(txt_tipo_de_vacuna);
            Controls.Add(label2);
            Controls.Add(txtfecha);
            Controls.Add(label1);
            Name = "Registro_de_administración_de_vacunas";
            Size = new Size(705, 413);
            ((System.ComponentModel.ISupportInitialize)tabla).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtfecha;
        private TextBox txt_tipo_de_vacuna;
        private Label label2;
        private TextBox txt_rangode_edades;
        private Label label3;
        private TextBox txtfechadeadministracion;
        private Label label4;
        private TextBox txtfechadeprimeravacuna;
        private Label label5;
        private Label label6;
        private FontAwesome.Sharp.IconButton btpaciente;
        private DataGridView tabla;
        private DataGridViewTextBoxColumn Clmfecha;
        private DataGridViewTextBoxColumn Clmtipodevacuna;
        private DataGridViewTextBoxColumn Clmrango_de_edades;
        private DataGridViewTextBoxColumn ClmFecha_De_Administracion;
        private DataGridViewTextBoxColumn Clmfecha_de_próxima_vacuda;
        private Label label7;
        private FontAwesome.Sharp.IconButton btmodificar;
        private FontAwesome.Sharp.IconButton bteliminar;
        private FontAwesome.Sharp.IconButton btactualizar;
        private FontAwesome.Sharp.IconButton btguardar;
        private Panel panel1;
    }
}
