using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria_1.Modelo
{

    
    internal class ModeloProductos
    {
        public List<ModeloProductos> listaProductos = new List<ModeloProductos>();
        

        private string nombre;
        public string Nombre {
            get  { return nombre; }
            set { nombre = value; }
        }
        private double costo;
        public double Costo
        {
            get { return costo; }
            set { costo = value; }
        }
        private  int cod;
        public int Cod
        {
            get { return cod; }
            set { cod = value; }
        }

        private static int registros;
        
        public ModeloProductos(){
        }

        public  List<ModeloProductos> getAll() {
            return this.listaProductos;
        }
        public ModeloProductos getOne(int cod) {
            return this.listaProductos.Find(x => x.Cod == cod);
        }

        public ModeloProductos actualizarProductos() {
            return null;
        }

        public ModeloProductos nuevo(string nombre , double costo) {
            ModeloProductos modelo= new ModeloProductos();
            modelo.Nombre = nombre;
            modelo.Costo = costo;
            ModeloProductos.registros++;
            modelo.Cod= registros;

            this.listaProductos.Add(modelo);

            return modelo;
        }

        public override string ToString()
        {
            return this.Nombre;
        }
    }
}
