using FontAwesome.Sharp;
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
    public partial class Empleados : UserControl
    {
        int posicion;

        ConexionBDSQL.Class1 conn = new ConexionBDSQL.Class1();
        public Empleados()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconBtguardar_Click(object sender, EventArgs e)
        {
            char sex;

            if (rdbhombre.Checked == true)
            {
                sex = 'M';
            }
            else
            {
                sex = 'F';
            }
            tabla.Rows.Add(txtnombre.Text, txtcargo.Text, txtdepartamento.Text, txtedad.Text, txtnumero.Text, sex);
            MessageBox.Show(conn.Insertarempleados(txtnombre.Text, txtcargo.Text, txtdepartamento.Text, int.Parse(txtedad.Text), txtnumero.Text, sex));
        }

        private void iconBtmostrar_Click(object sender, EventArgs e)
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
                        
                    string cargo = conn.red[1].ToString();
                    string departamento = conn.red[2].ToString();
                    string edad = conn.red[3].ToString();
                    string numero = conn.red[4].ToString();
                    string sexo = conn.red[5].ToString();
                    tabla.Rows.Add(nomb, cargo, departamento, edad, numero, sexo);
                }

            }
            catch (Exception)
            {

                throw;
            }
            conn.con.Close();
        }

        private void iconBteliminar_Click(object sender, EventArgs e)
        {

        }

        private void btmodificar_Click(object sender, EventArgs e)
        {

        }

        private void iconBtActualizar_Click(object sender, EventArgs e)
        {
            txtnombre.Clear();
            txtcargo.Clear();
            txtdepartamento.Clear();
            txtnumero.Clear();
            txtedad.Clear();
            
        }

        private void tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
