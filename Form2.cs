using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMoyaIEFI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void btnAggPais_Click(object sender, EventArgs e)
        {
            if (txtPais.Text == "")
            {
                MessageBox.Show("Ingrese un campo");
                return;
            }
            else
            {
                ClaseBD objConn = new ClaseBD();
                objConn.CargarPais(txtPais.Text);
               // objConn.cargarCombo(cmbPais);
            }
            txtPais.Text = "";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

    }
}
