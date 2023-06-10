using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_del_centro_de_salud
{
    public class campaña_de_vacunacion : Vacunas
    {
        String donde_se_aplico = "";

        public campaña_de_vacunacion(string fecha , string tipo_de_vacunas,string rango_de_edades ,string donde_se_aplico) : base(tipo_de_vacunas,  rango_de_edades,  fecha)
        {
            this.donde_se_aplico = donde_se_aplico;
        }

        public string Donde_se_aplico { get => donde_se_aplico; set => donde_se_aplico = value; }
    }
}
