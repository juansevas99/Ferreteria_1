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
namespace Ferreteria_1
{
    public partial class pedidos : frame
    {
        controladorPedido con;
        public pedidos()
        {
            this.con=controladorPedido.createInstance();
            InitializeComponent();
            

        }

        private void pedidos_Load(object sender, EventArgs e)
        {
            
        }
    }
}
