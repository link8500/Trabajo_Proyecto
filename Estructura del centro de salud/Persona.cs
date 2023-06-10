using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_del_centro_de_salud
{
    internal class Persona
    {
        string nombre;
        int numero ;
        byte edad ;

        public Persona(string nombre, int numero, byte edad)
        {
            this.nombre = "";
            this.numero = 0;
            this.edad = 0;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public byte Edad { get => edad; set => edad = value; }
        public int Numero { get => numero; set => numero = value; }
    }
}
