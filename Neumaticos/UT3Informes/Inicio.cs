using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neumaticos.UT3Informes
{
    public partial class Inicio : Form
    {
        /// <summary>
        /// Ventana donde se van a encontrar los botones y elementos necesarios a partir de donde se lanzan los informes
        /// </summary>
        public Inicio()
        {
            InitializeComponent();
            helpProvider1.HelpNamespace = Application.StartupPath + "/Documentation.chm" ;
            //helpProvider1.SetHelpNavigator(aiuda, HelpNavigator.Topic);
            //helpProvider1.SetHelpKeyword(aiuda, "/html/b3eb1d54-f499-e104-0846-7faa4730c2bb.htm");

            //como no me funciona la query del ejemplo prefiero dejar el botón deshabilitado para evitar que casque el programa.
            button4.Enabled = false; 
        }
        /// <summary>
        /// Método para que al pulsar el botón 'Clientes' se abra el informe con los datos de los clientes.
        /// </summary>
        private void btClientes_Click(object sender, EventArgs e)
        {
            Generador gen = new Generador();
            gen.CargarInformeClientes();
        }

        /// <summary>
        /// Método para que se active el informe de las facturas de cada cliente, al pulsar el botón 'Facturas clientes'
        /// </summary>
        private void btFacturasClientes_Click(object sender, EventArgs e)
        {
            Generador gen = new Generador();
            //En caso de que no haya ningún nombre indicado, se muestran todas las facturas de todos los clientes
            if (tbNombre.Text.Equals(""))
            {
                gen.CargarFacturasClientes();
            }
            //En caso de que sí se haya indicado un nombre, se van a mostrar todas las facturas de dicho cliente en caso de que éste exista.
            else
            {
                string nombre = tbNombre.Text;
                gen.CargarFacturasUnCliente(nombre);
            }
            
        }
        /// <summary>
        /// Método para ver todas las facturas en un rango de fechas indicado por el cliente
        /// </summary>
        private void btFacturasFechas_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dtDesde.Value;
            DateTime fechaFin = dtHasta.Value;
            Generador gen = new Generador();
            gen.CargarFactFechas(fechaInicio, fechaFin);
        }
        /// <summary>
        /// Método para ver el gráfico con el total facturado anualmente
        /// </summary>
        private void btGrafico_Click(object sender, EventArgs e)
        {
            Generador gen = new Generador();
            gen.CargarGrafico();
        }
        /// <summary>
        /// Botón para el formulario del ejemplo dado en clase, deshabilitado porque sólo se usó para ver su funcionalidad
        /// </summary>
        private void button4_Click(object sender, EventArgs e)
        {
            Generador gen = new Generador();
            gen.CargarInformeFabricantes();
        }
        //Método para poder abrir el manual realizado en SandBox, mediante un botón en el menú
        private void ayúdameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ruta = Application.StartupPath;
            Help.ShowHelp(this, ruta + "/Documentation.chm", "/html/d2e8996e-d28f-4934-8c17-2f18bdd9bd20.htm");

        }
        //método para poder abrir el manual realizado en SandBox, mediante la tecla F1
        private void Inicio_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string ruta = Application.StartupPath;
            Help.ShowHelp(this, ruta + "/Documentation.chm", HelpNavigator.Topic, "/html/b3eb1d54-f499-e104-0846-7faa4730c2bb.htm");
        }
    }
}
