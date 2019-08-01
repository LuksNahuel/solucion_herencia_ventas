using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentasBDD.Entities;

namespace VentasBDD.Actions
{
    public class Vendedor_Action : Interfaz.ICRRUD<Entities.Vendedor>
    {
        Datos.DAO_Vendedor dao_vendedor = new Datos.DAO_Vendedor();
        public bool Create(Vendedor Entity)
        {
            dao_vendedor.Create(Entity);
            return true;
        }

        public bool Delete(object ID)
        {
            throw new NotImplementedException();
        }

        public Vendedor Read(object ID)
        {
            return dao_vendedor.Read(ID);
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
