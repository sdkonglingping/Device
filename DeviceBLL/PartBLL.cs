using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace BLL
{
    public class PartBLL
    {
        PartDAL partDAL = new PartDAL();
        public List<Part> GetAll()
        {
            return partDAL.GetAll();
        }
        public List<Part> GetDataByFilter(string filter)
        {
            return partDAL.GetDataByFilter(filter);
        }
        public int Save(Part obj, EntityState objState)
        {
            if (objState == EntityState.Added)
            {
                return partDAL.Insert(obj);

            }
            if (objState == EntityState.Changed)
            {
                return partDAL.Update(obj);

            }
            return 0;

        }

        public int Delete(int id)
        {

            return partDAL.Delete(id);
        }
    }

}

