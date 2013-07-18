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
    public class JoinProjects
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        public DataTable SelectJoinProject(Member member)
        {
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                string query = "SELECT * " +
                               "FROM JoinProjects " +
                               "WHERE JoinProjectID = @JoinProjectID OR ProjectID = @ProjectID OR UserID = @UserID OR RoleID = @RoleID";
                cmd = new SqlCommand(query, con); 
                cmd.Parameters.AddWithValue("@JoinProjectID", member.JoinProjectID);
                cmd.Parameters.AddWithValue("@ProjectID", member.ProjectID);
                cmd.Parameters.AddWithValue("@UserID", member.UserID);
                cmd.Parameters.AddWithValue("@RoleID", member.RoleID);

                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "JoinProjects");
                DataTable dt = ds.Tables["JoinProjects"];
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

        public int InsertJoinProject(Member member)
        {
            try
            {
                con.Open();
                string query = "INSERT INTO JoinProjects " +
                                       "(ProjectID " +
                                       ",UserID " +
                                       ",RoleID) " +
                                 "VALUES " +
                                       "(@ProjectID " +
                                       ",@UserID " +
                                       ",@RoleID)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ProjectID", member.ProjectID);
                cmd.Parameters.AddWithValue("@UserID", member.UserID);
                cmd.Parameters.AddWithValue("@RoleID", member.RoleID);

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

        public int DeleteJoinProject(Member member)
        {
            try
            {
                con.Open();
                string query = "DELETE FROM JoinProjects " +
                               "WHERE JoineProjectID = @JoinProjectID OR UserID = @UserID OR ProjectID = @ProjectID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@JoinProjectID", member.JoinProjectID);
                cmd.Parameters.AddWithValue("@UserID", member.UserID);
                cmd.Parameters.AddWithValue("@ProjectID", member.ProjectID);

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