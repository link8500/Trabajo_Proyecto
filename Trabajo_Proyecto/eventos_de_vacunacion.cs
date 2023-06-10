using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Trabajo_Proyecto
{
    public partial class eventos_de_vacunacion : UserControl
    {

        ConexionBDSQL.Class1 conn = new ConexionBDSQL.Class1();
        listado lista = new listado();
        public eventos_de_vacunacion()
        {
            InitializeComponent();
            limpiar();
        }

        private void btSeleccion_Click(object sender, EventArgs e)
        {

            lista.Show();



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
            string seleccion = comboSeleccion.SelectedItem.ToString();
            
            tabla.Rows.Add(ejecucion, txtfecha.Text, txttipodevacuna.Text, txtRangoDeEdades.Text, txtZonaDondeSeAplico.Text, seleccion);
            MessageBox.Show(conn.Insertarcampaña(ejecucion, txtfecha.Text, txttipodevacuna.Text, txtRangoDeEdades.Text, txtZonaDondeSeAplico.Text ,seleccion));
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            limpiar();


        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            tabla.Rows.Clear();
            String cadena = "DELETE FROM Informacion";
            conn.eliminardatos(cadena);
        }

        private void btMostrar_Click(object sender, EventArgs e)
        {
            limpiar();
            string cadsql = "SELECT * From Informacion";
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
           
            txtfecha.Clear();
            txtRangoDeEdades.Clear();
            txttipodevacuna.Clear();
            txtZonaDondeSeAplico.Clear();
            tabla.Rows.Clear();
        }

        private void txtseleccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void eventos_de_vacunacion_Load(object sender, EventArgs e)
        {
            string cadsql = "SELECT * From Empleados";
            try
            {
                conn.con.Open();
                conn.cmd = new SqlCommand(cadsql, conn.con);
                conn.red = conn.cmd.ExecuteReader();
                while (conn.red.Read())
                {
                    string nomb = conn.red[0].ToString();


                    comboSeleccion.Items.Add(nomb);
                }

            }
            catch (Exception)
            {

                throw;
            }
            conn.con.Close();
            comboSeleccion.SelectedIndex = 0;
        }

        private void comboSeleccion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
