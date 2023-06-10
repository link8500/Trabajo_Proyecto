using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionBDSQL
{
    public class Class1
    {
        public SqlConnection con = new SqlConnection("Data Source=DESKTOP-8IUMI9O\\SQLEXPRESS;Initial Catalog=Empresa;Encrypt = false;Integrated Security=True");
        public SqlCommand cmd ;
        public SqlDataReader red ;
        public SqlCommand cmd2;
        public SqlDataReader red2;
        public string mensaje;
        public Class1()
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
        public String Insertarempleados(string nomb, string cargo, string departamento, int edad, string numero, char sexo)
        {
            String cadena = "INSERT INTO Empleados(Nombre,Cargo,Departamento,Edad,Numero,Sexo)" +
                "values('" + nomb + "','" + cargo + "','" + departamento + "','" + edad + "','" + numero + "','" + sexo + "')";
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
        public String Insertarvacunas(String fecha, string dosis, string tipo, string rango, string fechaadm, string fechaprox)
        {
            String cadena = "INSERT INTO registro_de_vacunas(Fecha,Tipo_de_vacuna,Rango_de_Edades,Fecha_De_Administración,Fecha_De_Próxima_Vacuna,Dosis)" +
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
                "values('" + nomb + "','" + edad + "','" + dirrecion + "','" + tele + "','" + enfermedades + "')";
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
            String cadena = "INSERT INTO Informacion(Ejecucion,Fecha,Tipo,Rango,Zona,Empleados)" +
                "values('" + ejecucion + "','" + fecha + "','" + tipo + "','" + rango + "','" + zona + "','" + empleados + "')";
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
        public String InsertSeleccion( string Datos)
        {
            String cadena = "INSERT INTO Datos(Datos)" +
                "values('" + Datos + "')";
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
        public string eliminardatos(string datos) 
        {
            
                 
            try
            {
                con.Open();
                cmd = new SqlCommand(datos, con);
                cmd.ExecuteNonQuery();
                mensaje = "se elimino exitosamente";

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