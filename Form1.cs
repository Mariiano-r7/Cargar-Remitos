using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cargar_Remitos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BaseDeDatos bd = new BaseDeDatos();
        private void Form1_Load(object sender, EventArgs e)
        {
            dgv1.DataSource = bd.SelectDataTable("Select * From Comprobantes");
            dgv2.DataSource = bd.SelectDataTable("Select * From Articulos");
            txtIdComprobante.Enabled = false;
            dtpEmision.Enabled = false;
            dtpCarga.Enabled = false;
            txtCantidad.Enabled = false;
            txtIdProveedor.Enabled = false;
            txtTipoComprobante.Enabled = false;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            DateTime FechEmision = dtpEmision.Value;
            string consultar = bd.selectstring("Select * from Comprobantes where Id_Comprobantes = '" + txtIdComprobante.Text + "'");
            string agregar = "Insert into Comprobantes values (" + txtIdComprobante.Text + ",'" + dtpEmision.Text + "','" + dtpCarga.Text + "'," + txtCantidad.Text + "," + txtIdProveedor.Text + "," + txtTipoComprobante.Text + ")";

            if (string.IsNullOrWhiteSpace(txtIdComprobante.Text))
            {
                MessageBox.Show("Error");
            }
            else
            {
                if (consultar == txtIdComprobante.Text)
                {
                    MessageBox.Show("Esta clave ya Existe");
                }
                else
                {
                    if (bd.executecommand(agregar))
                    {
                        MessageBox.Show("Registro Agregado Correctamente");
                        dgv1.DataSource = bd.SelectDataTable("Select * From Comprobantes");
                    }
                    else
                    {
                        MessageBox.Show("Error al Agregar");
                    }





                }

            }


        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string consultar = bd.selectstring("Select * from Proveedores where Id_Proveedores = '" + txtCodProv.Text + "'");

            if (string.IsNullOrWhiteSpace(txtCodProv.Text))
            {
                MessageBox.Show("Error");
            }
            else
            {
                if (consultar == txtCodProv.Text)
                {
                    MessageBox.Show("Esta clave existe en la Base de Datos, Por favor rellenar el Remito");
                    txtIdComprobante.Enabled = true;
                    dtpEmision.Enabled = true;
                    dtpCarga.Enabled = true;
                    txtCantidad.Enabled = true;
                    txtIdProveedor.Enabled = true;
                    txtTipoComprobante.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Debe Registrarse");

                }


            }
        }

        private void btnVerificarArt_Click(object sender, EventArgs e)
        {
            string consultar = bd.selectstring("Select * from Articulos where Id_Articulos = '" + txtIdArticulo.Text + "'");

            if (string.IsNullOrWhiteSpace(txtIdArticulo.Text))
            {
                MessageBox.Show("Error");
            }
            else
            {
                if (consultar == txtIdArticulo.Text)
                {
                    MessageBox.Show("El Codigo de este articulo si existe en la Base de Datos");
                    dgv2.DataSource = bd.SelectDataTable("Select Nombre_Art, UnidadMedida_Art, Descripcion_Art from Articulos where Id_Articulos =" + txtIdArticulo.Text);

                }
                else
                {
                    MessageBox.Show("Debe Registrar este Articulo");

                }


            }


        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Form CalculosTotales = new CalculosTotales();
            CalculosTotales.Show();
        }
    }
}