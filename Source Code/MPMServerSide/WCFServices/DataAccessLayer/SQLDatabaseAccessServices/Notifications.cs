using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using WCFServices.BusinessLogicLayer.MessageNotificationServices;
using WCFServices.BusinessLogicLayer.SupportServices;

namespace WCFServices.DataAccessLayer.SQLDatabaseAccessServices
{
    public class Notifications
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        public DataTable SelectNotifiction(Notification notification)
        {
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                string query = "SELECT * " +
                               "FROM Notifications " +
                               "WHERE NotificationID = @NotificationID OR UserID = @UserID";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@NotificationID", notification.NotificationID);
                cmd.Parameters.AddWithValue("@UserID", notification.UserID);

                da = new SqlDataAdapter(cmd);
                ds = new DataSet(); 
                da.Fill(ds, "Notifications");
                DataTable dt = ds.Tables["Notifications"];
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

        public int InsertNotification(Notification notification)
        {
            try
            {
                con.Open();
                string query = "INSERT INTO Notifications " +
                                       "(UserID " +
                                       ",Content) " +
                                 "VALUES " +
                                       "(@UserID " +
                                       ",@Content)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UserID", notification.UserID);
                cmd.Parameters.AddWithValue("@Content", notification.Content);

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

        public int DeleteNotification(Notification notification)
        {
            try
            {
                con.Open();
                string query = "DELETE FROM Notifications " +
                               "WHERE NotificationID = @NotificationID OR UserID = @UserID ";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@NotificationID", notification.NotificationID);
                cmd.Parameters.AddWithValue("@UserID", notification.UserID);

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