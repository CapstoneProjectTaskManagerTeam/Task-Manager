using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using WCFServices.BusinessLogicLayer.SupportServices;

namespace WCFServices.DataAccessLayer.SQLDatabaseAccessServices
{
    public class Logs
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        public int InsertLog(Log log)
        {
            try
            {
                con.Open();
                string query = "INSERT INTO Logs " +
                                       "(Time " +
                                       ",TAG " +
                                       ",Method " +
                                       ",Type " +
                                       ",Description)" +
                                 "VALUES " +
                                       "(@Time " +
                                       ",@TAG " +
                                       ",@Method " +
                                       ",@Type " +
                                       ",@Description)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Time", log.Time);
                cmd.Parameters.AddWithValue("@TAG", log.TAG);
                cmd.Parameters.AddWithValue("@Method", log.Method);
                cmd.Parameters.AddWithValue("@Type", log.Type);
                cmd.Parameters.AddWithValue("@Description", log.Description);

                return cmd.ExecuteNonQuery();
            }
            catch (SqlException i)
            {
                return 0;
            }
            catch (Exception i)
            {
                return 0;
            }
            finally
            {
                con.Close();
            }
        }
    }
}