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
    class receiverDAL
    {
        //Connecting DB using static string
        static string myConnStr = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;

        #region Select data from DB
        public DataTable Select()
        {
            //Object to connect DB
            SqlConnection conn = new SqlConnection(myConnStr);

            //DataTable to hold data from DB
            DataTable dt = new DataTable();


            //Exception handling
            try
            {
                //Getting data from DB
                String sql = "Select Receiver_ID, Full_Name, Email, Phone, Address, Gender, Blood_Type, Added_Date, Image_Name from Table_Receivers";

                //Executing query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Temporarily holding data from DB
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //Open DB connection
                conn.Open();

                Console.WriteLine(adapter);

                //Transfering data to DataTable
                adapter.Fill(dt);
            }

            catch(Exception ex)
            {
                //Displaying error message
                MessageBox.Show(ex.Message);

            }

            finally
            {
                //Closing DB connection
                conn.Close();

            }
            return dt;
        }
        #endregion

        #region Insert data into DB
        public bool Insert(receiverBLL u)
        {
            //Bool var with default value=false
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myConnStr);

            try
            {
                //str var for insertion
                String sql = "Insert into Table_Receivers(Full_Name, Email, Phone, Address, Gender, Blood_Type, Added_Date, Image_Name) values(@Full_Name, @Email, @Phone, @Address, @Gender, @Blood_Type, @Added_Date, @Image_Name) ";

                //Passing the value
                SqlCommand cmd=new SqlCommand(sql, conn);

                //Params to pass values from GUI to query
                cmd.Parameters.AddWithValue("@Full_Name", u.Full_Name);
                cmd.Parameters.AddWithValue("@Email", u.Email);
                cmd.Parameters.AddWithValue("@Phone", u.Phone);
                cmd.Parameters.AddWithValue("@Address", u.Address);
                cmd.Parameters.AddWithValue("@Gender", u.Gender);
                cmd.Parameters.AddWithValue("@Blood_Type", u.Blood_Type);
                cmd.Parameters.AddWithValue("@Added_Date", u.Added_Date);
                cmd.Parameters.AddWithValue("@Image_Name", u.Image_Name);

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
        }
        #endregion

        #region Update data in DB
        public bool Update(receiverBLL u)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myConnStr);

            try
            {

                String sql = "Update Table_Receivers SET Full_Name=@Full_Name, Email=@Email, Phone=@Phone, Address=@Address, Gender=@Gender, Blood_Type=@Blood_Type, Added_Date=@Added_Date, Image_Name=@Image_Name where Receiver_ID=@Receiver_ID";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Full_Name", u.Full_Name);
                cmd.Parameters.AddWithValue("@Email", u.Email);
                cmd.Parameters.AddWithValue("@Phone", u.Phone);
                cmd.Parameters.AddWithValue("@Address", u.Address);
                cmd.Parameters.AddWithValue("@Gender", u.Gender);
                cmd.Parameters.AddWithValue("@Blood_Type", u.Blood_Type);
                cmd.Parameters.AddWithValue("@Added_Date", u.Added_Date);
                cmd.Parameters.AddWithValue("@Image_Name", u.Image_Name);
                cmd.Parameters.AddWithValue("@Receiver_ID", u.Receiver_ID);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

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
        }
        #endregion

        #region Delete data from DB
        public bool Delete(receiverBLL u)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myConnStr);

            try
            {

                String sql = "Delete from Table_Receivers where Receiver_ID=@Receiver_ID";

                SqlCommand cmd = new SqlCommand(sql, conn);

                conn.Open();

                cmd.Parameters.AddWithValue("@Receiver_ID", u.Receiver_ID);

                int rows = cmd.ExecuteNonQuery();

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
        }
        #endregion

        #region Search
        public DataTable Search(string keywords)
        {
            SqlConnection conn = new SqlConnection(myConnStr);

            DataTable dt = new DataTable();

            try
            {

                String sql = "Select * from Table_Receivers where Full_Name LIKE '%" + keywords + "%' or Address LIKE '%" + keywords + "%' or Added_Date LIKE '%" + keywords + "%' or Gender LIKE '%" + keywords + "%' or Blood_Type LIKE '%" + keywords + "%'";

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();

                adapter.Fill(dt);
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            finally
            {
                conn.Close();

            }
            return dt;
        }
        #endregion
    }
}
