using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neumaticos
{
    /// <summary>
    /// En esta clase se van a generar todos los métodos que serán necesarios para realizar lanzas las consultas SQL, 
    /// recoger los datos que estas consultas devuelven y lanzar en los formularios necesarios.
    /// </summary>
    public class Generador
    {
        /// <summary>
        /// Método para recoger todos los fabricantes que hay
        /// Método de ejemplo
        /// </summary>
        public void CargarInformeFabricantes()
        {
            VisorInforme visor = new VisorInforme();
            visor.rpvVisorInforme.LocalReport.ReportEmbeddedResource = "Neumaticos.rptFabricantes.rdlc";

            string consultaFabricantes = "select p.fabricante, min(p.Precio) as preciodesde, max(p.precio) as preciohasta, count(*) as referencias from productos p group by p.Fabricante order by preciodesde";
            NeumaticosEntities ctx = new NeumaticosEntities();
            List<FabricanteWr> listaFabricantes = ctx.Database.SqlQuery<FabricanteWr>(consultaFabricantes, new object[0]).ToList();

            ReportDataSource funteDatosInforme = new ReportDataSource("DataSetFabricantes", listaFabricantes);
            visor.rpvVisorInforme.LocalReport.DataSources.Add(funteDatosInforme);
            
            ReportParameter parametro = new ReportParameter("ParametroInformacion", "Esto es un mensaje de prueba");
            visor.rpvVisorInforme.LocalReport.SetParameters(parametro);
            
            visor.rpvVisorInforme.SetDisplayMode(DisplayMode.PrintLayout);
            visor.rpvVisorInforme.RefreshReport();

            //visor.rpvVisorInforme.LocalReport.SubreportProcessing += LocalReport_SubreportProcessing;
            //si quisieramos generar documentos sin el visor deberemos trabajar con el metodo render
            //que devuelve el array de bits
            //visor.rpvVisorInforme.LocalReport.Render(multiples opciones de configuracion);

            visor.Show();

        }

        /*
        private void LocalReport_SubreportProcessing(object sender,
        SubreportProcessingEventArgs e)
        {
        //Podemos conocer el subreport a traves de la propiedad ReportPath,
        ojo que es el nombre del
        //report cuando se incrusta en el contenedor
        //e.ReportPath
        //debemos asignar los datasource de los subreports
        //e.DataSources.Add(new ReportDataSource("nombre", datos));
        //los parametros hay que asignarselos al report padre y al insertar
        el subreport en la pestaña parametros
        //hacer una asignacion manual entre los parametros del contenedor y
        los del hijo
        throw new NotImplementedException();
        }
        */


        /// <summary>
        /// Método para cargar todos los clientes de la empresa, ordenados por el nombre del cliente.
        /// </summary>
        public void CargarInformeClientes()
        {
            VisorInforme visor = new VisorInforme(); //se crea un nuevo informe
            visor.rpvVisorInforme.LocalReport.ReportEmbeddedResource = "Neumaticos.UT3Informes.Clientes.rptClientes.rdlc"; //se indica la ruta del informe

            string consultaClientes = "Select c.nombre, c.dnicif, c.direccion, c.telefono from clientes c order by c.nombre"; //query necesaria para la consulta
            NeumaticosEntities ctx = new NeumaticosEntities();
            List<UT3Informes.Clientes.ClienteWr> listaClientes = ctx.Database.SqlQuery<UT3Informes.Clientes.ClienteWr>(consultaClientes, new object[0]).ToList(); //se recogen los resultados de la query en una lista

            ReportDataSource funteDatosInforme = new ReportDataSource("DataSetClientes", listaClientes);
            visor.rpvVisorInforme.LocalReport.DataSources.Add(funteDatosInforme);

            visor.rpvVisorInforme.SetDisplayMode(DisplayMode.PrintLayout);
            visor.rpvVisorInforme.RefreshReport();

            visor.Show();
        }
        /// <summary>
        /// Método para recoger todas las facturas de los clientes
        /// </summary>
        public void CargarFacturasClientes()
        {
            VisorInforme visor = new VisorInforme();
            visor.rpvVisorInforme.LocalReport.ReportEmbeddedResource = "Neumaticos.UT3Informes.FacturaCliente.rptFacturaCliente.rdlc";

            string consultaFactCli = "select c.nombre, c.dnicif, f.numero as Facturas, f.importeTotal as Total from clientes as c inner join facturas as f on c.ClienteId=f.ClienteId";
            NeumaticosEntities ctx = new NeumaticosEntities();
            List<UT3Informes.FacturaCliente.FacturasClienteWr> listaFactCli = ctx.Database.SqlQuery<UT3Informes.FacturaCliente.FacturasClienteWr>(consultaFactCli, new object[0]).ToList();

            ReportDataSource funteFactCli = new ReportDataSource("DataSetFactCliente", listaFactCli);
            visor.rpvVisorInforme.LocalReport.DataSources.Add(funteFactCli);

            visor.rpvVisorInforme.SetDisplayMode(DisplayMode.PrintLayout);
            visor.rpvVisorInforme.RefreshReport();

            visor.Show();
        }
        /// <summary>
        /// Método para recoger todas las facturas de un solo cliente, en caso de que se indique un nombre
        /// </summary>
        /// <param name="nomBusca">El nombre del cliente que se quiere buscar</param>
        public void CargarFacturasUnCliente(String nomBusca)
        {
            VisorInforme visor = new VisorInforme();
            visor.rpvVisorInforme.LocalReport.ReportEmbeddedResource = "Neumaticos.UT3Informes.FacturaCliente.rptFacturaCliente.rdlc";

            string consultaFactCli = $"select c.nombre, c.dnicif, f.numero as Facturas, f.importeTotal as Total from clientes as c inner join facturas as f on c.ClienteId=f.ClienteId where c.nombre = '{nomBusca}'";
            NeumaticosEntities ctx = new NeumaticosEntities();
            List<UT3Informes.FacturaCliente.FacturasClienteWr> listaFactCli = ctx.Database.SqlQuery<UT3Informes.FacturaCliente.FacturasClienteWr>(consultaFactCli, new object[0]).ToList();

            ReportDataSource funteFactCli = new ReportDataSource("DataSetFactCliente", listaFactCli);
            visor.rpvVisorInforme.LocalReport.DataSources.Add(funteFactCli);

            visor.rpvVisorInforme.SetDisplayMode(DisplayMode.PrintLayout);
            visor.rpvVisorInforme.RefreshReport();

            visor.Show();
        }

        /// <summary>
        /// Método para recoger las facturas que se quieran revisar dado un rango de fecha
        /// </summary>
        /// <param name="fechaInicio">La fecha inicio es la fecha desde la que se quieren ver las facturas</param>
        /// <param name="fechaFin">La fecha fin es la fecha hasta la que se quieren ver las facturas</param>
        public void CargarFactFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            VisorInforme visor = new VisorInforme();
            visor.rpvVisorInforme.LocalReport.ReportEmbeddedResource = "Neumaticos.UT3Informes.FacturaFecha.rptFacturaFecha.rdlc";

            string consultaFactFechas = $"select c.nombre, f.numero, f.fecha, f.importeTotal as total, f.Pagada from clientes as c inner join facturas as f on c.ClienteId=f.ClienteId where f.fecha between '{fechaInicio.Date.ToString("yyyy-MM-dd")}' and '{fechaFin.Date.ToString("yyyy-MM-dd")}'";
            NeumaticosEntities ctx = new NeumaticosEntities();
            List<UT3Informes.FacturaFecha.FacturaFechaWr> listaFactFecha = ctx.Database.SqlQuery<UT3Informes.FacturaFecha.FacturaFechaWr>(consultaFactFechas, new object[0]).ToList();

            ReportDataSource funteFactFecha = new ReportDataSource("DataSetFacturaFecha", listaFactFecha);
            visor.rpvVisorInforme.LocalReport.DataSources.Add(funteFactFecha);

            visor.rpvVisorInforme.SetDisplayMode(DisplayMode.PrintLayout);
            visor.rpvVisorInforme.RefreshReport();

            visor.Show();
        }
        /// <summary>
        /// Método para cargar un gráfico para ver el importe total de las facturas de cada año que hay en la BBDD
        /// </summary>
        public void CargarGrafico()
        {
            VisorInforme visor = new VisorInforme();
            visor.rpvVisorInforme.LocalReport.ReportEmbeddedResource = "Neumaticos.UT3Informes.Grafico.rptGrafico.rdlc";

            string consultaGrafico = "select year(fecha) as anno, sum(importeTotal) as importe from facturas group by year(fecha)";
            NeumaticosEntities ctx = new NeumaticosEntities();
            List<UT3Informes.Grafico.GraficoWr> listaGrafico = ctx.Database.SqlQuery<UT3Informes.Grafico.GraficoWr>(consultaGrafico, new object[0]).ToList();

            ReportDataSource funteGrafico = new ReportDataSource("DataSetGrafico", listaGrafico);
            visor.rpvVisorInforme.LocalReport.DataSources.Add(funteGrafico);

            visor.rpvVisorInforme.SetDisplayMode(DisplayMode.PrintLayout);
            visor.rpvVisorInforme.RefreshReport();

            visor.Show();
        }
    }
}
