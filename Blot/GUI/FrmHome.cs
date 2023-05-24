using Blot.DAL;
using Blot.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blot
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();

        }

        //Donor DAL object creation
        donorDAL dal = new donorDAL();

        private void receiversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open Receivers Form
            FrmReceivers receivers = new FrmReceivers();
            receivers.Show();
            this.Hide();

        }

        private void pictureCloseHome_Click(object sender, EventArgs e)
        {
            //Close the app
            Application.Exit();

        }

        
        private void pictureCloseHome_Leave(object sender, EventArgs e)
        {
            pictureCloseHome.BackColor = Color.White;

        }

        private void pictureCloseHome_MouseEnter(object sender, EventArgs e)
        {
            //Background color change on enter
            pictureCloseHome.BackColor = Color.Azure;

        }

        private void donorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDonors donors = new FrmDonors();
            donors.Show();
            this.Hide();

        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            //Load donors
            allDonorCount();

            //Display all donors
            DataTable dt = dal.Select();
            dataDonor.DataSource = dt;

            //Display username when logged in
            labelUsername.Text = FrmLogin.loggedInUser;

        }

        public void allDonorCount()
        {
            //Get donor count from DB
            labelOPosCount.Text = dal.countDonors("O+");
            labelONegCount.Text = dal.countDonors("O-");
            labelAPosCount.Text = dal.countDonors("A+");
            labelANegCount.Text = dal.countDonors("A-");
            labelBPosCount.Text = dal.countDonors("B+");
            labelBNegCount.Text = dal.countDonors("B-");
            labelABPosCount.Text = dal.countDonors("AB+");
            labelABNegCount.Text = dal.countDonors("AB-");

        }

        private void frmHome_Activated(object sender, EventArgs e)
        {
            //Instant donor count update
            allDonorCount();

        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            //Get keywords from textbox
            String keywords = textSearch.Text;

            //Display donors based on keywords if textbox is not empty
            if (keywords != null)
            {
                DataTable dt = dal.Search(keywords);
                dataDonor.DataSource = dt;

            }

            else
            {
                DataTable dt = dal.Select();
                dataDonor.DataSource = dt;

            }
        }
    }
}
