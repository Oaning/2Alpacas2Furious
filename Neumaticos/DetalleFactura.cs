//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Neumaticos
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetalleFactura
    {
        public int DetalleFacturaId { get; set; }
        public int FacturaId { get; set; }
        public string Concepto { get; set; }
        public int Cantidad { get; set; }
        public double PrecioUnidad { get; set; }
    
        public virtual Factura Factura { get; set; }
    }
}
