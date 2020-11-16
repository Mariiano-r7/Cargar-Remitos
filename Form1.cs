using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Cargar_Remitos
{
    public partial class Form1 : Form
    {
        private int n = 0;
        SqlConnection con = new SqlConnection( @"Data Source=DESKTOP-TPN7G35;Initial Catalog=CargarRemito;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public Form1()
        {
            InitializeComponent();
        }

        BaseDeDatos bd = new BaseDeDatos();
        private void Form1_Load(object sender, EventArgs e)
        {
            dgv1.Columns[0].Visible = false;
            
        }

        

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string consultar = "Select Personas.Nombres, Comprobantes.FechaEmision, Comprobantes.FechaCarga, TipoComprobantes.TipoComprobante,TipoComprobantes.Id_TipComprobante, Comprobantes.Id_Comprobante from Personas join Domicilio on Domicilio.Id_Domicilio = Personas.Id_Domicilio join Proveedores on Proveedores.Id_Domicilio = Personas.Id_Domicilio join Comprobantes on Comprobantes.Id_Proveedores = Proveedores.Id_Proveedores join TipoComprobantes on TipoComprobantes.Id_TipComprobante = Comprobantes.Id_TipoComprobante where Proveedores.Id_Proveedores = '" + txtCodProv.Text + "'";
            SqlCommand comando = new SqlCommand(consultar, con);
            con.Open();

            SqlDataReader leer = comando.ExecuteReader();
            if (leer.Read() == true)
            {

                MessageBox.Show("El Registro se ha encontrado");
                txtNombreProveedor.Text = leer["Nombres"].ToString();
                dtpEmision.Text = leer["FechaEmision"].ToString();
                dtpCarga.Text = leer["FechaCarga"].ToString();
                txtTipoComprobante.Text = leer["TipoComprobante"].ToString();
                txtNumeroComprobante.Text = leer["Id_Comprobante"].ToString();
                lblTipoComprobante.Text = leer["Id_TipComprobante"].ToString();
            }
            else
            {
                MessageBox.Show("No Existe");
            }
            con.Close();

        }

        private void btnVerificarArt_Click(object sender, EventArgs e)
        {
            string consultar = "Select Articulos.Nombre_Art, Articulos.Descripcion_Art, Articulos.StockActual_Art, Precios.PrecioActual from Articulos join Precios on Articulos.Id_Precios = Precios.Id_Precios where Articulos.Id_Articulos = '" + txtIdArticulo.Text + "'";
            SqlCommand comando = new SqlCommand(consultar, con);
            con.Open();

            SqlDataReader leer = comando.ExecuteReader();
            if (leer.Read() == true)
            {

                MessageBox.Show("El Registro se ha encontrado");
                txtDescripcionArt.Text = leer["Descripcion_Art"].ToString();
                txtStockArt.Text = leer["StockActual_Art"].ToString();
                txtPrecioUnitarioArt.Text = leer["PrecioActual"].ToString();
                lblNombre.Text = leer["Nombre_Art"].ToString();
               

            }
            else
            {
                MessageBox.Show("No Existe");
            }
            con.Close();


        }
        
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Form CalculosTotales = new CalculosTotales();
            CalculosTotales.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //int cant;
            //double prec, subt, tot1, descuento10, ff;
            //cant = int.Parse(txtCantidad.Text);
            //prec = double.Parse(txtPrecio.Text);

            //if (cmbDescuento.Text == Convert.ToString(10))
            //{
            //    subt = cant * prec;
            //    descuento10 = 0.1;
            //    ff = subt * descuento10;
            //    tot1 = subt - ff;

            //    txtTotal.Text = Convert.ToString(tot1) + "$";
            //    lblArticulos.Text = cant.ToString();
            //    lblImporteUnit.Text = prec.ToString();
            //    lblDesc.Text = "10%";
            //    lblTotal.Text = tot1.ToString();


            //}
            //else
            //{
            //    MessageBox.Show("Error, Agregar valores");
            //}
            //int cant;
            //double prec, subt, tot1, descuento10, ff;
            int n = dgv1.Rows.Add();

            //descuento10 = 0.1;
            //ff = Multi * descuento10;
            //tot1 = subt - ff;
            //lblTotal.Text = tot1.ToString();
            decimal Multi = decimal.Parse(txtCantidadArt.Text) * decimal.Parse(txtPrecioUnitarioArt.Text);
            double Descuento = 0.1;
            decimal sub = Convert.ToDecimal(Descuento) * Multi;
            decimal Total = Multi- sub;

            dgv1.Rows[n].Cells[0].Value = txtIdArticulo.Text;
            dgv1.Rows[n].Cells[1].Value = txtCantidadArt.Text;
            dgv1.Rows[n].Cells[2].Value = lblNombre.Text;
            dgv1.Rows[n].Cells[3].Value = CmbDescuento.Text + '%';
            dgv1.Rows[n].Cells[4].Value = txtPrecioUnitarioArt.Text;
            dgv1.Rows[n].Cells[5].Value = Total;
            txtCantidadArt.Text = "";

            decimal total = 0;
            foreach (DataGridViewRow row in dgv1.Rows)
            {
                total += Convert.ToDecimal(row.Cells["Precio_Totales"].Value);
            }
            txtTotalTotales.Text = Convert.ToString(total);

            double CantidadTotal = 0;
            foreach (DataGridViewRow row in dgv1.Rows)
            {
                CantidadTotal += Convert.ToDouble(row.Cells["CantidadArticulo"].Value);
            }
            lblCantidadTotal.Text = Convert.ToString(CantidadTotal);

            //-----------------------------------------------------------------------------------------------------------------------
            


            //int cant;
            //double prec, subt, tot1, descuento10, ff;
            //cant = int.Parse(txtCantidadArt.Text);
            //prec = double.Parse(txtPrecioUnitarioArt.Text);

            //if (CmbDescuento.Text == Convert.ToString(10))
            //{
            //    subt = cant * prec;
            //    descuento10 = 0.1;
            //    ff = subt * descuento10;
            //    tot1 = subt - ff;



            //}

            //dgv1.Rows.Add(txtCantidadArt.Text, lblNombre.Text, CmbDescuento.Text+'%', txtPrecioUnitarioArt.Text);







        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
        
            if(n!=-1)
            {
                dgv1.Rows.RemoveAt(n);
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            //double CantidadTotal = 0;
            //foreach (DataGridViewRow row in dgv1.Rows)
            //{
            //    CantidadTotal += Convert.ToDouble(row.Cells["CantidadArticulo"].Value);
            //}
            //lblCantidadTotal.Text = Convert.ToString(CantidadTotal);

            //SqlCommand AgregarComprobantes = new SqlCommand("insert into Comprobantes values (@fechaEmision, @fechaCarga, @cantidadItems, @id_Provedores, @id_TipoComprobante)", con);
            //con.Open();
            //try 
            //{
            //    AgregarComprobantes.Parameters.Clear();

            //AgregarComprobantes.Parameters.AddWithValue("@fechaEmision", dtpEmision.Text);
            //AgregarComprobantes.Parameters.AddWithValue("@fechaCarga", dtpCarga.Text);
            //AgregarComprobantes.Parameters.AddWithValue("@cantidadItems", lblCantidadTotal.Text);
            //AgregarComprobantes.Parameters.AddWithValue("@id_Proveedores", txtCodProv.Text);
            //AgregarComprobantes.Parameters.AddWithValue("@id_TipoComprobante", txtTipoComprobante.Text);
            //AgregarComprobantes.ExecuteNonQuery();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error al Agregar");
            //}
            //finally 
            //{
            //    con.Close();

            //}




            //SqlCommand agregar = new SqlCommand("insert into DetalleComprobantes values (@cantidad, @precioUnitario, @id_Comprobante, @id_Articulos)", con);
            //con.Open();

            //try 
            //{
            //    foreach (DataGridViewRow row in dgv1.Rows )
            //    {
            //        agregar.Parameters.Clear();

            //        agregar.Parameters.AddWithValue("@cantidad", Convert.ToString(row.Cells["CantidadArticulo"].Value));
            //        agregar.Parameters.AddWithValue("@precioUnitario", Convert.ToString(row.Cells["Prec_Arti"].Value));
            //        agregar.Parameters.AddWithValue("@id_Comprobante", txtNumeroComprobante.Text);
            //        agregar.Parameters.AddWithValue("@id_Articulos", txtIdArticulo.Text);
            //        agregar.ExecuteNonQuery();

            //    }
            //    MessageBox.Show("Datos Agregados Correctamente");
            
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error al Agregar");
            //}
            //finally 
            //{
            //    con.Close();
            //}


        }

        private void btnFinalizar_Click_1(object sender, EventArgs e)
        {
            string query = "insert into Comprobantes (FechaEmision, FechaCarga, CantidadItems, Id_Proveedores, Id_TipoComprobante)values (@fechaEmision, @fechaCarga, @cantidadItems, @id_Proveedores, @id_TipComprobante)";
            con.Open();
            SqlCommand comando = new SqlCommand(query, con);
            comando.Parameters.AddWithValue("@fechaEmision", Convert.ToDateTime(dtpEmision.Text));
            comando.Parameters.AddWithValue("@fechaCarga", Convert.ToDateTime(dtpCarga.Text));
            comando.Parameters.AddWithValue("@cantidadItems", lblCantidadTotal.Text);
            comando.Parameters.AddWithValue("@id_Proveedores", txtCodProv.Text);
            comando.Parameters.AddWithValue("@id_TipComprobante", lblTipoComprobante.Text);
            comando.ExecuteNonQuery();
            MessageBox.Show("El Remito Se realizo con exito");
            con.Close();


            //string queryActuaStock = "Select StockActual_Art from Precios, Articulos where Precios.Id_Precios = Articulos.Id_Precios and Articulos.Id_Articulos =" +txtIdArticulo.Text+;
            
            //string queryStock = "update Articulos set StockActual_Art = "+txtStockArt.Text+ "where Id_Articulos= " + txtIdArticulo.Text;

            //int RestaStock = Convert.ToInt32(queryActuaStock) - queryStock;
            //con.Open();
            //SqlCommand comandoStock = new SqlCommand(queryStock, con);
            //comandoStock.Parameters.AddWithValue("@stockActual_Art", txtCantidadArt.Text)




            //SqlCommand AgregarComprobantes = new SqlCommand("insert into Comprobantes values (@fechaEmision, @fechaCarga, @cantidadItems, @id_Proveedores, @id_TipoComprobante)", con);
            //con.Open();
            //try
            //{
            //    AgregarComprobantes.Parameters.Clear();

            //    AgregarComprobantes.Parameters.AddWithValue("@fechaEmision", dtpEmision.Text);
            //    AgregarComprobantes.Parameters.AddWithValue("@fechaCarga", dtpCarga.Text);
            //    AgregarComprobantes.Parameters.AddWithValue("@cantidadItems", lblCantidadTotal.Text);
            //    AgregarComprobantes.Parameters.AddWithValue("@id_Proveedores", txtCodProv.Text);
            //    AgregarComprobantes.Parameters.AddWithValue("@id_TipoComprobante", txtTipoComprobante.Text);
            //    AgregarComprobantes.ExecuteNonQuery();

            //    MessageBox.Show("Datos Agregados Correctamente");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error al Agregar");
            //}
            //finally
            //{
            //    con.Close();

            //}
            //-------------------------------------------------------------------------------------------
            SqlCommand agregar = new SqlCommand("insert into DetalleComprobantes values (@cantidad, @precioUnitario, @id_Comprobante, @id_Articulos)", con);
            con.Open();

            try
            {
                foreach (DataGridViewRow row in dgv1.Rows)
                {
                    agregar.Parameters.Clear();

                    agregar.Parameters.AddWithValue("@cantidad", Convert.ToString(row.Cells["CantidadArticulo"].Value));
                    agregar.Parameters.AddWithValue("@precioUnitario", Convert.ToString(row.Cells["Prec_Arti"].Value));
                    agregar.Parameters.AddWithValue("@id_Comprobante", txtNumeroComprobante.Text);
                    agregar.Parameters.AddWithValue("@id_Articulos", Convert.ToString(row.Cells["CodigoArt"].Value));
                    agregar.ExecuteNonQuery();

                }
                MessageBox.Show("Datos Agregados Correctamente");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Agregar");
            }
            finally
            { 
                con.Close(); 
            }
            



        }
    }
}