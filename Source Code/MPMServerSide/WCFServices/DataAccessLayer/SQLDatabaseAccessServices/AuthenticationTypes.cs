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
    public class AuthenticationTypes
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        public DataTable SelectAuthenticationType(string authenticationTypeId)
        {
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                string query = "SELECT * " +
                               "FROM AuthenticationTypes " +
                               "WHERE AuthenticationTypeID = @AuthenticationTypeID";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@AuthenticationTypeID", authenticationTypeId);
 
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "AuthenticationTypes");
                DataTable dt = ds.Tables["AuthenticationTypes"];
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