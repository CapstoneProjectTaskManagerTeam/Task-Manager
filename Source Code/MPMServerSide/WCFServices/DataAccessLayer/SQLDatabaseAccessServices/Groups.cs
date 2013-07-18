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
    public class Groups
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        public DataTable SelectGroup(int groupId, string lowercase, string uppercase)
        {
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                string query = "SELECT * " +
                               "FROM Groups " +
                               "WHERE GroupID = @GroupID OR Lowercase = @Lowercase OR Uppercase = Uppercase";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@GroupID", groupId);
                cmd.Parameters.AddWithValue("@Lowercase", lowercase);
                cmd.Parameters.AddWithValue("@Uppercase", uppercase);

                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "Groups");
                DataTable dt = ds.Tables["Groups"];
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