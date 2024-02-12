using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repaso7022024C.Dtos
{
    /// <summary>
    /// clase que se encargada de guardar los datos de las actividades
    /// author amd-12/02/24
    /// </summary>
    internal class actividadDto
    {
        string nombreActividad = "aaaaaaaaa";
        DateTime fchaInicio ;
        DateTime fchaFin;
        DateTime duracion;

        public actividadDto(string nombreActividad, DateTime fchaInicio, DateTime fchaFin, DateTime duracion)
        {
            this.nombreActividad = nombreActividad;
            this.fchaInicio = fchaInicio;
            this.fchaFin = fchaFin;
            this.duracion = duracion;
        }
        public actividadDto() { }

        
        public string NombreActividad { get => nombreActividad; set => nombreActividad = value; }
        public DateTime FchaInicio { get => fchaInicio; set => fchaInicio = value; }
        public DateTime FchaFin { get => fchaFin; set => fchaFin = value; }
        public DateTime Duracion { get => duracion; set => duracion = value; }

        override
            public string ToString()
        {
            string actividad = "nombre de actividad=  " + this.nombreActividad +
                "  fecha inicio=  " + this.fchaInicio +
                "  duracion=  " + this.duracion;
            return actividad;
        }
        public string toString()
        {
            string eliminado = "nombre de actividad=  " + this.nombreActividad + "  duracion=  " + this.duracion;
            return eliminado;   
        }
    }
}
