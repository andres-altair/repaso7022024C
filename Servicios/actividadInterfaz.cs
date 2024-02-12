using repaso7022024C.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repaso7022024C.Servicios
{
    /// <summary>
    /// interfaz que se encarga encarga de las actividades
    /// author amd-12/02/24
    /// </summary>
    internal interface actividadInterfaz
    {
        /// <summary>
        /// metodo que se encarga de dar de alta de una actividad
        /// author amd-12/02/24
        /// </summary>
        /// <param name="lista">actividadDto</param>
        public void darAltaActividad(List<actividadDto> lista);

        /// <summary>
        /// metodo que se encarga de eliminar una actividad
        /// author amd-12/02/24
        /// </summary>
        /// <param name="lista">actividadDto</param>
        public void eliminarActividad(List<actividadDto> lista);

        /// <summary>
        /// metodo que se encarga de mostrar la actividad
        /// author amd-12/02/24
        /// </summary>
        /// <param name="lista">actividadDto</param>
        public void mostrarActividad(List<actividadDto> lista);
    }
}
