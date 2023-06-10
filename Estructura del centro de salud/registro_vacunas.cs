using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_del_centro_de_salud
{
    public class registro_vacunas : Vacunas
    {
        String dosis;
        string fecha_de_administracion = "";
        string fecha_de_proxima_vacuna = "";

        public registro_vacunas(string fecha,string dosis,string tipo_de_vacunas,string rango_de_edades, string fecha_de_administracion, string fecha_de_proxima_vacuna) : base(tipo_de_vacunas,rango_de_edades,  fecha)
        {
            this.dosis = dosis;
            this.fecha_de_administracion = fecha_de_administracion;
            this.fecha_de_proxima_vacuna = fecha_de_proxima_vacuna;
        }

        public string Fecha { get => fecha; set => fecha = value; }
        public string Tipo_devacuna { get => tipo_devacuna; set => tipo_devacuna = value; }
        public string Rango_de_edades { get => rango_de_edades; set => rango_de_edades = value; }
        public string Fecha_de_administracion { get => fecha_de_administracion; set => fecha_de_administracion = value; }
        public string Fecha_de_proxima_vacuna { get => fecha_de_proxima_vacuna; set => fecha_de_proxima_vacuna = value; }
        public string Dosis { get => dosis; set => dosis = value; }
    }
}
