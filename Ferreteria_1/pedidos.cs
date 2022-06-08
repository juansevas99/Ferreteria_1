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
namespace Ferreteria_1
{
    public partial class pedidos : frame
    {
        controladorPedido con;
        ControladorPedidoProducto con3;
        controladorProductos con2;
        
        public pedidos()
        {
            this.con=controladorPedido.createInstance();
            this.con2 = controladorProductos.createInstance();
            this.con3 = ControladorPedidoProducto.createInstance();
           
            InitializeComponent();

            

        }

        private void pedidos_Load(object sender, EventArgs e)
        {
            this.con.crearPedido();
            BindingSource binding= new BindingSource();
            string name = "";
            this.con2.traerProductosActivos().ForEach(pr =>
            {
                name = pr.Nombre;
                binding.Add(pr);
            });
            producto.DataSource = binding;
            Modelo.ModeloPedido actualPedido=this.con.traerUltimoPedido();
            descripcion.Text = actualPedido.descripcion;
            fechaEfectiva.Text = actualPedido.fechaEfectiva.ToString();

            BindingSource binding2 = new BindingSource();
            this.con3.traerRelaciones().ForEach(rel=>
            {
                binding2.Add(rel);
            });
            pedidoTable.DataSource = binding2;
            
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime fechaEfectica = DateTime.Parse( fechaEfectiva.Text);
            string des = descripcion.Text;
            DateTime fechaActual= DateTime.Now;


            string[] mess=this.con.actualizarPedido(fechaActual,fechaEfectica, des);
            MessageBox.Show(mess[1]);
        }

        private void anadirProducto_Click(object sender, EventArgs e)
        {
            Modelo.ModeloProductos selectedProduct=(Modelo.ModeloProductos)producto.SelectedValue;
            
            int can = int.Parse(cantidad.Text);
            this.con3.crearRelacion(selectedProduct, can);
        }
    }
}
