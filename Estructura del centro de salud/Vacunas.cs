using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_del_centro_de_salud
{
     public class Vacunas
    {
        String tipo_de_vacunas = "";
        String rango_de_edades = "";
        String fecha = "";

        public Vacunas(string tipo_de_vacunas, string rango_de_edades, string fecha)
        {
            this.tipo_de_vacunas = tipo_de_vacunas;
            this.rango_de_edades = rango_de_edades;
            this.fecha = fecha;
        }

        public string Tipo_de_vacunas { get => tipo_de_vacunas; set => tipo_de_vacunas = value; }
        public string Rango_de_edades { get => rango_de_edades; set => rango_de_edades = value; }
        public string Fecha { get => fecha; set => fecha = value; }
    }
}
