using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentasBDD.Entities;

namespace VentasBDD.Actions
{
    public class Producto_Actions : Interfaz.ICRRUD<Producto>
    {
        Datos.DAO_Producto dao_producto = new Datos.DAO_Producto();

        public bool Create(Producto Entity)
        {
            dao_producto.Create(Entity);
            return true;
        }

        public bool Delete(object ID)
        {
            throw new NotImplementedException();
        }

        public Producto Read(object ID)
        {
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
