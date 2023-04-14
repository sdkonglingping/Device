using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class PartDAL : IModel<Part>
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

                p.AddDynamicParams(new { PId = id });
                try
                {
                    return db.Execute("pr_Part_Delete", p, commandType: CommandType.StoredProcedure);
                }
                catch (Exception)
                {

                    return -1;
                }


            }
        }

        public List<Part> GetAll(string[] filter)
        {
            using (IDbConnection db = new SqlConnection(DBHelper.ConnectionString))//"server=.;database=DeviceDB;uid=sa;pwd=123"
            {
                try
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();
                    }
                    return db.Query<Part>("pr_Part_GetData", commandType: CommandType.StoredProcedure).ToList();

                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public List<Part> GetDataByFilter<M>(M filter)
        {
            throw new NotImplementedException();
        }

        public int Insert(Part obj)
        {
            using (IDbConnection db = new SqlConnection("server=.;database=eleDB;uid=sa;pwd=123"))
            {
                try
                {
                    if (db.State == ConnectionState.Closed)
                    {
                        db.Open();

                    }
                    DynamicParameters p = new DynamicParameters();
                    p.Add("PId", dbType: DbType.Int32, direction: ParameterDirection.Output);
                    ////DId, DNameCN, DNameEN, DType, DModel, DKKS, DArea, DStatus, StartDate, Manufacturer, Provider, DRemark
                    p.AddDynamicParams(new { PNameCN = obj.PNameCN, PNameEN = obj.PNameEN, PKKS = obj.PKKS, PModel = obj.PModel, Lifecycle = obj.Lifecycle, Manufacturer = obj.Manufacturer, Provider = obj.Provider, PRemark = obj.PRemark });
                    return db.Execute("pr_Part_Insert", p, commandType: CommandType.StoredProcedure);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public int Update(Part obj)
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
                    p.AddDynamicParams(new { PId = obj.PId, PNameCN = obj.PNameCN, PNameEN = obj.PNameEN, PKKS = obj.PKKS, PModel = obj.PModel, Lifecycle = obj.Lifecycle, Manufacturer = obj.Manufacturer, Provider = obj.Provider, PRemark = obj.PRemark });
                    return db.Execute("pr_Part_Update", p, commandType: CommandType.StoredProcedure);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
    }

