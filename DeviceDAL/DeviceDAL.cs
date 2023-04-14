using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Model;
using System.Configuration;


namespace DAL
{
    public class DeviceDAL : IModel<Device>
    {
        public int Delete(int id)
        {
            using (IDbConnection db = new SqlConnection(DBHelper.ConnectionString))
            {

                if (db.State == ConnectionState.Closed)
                {
                    db.Open();
                }
                DynamicParameters p = new DynamicParameters();
               
                p.AddDynamicParams(new { DId = id });
                try
                {
                    return db.Execute("pr_Device_Delete", p, commandType: CommandType.StoredProcedure);
                }
                catch (Exception)
                {

                    return -1;
                }


            }
        }

        public List<Device> GetAll(string[] filter)
        {
            using (IDbConnection db = new SqlConnection(DBHelper.ConnectionString))//"server=.;database=DeviceDB;uid=sa;pwd=123"
            {
                try
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                    }
                    DynamicParameters p = new DynamicParameters();
                    p.AddDynamicParams(new { Dept=filter[0], Area=filter[1],Name =filter[2], DModel=filter[3], DKKS=filter[4], DStatus=filter[5] });
                    return db.Query<Device>("pr_Device_GetData ",p,commandType: CommandType.StoredProcedure).ToList();

                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public List<Device> GetDataByFilter<M>(M filter)
        {
            using (IDbConnection db = new SqlConnection(DBHelper.ConnectionString))//"server=.;database=DeviceDB;uid=sa;pwd=123"
            {
                try
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                    }
                    DynamicParameters p = new DynamicParameters();
                    //p.AddDynamicParams(new { DNameEN = obj.DNameEN, DType = obj.DType, DModel = obj.DModel, DKKS = obj.DKKS, DArea = obj.DArea, DStatus = obj.DStatus, StartDate = obj.StartDate, Manufacturer = obj.Manufacturer, Provider = obj.Provider, DRemark = obj.DRemark });
                    return db.Query<Device>("pr_Device_GetData ", commandType: CommandType.StoredProcedure).ToList();

                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public int Insert(Device obj)
        {
            using (IDbConnection db = new SqlConnection(DBHelper.ConnectionString))
            {
                try
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();

                    }
                    DynamicParameters p = new DynamicParameters();
                    p.Add("DId", dbType: DbType.Int32, direction: ParameterDirection.Output);
                    ////DId, DNameCN, DNameEN, DType, DModel, DKKS, DArea, DStatus, StartDate, Manufacturer, Provider, DRemark
                    p.AddDynamicParams(new { DNameCN = obj.DNameCN, DNameEN = obj.DNameEN, DType = obj.DType, DModel = obj.DModel, DKKS = obj.DKKS, DArea = obj.DArea, DStatus=obj.DStatus, StartDate=obj.StartDate,Manufacturer = obj.Manufacturer, Provider = obj.Provider, DRemark = obj.DRemark });
                    return db.Execute("pr_Device_Insert", p, commandType: CommandType.StoredProcedure);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public int Update(Device obj)
        {
            using (IDbConnection db = new SqlConnection(DBHelper.ConnectionString))
            {
                try
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();

                    }
                    DynamicParameters p = new DynamicParameters();
                    p.AddDynamicParams(new { DId = obj.DId, DNameCN = obj.DNameCN, DNameEN = obj.DNameEN, DType = obj.DType, DModel = obj.DModel, DKKS = obj.DKKS, DArea = obj.DArea, DStatus = obj.DStatus, StartDate = obj.StartDate, Manufacturer = obj.Manufacturer, Provider = obj.Provider, DRemark = obj.DRemark });
                    return db.Execute("pr_Device_Update", p, commandType: CommandType.StoredProcedure);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
