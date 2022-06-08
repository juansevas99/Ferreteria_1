using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ferreteria_1.Modelo;
namespace Ferreteria_1.Controladores
{
    internal class ControladorPedidoProducto
    {
        private static ControladorPedidoProducto con;
        
        private ModeloPedidoProducto mod;
        private ModeloPedido mod2;

        private ControladorPedidoProducto()
        {
            this.mod = new ModeloPedidoProducto();
            this.mod2 = new ModeloPedido();
        }
        public static ControladorPedidoProducto createInstance()
        {

            if (ControladorPedidoProducto.con == null)
            {
                ControladorPedidoProducto.con = new ControladorPedidoProducto();

            }
            return ControladorPedidoProducto.con;
        }
        public void crearRelacion(ModeloProductos producto, int cantidad) {
           ModeloPedido pedido=this.mod2.getAll().ElementAt(ModeloPedido.cont - 1);

            this.mod.nuevo(pedido, producto, cantidad);
        }
        public List<ModeloPedidoProducto> traerRelaciones() {
            return this.mod.getProductos(ModeloPedido.cont);
            
        }
    }
}
