using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria_1.Modelo
{
    internal class ModeloPedidoProducto
    {
        List<ModeloPedidoProducto> relacion = new List<ModeloPedidoProducto>();

        public int producto { get; set; }
        public int pedido { get; set; }


        public List<ModeloPedidoProducto> getAll() {
            return this.relacion;
        }
        public ModeloPedidoProducto getOne(int producto, int pedido) {
            return this.relacion.Find(x => x.producto == producto && x.pedido == pedido);
        }
        public List<ModeloPedidoProducto> getProductos(int pedido) {
            return this.relacion.FindAll(x => x.pedido == pedido);
        }

        public void remove(int pedido) {

            int index=this.relacion.FindIndex(x => x.producto == producto && x.pedido == pedido);
            this.relacion.RemoveAt(index);
        }

       
    }
}
