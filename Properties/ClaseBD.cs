using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace pryMoyaIEFI.Properties
{

    internal class ClaseBD
    {
        OleDbCommand Micommand;
        OleDbConnection Miconnection;
        OleDbDataReader Reader;

        string CadenaDeConexion;


        public void ConectarBD()
        {
            string CadenaDeConexion = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source =EL_CLUB.accdb;";

            try
            {
                Miconnection = new OleDbConnection(CadenaDeConexion);

                Miconnection.ConnectionString = CadenaDeConexion;

                Miconnection.Open();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
    }

}
