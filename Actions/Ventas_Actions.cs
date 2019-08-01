using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentasBDD.Datos;
using VentasBDD.Entities;

namespace VentasBDD.Actions
{
    public class Ventas_Actions : Interfaz.ICRRUD<Ventas>
    {
        DAO_Ventas dao_ventas = new DAO_Ventas();
        public bool Create(Ventas Entity)
        {
            dao_ventas.Create(Entity);
            return true;
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
