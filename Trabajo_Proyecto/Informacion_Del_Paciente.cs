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
    public partial class Informacion_Del_Paciente : UserControl
    {
        ConexionBDSQL.Class1 conn = new ConexionBDSQL.Class1();
        public Informacion_Del_Paciente()
        {
            InitializeComponent();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            tabla.Rows.Add(txtnombre.Text, txtedad.Text, txtDirrecion.Text, txttelefono.Text, txtenfermedades.Text);
            MessageBox.Show(conn.Insertpacientes(txtnombre.Text, int.Parse(txtedad.Text), txtDirrecion.Text, int.Parse(txttelefono.Text), txtenfermedades.Text));
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            txtDirrecion.Clear();
            txtedad.Clear();
            txtenfermedades.Clear();
            txtnombre.Clear();
            txttelefono.Clear();
        }

        private void bteliminar_Click(object sender, EventArgs e)
        {
            tabla.Rows.Clear();
            String cadena = "DELETE FROM Pacientes";
            conn.eliminardatos(cadena);
        }

        private void btmostrar_Click(object sender, EventArgs e)
        {
            string cadsql = "SELECT * From Pacientes";
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
                   
                    tabla.Rows.Add(fecha, dosis, tipo, rango, fechaad);
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
