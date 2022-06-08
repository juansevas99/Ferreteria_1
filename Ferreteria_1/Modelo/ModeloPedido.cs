using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria_1.Modelo
{
    internal class ModeloPedido
    {
        public List<ModeloPedido> listaPedidos = new List<ModeloPedido>();
        public int Cod { get; set; }
        public int estado {get; set;}
        public string descripcion { get; set; }
        public void setCod (){
            this.Cod = ModeloPedido.cont++;
        }

        public static int cont=0;
        public DateTime fecha { get; set; }
        public DateTime fechaEfectiva { get; set; }

        public List<ModeloProductos> listaProductos { get; set; }

        public ModeloPedido getOne(int cod) {
            return this.listaPedidos.Find(x=> x.Cod==cod);
        }

        public List<ModeloPedido> getAll() {
            return this.listaPedidos;
        }
        public ModeloPedido nuevo(int estado) {
            ModeloPedido pedido= new ModeloPedido();
            pedido.setCod();
            pedido.estado = estado;
            return pedido;
        }

        public ModeloPedido nuevo(DateTime fechaActual, DateTime fechaEfectiva, string desc, int  code) {
            ModeloPedido pedido=this.listaPedidos.Find(x=> x.Cod==code);
            pedido.fechaEfectiva = fechaEfectiva;
            pedido.fecha = fechaActual;
            pedido.descripcion = desc;
            return pedido;
        }

    }
}
