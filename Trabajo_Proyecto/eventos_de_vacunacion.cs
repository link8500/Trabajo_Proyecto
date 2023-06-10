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
    public partial class eventos_de_vacunacion : UserControl
    {

        ConexionBDSQL.Class1 conn = new ConexionBDSQL.Class1();
        public eventos_de_vacunacion()
        {
            InitializeComponent();
            limpiar();
        }

        private void btSeleccion_Click(object sender, EventArgs e)
        {
            listado lista = new listado();
            lista.Show(this);
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            char ejecucion = ' ';
            if (rdbSi.Checked == true)
            {
                ejecucion = 'Y';
            }
            else
            {
                ejecucion = 'N';
            }
            tabla.Rows.Add(ejecucion, txtfecha.Text, txttipodevacuna.Text, txtRangoDeEdades.Text, txtseleccion.Text);
            MessageBox.Show(conn.Insertarcampaña(ejecucion, txtfecha.Text, txttipodevacuna.Text, txtRangoDeEdades.Text, txtZonaDondeSeAplico.Text, txtseleccion.Text));
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            tabla.Rows.Clear();
        }

        private void btMostrar_Click(object sender, EventArgs e)
        {
            limpiar();
            string cadsql = "SELECT * From Campaña";
            try
            {
                conn.con.Open();
                conn.cmd = new SqlCommand(cadsql, conn.con);
                conn.red = conn.cmd.ExecuteReader();
                while (conn.red.Read())
                {


                    string fecha = conn.red[0].ToString();
                    string dosis = conn.red[1].ToString();
                    string tipo = conn.red[2].ToString();
                    string rango = conn.red[3].ToString();
                    string fechaad = conn.red[4].ToString();
                    string fechapro = conn.red[5].ToString();
                    tabla.Rows.Add(fecha, dosis, tipo, rango, fechaad, fechapro);
                }

            }
            catch (Exception)
            {

                throw;
            }
            conn.con.Close();
        }

        private void BtModificar_Click(object sender, EventArgs e)
        {

        }
        public void limpiar() 
        {
            BtModificar.Enabled = false;
            btEliminar.Enabled = false;
            txtfecha.Clear();
            txtRangoDeEdades.Clear();
            txtseleccion.Clear();
            txttipodevacuna.Clear();
            txtZonaDondeSeAplico.Clear();
            txtseleccion.Clear();
            tabla.Rows.Clear();
        }
    }
}
