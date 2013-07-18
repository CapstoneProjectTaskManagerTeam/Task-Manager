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
    public class Messages
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        public DataTable SelectMessage(Message message)
        {
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                string query = "SELECT * " +
                               "FROM Messages " +
                               "WHERE MessageID = @MessageID OR Sender = @Sender OR Receiver = @Receiver ";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@MessageID", message.MessageID);
                cmd.Parameters.AddWithValue("@Sender", message.Sender);
                cmd.Parameters.AddWithValue("@Receiver", message.Receiver);

                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "Messages");
                DataTable dt = ds.Tables["Messages"];
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

        public int InsertMessage(Message message)
        {
            try
            {
                con.Open();
                string query = "INSERT INTO Messages " +
                                       "(Sender " +
                                       ",Receiver " +
                                       ",Content) " +
                                 "VALUES " +
                                       "(@Sender " +
                                       ",@Receiver " +
                                       ",@Content)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Sender", message.Sender);
                cmd.Parameters.AddWithValue("@Receiver", message.Receiver);
                cmd.Parameters.AddWithValue("@Content", message.Content);

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

        public int DeleteMessage(Message message)
        {
            try
            {
                con.Open();
                string query = "DELETE FROM Messages " +
                               "WHERE MessageID = @MessageID OR Sender = @Sender OR Receiver = @Receiver ";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@MessageID", message.MessageID);
                cmd.Parameters.AddWithValue("@Sender", message.Sender);
                cmd.Parameters.AddWithValue("@Receiver", message.Receiver);

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