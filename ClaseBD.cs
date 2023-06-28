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
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EL_CLUB.accdb");
        OleDbCommand command = new OleDbCommand();
        OleDbDataReader reader;

        public void CargarPais(string nombrePais)
        {
            try
            {
                using (var connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EL_CLUB.accdb"))
                {
                    using (var command = new OleDbCommand())
                    {
                        connection.Open();
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;
                        command.CommandText = "SELECT NOMBRE_PAIS FROM PAISES WHERE NOMBRE_PAIS = @Pais";
                        command.Parameters.AddWithValue("@Pais", nombrePais);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                MessageBox.Show("Pais existente");
                                return;
                            }
                        }

                        command.CommandText = "INSERT INTO PAISES (NOMBRE_PAIS) VALUES (@Pais)";
                        command.ExecuteNonQuery();

                        MessageBox.Show("Pais agregado con exito");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }


        public void cargarCombo(ComboBox cmbPaises)
        {
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
            connection.Open();

            try
            {
                OleDbCommand commandInsert = new OleDbCommand();
                commandInsert.Connection = connection;
                commandInsert.CommandType = CommandType.Text;
                commandInsert.CommandText = "INSERT INTO SOCIOS (NOMBRE, APELLIDO, LUGAR_NACIMIENTO, " +
                    "EDAD, SEXO, INGRESO, PUNTAJE) VALUES (@Nombre, @Apellido, " +
                    "@Pais, @Edad, @Sexo, @Importe, @Puntaje)";
                commandInsert.Parameters.AddWithValue("@Nombre", nombre);
                commandInsert.Parameters.AddWithValue("@Apellido", apellido);
                commandInsert.Parameters.AddWithValue("@Pais", pais);
                commandInsert.Parameters.AddWithValue("@Edad", edad);
                commandInsert.Parameters.AddWithValue("@Sexo", sexo);
                commandInsert.Parameters.AddWithValue("@Importe", importe);
                commandInsert.Parameters.AddWithValue("@Puntaje", puntaje);

                commandInsert.ExecuteNonQuery();


            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

            connection.Close();
        }
    }
}
