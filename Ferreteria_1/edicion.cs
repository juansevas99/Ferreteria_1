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
        // binding source para tabla de productos
        private BindingSource bindingSource1 ;
        // controlador Productos
        controladorProductos con;
        public edicion()
        {
            InitializeComponent();
            // crea la instancia si aplica
            this.con =controladorProductos.createInstance();
        }

        private void edicion_Load(object sender, EventArgs e)
        {
            // crea la vinculacion de la lista de productos con la tabla de productos
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
        // Añade un producto
        private void crear_Click(object sender, EventArgs e)
        {
            // se captura cualquier errro de tipo FormatException en caso de que el string no sea aceptado
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
