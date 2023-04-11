using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IModel<T> where T: class
    {
        List<T> GetAll();
        List<T> GetDataByFilter<M>(M filter);
        int Insert(T obj);
        int Update(T obj);
        int Delete(int id);

    }
}
