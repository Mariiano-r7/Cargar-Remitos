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
    public partial class CalculosTotales : Form
    {
        public CalculosTotales()
        {
            InitializeComponent();

            
        }
     
        

        public void Descuento10()
        {
           

            
        }

        public void Descuento20()
        {
            

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int cant;
            double prec, subt, tot1, descuento10, ff;
            cant = int.Parse(txtCantidad.Text);
            prec = double.Parse(txtPrecio.Text);

            if (cmbDescuento.Text == Convert.ToString(10))
            {
                subt = cant * prec;
                descuento10 = 0.1;
                ff = subt * descuento10;
                tot1 = subt - ff;

                txtTotal.Text = Convert.ToString(tot1) + "$";
                lblArticulos.Text = cant.ToString();
                lblImporteUnit.Text = prec.ToString();
                lblDesc.Text = "10%";
                lblTotal.Text = tot1.ToString();


            }
            else
            {
                MessageBox.Show("Error, Agregar valores");
            }

            
        
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
