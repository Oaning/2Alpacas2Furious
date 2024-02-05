using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neumaticos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            string volver = "cliente";
            InitializeComponent();
            CargarCombobos();
            if (dgv.SelectedRows.Count==1)
            {
                btFacturas.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            desTodo();
        }

        

        void CargarDatos(int opc)
        {
            using (NeumaticosEntities db = new NeumaticosEntities())
            {
                switch (opc)
                {
                    case 0:
                        dgv.DataSource = db.Clientes.ToList();
                        break;
                    case 1:
                        dgv.DataSource = db.DetalleFacturas.ToList();
                        break;
                    case 2:
                        dgv.DataSource = db.Facturas.ToList();
                        break;
                    case 3:
                        dgv.DataSource = db.Productos.ToList();
                        break;
                }
            }
        }
        
        public void CargarCombobos() //método para cargar combos
        {
            NeumaticosEntities db = new NeumaticosEntities();
            string consulta = "select table_name from Information_Schema.TABLES";// query para obtener el nombre de las tablas de base de datos
            List <string> tablas = db.Database.SqlQuery<String>(consulta).ToList();
            combobosTablas.DataSource = tablas;

        }

        private void combobosTablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            CargarDatos(cb.SelectedIndex);
        }

        private void desFact()
        {
            btFacturas.Enabled = false;
        }
        private void desDet()
        {
            btDetalles.Enabled = false;
        }

        private void desVolv()
        {
            btVolver.Enabled = false;
        }
        private void desTodo()
        {
            desFact();
            desDet();
            desVolv();
        }
    }
}
