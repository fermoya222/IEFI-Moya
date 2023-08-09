using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace pryMoyaIEFI
{
    
    public partial class FrmCargarBD : Form
    {

        
        public FrmCargarBD()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ClaseBD objConnection = new ClaseBD();
            objConnection.cargarCombo(cmbPais);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string pais = cmbPais.Text;

            //crea obj clase y me pasa los datos del socio
            ClaseBD objCargarBD = new ClaseBD();
            objCargarBD.agregarSocio(nombre, apellido, pais, Convert.ToInt32(mtxtEdad.Text), optMasculino.Checked, Convert.ToInt32(mtxtIngreso.Text), Convert.ToInt32(mtxtPuntaje.Text));


        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }
    }
}
