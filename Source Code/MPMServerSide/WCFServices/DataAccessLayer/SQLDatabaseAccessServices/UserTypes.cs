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
    public class UserTypes
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        public DataTable SelectUserType(string userTypeId)
        {
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                string query = "SELECT * " +
                               "FROM UserTypes " +
                               "WHERE UserTypeID = @UserTypeID";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UserTypeID", userTypeId);

                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "UserTypes");
                DataTable dt = ds.Tables["UserTypes"];
                return dt;

            }
            catch (SqlException i)
            {
                Logs logging = new Logs();
                logging.InsertLog(new Log());
                return null;
            }
            catch (Exception i)
            {
                Logs logging = new Logs();
                logging.InsertLog(new Log());
                return null;
            }
            finally
            {
                con.Close();
            }
        }
    }
}