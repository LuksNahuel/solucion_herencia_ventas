using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentasBDD.Entities;
using System.Data;
using System.Data.SqlClient;

namespace VentasBDD.Datos
{
    public class DAO_Producto : Interfaz.ICRRUD<Producto>
    {
        public bool Create(Producto Entity)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                //Conectarnos a la tabla ventas.
                conn.ConnectionString = @"Data Source = SEA-DEV19\SQL2017; Initial Catalog = Ventas; 
                                         Integrated Security = true";
                conn.Open();
                //Guardar en la base de datos el producto
                //Declaramos el comando
                SqlCommand comm = new SqlCommand();
                comm.CommandText = "CREATE_PRODUCTO";
                comm.CommandType = CommandType.StoredProcedure;
                comm.Connection = conn;
                //Declaramos los parámetros
                SqlParameter paramNombre = new SqlParameter("@NOMBRE", SqlDbType.NVarChar, 100);
                SqlParameter paramPrecio = new SqlParameter("@PRECIO", SqlDbType.Money);
                SqlParameter paramDescripcion = new SqlParameter("@DESCRIPCION", SqlDbType.NVarChar, 500);
                //Incluir valores en los parámetros
                paramNombre.Value = Entity.NOMBRE;
                paramPrecio.Value = Entity.PRECIO;
                paramDescripcion.Value = Entity.DESCRIPCION;
                //Incluir los parámetros en el comando
                comm.Parameters.Add(paramNombre);
                comm.Parameters.Add(paramPrecio);
                comm.Parameters.Add(paramDescripcion);
                //Ejectur el comando
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

        public Producto Read(object ID)
        {
            /*SqlConnection conn = new SqlConnection();
            try
            {
                //Conectarnos a ventas.
                conn.ConnectionString = @"Data Source = SEA-DEV19\SQL2017; Initial Catalog = Ventas; 
                                         Integrated Security = true";
                conn.Open();
                //Guardar en la base de datos el cliente
                //Declaramos el comando
                SqlCommand comm = new SqlCommand();
                comm.CommandText = "READ_CLIENTE";
                comm.CommandType = CommandType.StoredProcedure;
                comm.Connection = conn;
                //Declaramos los parámetros
                SqlParameter paramID = new SqlParameter("@DNI", SqlDbType.NVarChar, 8);
                //Incluir los valores a los parámetros
                paramDNI.Value = ID.ToString();
                //Incluir los parámetros en el comando
                comm.Parameters.Add(paramDNI);
                //Ejecutar el comando
                SqlDataReader data = comm.ExecuteReader();
                data.Read();
                //Crear un cliente
                Cliente cliente = new Cliente();
                cliente.DNI = data[0].ToString();
                cliente.NOMBRE = data[1].ToString();
                cliente.APELLIDO = data[2].ToString();
                cliente.DIRRECIOn = data[3].ToString();
                cliente.TELEFONO = data[4].ToString();
                cliente.EMAIL = data[5].ToString();
                return cliente;
            }
            catch (SqlException e)
            {
                string error = e.Message;
                return null;
            }
            catch (Exception e)
            {
                string error = e.Message;
                return null;
            }
            finally
            {
                conn.Close();
            }*/
            throw new NotImplementedException();
        }

        public List<Producto> ReadAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Producto Entity, object ID)
        {
            throw new NotImplementedException();
        }
    }

}
