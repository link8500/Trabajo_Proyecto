using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionBD
{
    public class Conexion
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-8IUMI9O\\SQLEXPRESS;Initial Catalog=Empresa;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader red;
        public string mensaje;
        public Conexion()
        {
            try
            {

                con.Open();
                mensaje = "Conexion exitosa";

            }
            catch (Exception ex)
            {

                mensaje = ex.ToString();
            }
            con.Close();

        }
        public String Insertarempleados(string nomb, string cargo,string departamento, int edad, string numero, char sexo)
        {
            String cadena = "INSERT INTO Empleados(Nombre,Cargo,Departamento,Edad,Numero,Sexo)" +
                "values('" + nomb + "','" + cargo + "','" + departamento + "','" + edad + "','" + numero + "','"+ sexo +"')";
            try
            {
                con.Open();
                cmd = new SqlCommand(cadena, con);
                cmd.ExecuteNonQuery();
                mensaje = "los datos se agregaron exitoxamente";

                con.Close();
            }
            catch (Exception ex)
            {
                mensaje = ex.ToString();
            }
            con.Close();
            return mensaje;

        }
        public String Insertarvacunas(string fecha, string dosis, string tipo, string rango, string fechaadm, string fechaprox)
        {
            String cadena = "INSERT INTO registro de vacunas(Fecha,Tipo_de_vacuna,Rango_de_Edades,Fecha_De_Administración,Fecha_De_Próxima_Vacuna,Dosis)" +
                "values('" + fecha + "','" + tipo + "','" + rango + "','" + fechaadm + "','" + fechaprox + "','" + dosis + "')";
            try
            {
                con.Open();
                cmd = new SqlCommand(cadena, con);
                cmd.ExecuteNonQuery();
                mensaje = "los datos se agregaron exitoxamente";

                con.Close();
            }
            catch (Exception ex)
            {
                mensaje = ex.ToString();
            }
            con.Close();
            return mensaje;

        }
        public String Insertpacientes(string nomb, int edad, string dirrecion, int tele, string enfermedades)
        {
            String cadena = "INSERT INTO Pacientes(Nombre,Edad,Direccion,Telefono,Enfermedades)" +
                "values('" + nomb + "','" + edad + "','" + dirrecion + "','" + tele + "','" + enfermedades +  "')";
            try
            {
                con.Open();
                cmd = new SqlCommand(cadena, con);
                cmd.ExecuteNonQuery();
                mensaje = "los datos se agregaron exitoxamente";

                con.Close();
            }
            catch (Exception ex)
            {
                mensaje = ex.ToString();
            }
            con.Close();
            return mensaje;

        }
        public String Insertarcampaña(char ejecucion, string fecha, string tipo, string rango, string zona, string empleados)
        {
            String cadena = "INSERT INTO Campaña(Ejecucion,Fecha,Tipo,Rango,Zona,Empleados)" +
                "values('" + ejecucion + "','" + fecha + "','"+ tipo + "','" + rango + "','" + zona + "','" + empleados + "')";
            try
            {
                con.Open();
                cmd = new SqlCommand(cadena, con);
                cmd.ExecuteNonQuery();
                mensaje = "los datos se agregaron exitoxamente";

                con.Close();
            }
            catch (Exception ex)
            {
                mensaje = ex.ToString();
            }
            con.Close();
            return mensaje;

        }
    }
}
