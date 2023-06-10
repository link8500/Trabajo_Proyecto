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
    public partial class Registro_de_administración_de_vacunas : UserControl
    {
        ConexionBDSQL.Class1 conn = new ConexionBDSQL.Class1();
        public Registro_de_administración_de_vacunas()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btguardar_Click(object sender, EventArgs e)
        {
            tabla.Rows.Add(txtfecha.Text, txtdosis.Text, txt_tipo_de_vacuna.Text, txt_rangode_edades.Text, txtfechadeadministracion.Text, txtfechadeprimeravacuna.Text);
            MessageBox.Show(conn.Insertarvacunas(txtfecha.Text, txtdosis.Text, txt_tipo_de_vacuna.Text, txt_rangode_edades.Text, txtfechadeadministracion.Text, txtfechadeprimeravacuna.Text));
        }

        private void btactualizar_Click(object sender, EventArgs e)
        {
            txtdosis.Clear();
            txtfecha.Clear();
            txtfechadeadministracion.Clear();
            txtfechadeprimeravacuna.Clear();
            txt_rangode_edades.Clear();
            txt_tipo_de_vacuna.Clear();
        }

        private void bteliminar_Click(object sender, EventArgs e)
        {
            tabla.Rows.Clear();
            txtdosis.Clear();
            txtfecha.Clear();
            txtfechadeadministracion.Clear();
            txtfechadeprimeravacuna.Clear();
            txt_rangode_edades.Clear();
            txt_tipo_de_vacuna.Clear();
            String cadena = "DELETE FROM registro_de_vacunas";
            conn.eliminardatos(cadena);
        }

        private void iconMostrar_Click(object sender, EventArgs e)
        {
            string cadsql = "SELECT * From registro_de_vacunas";
            try
            {
                conn.con.Open();
                conn.cmd = new SqlCommand(cadsql, conn.con);
                conn.red = conn.cmd.ExecuteReader();
                while (conn.red.Read())
                {
                    string fecha = conn.red[0].ToString();
                    string tipo = conn.red[1].ToString();
                    string rango = conn.red[2].ToString();
                    string fechaad = conn.red[3].ToString();
                    string fechapro = conn.red[4].ToString();
                    string dosis = conn.red[5].ToString();
                    tabla.Rows.Add(fecha, dosis, tipo, rango, fechaad, fechapro);
                }

            }
            catch (Exception)
            {

                throw;
            }
            conn.con.Close();
        }

        private void Registro_de_administración_de_vacunas_Load(object sender, EventArgs e)
        {

        }
    }
}
