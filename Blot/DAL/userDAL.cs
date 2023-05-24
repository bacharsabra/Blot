using Blot.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blot.DAL
{
    class userDAL
    {
        //Connect DB
        static string myConnStr = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;

        #region
        public bool Insert(userBLL u)
        {
            //Bool var with default value=false
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myConnStr);

            try
            {
                //str var for insertion
                String sql = "Insert into Table_Users(Full_Name, Username, Email, Password) values(@Full_Name, @Username, @Email, @Password) ";

                //Passing the value
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Params to pass values from GUI to query
                
                cmd.Parameters.AddWithValue("@Full_Name", u.Full_Name);
                cmd.Parameters.AddWithValue("@Username", u.Username);
                cmd.Parameters.AddWithValue("@Email", u.Email);
                cmd.Parameters.AddWithValue("@Password", u.Password);

                conn.Open();

                //int var to hold values after execution
                int rows = cmd.ExecuteNonQuery();

                //Query execution is successful if row values > 0
                if (rows > 0)
                {
                    isSuccess = true;

                }

                else
                {
                    isSuccess = false;

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            finally
            {
                conn.Close();

            }
            return isSuccess;
            #endregion
        }

        #region
        public bool registeredCheck(userBLL u)
        {
            bool isSuccess = false;
            //Connnection DB
            SqlConnection conn = new SqlConnection(myConnStr);

            try
            {
                //Check register via username and password
                string sql = "Select * from Table_Users where Full_Name=@Full_Name AND Username=@Username AND Email=@Email AND Password=@Password";

                //Executing the query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Passing values from GUI to DB
                cmd.Parameters.AddWithValue("@Full_Name", u.Full_Name);
                cmd.Parameters.AddWithValue("@Username", u.Username);
                cmd.Parameters.AddWithValue("@Email", u.Email);
                cmd.Parameters.AddWithValue("@Password", u.Password);

                //Get data from DB
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //Holding data from DB
                DataTable dt = new DataTable();

                //Fills the DT with data
                adapter.Fill(dt);

                //Check if user exists
                if (dt.Rows.Count > 0)
                {
                    isSuccess = true;

                }
                else
                {
                    isSuccess = false;

                }

            }
            catch (Exception ex)
            {
                //Display error message
                MessageBox.Show(ex.Message);

            }
            finally
            {
                //Close connection
                conn.Close();

            }
            return isSuccess;
        }
        #endregion

        #region Get ID of logged in user
        public userBLL GetIDFromUsername(string username)
            {
                userBLL u = new userBLL();

                SqlConnection conn = new SqlConnection(myConnStr);

                DataTable dt = new DataTable();
                try
                {

                    String sql = "Select User_ID from Table_Users where  Username='" + username + "'";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    conn.Open();

                    adapter.Fill(dt);

                    //Get ID based on the username
                    if (dt.Rows.Count > 0)
                    {
                        u.User_ID = int.Parse(dt.Rows[0]["User_ID"].ToString()); ;

                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

                finally
                {
                    conn.Close();

                }
                return u;
            }
            #endregion
        }
    }