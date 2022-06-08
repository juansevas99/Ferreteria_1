namespace Ferreteria_1
{
    partial class edicion
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
            this.productView = new System.Windows.Forms.DataGridView();
            this.crear = new System.Windows.Forms.Button();
            this.costo = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productView)).BeginInit();
            this.SuspendLayout();
            // 
            // productView
            // 
            this.productView.AllowUserToOrderColumns = true;
            this.productView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productView.Location = new System.Drawing.Point(336, 262);
            this.productView.Name = "productView";
            this.productView.RowTemplate.Height = 25;
            this.productView.Size = new System.Drawing.Size(342, 149);
            this.productView.TabIndex = 2;
            this.productView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // crear
            // 
            this.crear.Location = new System.Drawing.Point(603, 213);
            this.crear.Name = "crear";
            this.crear.Size = new System.Drawing.Size(75, 23);
            this.crear.TabIndex = 3;
            this.crear.Text = "crear";
            this.crear.UseVisualStyleBackColor = true;
            this.crear.Click += new System.EventHandler(this.crear_Click);
            // 
            // costo
            // 
            this.costo.Location = new System.Drawing.Point(356, 163);
            this.costo.Name = "costo";
            this.costo.Size = new System.Drawing.Size(322, 23);
            this.costo.TabIndex = 4;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(356, 107);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(322, 23);
            this.nombre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Costo";
            // 
            // edicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.costo);
            this.Controls.Add(this.crear);
            this.Controls.Add(this.productView);
            this.Name = "edicion";
            this.Text = "edicion";
            this.Load += new System.EventHandler(this.edicion_Load);
            this.Controls.SetChildIndex(this.productView, 0);
            this.Controls.SetChildIndex(this.crear, 0);
            this.Controls.SetChildIndex(this.costo, 0);
            this.Controls.SetChildIndex(this.nombre, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            ((System.ComponentModel.ISupportInitialize)(this.productView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView productView;
        private Button crear;
        private TextBox costo;
        private TextBox nombre;
        private Label label3;
        private Label label4;
    }
}