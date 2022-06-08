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

    public partial class frame : Form
    {
    
        public frame()
        { 
            InitializeComponent();
        }

        private void frame_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.openForm("Ferreteria_1.edicion");

        }

        private void productos_Click(object sender, EventArgs e)
        {
            this.openForm("Ferreteria_1.productos");

        }

        private void Pedidos_Click(object sender, EventArgs e)
        {
            this.openForm("Ferreteria_1.pedidos");
        }
        protected void openForm(string nameOfCLass)
        {


            if (!("Ferreteria_1." + this.GetType().Name).Equals(nameOfCLass))
            {
                Type t = Type.GetType(nameOfCLass);
                frame className;
                if (t != null)
                {
                    className = (frame)Activator.CreateInstance(t);


                    this.Hide();
                    className.Show();





                }

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
