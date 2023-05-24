using Blot.BLL;
using Blot.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blot.GUI
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        //BLL and DAL objects
        userBLL u = new userBLL();
        userDAL dal = new userDAL();

        //Method to save the username
        public static string registeredUser;


        private void pictureCloseRegister_Click(object sender, EventArgs e)
        {
            //Close the app
            Application.Exit();

        }

        //Background color change on enter
        private void pictureCloseRegister_Leave(object sender, EventArgs e)
        {
            pictureCloseRegister.BackColor = Color.FromArgb(44, 47, 51);

        }

        private void pictureCloseRegister_MouseEnter(object sender, EventArgs e)
        {
            pictureCloseRegister.BackColor = Color.Azure;

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Get username and password from register form
            u.Full_Name = textBoxFullName.Text;
            u.Username = textBoxUsername.Text;
            u.Email = textBoxEmail.Text;
            u.Password = textBoxPassword.Text;

            //Check credentials
            bool isSuccess = dal.Insert(u);

            //Check if login is successful
            if (isSuccess == true)
            {
                MessageBox.Show("Register Successful!");

                //Send to login form
                FrmLogin login = new FrmLogin();
                login.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Registration error.");

            }

        }

        private void labelGoLog_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Hide();
        }
    }
}
