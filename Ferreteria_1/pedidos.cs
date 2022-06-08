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
        BindingSource binding;
        controladorProductos con2;
        public pedidos()
        {
            this.con=controladorPedido.createInstance();
            this.con2 = controladorProductos.createInstance();
           
            InitializeComponent();

            

        }

        private void pedidos_Load(object sender, EventArgs e)
        {
            this.con.crearPedido();
            this.binding = new BindingSource();
            string name = "";
            this.con2.traerProductosActivos().ForEach(pr =>
            {
                name = pr.Nombre;
                this.binding.Add(name);
            });
            producto.DataSource = this.binding;
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime fechaEfectica = DateTime.Parse( fechaEfectiva.Text);
            string des = descripcion.Text;
            DateTime fechaActual= DateTime.Now;


            this.con.actualizarPedido(fechaActual,fechaEfectica, des);
        }
    }
}
