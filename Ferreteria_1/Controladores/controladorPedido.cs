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

        public ModeloPedido traerUltimoPedido() {
           return this.mod.getAll().ElementAt(ModeloPedido.cont - 1);
        }

        public void crearPedido() {

            if ( ModeloPedido.cont==0 || this.mod.getAll().ElementAt(ModeloPedido.cont-1).estado == 0)
            { this.mod.nuevo(1); }
            
            
           
        }



        public string[] actualizarPedido(DateTime fechaActual, DateTime fechaEfectiva, string desc) {
            try
            {
                int code = ModeloPedido.cont;
                ModeloPedido pedido = this.mod.nuevo(fechaActual, fechaEfectiva, desc, code);
                return new string[] { "1", "Pedido actualizado :: " + pedido.Cod };
            }
            catch {
                return new string[]{ "0", "Algo paso intente de nuevo"};
            }
            
            
        }



        public void sunmitPedido() {
            this.traerUltimoPedido().estado = 0;
        }






    }
}
