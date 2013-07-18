using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using WCFServices.BusinessLogicLayer.ProjectManagementServices;
using WCFServices.BusinessLogicLayer.SupportServices;

namespace WCFServices.DataAccessLayer.SQLDatabaseAccessServices
{
    public class Comments
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        public DataTable SelectComment(Comment comment)
        {
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                string query = "SELECT * " +
                               "FROM Comments " +
                               "WHERE CommentID = @CommentID OR UserID = @UserID OR TaskID = @TaskID";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@CommentID", comment.CommentID);
                cmd.Parameters.AddWithValue("@UserID", comment.UserID);
                cmd.Parameters.AddWithValue("@TaskID", comment.TaskID);

                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "Comments");
                DataTable dt = ds.Tables["Comments"];
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

        public int InsertComment(Comment comment)
        {
            try
            {
                con.Open();
                string query = "INSERT INTO Comments " +
                                       "(Content " +
                                       ",UserID " +
                                       ",TaskID) " +
                                 "VALUES " +
                                       "(@Content " +
                                       ",@UserID " +
                                       ",@TaskID )";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Content", comment.Content);
                cmd.Parameters.AddWithValue("@UserID", comment.UserID);
                cmd.Parameters.AddWithValue("@TaskID", comment.TaskID);

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

        public int DeleteComment(Comment comment)
        {
            try
            {
                con.Open();
                string query = "DELETE FROM Comments " +
                               "WHERE CommentID = @CommentID OR UserID = @UserID OR TaskID = @TaskID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@CommentID", comment.CommentID);
                cmd.Parameters.AddWithValue("@UserID", comment.UserID);
                cmd.Parameters.AddWithValue("@TaskID", comment.TaskID);

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