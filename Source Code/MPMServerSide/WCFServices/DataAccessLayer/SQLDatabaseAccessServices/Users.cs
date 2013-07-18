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
    public class Users
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        public DataTable SelectUser(User user)
        {
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                string query = "SELECT * " +
                               "FROM USers " +
                               "WHERE UserID = @UserID OR Name = @Name OR GroupID = @GroupID OR " +
                               "Email = @Email OR Password = @Password";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UserID", user.UserID);
                cmd.Parameters.AddWithValue("@Name", user.Name);
                cmd.Parameters.AddWithValue("@GroupID", user.GroupID);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@Password", user.Password);

                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "Users");
                DataTable dt = ds.Tables["Users"];
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

        public int InsertUser(User user)
        {
            try
            {
                con.Open();
                string query = "INSERT Users " +
                                       "(Name, " +
                                        "GroupID, " +
                                        "Email, " +
                                        "Password, " +
                                        "Avatar, " +
                                        "UserTypeId, " +
                                        "GenderID, " +
                                        "AuthenticationTypeID)" +
                                    "VALUES " +
                                       "(@Name, " +
                                        "@GroupID, " +
                                        "@Email, " +
                                        "@Password, " +
                                        "@Avatar, " +
                                        "@UserTypeId, " +
                                        "@GenderID, " +
                                        "@AuthenticationTypeID)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UserID", user.UserID);
                cmd.Parameters.AddWithValue("@Name", user.Name);
                cmd.Parameters.AddWithValue("@GroupID", user.GroupID);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@Avatar", user.Avatar);
                cmd.Parameters.AddWithValue("@UserTypeID", user.UserTypeID);
                cmd.Parameters.AddWithValue("@AuthenticationTypeID", user.AuthenticationTypeID);

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

        public int UpdateUser(User user)
        {
            try
            {
                con.Open();
                string query = "UPDATE Users " +
                                  "SET Name = @Name, " +
                                      "Group = @GroupID, " +
                                      "Email = @Email, " +
                                      "Password = @Password, " +
                                      "Avatar = @Avatar, " +
                                      "UserTypeID = @UserTypeId, " +
                                      "GenderID = @GenderID, " +
                                      "AuthenticationTypeID = @AuthenticationTypeID " +
                                "WHERE UserID = @UserID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UserID", user.UserID);
                cmd.Parameters.AddWithValue("@Name", user.Name);
                cmd.Parameters.AddWithValue("@GroupID", user.GroupID);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@Avatar", user.Avatar);
                cmd.Parameters.AddWithValue("@UserTypeID", user.UserTypeID);
                cmd.Parameters.AddWithValue("@AuthenticationTypeID", user.AuthenticationTypeID);

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

        public int DeleteUser(User user)
        {
            try
            {
                con.Open();
                string query = "DELETE FROM Users "
                                     + "WHERE UserID = @UserID OR Email = @Email";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UserID", user.UserID);
                cmd.Parameters.AddWithValue("@Email", user.Email);

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