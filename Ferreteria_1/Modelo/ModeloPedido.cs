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
        public int Cod { get; set;}

        public void setCod (){
            this.Cod = ModeloPedido.cont++;
        }

        public static int cont;
        public string fecha { get; set; }

        public List<ModeloProductos> listaProductos { get; set; }

        public ModeloPedido getOne(int cod) {
            return this.listaPedidos.Find(x=> x.Cod==cod);
        }

        public List<ModeloPedido> getAll() {
            return this.listaPedidos;
        }
        public ModeloPedido nuevo() {
            ModeloPedido pedido= new ModeloPedido();
            pedido.setCod();
            return pedido;
        }

        public void actualizar(string fecha, ModeloProductos producto) { 
            
        }

    }
}
