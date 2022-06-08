namespace Ferreteria_1
{
    partial class frame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pedidos = new System.Windows.Forms.Label();
            this.confPro = new System.Windows.Forms.Label();
            this.productos = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Pedidos);
            this.panel1.Controls.Add(this.confPro);
            this.panel1.Controls.Add(this.productos);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Pedidos
            // 
            this.Pedidos.AutoSize = true;
            this.Pedidos.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Pedidos.Location = new System.Drawing.Point(13, 188);
            this.Pedidos.Name = "Pedidos";
            this.Pedidos.Size = new System.Drawing.Size(56, 16);
            this.Pedidos.TabIndex = 2;
            this.Pedidos.Text = "Pedidos";
            this.Pedidos.Click += new System.EventHandler(this.Pedidos_Click);
            // 
            // confPro
            // 
            this.confPro.AutoSize = true;
            this.confPro.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confPro.Location = new System.Drawing.Point(13, 132);
            this.confPro.Name = "confPro";
            this.confPro.Size = new System.Drawing.Size(179, 16);
            this.confPro.TabIndex = 1;
            this.confPro.Text = "Configuracion de Productos";
            this.confPro.Click += new System.EventHandler(this.label2_Click);
            // 
            // productos
            // 
            this.productos.AutoSize = true;
            this.productos.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productos.Location = new System.Drawing.Point(13, 71);
            this.productos.Name = "productos";
            this.productos.Size = new System.Drawing.Size(71, 16);
            this.productos.TabIndex = 0;
            this.productos.Text = "Productos";
            this.productos.Click += new System.EventHandler(this.productos_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(204, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(594, 56);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(519, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Perfil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ferreteria";
            // 
            // frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frame";
            this.Text = "frame";
            this.Load += new System.EventHandler(this.frame_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label Pedidos;
        private Label confPro;
        private Label productos;
        private Label label1;
        private Label label2;
    }
}