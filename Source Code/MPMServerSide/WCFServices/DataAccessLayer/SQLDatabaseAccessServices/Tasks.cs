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
    public class Tasks
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        public DataTable SelectTask(Task task)
        {
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                string query = "SELECT * " +
                               "FROM Tasks " +
                               "WHERE TaskID = @TaskID OR TaskName = @TaskName OR StateID = @StateID OR " +
                                     "ProjectID = @ProjectID";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@TaskID", task.TaskID);
                cmd.Parameters.AddWithValue("@TaskName", task.TaskName);
                cmd.Parameters.AddWithValue("@StateID", task.StateID);
                cmd.Parameters.AddWithValue("@ProjectID", task.ProjectID);

                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "Tasks");
                DataTable dt = ds.Tables["Tasks"];
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

        public int InsertTask(Task task)
        {
            try
            {
                con.Open();
                string query = "INSERT Tasks " +
                                       "(TaskName, " +
                                        "Description, " +
                                        "StateID, " +
                                        "ProjectID, " +
                                        "Comments, " +
                                        "Status, " +
                                        "StartDate, " +
                                        "DueDate)" +
                                    "VALUES " +
                                       "(@TaskName, " +
                                        "@Description, " +
                                        "@StateID, " +
                                        "@ProjectID, " +
                                        "@Comments, " +
                                        "@Status, " +
                                        "@StartDate, " +
                                        "@DueDate)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@TaskName", task.TaskName);
                cmd.Parameters.AddWithValue("@Description", task.Description);
                cmd.Parameters.AddWithValue("@StateID", task.StateID);
                cmd.Parameters.AddWithValue("@ProjectID", task.ProjectID);
                cmd.Parameters.AddWithValue("@Comments", task.Comments);
                cmd.Parameters.AddWithValue("@Status", task.Status);
                cmd.Parameters.AddWithValue("@StartDate", task.StartDate);
                cmd.Parameters.AddWithValue("@DueDate", task.DueDate);

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

        public int UpdateTask(Task task)
        {
            try
            {
                con.Open();
                string query = "UPDATE Tasks " +
                                   "SET TaskName = @TaskName, " +
                                       "Description = @Description, " +
                                       "StateID = @StateID, " +
                                       "ProjectID = @ProjectID, " +
                                       "Comments = @Comments " +
                                       "Status = @Status" +
                                       "StartDate = @StartDate, " +
                                       "DueDate = @DueDate)" +
                                "WHERE TaskID = @TaskID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@TaskID", task.TaskID);
                cmd.Parameters.AddWithValue("@TaskName", task.TaskName);
                cmd.Parameters.AddWithValue("@Description", task.Description);
                cmd.Parameters.AddWithValue("@StateID", task.StateID);
                cmd.Parameters.AddWithValue("@ProjectID", task.ProjectID);
                cmd.Parameters.AddWithValue("@Comments", task.Comments);
                cmd.Parameters.AddWithValue("@Status", task.Status);
                cmd.Parameters.AddWithValue("@StartDate", task.StartDate);
                cmd.Parameters.AddWithValue("@DueDate", task.DueDate);

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

        public int DeleteTask(Task task)
        {
            try
            {
                con.Open();
                string query = "DELETE FROM Tasks "
                                     + "WHERE TaskID = @TaskID OR StateID = @StateID OR ProjectID = @ProjectID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@TaskID", task.TaskID);
                cmd.Parameters.AddWithValue("@StateID", task.StateID);
                cmd.Parameters.AddWithValue("@ProjectID", task.ProjectID);

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