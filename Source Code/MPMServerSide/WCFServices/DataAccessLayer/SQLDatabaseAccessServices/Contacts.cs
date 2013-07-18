using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using WCFServices.BusinessLogicLayer.UserManagementServices;
using WCFServices.BusinessLogicLayer.SupportServices;

namespace WCFServices.DataAccessLayer.SQLDatabaseAccessServices
{
    public class Contacts
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        public DataTable SelectContact(Contact contact)
        {
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                string query = "SELECT * " +
                               "FROM Contacts "+
                               "WHERE ContactID = @ContactID OR User01 = @User01 OR User02 = @User02";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ContactID", contact.ContactId);
                cmd.Parameters.AddWithValue("@User01", contact.User01);
                cmd.Parameters.AddWithValue("@User02", contact.User02);

                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "Contacts");
                DataTable dt = ds.Tables["Contacts"];
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

        public int InsertContact(Contact contact)
        {
            try
            {
                con.Open();
                string query = "INSERT INTO Contacts " +
                                       "(User01 " +
                                       ",User02) "+
                                 "VALUES " +
                                       "(@User01 " +
                                       ",@User02)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@User01", contact.User01);
                cmd.Parameters.AddWithValue("@User02", contact.User02);

                return cmd.ExecuteNonQuery();
            }
            catch (SqlException i)
            {
                Logs logging = new Logs();
                logging.InsertLog(new Log());
                return 0;
            }
            catch (Exception i)
            {
                Logs logging = new Logs();
                logging.InsertLog(new Log());
                return 0;
            }
            finally
            {
                con.Close();
            }
        }

        public int DeleteContact(Contact contact)
        {
            try
            {
                con.Open();
                string query = "DELETE FROM Contacts " +
                               "WHERE ContactID = @ContactID OR User01 = @User01 OR User02 = @User02";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ContactID", contact.ContactId);
                cmd.Parameters.AddWithValue("@User01", contact.User01);
                cmd.Parameters.AddWithValue("@User02", contact.User02);

                return cmd.ExecuteNonQuery();
            }
            catch (SqlException i)
            {
                Logs logging = new Logs();
                logging.InsertLog(new Log());
                return 0;
            }
            catch (Exception i)
            {
                Logs logging = new Logs();
                logging.InsertLog(new Log());
                return 0;
            }
            finally
            {
                con.Close();
            }
        }
    }
}