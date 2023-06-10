using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_del_centro_de_salud
{
    public class Pacientes : Persona
    {
        string dirreccion = "";
        string enfermedades_del_paciente = "";

        public Pacientes(string nombre, byte edad, string dirreccion, int numero , string enfermedades_del_paciente) : base (nombre,numero,edad)
        {
            this.dirreccion = dirreccion;
            this.enfermedades_del_paciente = enfermedades_del_paciente;
        }

        public string Dirreccion { get => dirreccion; set => dirreccion = value; }
        public string Enfermedades_del_paciente { get => enfermedades_del_paciente; set => enfermedades_del_paciente = value; }
    }
}
