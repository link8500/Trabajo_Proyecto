using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_Proyecto
{
    public partial class información_De_Vacunas : UserControl
    {
        ConexionBDSQL.Class1 conn = new ConexionBDSQL.Class1();
        public información_De_Vacunas()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void información_De_Vacunas_Load(object sender, EventArgs e)
        {

        }

        private void btmostrar_Click(object sender, EventArgs e)
        {
            string cadsql = "SELECT * From registro_de_vacunas";
            string cad = "SELECT * From Pacientes";
            try
            {
                conn.con.Open();
                conn.cmd = new SqlCommand(cadsql, conn.con);
                conn.red = conn.cmd.ExecuteReader();
                conn.cmd2 = new SqlCommand(cad, conn.con);
                conn.red2 = conn.cmd2.ExecuteReader();
                while (conn.red.Read())
                {
                    string nomb = conn.red2[0].ToString();

                    string edad = conn.red2[1].ToString();
                    string dirrecion = conn.red2[2].ToString();
                    string telefono = conn.red2[3].ToString();
                    string enfermedad = conn.red2[4].ToString();


                    string fecha = conn.red[0].ToString();
                    string dosis = conn.red[6].ToString();
                    string tipo = conn.red[1].ToString();
                    string rango = conn.red[2].ToString();
                    string fechaad = conn.red[3].ToString();
                    string fechapro = conn.red[4].ToString();
                    tablavacunas.Rows.Add(nomb, tipo, dosis, fechapro, edad, enfermedad);
                }

            }
            catch (Exception)
            {

                throw;
            }
            conn.con.Close();


        }
    }
}
