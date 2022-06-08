using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ferreteria_1.Modelo;

namespace Ferreteria_1.Controladores
{
    internal  class controladorProductos
    {
        private static controladorProductos con;
        private ModeloProductos mod;
        private controladorProductos() {
            this.mod= new ModeloProductos();    
        }
        public static controladorProductos createInstance() {

            if (controladorProductos.con == null) { 
                controladorProductos.con = new controladorProductos();
                
            }
            return controladorProductos.con;
        }

        public ModeloProductos actualizarProducto() {
            return null;
        }


        public List<ModeloProductos> traerProductosActivos() {
            return this.mod.getAll();
        }

        public ModeloProductos crearProducto(string nombre, double costo) {
            ModeloProductos producto=this.mod.nuevo(nombre, costo);
            return producto;

        }
    }
}
