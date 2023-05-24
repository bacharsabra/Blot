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
    class donorDAL
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
                String sql = "Select Donor_ID, Full_Name, Email, Phone, Address, Gender, Blood_Type, Added_Date, Added_By, Image_Name from Table_Donors";

                //Executing query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Temporarily holding data from DB
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //Open DB connection
                conn.Open();

                //Transfering data to DataTable
                adapter.Fill(dt);
            }

            catch (Exception ex)
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
        public bool Insert(donorBLL d)
        {
            //Bool var with default value=false
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myConnStr);

            try
            {
                //str var for insertion
                String sql = "Insert into Table_Donors(Full_Name, Email, Phone, Address, Gender, Blood_Type, Added_Date, Image_Name, Added_By) values(@Full_Name, @Email, @Phone, @Address, @Gender, @Blood_Type, @Added_Date, @Image_Name, @Added_By) ";

                //Passing the value
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Params to pass values from GUI to query
                cmd.Parameters.AddWithValue("@Full_Name", d.Full_Name);
                cmd.Parameters.AddWithValue("@Email", d.Email);
                cmd.Parameters.AddWithValue("@Phone", d.Phone);
                cmd.Parameters.AddWithValue("@Address", d.Address);
                cmd.Parameters.AddWithValue("@Gender", d.Gender);
                cmd.Parameters.AddWithValue("@Blood_Type", d.Blood_Type);
                cmd.Parameters.AddWithValue("@Added_Date", d.Added_Date);
                cmd.Parameters.AddWithValue("@Image_Name", d.Image_Name);
                cmd.Parameters.AddWithValue("@Added_By", d.Added_By);

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
        public bool Update(donorBLL d)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myConnStr);

            try
            {
                String sql = "Update Table_Donors SET Full_Name=@Full_Name, Email=@Email, Phone=@Phone, Address=@Address, Gender=@Gender, Blood_Type=@Blood_Type, Added_Date=@Added_Date, Image_Name=@Image_Name, Added_By=@Added_By where Donor_ID=@Donor_ID";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Full_Name", d.Full_Name);
                cmd.Parameters.AddWithValue("@Email", d.Email);
                cmd.Parameters.AddWithValue("@Phone", d.Phone);
                cmd.Parameters.AddWithValue("@Address", d.Address);
                cmd.Parameters.AddWithValue("@Gender", d.Gender);
                cmd.Parameters.AddWithValue("@Blood_Type", d.Blood_Type);
                cmd.Parameters.AddWithValue("@Added_Date", d.Added_Date);
                cmd.Parameters.AddWithValue("@Image_Name", d.Image_Name);
                cmd.Parameters.AddWithValue("@Added_By", d.Added_By);
                cmd.Parameters.AddWithValue("@Donor_ID", d.Donor_ID);

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
        public bool Delete(donorBLL d)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myConnStr);

            try
            {
                String sql = "Delete from Table_Donors where Donor_ID=@Donor_ID";

                SqlCommand cmd = new SqlCommand(sql, conn);

                conn.Open();

                cmd.Parameters.AddWithValue("@Donor_ID", d.Donor_ID);

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
                String sql = "Select * from Table_Donors where Full_Name LIKE '%" + keywords + "%' or Address LIKE '%" + keywords + "%' or Added_Date LIKE '%" + keywords + "%' or Gender LIKE '%" + keywords + "%' or Blood_Type LIKE '%" + keywords + "%'";

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

        #region Donor count per blood group
        public string countDonors(string Blood_Type)
        {
            SqlConnection conn = new SqlConnection(myConnStr);

            //Default donor count
            string donors = "0";

            try
            {
                string sql = "Select * from Table_Donors where Blood_Type='" + Blood_Type + "'";

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                //Total number per blood type
                donors = dt.Rows.Count.ToString();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();

            }
            return donors;
        } 
        #endregion
    }
}