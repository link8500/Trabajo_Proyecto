using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Conexion
{
    public class ConexionBD
    {
       
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-8IUMI9O\\SQLEXPRESS;Initial Catalog=SegurosSA;Integrated Security=True");
            SqlCommand cmd ;
            SqlDataReader red ;
            public string mensaje;
            public ConexionBD()
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
            public String Insertar(string nomb, string ced, int edad, float salario, char sexo)
            {
                String cadena = "INSERT INTO Tabla(Nombre,Cedula,Edad,Salario,Sexo)" +
                    "values('" + nomb + "','" + ced + "','" + edad + "','" + salario + "','" + sexo + "')";
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


