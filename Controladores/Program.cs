using repaso7022024C.Dtos;
using repaso7022024C.Servicios;

namespace repaso7022024C.Controladores
{
    /// <summary>
    /// clase pricipal
    /// author amd-12/02/24
    /// </summary>
    class Program
    {
        /// <summary>
        /// metodo principal
        /// author amd-12/02/24
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<actividadDto> lista = new List<actividadDto>();
            menuInterfaz mi = new menuImplementacion();
            actividadInterfaz ai = new actividadImplementacion();
            int eleccion;
            bool abrir = false;
            while (!abrir)
            {
                eleccion = mi.menu();
                switch (eleccion)
                {
                    case 0:Console.WriteLine("cerrado");
                        abrir = true;
                        break;
                    case 1: Console.WriteLine("1. añadir elemento");
                        break;
                    case 2: Console.WriteLine("2. mostrar cararcteristica de la actividad");
                        break;
                    case 3:
                        Console.WriteLine("3. eliminar elemento");
                        break;
                    default: Console.WriteLine("eleccion incorrecta");
                        break;
                }
            }
        }
    }
}