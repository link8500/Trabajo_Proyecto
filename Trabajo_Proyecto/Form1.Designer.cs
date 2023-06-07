namespace Trabajo_Proyecto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnborde_inferior = new Panel();
            pnbordeizquierdo = new Panel();
            pnborderecho = new Panel();
            maximizar = new FontAwesome.Sharp.IconButton();
            btminimizar = new FontAwesome.Sharp.IconButton();
            btcerrar = new FontAwesome.Sharp.IconButton();
            pnborde = new Panel();
            panelcontenedor = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            btcentro_de_salud = new FontAwesome.Sharp.IconButton();
            btcampaña_de_vacunacion = new FontAwesome.Sharp.IconButton();
            btpaciente = new FontAwesome.Sharp.IconButton();
            btregistro = new FontAwesome.Sharp.IconButton();
            btvacunas = new FontAwesome.Sharp.IconButton();
            btempleados = new FontAwesome.Sharp.IconButton();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            pnremplazo = new Panel();
            pnborde.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnremplazo.SuspendLayout();
            SuspendLayout();
            // 
            // pnborde_inferior
            // 
            pnborde_inferior.BackColor = Color.FromArgb(8, 8, 12);
            pnborde_inferior.Dock = DockStyle.Bottom;
            pnborde_inferior.Location = new Point(10, 525);
            pnborde_inferior.Name = "pnborde_inferior";
            pnborde_inferior.Size = new Size(858, 10);
            pnborde_inferior.TabIndex = 16;
            // 
            // pnbordeizquierdo
            // 
            pnbordeizquierdo.BackColor = Color.FromArgb(8, 8, 12);
            pnbordeizquierdo.Dock = DockStyle.Left;
            pnbordeizquierdo.Location = new Point(0, 0);
            pnbordeizquierdo.Name = "pnbordeizquierdo";
            pnbordeizquierdo.Size = new Size(10, 535);
            pnbordeizquierdo.TabIndex = 15;
            // 
            // pnborderecho
            // 
            pnborderecho.BackColor = Color.FromArgb(8, 8, 12);
            pnborderecho.Dock = DockStyle.Right;
            pnborderecho.Location = new Point(868, 0);
            pnborderecho.Name = "pnborderecho";
            pnborderecho.Size = new Size(10, 535);
            pnborderecho.TabIndex = 14;
            // 
            // maximizar
            // 
            maximizar.BackColor = Color.FromArgb(8, 8, 12);
            maximizar.Dock = DockStyle.Right;
            maximizar.FlatAppearance.BorderSize = 0;
            maximizar.FlatStyle = FlatStyle.Flat;
            maximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            maximizar.IconColor = Color.FromArgb(248, 181, 212);
            maximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            maximizar.IconSize = 25;
            maximizar.Location = new Point(738, 0);
            maximizar.Name = "maximizar";
            maximizar.Size = new Size(40, 23);
            maximizar.TabIndex = 9;
            maximizar.UseVisualStyleBackColor = false;
            maximizar.Click += maximizar_Click;
            // 
            // btminimizar
            // 
            btminimizar.BackColor = Color.FromArgb(8, 8, 12);
            btminimizar.Dock = DockStyle.Right;
            btminimizar.FlatAppearance.BorderSize = 0;
            btminimizar.FlatStyle = FlatStyle.Flat;
            btminimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btminimizar.IconColor = Color.FromArgb(248, 181, 212);
            btminimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btminimizar.IconSize = 25;
            btminimizar.Location = new Point(778, 0);
            btminimizar.Name = "btminimizar";
            btminimizar.Size = new Size(40, 23);
            btminimizar.TabIndex = 11;
            btminimizar.UseVisualStyleBackColor = false;
            btminimizar.Click += btminimizar_Click;
            // 
            // btcerrar
            // 
            btcerrar.BackColor = Color.FromArgb(8, 8, 12);
            btcerrar.Dock = DockStyle.Right;
            btcerrar.FlatAppearance.BorderSize = 0;
            btcerrar.FlatStyle = FlatStyle.Flat;
            btcerrar.IconChar = FontAwesome.Sharp.IconChar.TimesRectangle;
            btcerrar.IconColor = Color.FromArgb(248, 181, 212);
            btcerrar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btcerrar.IconSize = 25;
            btcerrar.Location = new Point(818, 0);
            btcerrar.Name = "btcerrar";
            btcerrar.Size = new Size(40, 23);
            btcerrar.TabIndex = 10;
            btcerrar.UseVisualStyleBackColor = false;
            btcerrar.Click += btcerrar_Click;
            // 
            // pnborde
            // 
            pnborde.BackColor = Color.FromArgb(8, 8, 12);
            pnborde.Controls.Add(maximizar);
            pnborde.Controls.Add(btminimizar);
            pnborde.Controls.Add(btcerrar);
            pnborde.Dock = DockStyle.Top;
            pnborde.Location = new Point(10, 0);
            pnborde.Name = "pnborde";
            pnborde.Size = new Size(858, 23);
            pnborde.TabIndex = 17;
            pnborde.MouseMove += pnborde_MouseMove;
            // 
            // panelcontenedor
            // 
            panelcontenedor.Dock = DockStyle.Fill;
            panelcontenedor.Location = new Point(153, 89);
            panelcontenedor.Name = "panelcontenedor";
            panelcontenedor.Size = new Size(705, 413);
            panelcontenedor.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(153, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(705, 89);
            panel2.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(btcentro_de_salud);
            panel1.Controls.Add(btcampaña_de_vacunacion);
            panel1.Controls.Add(btpaciente);
            panel1.Controls.Add(btregistro);
            panel1.Controls.Add(btvacunas);
            panel1.Controls.Add(btempleados);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(153, 502);
            panel1.TabIndex = 0;
            // 
            // btcentro_de_salud
            // 
            btcentro_de_salud.Dock = DockStyle.Top;
            btcentro_de_salud.FlatAppearance.BorderSize = 0;
            btcentro_de_salud.FlatStyle = FlatStyle.Flat;
            btcentro_de_salud.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btcentro_de_salud.ForeColor = Color.WhiteSmoke;
            btcentro_de_salud.IconChar = FontAwesome.Sharp.IconChar.House;
            btcentro_de_salud.IconColor = Color.WhiteSmoke;
            btcentro_de_salud.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btcentro_de_salud.IconSize = 35;
            btcentro_de_salud.ImageAlign = ContentAlignment.MiddleLeft;
            btcentro_de_salud.Location = new Point(0, 437);
            btcentro_de_salud.Name = "btcentro_de_salud";
            btcentro_de_salud.Size = new Size(153, 63);
            btcentro_de_salud.TabIndex = 6;
            btcentro_de_salud.Text = "Informacion Del Hospital";
            btcentro_de_salud.TextAlign = ContentAlignment.MiddleLeft;
            btcentro_de_salud.TextImageRelation = TextImageRelation.ImageBeforeText;
            btcentro_de_salud.UseVisualStyleBackColor = true;
            btcentro_de_salud.Click += btcentro_de_salud_Click;
            // 
            // btcampaña_de_vacunacion
            // 
            btcampaña_de_vacunacion.Dock = DockStyle.Top;
            btcampaña_de_vacunacion.FlatAppearance.BorderSize = 0;
            btcampaña_de_vacunacion.FlatStyle = FlatStyle.Flat;
            btcampaña_de_vacunacion.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btcampaña_de_vacunacion.ForeColor = Color.WhiteSmoke;
            btcampaña_de_vacunacion.IconChar = FontAwesome.Sharp.IconChar.Medkit;
            btcampaña_de_vacunacion.IconColor = Color.WhiteSmoke;
            btcampaña_de_vacunacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btcampaña_de_vacunacion.IconSize = 35;
            btcampaña_de_vacunacion.ImageAlign = ContentAlignment.MiddleLeft;
            btcampaña_de_vacunacion.Location = new Point(0, 374);
            btcampaña_de_vacunacion.Name = "btcampaña_de_vacunacion";
            btcampaña_de_vacunacion.Size = new Size(153, 63);
            btcampaña_de_vacunacion.TabIndex = 5;
            btcampaña_de_vacunacion.Text = "Campañas de Vacunacion";
            btcampaña_de_vacunacion.TextAlign = ContentAlignment.MiddleLeft;
            btcampaña_de_vacunacion.TextImageRelation = TextImageRelation.ImageBeforeText;
            btcampaña_de_vacunacion.UseVisualStyleBackColor = true;
            btcampaña_de_vacunacion.Click += btcampaña_de_vacunacion_Click;
            // 
            // btpaciente
            // 
            btpaciente.Dock = DockStyle.Top;
            btpaciente.FlatAppearance.BorderSize = 0;
            btpaciente.FlatStyle = FlatStyle.Flat;
            btpaciente.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btpaciente.ForeColor = Color.WhiteSmoke;
            btpaciente.IconChar = FontAwesome.Sharp.IconChar.Smile;
            btpaciente.IconColor = Color.WhiteSmoke;
            btpaciente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btpaciente.IconSize = 35;
            btpaciente.ImageAlign = ContentAlignment.MiddleLeft;
            btpaciente.Location = new Point(0, 311);
            btpaciente.Name = "btpaciente";
            btpaciente.Size = new Size(153, 63);
            btpaciente.TabIndex = 4;
            btpaciente.Text = "Informacion Del Paciente";
            btpaciente.TextAlign = ContentAlignment.MiddleLeft;
            btpaciente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btpaciente.UseVisualStyleBackColor = true;
            btpaciente.Click += btpaciente_Click;
            // 
            // btregistro
            // 
            btregistro.Dock = DockStyle.Top;
            btregistro.FlatAppearance.BorderSize = 0;
            btregistro.FlatStyle = FlatStyle.Flat;
            btregistro.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btregistro.ForeColor = Color.WhiteSmoke;
            btregistro.IconChar = FontAwesome.Sharp.IconChar.File;
            btregistro.IconColor = Color.WhiteSmoke;
            btregistro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btregistro.IconSize = 35;
            btregistro.ImageAlign = ContentAlignment.MiddleLeft;
            btregistro.Location = new Point(0, 248);
            btregistro.Name = "btregistro";
            btregistro.Size = new Size(153, 63);
            btregistro.TabIndex = 3;
            btregistro.Text = "Registro De Vacunas";
            btregistro.TextAlign = ContentAlignment.MiddleLeft;
            btregistro.TextImageRelation = TextImageRelation.ImageBeforeText;
            btregistro.UseVisualStyleBackColor = true;
            btregistro.Click += btregistro_Click;
            // 
            // btvacunas
            // 
            btvacunas.Dock = DockStyle.Top;
            btvacunas.FlatAppearance.BorderSize = 0;
            btvacunas.FlatStyle = FlatStyle.Flat;
            btvacunas.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btvacunas.ForeColor = Color.WhiteSmoke;
            btvacunas.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btvacunas.IconColor = Color.WhiteSmoke;
            btvacunas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btvacunas.IconSize = 35;
            btvacunas.ImageAlign = ContentAlignment.MiddleLeft;
            btvacunas.Location = new Point(0, 185);
            btvacunas.Name = "btvacunas";
            btvacunas.Size = new Size(153, 63);
            btvacunas.TabIndex = 2;
            btvacunas.Text = "Informacion De Vacunas";
            btvacunas.TextAlign = ContentAlignment.MiddleLeft;
            btvacunas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btvacunas.UseVisualStyleBackColor = true;
            btvacunas.Click += btvacunas_Click;
            // 
            // btempleados
            // 
            btempleados.Dock = DockStyle.Top;
            btempleados.FlatAppearance.BorderSize = 0;
            btempleados.FlatStyle = FlatStyle.Flat;
            btempleados.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btempleados.ForeColor = Color.WhiteSmoke;
            btempleados.IconChar = FontAwesome.Sharp.IconChar.User;
            btempleados.IconColor = Color.WhiteSmoke;
            btempleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btempleados.IconSize = 35;
            btempleados.ImageAlign = ContentAlignment.MiddleLeft;
            btempleados.Location = new Point(0, 122);
            btempleados.Name = "btempleados";
            btempleados.Size = new Size(153, 63);
            btempleados.TabIndex = 1;
            btempleados.Text = "Empleados";
            btempleados.TextAlign = ContentAlignment.MiddleLeft;
            btempleados.TextImageRelation = TextImageRelation.ImageBeforeText;
            btempleados.UseVisualStyleBackColor = true;
            btempleados.Click += btempleados_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(153, 122);
            panel4.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.logo_2_removebg_preview;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(153, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnremplazo
            // 
            pnremplazo.Controls.Add(panelcontenedor);
            pnremplazo.Controls.Add(panel2);
            pnremplazo.Controls.Add(panel1);
            pnremplazo.Dock = DockStyle.Fill;
            pnremplazo.Location = new Point(10, 23);
            pnremplazo.Name = "pnremplazo";
            pnremplazo.Size = new Size(858, 502);
            pnremplazo.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(878, 535);
            Controls.Add(pnremplazo);
            Controls.Add(pnborde);
            Controls.Add(pnborde_inferior);
            Controls.Add(pnborderecho);
            Controls.Add(pnbordeizquierdo);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            pnborde.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnremplazo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private FontAwesome.Sharp.IconButton btminimizar;
        private FontAwesome.Sharp.IconButton maximizar;
        private FontAwesome.Sharp.IconButton btcerrar;
        private Panel pnborde_inferior;
        private Panel pnbordeizquierdo;
        private Panel pnborderecho;
        private Panel pnborde;
        private Panel panelcontenedor;
        private Panel panel2;
        private Panel panel1;
        private Panel panel4;
        private FontAwesome.Sharp.IconButton btpaciente;
        private FontAwesome.Sharp.IconButton btregistro;
        private FontAwesome.Sharp.IconButton btvacunas;
        private FontAwesome.Sharp.IconButton btempleados;
        private FontAwesome.Sharp.IconButton btcentro_de_salud;
        private FontAwesome.Sharp.IconButton btcampaña_de_vacunacion;
        private PictureBox pictureBox1;
        private Panel pnremplazo;
    }
}