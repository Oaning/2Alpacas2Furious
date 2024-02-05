using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neumaticos.UT3Informes.FacturaCliente
{
    /*
     * Se debe obtener un informe en el que aparezcan todas las facturas agrupadas por cliente.
            Deben aparecer los siguientes datos:
             Nombre y DNICIF del cliente
             Facturas de cada cliente
             Total del importe facturado a cada cliente
     */
    /// <summary>
    /// Clase con los datos necesarios para el informe que muestra las facturas de los clientes
    /// </summary>
    internal class FacturasClienteWr
    {
        public string Nombre { get; set; }
        public string DNICIF { get; set; }
        public int Facturas { get; set; }
        public double Total { get; set; }
    }
}
