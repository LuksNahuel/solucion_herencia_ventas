using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz
{
    public interface ICRRUD<T>
    {
        bool Create(T Entity);
        T Read(object ID);
        List<T> ReadAll();
        bool Update(T Entity, object ID);
        bool Delete(object ID);
    }
}
