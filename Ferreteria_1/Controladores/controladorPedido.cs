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

            if (this.mod.getAll().ElementAt(ModeloPedido.cont).estado == 0)
            { this.mod.nuevo(1); }
            
            
           
        }


        public void actualizarPedido(DateTime fechaActual, DateTime fechaEfectiva, string desc) {
            int code = ModeloPedido.cont;
            this.mod.nuevo(fechaActual, fechaEfectiva, desc, code);
        }

      



    }
}
