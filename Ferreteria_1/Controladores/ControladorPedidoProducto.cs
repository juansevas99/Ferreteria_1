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
        private controladorPedido con1;

        private ControladorPedidoProducto()
        {
            this.mod = new ModeloPedidoProducto();
            this.con1 =  controladorPedido.createInstance();
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
           ModeloPedido pedido=this.con1.traerUltimoPedido();

            this.mod.nuevo(pedido, producto, cantidad);
            
        }
        public List<ModeloPedidoProducto> traerRelaciones() {
            return this.mod.getProductos(ModeloPedido.cont);
            
        }
    }
}



