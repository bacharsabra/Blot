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
    class loginDAL
    {
        //Connect DB
        static string myConnStr = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;

        public bool loginCheck(loginBLL l)
        {
            bool isSuccess = false;
            //Connnection DB
            SqlConnection conn = new SqlConnection(myConnStr);

            try
            {
                //Check login via username and password
                string sql = "Select * from Table_Users where Username=@Username AND Password=@Password";

                //Executing the query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Passing values from GUI to DB
                cmd.Parameters.AddWithValue("@Username", l.Username);
                cmd.Parameters.AddWithValue("@Password", l.Password);

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
            catch(Exception ex)
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
    }
}
