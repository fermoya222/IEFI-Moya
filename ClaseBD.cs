using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace pryMoyaIEFI
{
    internal class ClaseBD
    {
        //crea una conexiom a una base de datos tipo oledb
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EL_CLUB.accdb");
        OleDbCommand command = new OleDbCommand();
        OleDbDataReader reader;

        public void CargarPais(string nombrePais)
        {
            try
            {
                //
                using (var connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EL_CLUB.accdb"))
                {
                    
                    using (var command = new OleDbCommand())
                    {
                        //abre la conexion y lee la tabla pais 
                        connection.Open();
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;
                        //busca si encuentra un pais con el nombre ingresado 
                        command.CommandText = "SELECT NOMBRE_PAIS FROM PAISES WHERE NOMBRE_PAIS = '" + nombrePais + "'";
                        
                        //cuando se ejecutta si existe te tira mssj y sale
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                MessageBox.Show("Pais existente");
                                return;
                            }
                        }

                        //lo inserta/agrega si no existe
                        command.CommandText = "INSERT INTO PAISES (NOMBRE_PAIS) VALUES ('"+nombrePais+"')" ;
                        command.ExecuteNonQuery();

                        MessageBox.Show("Pais agregado con exito");
                    }
                }
            }

            //si hay un error salta ahi e informa al usuario ej: sin conexion, error ortografico
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }


        public void cargarCombo(ComboBox cmbPaises)
        {
            //limpia el combo para volver a cargarlo, lee la tabla y agg
            cmbPaises.Items.Clear();
            command.Connection = connection;
            command.CommandType = CommandType.TableDirect;
            command.CommandText = "PAISES";
            command.Connection.Open();
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                cmbPaises.Items.Add(reader[1]);
            }

            command.Connection.Close();
        }

        public void agregarSocio(string nombre, string apellido, string pais, int edad, bool sexo, decimal importe, int puntaje)
        {
            //abro la bd
            connection.Open();

            try
            {
                //creo un comando para darle una instruccion a la bd, lo conecto y le doy la orden 
                OleDbCommand commandInsert = new OleDbCommand();
                commandInsert.Connection = connection;
                commandInsert.CommandType = CommandType.Text;
                commandInsert.CommandText = "INSERT INTO SOCIOS (NOMBRE, APELLIDO, LUGAR_NACIMIENTO, " +
                    //cuando son int ,decimal o boolean van sin comilla simple, de los contrario o string con comilla para idnetificar el string en la base de datos
                    "EDAD, SEXO, INGRESO, PUNTAJE) VALUES ( '"+nombre+ "', '"+apellido+"', '" + pais + "','"+edad+ "',"+sexo+", "+importe+", "+puntaje+")";
                commandInsert.ExecuteNonQuery();

                MessageBox.Show(" Socio " + nombre.ToUpper() + ", " + apellido.ToUpper() + " cargado correctamente");

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

            connection.Close();
        }
    }
}
