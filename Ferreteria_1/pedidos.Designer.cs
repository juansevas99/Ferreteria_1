namespace Ferreteria_1
{
    partial class pedidos
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
            this.pedidoTable = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.fechaEfectiva = new System.Windows.Forms.DateTimePicker();
            this.producto = new System.Windows.Forms.ComboBox();
            this.lbl = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoTable)).BeginInit();
            this.SuspendLayout();
            // 
            // pedidoTable
            // 
            this.pedidoTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pedidoTable.Location = new System.Drawing.Point(357, 288);
            this.pedidoTable.Name = "pedidoTable";
            this.pedidoTable.RowTemplate.Height = 25;
            this.pedidoTable.Size = new System.Drawing.Size(240, 150);
            this.pedidoTable.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Producto";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(509, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 50);
            this.button1.TabIndex = 7;
            this.button1.Text = "Añadir Producto";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(678, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 50);
            this.button2.TabIndex = 8;
            this.button2.Text = "Generar pedido";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // fechaEfectiva
            // 
            this.fechaEfectiva.Location = new System.Drawing.Point(357, 111);
            this.fechaEfectiva.Name = "fechaEfectiva";
            this.fechaEfectiva.Size = new System.Drawing.Size(200, 23);
            this.fechaEfectiva.TabIndex = 9;
            // 
            // producto
            // 
            this.producto.FormattingEnabled = true;
            this.producto.Location = new System.Drawing.Point(357, 247);
            this.producto.Name = "producto";
            this.producto.Size = new System.Drawing.Size(121, 23);
            this.producto.TabIndex = 10;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(599, 83);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(69, 15);
            this.lbl.TabIndex = 11;
            this.lbl.Text = "Descripcion";
            // 
            // descripcion
            // 
            this.descripcion.Location = new System.Drawing.Point(599, 111);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(100, 23);
            this.descripcion.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(713, 113);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 44);
            this.button3.TabIndex = 13;
            this.button3.Text = "actualizar Pedido";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.producto);
            this.Controls.Add(this.fechaEfectiva);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pedidoTable);
            this.Name = "pedidos";
            this.Text = "pedidos";
            this.Load += new System.EventHandler(this.pedidos_Load);
            this.Controls.SetChildIndex(this.pedidoTable, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.fechaEfectiva, 0);
            this.Controls.SetChildIndex(this.producto, 0);
            this.Controls.SetChildIndex(this.lbl, 0);
            this.Controls.SetChildIndex(this.descripcion, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pedidoTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView pedidoTable;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private DateTimePicker fechaEfectiva;
        private ComboBox producto;
        private Label lbl;
        private TextBox descripcion;
        private Button button3;
    }
}