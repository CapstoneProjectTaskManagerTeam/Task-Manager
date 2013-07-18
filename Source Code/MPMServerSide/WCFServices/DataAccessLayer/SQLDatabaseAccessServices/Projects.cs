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
    public class Projects
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        public DataTable SelectProject(Project project)
        {
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                string query = "SELECT * " +
                               "FROM Projects " +
                               "WHERE ProjectID = @ProjectID OR ProjectName = @ProjectName OR OwnerUser = @OwnerUser";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ProjectID", project.ProjectID);
                cmd.Parameters.AddWithValue("@ProjectName", project.ProjectName);
                cmd.Parameters.AddWithValue("@OwnerUser", project.OwnerUser);

                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "Projects");
                DataTable dt = ds.Tables["Projects"];
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

        public int InsertProject(Project project)
        {
            try
            {
                con.Open();
                string query = "INSERT INTO Projects " +
                                       "(ProjectName " +
                                       ",Description " +
                                       ",OwnerUser " +
                                       ",StartDate " +
                                       ",DueDate) " +
                                 "VALUES " +
                                       "(@ProjectName " +
                                       ",@Description " +
                                       ",@OwnerUser " +
                                       ",@StartDate " +
                                       ",@DueDate)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ProjectName", project.ProjectName);
                cmd.Parameters.AddWithValue("@Description", project.Description);
                cmd.Parameters.AddWithValue("@OwnerUser", project.OwnerUser);
                cmd.Parameters.AddWithValue("@StartDate", project.StartDate);
                cmd.Parameters.AddWithValue("@DueDate", project.DueDate);

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

        public int UpdateProject(Project project)
        {
            try
            {
                con.Open();
                string query =  "UPDATE Projects " +
                                   "SET ProjectName = @ProjectName " +
                                      ",Description = @Description " +
                                      ",OwnerUser = @OwnerUser " +
                                      ",StartDate = @StartDate " +
                                      ",DueDate = @DueDate " +
                                 "WHERE ProjectID = @ProjectID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ProjectID", project.ProjectID);
                cmd.Parameters.AddWithValue("@ProjectName", project.ProjectName);
                cmd.Parameters.AddWithValue("@Description", project.Description);
                cmd.Parameters.AddWithValue("@OwnerUser", project.OwnerUser);
                cmd.Parameters.AddWithValue("@StartDate", project.StartDate);
                cmd.Parameters.AddWithValue("@DueDate", project.DueDate);


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

        public int DeleteProject(Project project)
        {
            try
            {
                con.Open();
                string query = "DELETE FROM Projects "
                                     + "WHERE ProjectID = @ProjectID OR ProjectName = @ProjectName OR OwnerUser = @OwnerUser";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ProjectID", project.ProjectID);
                cmd.Parameters.AddWithValue("@ProjectName", project.ProjectName);
                cmd.Parameters.AddWithValue("@OwnerUser", project.OwnerUser);

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