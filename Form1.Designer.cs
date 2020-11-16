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
            this.txtCodProv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpEmision = new System.Windows.Forms.DateTimePicker();
            this.dtpCarga = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.txtIdArticulo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTipoComprobante = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnVerificarArt = new System.Windows.Forms.Button();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.txtNumeroComprobante = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescripcionArt = new System.Windows.Forms.TextBox();
            this.txtStockArt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCantidadTotal = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTotalTotales = new System.Windows.Forms.TextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.CmbDescuento = new System.Windows.Forms.ComboBox();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPrecioUnitarioArt = new System.Windows.Forms.TextBox();
            this.txtCantidadArt = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.CodigoArt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionArt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc_Art = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prec_Arti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Totales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTipoComprobante = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodProv
            // 
            this.txtCodProv.Location = new System.Drawing.Point(19, 36);
            this.txtCodProv.Name = "txtCodProv";
            this.txtCodProv.Size = new System.Drawing.Size(100, 20);
            this.txtCodProv.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(387, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Formulario de Carga";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Codigo de Proveedor";
            // 
            // dtpEmision
            // 
            this.dtpEmision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEmision.Location = new System.Drawing.Point(424, 36);
            this.dtpEmision.MaxDate = new System.DateTime(2020, 11, 16, 0, 0, 0, 0);
            this.dtpEmision.Name = "dtpEmision";
            this.dtpEmision.Size = new System.Drawing.Size(100, 20);
            this.dtpEmision.TabIndex = 7;
            this.dtpEmision.Value = new System.DateTime(2020, 11, 9, 0, 0, 0, 0);
            // 
            // dtpCarga
            // 
            this.dtpCarga.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCarga.Location = new System.Drawing.Point(558, 36);
            this.dtpCarga.Name = "dtpCarga";
            this.dtpCarga.Size = new System.Drawing.Size(100, 20);
            this.dtpCarga.TabIndex = 8;
            this.dtpCarga.Value = new System.DateTime(2020, 11, 9, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(409, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fecha de Emision";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(555, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha de Carga";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(165, 36);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 23);
            this.btnVerificar.TabIndex = 13;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // txtIdArticulo
            // 
            this.txtIdArticulo.Location = new System.Drawing.Point(22, 61);
            this.txtIdArticulo.Name = "txtIdArticulo";
            this.txtIdArticulo.Size = new System.Drawing.Size(100, 20);
            this.txtIdArticulo.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "Codigo de Articulo";
            // 
            // txtTipoComprobante
            // 
            this.txtTipoComprobante.Location = new System.Drawing.Point(713, 36);
            this.txtTipoComprobante.Name = "txtTipoComprobante";
            this.txtTipoComprobante.Size = new System.Drawing.Size(100, 20);
            this.txtTipoComprobante.TabIndex = 33;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(693, 12);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(152, 18);
            this.label17.TabIndex = 35;
            this.label17.Text = "Tipo de Comprobante";
            // 
            // btnVerificarArt
            // 
            this.btnVerificarArt.Location = new System.Drawing.Point(168, 58);
            this.btnVerificarArt.Name = "btnVerificarArt";
            this.btnVerificarArt.Size = new System.Drawing.Size(75, 23);
            this.btnVerificarArt.TabIndex = 36;
            this.btnVerificarArt.Text = "Verificar";
            this.btnVerificarArt.UseVisualStyleBackColor = true;
            this.btnVerificarArt.Click += new System.EventHandler(this.btnVerificarArt_Click);
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Location = new System.Drawing.Point(273, 36);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(124, 20);
            this.txtNombreProveedor.TabIndex = 40;
            // 
            // txtNumeroComprobante
            // 
            this.txtNumeroComprobante.Location = new System.Drawing.Point(907, 36);
            this.txtNumeroComprobante.Name = "txtNumeroComprobante";
            this.txtNumeroComprobante.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroComprobante.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(865, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 18);
            this.label8.TabIndex = 42;
            this.label8.Text = "Numero de Comprobante";
            // 
            // txtDescripcionArt
            // 
            this.txtDescripcionArt.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionArt.Location = new System.Drawing.Point(276, 58);
            this.txtDescripcionArt.Multiline = true;
            this.txtDescripcionArt.Name = "txtDescripcionArt";
            this.txtDescripcionArt.Size = new System.Drawing.Size(428, 61);
            this.txtDescripcionArt.TabIndex = 43;
            // 
            // txtStockArt
            // 
            this.txtStockArt.Location = new System.Drawing.Point(721, 60);
            this.txtStockArt.Name = "txtStockArt";
            this.txtStockArt.Size = new System.Drawing.Size(88, 20);
            this.txtStockArt.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(440, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 18);
            this.label9.TabIndex = 45;
            this.label9.Text = "Descripcion";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(743, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 18);
            this.label10.TabIndex = 46;
            this.label10.Text = "Stock";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblCantidadTotal);
            this.panel2.Controls.Add(this.btnFinalizar);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.txtTotalTotales);
            this.panel2.Controls.Add(this.btnBorrar);
            this.panel2.Controls.Add(this.lblNombre);
            this.panel2.Controls.Add(this.CmbDescuento);
            this.panel2.Controls.Add(this.dgv1);
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtIdArticulo);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtPrecioUnitarioArt);
            this.panel2.Controls.Add(this.btnVerificarArt);
            this.panel2.Controls.Add(this.txtCantidadArt);
            this.panel2.Controls.Add(this.txtStockArt);
            this.panel2.Controls.Add(this.txtDescripcionArt);
            this.panel2.Location = new System.Drawing.Point(12, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(863, 457);
            this.panel2.TabIndex = 37;
            // 
            // lblCantidadTotal
            // 
            this.lblCantidadTotal.AutoSize = true;
            this.lblCantidadTotal.Location = new System.Drawing.Point(25, 366);
            this.lblCantidadTotal.Name = "lblCantidadTotal";
            this.lblCantidadTotal.Size = new System.Drawing.Size(0, 13);
            this.lblCantidadTotal.TabIndex = 59;
            this.lblCantidadTotal.Visible = false;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(22, 402);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(262, 42);
            this.btnFinalizar.TabIndex = 48;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click_1);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(474, 366);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 18);
            this.label15.TabIndex = 58;
            this.label15.Text = "Total";
            // 
            // txtTotalTotales
            // 
            this.txtTotalTotales.Location = new System.Drawing.Point(526, 364);
            this.txtTotalTotales.Name = "txtTotalTotales";
            this.txtTotalTotales.Size = new System.Drawing.Size(100, 20);
            this.txtTotalTotales.TabIndex = 57;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(561, 162);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 56;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(329, 81);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 13);
            this.lblNombre.TabIndex = 55;
            this.lblNombre.Visible = false;
            // 
            // CmbDescuento
            // 
            this.CmbDescuento.FormattingEnabled = true;
            this.CmbDescuento.Items.AddRange(new object[] {
            "10"});
            this.CmbDescuento.Location = new System.Drawing.Point(332, 164);
            this.CmbDescuento.Name = "CmbDescuento";
            this.CmbDescuento.Size = new System.Drawing.Size(83, 21);
            this.CmbDescuento.TabIndex = 54;
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoArt,
            this.CantidadArticulo,
            this.DescripcionArt,
            this.Desc_Art,
            this.Prec_Arti,
            this.Precio_Totales});
            this.dgv1.Location = new System.Drawing.Point(22, 199);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersVisible = false;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(604, 150);
            this.dgv1.TabIndex = 53;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(469, 161);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 47;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(333, 143);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 18);
            this.label14.TabIndex = 52;
            this.label14.Text = "Descuento";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(181, 143);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 18);
            this.label13.TabIndex = 51;
            this.label13.Text = "Precio C/U";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(7, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 18);
            this.label12.TabIndex = 47;
            this.label12.Text = "Cantidad Ingresada";
            // 
            // txtPrecioUnitarioArt
            // 
            this.txtPrecioUnitarioArt.Location = new System.Drawing.Point(172, 164);
            this.txtPrecioUnitarioArt.Name = "txtPrecioUnitarioArt";
            this.txtPrecioUnitarioArt.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioUnitarioArt.TabIndex = 48;
            // 
            // txtCantidadArt
            // 
            this.txtCantidadArt.Location = new System.Drawing.Point(24, 164);
            this.txtCantidadArt.Name = "txtCantidadArt";
            this.txtCantidadArt.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadArt.TabIndex = 47;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtCodProv);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtNumeroComprobante);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtNombreProveedor);
            this.panel3.Controls.Add(this.dtpCarga);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.btnVerificar);
            this.panel3.Controls.Add(this.dtpEmision);
            this.panel3.Controls.Add(this.txtTipoComprobante);
            this.panel3.Location = new System.Drawing.Point(15, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1049, 70);
            this.panel3.TabIndex = 47;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(304, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 18);
            this.label11.TabIndex = 47;
            this.label11.Text = "Nombre";
            // 
            // CodigoArt
            // 
            this.CodigoArt.HeaderText = "CodigoArticulo";
            this.CodigoArt.Name = "CodigoArt";
            // 
            // CantidadArticulo
            // 
            this.CantidadArticulo.HeaderText = "Cantidad";
            this.CantidadArticulo.Name = "CantidadArticulo";
            // 
            // DescripcionArt
            // 
            this.DescripcionArt.HeaderText = "Descripcion";
            this.DescripcionArt.Name = "DescripcionArt";
            // 
            // Desc_Art
            // 
            this.Desc_Art.HeaderText = "Descuento";
            this.Desc_Art.Name = "Desc_Art";
            // 
            // Prec_Arti
            // 
            this.Prec_Arti.HeaderText = "Precio Unitario";
            this.Prec_Arti.Name = "Prec_Arti";
            // 
            // Precio_Totales
            // 
            this.Precio_Totales.HeaderText = "Precios Totales";
            this.Precio_Totales.Name = "Precio_Totales";
            // 
            // lblTipoComprobante
            // 
            this.lblTipoComprobante.AutoSize = true;
            this.lblTipoComprobante.Location = new System.Drawing.Point(900, 116);
            this.lblTipoComprobante.Name = "lblTipoComprobante";
            this.lblTipoComprobante.Size = new System.Drawing.Size(0, 13);
            this.lblTipoComprobante.TabIndex = 60;
            this.lblTipoComprobante.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 603);
            this.Controls.Add(this.lblTipoComprobante);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCodProv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpCarga;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.TextBox txtIdArticulo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTipoComprobante;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.DateTimePicker dtpEmision;
        private System.Windows.Forms.Button btnVerificarArt;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.TextBox txtNumeroComprobante;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDescripcionArt;
        private System.Windows.Forms.TextBox txtStockArt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPrecioUnitarioArt;
        private System.Windows.Forms.TextBox txtCantidadArt;
        private System.Windows.Forms.ComboBox CmbDescuento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTotalTotales;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label lblCantidadTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoArt;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionArt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc_Art;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prec_Arti;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Totales;
        private System.Windows.Forms.Label lblTipoComprobante;
    }
}

