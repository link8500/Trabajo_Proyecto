using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Trabajo_Proyecto
{
    public partial class listado : Form
    {
        ConexionBDSQL.Class1 conn = new ConexionBDSQL.Class1();
        public listado()
        {
            InitializeComponent();
        }



        private void iconButton1_Click(object sender, EventArgs e)
        {
            eventos_de_vacunacion lista = new eventos_de_vacunacion();
            lista.txtseleccion.Text = tabla.CurrentRow.ToString();
            this.Close();
        }

        private void tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
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


                    tabla.Rows.Add(nomb);
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
