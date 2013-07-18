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
    public class States
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        public DataTable SelectState(State state)
        {
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                string query = "SELECT * " +
                               "FROM States " +
                               "WHERE StateID = @StateID OR StateName = @StateName OR ProjectID = @ProjectID";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@StateID", state.StateID);
                cmd.Parameters.AddWithValue("@StateName", state.StateName);
                cmd.Parameters.AddWithValue("@ProjectID", state.ProjectID);

                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "States");
                DataTable dt = ds.Tables["States"];
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

        public int InsertState(State state)
        {
            try
            {
                con.Open();
                string query = "INSERT INTO States " +
                                       "(StateName " +
                                       ",Description " +
                                       ",ProjectID " +
                                       ",NextState " +
                                       ",StartDate " +
                                       ",DueDate) " +
                                 "VALUES " +
                                       "(@StateName " +
                                       ",@Description " +
                                       ",@ProjectID " +
                                       ",@NextState " +
                                       ",@StartDate " +
                                       ",@DueDate)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@StateName", state.StateName);
                cmd.Parameters.AddWithValue("@Description", state.Description);
                cmd.Parameters.AddWithValue("@ProjectID", state.ProjectID);
                cmd.Parameters.AddWithValue("@NextState", state.NextState);
                cmd.Parameters.AddWithValue("@StartDate", state.StartDate);
                cmd.Parameters.AddWithValue("@DueDate", state.DueDate);

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

        public int UpdateState(State state)
        {
            try
            {
                con.Open();
                string query = "UPDATE States " +
                                  "SET StateName = @StateName " +
                                     ",Description = @Description " +
                                     ",ProjectID = @ProjectID " +
                                     ",NextState = @NextState " +
                                     ",StartDate = @StartDate " +
                                     ",DueDate = @DueDate " +
                                "WHERE StateID = @StateID" ;

                SqlCommand cmd = new SqlCommand(query, con);
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@StateID", state.StateID);
                cmd.Parameters.AddWithValue("@StateName", state.StateName);
                cmd.Parameters.AddWithValue("@Description", state.Description);
                cmd.Parameters.AddWithValue("@ProjectID", state.ProjectID);
                cmd.Parameters.AddWithValue("@NextState", state.NextState);
                cmd.Parameters.AddWithValue("@StartDate", state.StartDate);
                cmd.Parameters.AddWithValue("@DueDate", state.DueDate);

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

        public int DeleteState(State state)
        {
            try
            {
                con.Open();
                string query = "DELETE FROM States "
                                     + "WHERE StateID = @StateID OR StateName = @StateName OR ProjectID = @ProjectID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@StateID", state.StateID);
                cmd.Parameters.AddWithValue("@StateName", state.StateName);
                cmd.Parameters.AddWithValue("@ProjectID", state.ProjectID);

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