using repaso7022024C.Dtos;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repaso7022024C.Servicios
{
    /// <summary>
    /// implementacion que implementa a la actividadInterfaz
    /// author amd-12/02/24
    /// </summary>
    internal class actividadImplementacion : actividadInterfaz
    {
        public void darAltaActividad(List<actividadDto> lista)
        {
           actividadDto actividad = new actividadDto();
            Console.WriteLine("escribe el nombre de la actividad");
            string nombre = Console.ReadLine();
            Console.WriteLine("escribe la fecha de inicio");
            DateTime inicio = Console.ReadLine();
            Console.WriteLine("escribe la fecha de fin");
            DateTime fin = Console.ReadLine();
            DateTime duracion = fin-inicio;
            actividad(nombre, inicio, fin, duracion);
            lista.Add(actividad);
        }

        public void eliminarActividad(List<actividadDto> lista)
        {
            actividadDto actividad = new actividadDto();
            foreach (actividadDto item in lista)
            {
                Console.WriteLine(item.toString());
            }
            Console.WriteLine("que actividad quireres eliminar");
            string nombreEliminar = Console.ReadLine();
            if (actividad.NombreActividad.Equals(nombreEliminar))
            {
                lista.Remove(actividad);
            }
            else { Console.WriteLine("no existe el nombre de la actividad"); }
   
        }

        public void mostrarActividad(List<actividadDto> lista)
        {
            actividadDto actividad = new actividadDto();
            Console.WriteLine("que actividad quireres eliminar");
            string nombreAVer = Console.ReadLine();
            if (actividad.NombreActividad.Equals(nombreAVer))
            {
                foreach (actividadDto item in lista) { Console.WriteLine(item.ToString()); }
            }
            
            else { Console.WriteLine("no existe el nombre de la actividad"); }  
        }
    }
}
