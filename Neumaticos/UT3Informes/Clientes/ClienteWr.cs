using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neumaticos.UT3Informes.Clientes
{
    /*
     * Crea un informe para los clientes; deberá contener los siguientes datos:
         Nombre
         DNICIF
         Dirección
         Teléfono
     */
    /// <summary>
    /// Clase con los datos necesarios para realizar un informe con todos los clientes de la empresa.
    /// </summary>
    internal class ClienteWr
    {
        public string Nombre { get; set; }
        public string DNICIF { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
    }
}
