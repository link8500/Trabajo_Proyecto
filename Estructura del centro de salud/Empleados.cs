using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_del_centro_de_salud
{
    public class Empleados : Persona
    {
        string cargo ;
        string departamento;
        char Sex;

        public Empleados(string nombre, string cargo, string departamento, byte edad, char sex,int numero) : base(nombre,numero,edad)
        {
            
            this.cargo = "";
            this.departamento = "";
            Sex = sex;
        }

       
    }
}
