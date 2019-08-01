using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using VentasBDD.Entities;

namespace VentasBDD.Datos
{
    public class DAO_Vendedor : Interfaz.ICRRUD<Entities.Vendedor>
    {
        public bool Create(Vendedor Entity)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                //Conectarnos a ventas.
                conn.ConnectionString = @"Data Source = SEA-DEV19\SQL2017; Initial Catalog = Ventas; 
                                         Integrated Security = true";
                conn.Open();
                //Guardar en la base de datos el cliente
                //Declaramos el comando
                SqlCommand comm = new SqlCommand();
                comm.CommandText = "CREATE_VENDEDOR";
                comm.CommandType = CommandType.StoredProcedure;
                comm.Connection = conn;
                //Declaramos los parámetros
                SqlParameter paramDNI = new SqlParameter("@DNI", SqlDbType.NVarChar, 8);
                SqlParameter paramNombre = new SqlParameter("@NOMBRE", SqlDbType.NVarChar, 50);
                SqlParameter paramApellido = new SqlParameter("@APELLIDO", SqlDbType.NVarChar, 50);
                SqlParameter paramDireccion = new SqlParameter("@DIRECCION", SqlDbType.NVarChar, 100);
                SqlParameter paramTelefono = new SqlParameter("@TELEFONO", SqlDbType.NVarChar, 20);
                SqlParameter paramEmail = new SqlParameter("@EMAIL", SqlDbType.NVarChar, 100);
                //Incluir los valores a los parámetros
                paramDNI.Value = Entity.DNI;
                paramNombre.Value = Entity.NOMBRE;
                paramApellido.Value = Entity.APELLIDO;
                paramDireccion.Value = Entity.DIRRECIOn;
                paramTelefono.Value = Entity.TELEFONO;
                paramEmail.Value = Entity.EMAIL;
                //Incluir los parámetros en el comando
                comm.Parameters.Add(paramDNI);
                comm.Parameters.Add(paramNombre);
                comm.Parameters.Add(paramApellido);
                comm.Parameters.Add(paramDireccion);
                comm.Parameters.Add(paramTelefono);
                comm.Parameters.Add(paramEmail);
                //Ejecutar el comando
                comm.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        
    }
        public bool Delete(object ID)
        {
            throw new NotImplementedException();
        }

        public Vendedor Read(object ID)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                //Conectarnos a ventas.
                conn.ConnectionString = @"Data Source = SEA-DEV19\SQL2017; Initial Catalog = Ventas; 
                                         Integrated Security = true";
                conn.Open();
                //Guardar en la base de datos el cliente
                //Declaramos el comando
                SqlCommand comm = new SqlCommand();
                comm.CommandText = "READ_VENDEDOR";
                comm.CommandType = CommandType.StoredProcedure;
                comm.Connection = conn;
                //Declaramos los parámetros
                SqlParameter paramDNI = new SqlParameter("@DNI", SqlDbType.NVarChar, 8);
                //Incluir los valores a los parámetros
                paramDNI.Value = ID.ToString();
                //Incluir los parámetros en el comando
                comm.Parameters.Add(paramDNI);
                //Ejecutar el comando
                SqlDataReader data = comm.ExecuteReader();
                data.Read();
                //Crear un cliente
                Vendedor vendedor = new Vendedor();
                vendedor.DNI = data[0].ToString();
                vendedor.NOMBRE = data[1].ToString();
                vendedor.APELLIDO = data[2].ToString();
                vendedor.DIRRECIOn = data[3].ToString();
                vendedor.TELEFONO = data[4].ToString();
                vendedor.EMAIL = data[5].ToString();
                return vendedor;
            }
            catch(SqlException e)
            {
                string error = e.Message;
                return null;
            }
            catch(Exception e)
            {
                string error = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Vendedor> ReadAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Vendedor Entity, object ID)
        {
            throw new NotImplementedException();
        }
    }
}
