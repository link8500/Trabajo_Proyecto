namespace Trabajo_Proyecto
{
    partial class listado
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
            iconButton1 = new FontAwesome.Sharp.IconButton();
            tabla = new DataGridView();
            Clmempleados = new DataGridViewTextBoxColumn();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)tabla).BeginInit();
            SuspendLayout();
            // 
            // iconButton1
            // 
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton1.ForeColor = Color.WhiteSmoke;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            iconButton1.IconColor = Color.WhiteSmoke;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(0, 277);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(173, 54);
            iconButton1.TabIndex = 1;
            iconButton1.Text = "Seleccione";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // tabla
            // 
            tabla.BackgroundColor = Color.WhiteSmoke;
            tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabla.Columns.AddRange(new DataGridViewColumn[] { Clmempleados });
            tabla.Location = new Point(0, 0);
            tabla.Name = "tabla";
            tabla.RowTemplate.Height = 25;
            tabla.Size = new Size(350, 277);
            tabla.TabIndex = 2;
            tabla.CellContentClick += tabla_CellContentClick;
            // 
            // Clmempleados
            // 
            Clmempleados.HeaderText = "Empleados";
            Clmempleados.Name = "Clmempleados";
            Clmempleados.Width = 307;
            // 
            // iconButton2
            // 
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton2.ForeColor = Color.WhiteSmoke;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.User;
            iconButton2.IconColor = Color.WhiteSmoke;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(177, 277);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(173, 54);
            iconButton2.TabIndex = 3;
            iconButton2.Text = "Mostrar";
            iconButton2.TextAlign = ContentAlignment.MiddleLeft;
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
            // 
            // listado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(350, 331);
            Controls.Add(iconButton2);
            Controls.Add(tabla);
            Controls.Add(iconButton1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "listado";
            StartPosition = FormStartPosition.CenterParent;
            Text = "listado";
            ((System.ComponentModel.ISupportInitialize)tabla).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private FontAwesome.Sharp.IconButton iconButton1;
        private DataGridView tabla;
        private DataGridViewTextBoxColumn Clmempleados;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}