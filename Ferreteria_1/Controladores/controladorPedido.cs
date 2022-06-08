using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ferreteria_1.Modelo;
namespace Ferreteria_1.Controladores
{
    internal class controladorPedido
    {
        private static controladorPedido con;
        private ModeloPedido mod;
        private ModeloPedidoProducto mod_1;
        
        private controladorPedido()
        {
            this.mod = new ModeloPedido();
            this.mod_1 = new ModeloPedidoProducto();
        }
        public static controladorPedido createInstance()
        {

            if (controladorPedido.con == null)
            {
                controladorPedido.con = new controladorPedido();

            }
            return controladorPedido.con;
        }

        public void crearPedido() {
            this.mod.nuevo();
        }


      



    }
}
