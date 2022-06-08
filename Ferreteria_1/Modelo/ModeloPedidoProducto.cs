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

        public ModeloProductos producto { get; set; }
        public ModeloPedido pedido { get; set; }
        public int cantidad { get; set; }


        public List<ModeloPedidoProducto> getAll() {
            return this.relacion;
        }
        public ModeloPedidoProducto getOne(int producto, int pedido) {
            return this.relacion.Find(x => x.producto.Cod == producto && x.pedido.Cod == pedido);
        }
        public List<ModeloPedidoProducto> getProductos(int pedido) {
            return this.relacion.FindAll(x => x.pedido.Cod == pedido);
        }

        public void remove(int pedido) {

            int index=this.relacion.FindIndex(x => x.producto == producto && x.pedido.Cod == pedido);
            this.relacion.RemoveAt(index);
        }

        public ModeloPedidoProducto nuevo(ModeloPedido pedido, ModeloProductos producto, int cantidad) {
            ModeloPedidoProducto nuevaRealcion = new ModeloPedidoProducto();
            nuevaRealcion.producto = producto;
            nuevaRealcion.pedido = pedido;
            nuevaRealcion.cantidad = cantidad;
            this.relacion.Add(nuevaRealcion);
            return nuevaRealcion;
        }

        public override string ToString() {
            return this.producto.Nombre;
        }



    }
}
