using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repaso7022024C.Servicios
{
    /// <summary>
    /// implemetacion que implemeta a menuInterfaz
    /// author amd-12/02/24
    /// </summary>
    internal class menuImplementacion : menuInterfaz
    {
        public int menu()
        {
            Console.WriteLine("0. cerrar aplicacion");
            Console.WriteLine("1. dar de alta una actividad");
            Console.WriteLine("2. mostrar una actividad concreta en base al nombre de la actividad");
            Console.WriteLine("3. eliminar actividad en base al nombre de la actividad");
            int eleccion = Convert.ToInt32(Console.ReadLine());
            return eleccion;
        }
    }
}
