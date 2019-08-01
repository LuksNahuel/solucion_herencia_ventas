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
    public class DAO_Ventas : Interfaz.ICRRUD<Ventas>
    {
        public bool Create(Ventas Entity)
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
                comm.CommandText = "CREATE_VENTA";
                comm.CommandType = CommandType.StoredProcedure;
                comm.Connection = conn;
                //Declaramos los parámetros
                SqlParameter paramCliente = new SqlParameter("@CLIENTE", SqlDbType.NVarChar, 8);
                SqlParameter paramVendedor = new SqlParameter("@VENDEDOR", SqlDbType.NVarChar, 8);
                SqlParameter paramProducto = new SqlParameter("@PRODUCTO", SqlDbType.Int);
                SqlParameter paramCantidad = new SqlParameter("@CANTIDAD", SqlDbType.Int);
                SqlParameter paramTotal = new SqlParameter("@TOTAL", SqlDbType.Money);
                SqlParameter paramDescripcion = new SqlParameter("@DESCRIPCION", SqlDbType.NVarChar, 500);
                //Incluir los valores a los parámetros
                paramCliente.Value = Entity.CLIENTE;
                paramVendedor.Value = Entity.VENDEDOR;
                paramProducto.Value = Entity.PRODUCTO;
                paramCantidad.Value = Entity.CANTIDAD;
                paramTotal.Value = Entity.TOTAL;
                paramDescripcion.Value = Entity.DESCRIPCION;
                //Incluir los parámetros en el comando
                comm.Parameters.Add(paramCliente);
                comm.Parameters.Add(paramVendedor);
                comm.Parameters.Add(paramProducto);
                comm.Parameters.Add(paramCantidad);
                comm.Parameters.Add(paramTotal);
                comm.Parameters.Add(paramDescripcion);
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

        public Ventas Read(object ID)
        {
            throw new NotImplementedException();
        }

        public List<Ventas> ReadAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Ventas Entity, object ID)
        {
            throw new NotImplementedException();
        }
    }
}
