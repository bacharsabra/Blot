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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();

        }

        //BLL and DAL objects
        loginBLL l = new loginBLL();
        loginDAL dal = new loginDAL();

        //Method to save the username
        public static string loggedInUser;

        private void pictureCloseLogin_Click(object sender, EventArgs e)
        {
            //Close the app
            Application.Exit();

        }

        //Background color change on enter
        private void pictureCloseLogin_Leave(object sender, EventArgs e)
        {
            pictureCloseLogin.BackColor = Color.FromArgb(44, 47, 51);

        }

        private void pictureCloseLogin_MouseEnter(object sender, EventArgs e)
        {
            pictureCloseLogin.BackColor = Color.Azure;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Get username and password from login form
            l.Username = textBoxUsername.Text;
            l.Password = textBoxPassword.Text;

            //Check credentials
            bool isSuccess = dal.loginCheck(l);

            //Check if login is successful
            if (isSuccess == true)
            {
                MessageBox.Show("Login Successful!");

                //Save username
                loggedInUser = l.Username;

                //Send to home form
                FrmHome home = new FrmHome();
                home.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Either username or password are wrong");

            }

        }

        private void labelGoReg_Click(object sender, EventArgs e)
        {
            //Send to register form
            FrmRegister register = new FrmRegister();
            register.Show();
            this.Hide();
        }
    }
}
