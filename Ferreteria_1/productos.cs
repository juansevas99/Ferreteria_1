using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ferreteria_1.Controladores;
using Ferreteria_1.Modelo;
namespace Ferreteria_1
{
    public partial class productos : frame
    {
        controladorProductos con;
        
        
        public productos()
        {
            InitializeComponent();
            this.con = controladorProductos.createInstance();
        }

        private void productos_Load(object sender, EventArgs e)
        {

            int itemsAncho = 1;
            int a = 0, b = 0;

            List<ModeloProductos> listaProductos = this.con.traerProductosActivos();


            listaProductos.ForEach(producto => {
                
                Label productLabel = new Label();
                CheckBox check = new CheckBox();
                Button agregar = new Button();
                TextBox cantidad = new TextBox();
                cantidad.Name = "cantidad";
                agregar.Size = new Size(20, 20);
                agregar.Text = "+";
                agregar.Name = "AgregarCarrito";
                agregar.Click += AgregarCarrito_Click;
                productLabel.Text = producto.Cod.ToString() + " : " + producto.Nombre.ToString();
                ProductView.Controls.Add(productLabel, a, b);
                ProductView.Controls.Add(agregar, a, b);
                ProductView.Controls.Add(check, a, b);
                a++;
                if (a == itemsAncho) { b++; a=0; }


            });
            
        }

        private  void AgregarCarrito_Click(Object sender, EventArgs e) { 
        }

        private void productosView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
            
        

        }

       

       
    }
}
