using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ferreteria_1.Controladores;
using Ferreteria_1.Modelo;
namespace Ferreteria_1
{
    public partial class edicion : frame
    {
        private BindingSource bindingSource1 ;
        controladorProductos con;
        public edicion()
        {
            InitializeComponent();
            this.con =controladorProductos.createInstance();
        }

        private void edicion_Load(object sender, EventArgs e)
        {

            this.bindingSource1 = new BindingSource();
            this.con.traerProductosActivos().ForEach(a =>
            {
                this.bindingSource1.Add(a);
            });
            productView.DataSource = this.bindingSource1;


        }




 

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void crear_Click(object sender, EventArgs e)
        {
            try {
                    
                    ModeloProductos nuevo=this.con.crearProducto(nombre.Text,double.Parse(costo.Text));
                    this.bindingSource1.Add(nuevo);
            }
            catch (FormatException ex) {
                    MessageBox.Show("Revise el valor de los campos y registre de nuevo");
                }
           
        }
    }
}
