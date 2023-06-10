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
            limpiar();
            string cadsql = "SELECT * From registro_de_vacunas";
            string cad = "SELECT * From Pacientes";
            try
            {
                conn.con.Open();
                conn.cmd = new SqlCommand(cadsql, conn.con);
                conn.red = conn.cmd.ExecuteReader();
                DataTable vacunas = new DataTable();
                vacunas.Columns.Add("Tipo", typeof(string));
                vacunas.Columns.Add("Dosis", typeof(string));
                vacunas.Columns.Add("Fecha Programada", typeof(string));
                while (conn.red.Read())
                {
                    string tipo = conn.red[1].ToString();
                    string dosis = conn.red[5].ToString();
                    string fechapro = conn.red[4].ToString();
                    vacunas.Rows.Add(tipo, dosis, fechapro);
                }
                conn.con.Close();
                conn.con.Open();
                conn.cmd = new SqlCommand(cad, conn.con);
                conn.red = conn.cmd.ExecuteReader();
                DataTable pacientes = new DataTable();
                pacientes.Columns.Add("Nombre", typeof(string));
                pacientes.Columns.Add("Teléfono", typeof(string));
                DataTable pacientes2 = new DataTable();
                pacientes2.Columns.Add("Enfermedad", typeof(string));
                pacientes2.Columns.Add("Dirección", typeof(string));
                while (conn.red.Read())
                {
                    string nombre = conn.red[0].ToString();
                    string telefono = conn.red[3].ToString();
                    string enfermedad = conn.red[4].ToString();
                    string direccion = conn.red[2].ToString();
                    pacientes.Rows.Add(nombre, telefono);
                    pacientes2.Rows.Add(enfermedad, direccion);
                }
                conn.con.Close();

                // Limpiar DataGridView antes de agregar los datos
                tablavacunas.Rows.Clear();
                tablavacunas.Columns.Clear();

                // Agregar las columnas al DataGridView
                foreach (DataColumn column in pacientes.Columns)
                {
                    tablavacunas.Columns.Add(column.ColumnName, column.ColumnName);
                }
                foreach (DataColumn column in vacunas.Columns)
                {
                    tablavacunas.Columns.Add(column.ColumnName, column.ColumnName);
                }
                foreach (DataColumn column in pacientes2.Columns)
                {
                    tablavacunas.Columns.Add(column.ColumnName, column.ColumnName);
                }

                // Calcular el número máximo de filas a agregar
                int rowCount = Math.Max(pacientes.Rows.Count, Math.Max(vacunas.Rows.Count, pacientes2.Rows.Count));

                // Agregar las filas al DataGridView
                for (int i = 0; i < rowCount; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();

                    if (i < pacientes.Rows.Count)
                    {
                        for (int j = 0; j < pacientes.Columns.Count; j++)
                        {
                            row.Cells.Add(new DataGridViewTextBoxCell { Value = pacientes.Rows[i][j] });
                        }
                    }

                    if (i < vacunas.Rows.Count)
                    {
                        int offset = pacientes.Columns.Count;
                        for (int j = 0; j < vacunas.Columns.Count; j++)
                        {
                            row.Cells.Add(new DataGridViewTextBoxCell { Value = vacunas.Rows[i][j] });
                        }
                    }

                    if (i < pacientes2.Rows.Count)
                    {
                        int offset = pacientes.Columns.Count + vacunas.Columns.Count;
                        for (int j = 0; j < pacientes2.Columns.Count; j++)
                        {
                            row.Cells.Add(new DataGridViewTextBoxCell { Value = pacientes2.Rows[i][j] });
                        }
                    }

                    tablavacunas.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                conn.mensaje = ex.ToString();
                MessageBox.Show(conn.mensaje);


            }
            conn.con.Close();


        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void tablavacunas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bteliminar_Click(object sender, EventArgs e)
        {
            limpiar();
            String cadena = "DELETE FROM Pacientes";
            conn.eliminardatos(cadena);
            cadena = "DELETE FROM registro_de_vacunas";
            conn.eliminardatos(cadena);
        }
        public void limpiar() 
        {
            tablavacunas.Rows.Clear();
        }
    }
}
