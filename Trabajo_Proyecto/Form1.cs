using FontAwesome.Sharp;
using Microsoft.Identity.Client;
using System.Drawing;

namespace Trabajo_Proyecto
{
    public partial class Form1 : Form
    {

        private IconButton currentbt;
        private Panel bordederecho;
        public Form1()
        {

            InitializeComponent();
            bordederecho = new Panel();
            bordederecho.Size = new Size(7, 50);
            panel1.Controls.Add(bordederecho);
            activarboton(btempleados, Colors.color1);
            Empleados emp = new Empleados();
            aplicarpestañas(emp);
            
        }
        
        private bool maximized = false;
        int posicion_Y = 0;
        int posicion_X = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void aplicar_interfaz(UserControl user)
        {
            user.Dock = DockStyle.Fill;

            user.BringToFront();
        }
        private void btcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void maximizar_Click(object sender, EventArgs e)
        {
            if (!maximized)
            {
                this.WindowState = FormWindowState.Maximized;
                maximized = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                maximized = false;
            }
        }
        private void pnborde_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posicion_X = e.Location.X;
                posicion_Y = e.Location.Y;
            }
            else
            {
                Left = Left + (e.X - posicion_X);
                Top = Top + (e.Y - posicion_Y);
            }
        }

        private void btminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void activarboton(object boton, System.Drawing.Color color)
        {
            desactivarboton();
            currentbt = (IconButton)boton;
            currentbt.BackColor = System.Drawing.Color.FromArgb(37, 38, 81);
            currentbt.ForeColor = color;
            currentbt.TextAlign = ContentAlignment.MiddleCenter;
            currentbt.IconColor = color;
            currentbt.TextImageRelation = TextImageRelation.TextBeforeImage;
            currentbt.ImageAlign = ContentAlignment.MiddleLeft;
            bordederecho.BackColor = color;
            bordederecho.Location = new Point(0, currentbt.Location.Y);
            bordederecho.Visible = true;
            bordederecho.BringToFront();


        }
        private void desactivarboton()
        {
            if (currentbt != null)
            {
                currentbt.BackColor = System.Drawing.Color.Navy;
                currentbt.ForeColor = SystemColors.ControlLightLight;
                currentbt.TextAlign = ContentAlignment.MiddleLeft;
                currentbt.IconColor = System.Drawing.Color.WhiteSmoke;
                currentbt.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentbt.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void btempleados_Click(object sender, EventArgs e)
        {
            activarboton(sender, Colors.color1);
            Empleados emp = new Empleados();
            aplicarpestañas(emp);
        }

        private void btvacunas_Click(object sender, EventArgs e)
        {
            activarboton(sender, Colors.color2);
            información_De_Vacunas vacunas = new información_De_Vacunas();
            aplicarpestañas(vacunas);
        }

        private void btregistro_Click(object sender, EventArgs e)
        {
            activarboton(sender, Colors.color3);
            Registro_de_administración_de_vacunas pestaña_de_registro = new Registro_de_administración_de_vacunas();
            aplicarpestañas (pestaña_de_registro);
        }

        private void btpaciente_Click(object sender, EventArgs e)
        {
            activarboton(sender, Colors.color4);
            Informacion_Del_Paciente paciente = new Informacion_Del_Paciente();
            aplicarpestañas(paciente);
        }

        private void btcampaña_de_vacunacion_Click(object sender, EventArgs e)
        {
            activarboton(sender, Colors.color5);
            eventos_de_vacunacion campaña = new eventos_de_vacunacion();
            aplicarpestañas(campaña);
        }

        private void btcentro_de_salud_Click(object sender, EventArgs e)
        {
            activarboton(sender, Colors.color6);
            Información_Del_Centro_De_Salud centro = new Información_Del_Centro_De_Salud();
            aplicarpestañas(centro);
        }

        private struct Colors
        {
            public static System.Drawing.Color color1 = System.Drawing.Color.FromArgb(249, 118, 176);
            public static System.Drawing.Color color2 = System.Drawing.Color.FromArgb(253, 138, 114);
            public static System.Drawing.Color color3 = System.Drawing.Color.FromArgb(95, 77, 221);
            public static System.Drawing.Color color4 = System.Drawing.Color.FromArgb(249, 88, 155);
            public static System.Drawing.Color color5 = System.Drawing.Color.FromArgb(24, 161, 251);
            public static System.Drawing.Color color6 = System.Drawing.Color.FromArgb(86, 85, 147);

        }
        public void aplicarpestañas(UserControl Pestaña)
        {
            Pestaña.Dock = DockStyle.Fill;
            panelcontenedor.Controls.Clear();
            panelcontenedor.Controls.Add(Pestaña);
            Pestaña.BringToFront();
        }
    }
}