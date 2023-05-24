using Blot.BLL;
using Blot.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blot.GUI
{
    public partial class FrmDonors : Form
    {
        public FrmDonors()
        {
            InitializeComponent();

        }

        //Create objects of donorBLL and donorDAL
        donorBLL d = new donorBLL();
        donorDAL dal = new donorDAL();
        userDAL udal = new userDAL();

        string imageName = "placeholder.png";
        string rowHeaderImage;
        string sourcePath = "";
        string destinationPath = "";

        private void pictureCloseDonors_Click(object sender, EventArgs e)
        {
            //Close the app
            Application.Exit();

        }

        //Background color change on enter
        private void pictureCloseDonors_Leave(object sender, EventArgs e)
        {
            pictureCloseDonors.BackColor = Color.White;

        }

        private void pictureCloseDonors_MouseEnter(object sender, EventArgs e)
        {
            pictureCloseDonors.BackColor = Color.Azure;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Get values from GUI
            d.Full_Name = textBoxFullName.Text;
            d.Email = textBoxEmail.Text;
            d.Gender = comboBoxGender.Text;
            d.Blood_Type = comboBoxBloodType.Text;
            d.Phone = textBoxPhone.Text;
            d.Address = textBoxAddress.Text;
            d.Added_Date = DateTime.Now;
            d.Image_Name = imageName;
            //Get the ID of logged in user
            string loggedInUser = FrmLogin.loggedInUser;
            userBLL usr = udal.GetIDFromUsername(loggedInUser);
            d.Added_By = usr.User_ID;

            //Check if the image is already selected
            if (imageName != "placeholder.png")
            {
                File.Copy(sourcePath, destinationPath);
            }

            bool success = dal.Insert(d);

            if (success == true)
            {
                MessageBox.Show("Added successfully.");

                DataTable dt = dal.Select();
                dataDonors.DataSource = dt;

                Clear();

            }

            else
            {
                MessageBox.Show("Failed to add.");

            }
        }

        //Method to clear textboxes
        public void Clear()
        {
            textBoxFullName.Text = "";
            textBoxEmail.Text = "";
            comboBoxGender.Text = "";
            comboBoxBloodType.Text = "";
            textBoxPhone.Text = "";
            textBoxAddress.Text = "";
            textBoxDonor_ID.Text = "";
            imageName = "placeholder.png";

            string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

            string imagePath = paths + "\\Images\\placeholder.png";

            pictureBoxProfile.Image = new Bitmap(imagePath);

        }

        private void dataDonors_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Find the row index in data grid
            int RowIndex = e.RowIndex;
            textBoxDonor_ID.Text = dataDonors.Rows[RowIndex].Cells[0].Value.ToString();
            textBoxFullName.Text = dataDonors.Rows[RowIndex].Cells[1].Value.ToString();
            textBoxEmail.Text = dataDonors.Rows[RowIndex].Cells[2].Value.ToString();
            textBoxPhone.Text = dataDonors.Rows[RowIndex].Cells[3].Value.ToString();
            textBoxAddress.Text = dataDonors.Rows[RowIndex].Cells[4].Value.ToString();
            comboBoxGender.Text = dataDonors.Rows[RowIndex].Cells[5].Value.ToString();
            comboBoxBloodType.Text = dataDonors.Rows[RowIndex].Cells[6].Value.ToString();
            imageName = dataDonors.Rows[RowIndex].Cells[8].Value.ToString();

            rowHeaderImage = imageName;

            //Display the image of selected donor
            string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

            if(imageName != "placeholder.png")
            {
                //Path to destination folder
                string imagePath = paths + "\\Images\\" + imageName;

                //Display in picture box
                pictureBoxProfile.Image = new Bitmap(imagePath);

            }

            else
            {
                string imagePath = paths + "\\Images\\placeholder.png";

                pictureBoxProfile.Image = new Bitmap(imagePath);

            }
        }

        private void FrmDonors_Load(object sender, EventArgs e)
        {
            //Display donors when form is loaded
            DataTable dt = dal.Select();
            dataDonors.DataSource = dt;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            d.Donor_ID = int.Parse(textBoxDonor_ID.Text);
            d.Full_Name = textBoxFullName.Text;
            d.Email = textBoxEmail.Text;
            d.Phone = textBoxPhone.Text;
            d.Address = textBoxAddress.Text;
            d.Gender = comboBoxGender.Text;
            d.Blood_Type = comboBoxBloodType.Text;
            d.Added_Date = DateTime.Now;
            string loggedInUser = FrmLogin.loggedInUser;
            userBLL usr = udal.GetIDFromUsername(loggedInUser);
            d.Added_By = usr.User_ID;
            d.Image_Name = imageName;

            //Upload new image
            if (imageName != "placeholder.png")
            {
                File.Copy(sourcePath, destinationPath);
            }

            bool success = dal.Update(d);

            //Remove outdated image
            if (rowHeaderImage != "placeholder.png")
            {
                string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                string imagePath = paths + "\\Images\\" + rowHeaderImage;

                Clear();

                //Garbage collection
                GC.Collect();
                GC.WaitForPendingFinalizers();

                //Remove image from folder
                File.Delete(imagePath);
            }

            if (success == true)
            {
                MessageBox.Show("Updated successfully.");

                DataTable dt = dal.Select();
                dataDonors.DataSource = dt;

                Clear();

            }

            else
            {
                MessageBox.Show("Update failed.");

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            d.Donor_ID = int.Parse(textBoxDonor_ID.Text);

            if(rowHeaderImage != "placeholder.png")
            {
                string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

                string imagePath = paths + "\\Images\\" + rowHeaderImage;

                Clear();

                //Garbage collection
                GC.Collect();
                GC.WaitForPendingFinalizers();

                File.Delete(imagePath);
            }

            bool success = dal.Delete(d);

            if (success == true)
            {
                MessageBox.Show("Deleted successfully.");

                DataTable dt = dal.Select();

                dataDonors.DataSource = dt;

                Clear();

            }
        }

        private void btnProfilePicture_Click(object sender, EventArgs e)
        {
            //Dialog box to select image
            OpenFileDialog open = new OpenFileDialog();

            //Filter file type
            open.Filter = "Image Files (*.png; *.PNG; *.jpg; *.jpeg;|*.png; *.PNG; *.jpg; *.jpeg;)";

            //Check if the file is selected
            if (open.ShowDialog() == DialogResult.OK)
            {
                //Check if the file exists
                if (open.CheckFileExists)
                {
                    pictureBoxProfile.Image = new Bitmap(open.FileName);

                    //Get image extension
                    string ext = Path.GetExtension(open.FileName);

                    string name = Path.GetFileNameWithoutExtension(open.FileName);

                    //Generate random int
                    Guid g = new Guid();
                    g = Guid.NewGuid();

                    //Rename selected image
                    imageName = "Blot_" + name + g + ext;

                    //Get image path
                    sourcePath = open.FileName;

                    //Get destination path
                    string paths = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10);

                    //Set destination path
                    destinationPath = paths + "\\Images\\" + imageName;         

                }
            }
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            //Get keywords from textbox
            String keywords = textSearch.Text;

            //Display donors based on keywords if textbox is not empty
            if (keywords != null)
            {
                DataTable dt = dal.Search(keywords);
                dataDonors.DataSource = dt;

            }

            else
            {
                DataTable dt = dal.Select();
                dataDonors.DataSource = dt;

            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open Home Form
            FrmHome home = new FrmHome();
            home.Show();
            this.Hide();
        }

        private void receiversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReceivers receivers = new FrmReceivers();
            receivers.Show();
            this.Hide();
        }
    }
}

