namespace Cargar_Remitos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCargar = new System.Windows.Forms.Button();
            this.txtCodProv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdComprobante = new System.Windows.Forms.TextBox();
            this.dtpEmision = new System.Windows.Forms.DateTimePicker();
            this.dtpCarga = new System.Windows.Forms.DateTimePicker();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.txtIdArticulo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdProveedor = new System.Windows.Forms.TextBox();
            this.txtTipoComprobante = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.btnVerificarArt = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(310, 214);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 0;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // txtCodProv
            // 
            this.txtCodProv.Location = new System.Drawing.Point(200, 81);
            this.txtCodProv.Name = "txtCodProv";
            this.txtCodProv.Size = new System.Drawing.Size(100, 20);
            this.txtCodProv.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Formulario de Carga";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Codigo de Proveedor";
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(12, 407);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(393, 150);
            this.dgv1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Id de Comprobante";
            // 
            // txtIdComprobante
            // 
            this.txtIdComprobante.Location = new System.Drawing.Point(188, 27);
            this.txtIdComprobante.Name = "txtIdComprobante";
            this.txtIdComprobante.Size = new System.Drawing.Size(100, 20);
            this.txtIdComprobante.TabIndex = 6;
            // 
            // dtpEmision
            // 
            this.dtpEmision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEmision.Location = new System.Drawing.Point(188, 64);
            this.dtpEmision.Name = "dtpEmision";
            this.dtpEmision.Size = new System.Drawing.Size(100, 20);
            this.dtpEmision.TabIndex = 7;
            this.dtpEmision.Value = new System.DateTime(2020, 11, 9, 0, 0, 0, 0);
            // 
            // dtpCarga
            // 
            this.dtpCarga.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCarga.Location = new System.Drawing.Point(188, 104);
            this.dtpCarga.Name = "dtpCarga";
            this.dtpCarga.Size = new System.Drawing.Size(100, 20);
            this.dtpCarga.TabIndex = 8;
            this.dtpCarga.Value = new System.DateTime(2020, 11, 9, 0, 0, 0, 0);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(188, 143);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fecha de Emision";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha de Carga";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cantidad de items";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(316, 79);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 23);
            this.btnVerificar.TabIndex = 13;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // txtIdArticulo
            // 
            this.txtIdArticulo.Location = new System.Drawing.Point(637, 82);
            this.txtIdArticulo.Name = "txtIdArticulo";
            this.txtIdArticulo.Size = new System.Drawing.Size(100, 20);
            this.txtIdArticulo.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(482, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "Codigo de Articulo";
            // 
            // txtIdProveedor
            // 
            this.txtIdProveedor.Location = new System.Drawing.Point(188, 176);
            this.txtIdProveedor.Name = "txtIdProveedor";
            this.txtIdProveedor.Size = new System.Drawing.Size(100, 20);
            this.txtIdProveedor.TabIndex = 32;
            // 
            // txtTipoComprobante
            // 
            this.txtTipoComprobante.Location = new System.Drawing.Point(188, 212);
            this.txtTipoComprobante.Name = "txtTipoComprobante";
            this.txtTipoComprobante.Size = new System.Drawing.Size(100, 20);
            this.txtTipoComprobante.TabIndex = 33;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(12, 178);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(141, 18);
            this.label16.TabIndex = 34;
            this.label16.Text = "Clave del Proveedor";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(12, 215);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(152, 18);
            this.label17.TabIndex = 35;
            this.label17.Text = "Tipo de Comprobante";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtIdComprobante);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.btnCargar);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTipoComprobante);
            this.panel1.Controls.Add(this.dtpEmision);
            this.panel1.Controls.Add(this.txtIdProveedor);
            this.panel1.Controls.Add(this.dtpCarga);
            this.panel1.Controls.Add(this.txtCantidad);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(12, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 250);
            this.panel1.TabIndex = 36;
            // 
            // dgv2
            // 
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(461, 125);
            this.dgv2.Name = "dgv2";
            this.dgv2.Size = new System.Drawing.Size(437, 150);
            this.dgv2.TabIndex = 37;
            // 
            // btnVerificarArt
            // 
            this.btnVerificarArt.Location = new System.Drawing.Point(785, 81);
            this.btnVerificarArt.Name = "btnVerificarArt";
            this.btnVerificarArt.Size = new System.Drawing.Size(100, 23);
            this.btnVerificarArt.TabIndex = 36;
            this.btnVerificarArt.Text = "Verificar";
            this.btnVerificarArt.UseVisualStyleBackColor = true;
            this.btnVerificarArt.Click += new System.EventHandler(this.btnVerificarArt_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(461, 298);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(434, 59);
            this.btnGenerar.TabIndex = 39;
            this.btnGenerar.Text = "Calcular Total";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 576);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.btnVerificarArt);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIdArticulo);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodProv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.TextBox txtCodProv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdComprobante;
        private System.Windows.Forms.DateTimePicker dtpCarga;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.TextBox txtIdArticulo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdProveedor;
        private System.Windows.Forms.TextBox txtTipoComprobante;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DateTimePicker dtpEmision;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.Button btnVerificarArt;
        private System.Windows.Forms.Button btnGenerar;
    }
}

