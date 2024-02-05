using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neumaticos.UT3Informes.FacturaFecha
{
    /*
     * Crear un informe con las facturas entre un rango de fechas indicado por formulario. Los datos  que deben aparecer en el informe son:
         Número de factura
         Cliente
         Fecha
         Importe total
         Pagada o no pagada
     */
    /// <summary>
    /// Clase con los datos necesarios para mostrar el informe con aquellas facturas comprendidas entre un rango de fechas
    /// </summary>
    internal class FacturaFechaWr
    {
        public int Numero { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public double Total { get; set; }
        public Boolean Pagado { get; set; }
    }
}
