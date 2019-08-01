using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentasBDD.Entities;

namespace VentasBDD.Actions
{
    public class Cliente_Actions : Interfaz.ICRRUD<Entities.Cliente>
    {

        Datos.DAO_Cliente dao_cliente = new Datos.DAO_Cliente();

        public bool Create(Cliente Entity)
        {
            dao_cliente.Create(Entity);

            return true;
        }

        public bool Delete(object ID)
        {
            return dao_cliente.Delete(ID);
        }

        public Cliente Read(object ID)
        {
            return dao_cliente.Read(ID);
        }

        public List<Cliente> ReadAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Cliente Entity, object ID)
        {
            throw new NotImplementedException();
        }
    }
}
