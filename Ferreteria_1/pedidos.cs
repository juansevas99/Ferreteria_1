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
        // variables de instancia
        // controladores 
        controladorPedido con; 
        ControladorPedidoProducto con3; 
        controladorProductos con2;


        // Binding -soiurce para Tabla de pedidos
        BindingSource binding2;


        public pedidos()
        {

            // cracion de instancia en caso de que aplique para cada controlador
            this.con=controladorPedido.createInstance();
            this.con2 = controladorProductos.createInstance();
            this.con3 = ControladorPedidoProducto.createInstance();
           // inicializacion de componente
            InitializeComponent();

            

        }

        private void pedidos_Load(object sender, EventArgs e)
        {
            // creacion de pedido cada que se carga. Este solo aplica para el primer pedido creado
            this.con.crearPedido();

            // vinculacion de datos de productos a comboBox
            BindingSource binding= new BindingSource();
            string name = "";
            this.con2.traerProductosActivos().ForEach(pr =>
            {
                name = pr.Nombre;
                binding.Add(pr);
            });
            producto.DataSource = binding;

            // Extraccion de datos a formularios del form
            Modelo.ModeloPedido actualPedido=this.con.traerUltimoPedido();
            descripcion.Text = actualPedido.descripcion;
            fechaEfectiva.Text = actualPedido.fechaEfectiva.ToString();

            // vinculacion de datos a tabla de pedidos
            this.binding2 = new BindingSource();
            this.con3.traerRelaciones().ForEach(rel=>
            {
                binding2.Add(rel);
            });

            
            pedidoTable.DataSource = binding2;
            
            

        }

        // Boton par actualizar pedido actual
        private void button3_Click(object sender, EventArgs e)
        {
            DateTime fechaEfectica = DateTime.Parse( fechaEfectiva.Text);
            string des = descripcion.Text;
            DateTime fechaActual= DateTime.Now;


            string[] mess=this.con.actualizarPedido(fechaActual,fechaEfectica, des);
            MessageBox.Show(mess[1]); // mess es un arreglo de 2 slots, en el primero guarda el codigo de salida y en el segundo el mensaje. 1 es para exito y 0  es para error
        }

        // Añade un producto al pedido
        private void anadirProducto_Click(object sender, EventArgs e)
        {
            Modelo.ModeloProductos selectedProduct=(Modelo.ModeloProductos)producto.SelectedValue;
            
            int can = int.Parse(cantidad.Text);
            this.con3.crearRelacion(selectedProduct, can);


            // Revisar alternativas para este codigo
            // Nose sabe porque no se trae las relaciones
            this.con3.traerRelaciones().ForEach(rel =>
            {
                binding2.Add(rel);
            });
            pedidoTable.DataSource=this.binding2;
        }

        // envia el pedido para ser efectivo 
        private void button2_Click(object sender, EventArgs e)
        {
            

            this.con.sunmitPedido();
            // es necesario cargar el form de nuevo ya que se necesita crear un nuevo peiddo de inmediato
            this.pedidos_Load(sender, e);

            MessageBox.Show("Pedido Enviado correctamente");
        }
    }
}
