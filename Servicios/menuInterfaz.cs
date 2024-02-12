using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repaso7022024C.Servicios
{
    /// <summary>
    /// interfaz que se encraga en la gestion del menu
    /// author amd-12/02/24
    /// </summary>
    internal interface menuInterfaz
    {
        /// <summary>
        /// metodo que recoge  la opcion menu
        /// author amd-12/02/24
        /// </summary>
        /// <returns>la eleccioin del menu(tipo int)</returns>
        public int menu();
    }
}
