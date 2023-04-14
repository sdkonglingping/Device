using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
namespace BLL
{
    public class DeviceBLL
    {
        DeviceDAL deviceDAL = new DeviceDAL();
        public List<Device> GetAll(string[] filter)
        {
            return deviceDAL.GetAll(filter);
        }
        public List<Device> GetDataByFilter(string filter)
        {
            return deviceDAL.GetDataByFilter(filter);
        }
        public int Save(Device obj, EntityState objState)
        {
            if (objState == EntityState.Added)
            {
                return deviceDAL.Insert(obj);

            }
            if (objState == EntityState.Changed)
            {
                return deviceDAL.Update(obj);

            }
            return 0;

        }

        public int Delete(int id)
        {
           
            return deviceDAL.Delete(id);
        }
    }
}
