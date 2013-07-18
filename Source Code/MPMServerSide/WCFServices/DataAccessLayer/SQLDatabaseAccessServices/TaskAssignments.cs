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
    public class TaskAssignments
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        public DataTable SelectTaskAssignment(TaskAssignmnet taskAssignment)
        {
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                string query = "SELECT * " +
                               "FROM TaskAssignments " +
                               "WHERE TaskAssignmentID = @TaskAssignmentID OR UserID = @UserID OR TaskID = @TaskID";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@TaskAssignmentID", taskAssignment.TaskAssignmentID);
                cmd.Parameters.AddWithValue("@UserID", taskAssignment.UserID);
                cmd.Parameters.AddWithValue("@TaskID", taskAssignment.TaskID);

                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "TaskAssignments");
                DataTable dt = ds.Tables["TaskAssignments"];
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

        public int InsertTaskAssignmnet(TaskAssignmnet taskAssignment)
        {
            try
            {
                con.Open();
                string query = "INSERT INTO TaskAssignments " +
                                       "(UserID " +
                                       ",TaskID) " +
                                 "VALUES " +
                                       "(@UserID " +
                                       ",@TaskID)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UserID", taskAssignment.UserID);
                cmd.Parameters.AddWithValue("@TaskID", taskAssignment.TaskID);

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

        public int DeleteTaskAssignmnet(TaskAssignmnet taskAssignment)
        {
            try
            {
                con.Open();
                string query = "DELETE FROM TaskAssignments "
                                     + "WHERE TaskAssignmentID = @TaskAssignmentID OR User = @UserID OR TaskID = @TaskID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@TaskAssignmentID", taskAssignment.TaskAssignmentID);
                cmd.Parameters.AddWithValue("@UserID", taskAssignment.UserID);
                cmd.Parameters.AddWithValue("@TaskID", taskAssignment.TaskID);

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