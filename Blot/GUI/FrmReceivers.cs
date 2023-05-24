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
    public partial class FrmReceivers : Form
    {
        public FrmReceivers()
        {
            InitializeComponent();

        }

        //Create objects of receiverBLL and receiverDAL
        receiverBLL r = new receiverBLL();
        receiverDAL dal = new receiverDAL();

        string imageName = "placeholder.png";
        string rowHeaderImage;
        string sourcePath = "";
        string destinationPath = "";

        private void pictureCloseReceiver_Click(object sender, EventArgs e)
        {
            //Close the app
            Application.Exit();
        }

        //Background color change on enter
        private void pictureCloseReceiver_Leave(object sender, EventArgs e)
        {
            pictureCloseReceiver.BackColor = Color.White;
        }

        private void pictureCloseReceiver_MouseEnter(object sender, EventArgs e)
        {
            pictureCloseReceiver.BackColor = Color.Azure;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Get values from GUI
            r.Full_Name = textBoxFullName.Text;
            r.Email = textBoxEmail.Text;
            r.Phone = textBoxPhone.Text;
            r.Address = textBoxAddress.Text;
            r.Gender = comboBoxGender.Text;
            r.Blood_Type = comboBoxBloodType.Text;
            r.Added_Date = DateTime.Now;
            r.Image_Name = imageName;

            //Check if the image is already selected
            if (imageName != "placeholder.png")
            {
                File.Copy(sourcePath, destinationPath);
            }

            bool success = dal.Insert(r);

            if (success == true)
            {
                MessageBox.Show("Added successfully.");

                DataTable dt = dal.Select();
                dataReceivers.DataSource = dt;

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
            textBoxReceiver_ID.Text = "";
            textBoxFullName.Text = "";
            textBoxEmail.Text = "";
            textBoxPhone.Text = "";
            textBoxAddress.Text = "";
            comboBoxGender.Text = "";
            comboBoxBloodType.Text = "";
            imageName = "placeholder.png";

            string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

            string imagePath = paths + "\\Images\\placeholder.png";

            pictureBoxProfile.Image = new Bitmap(imagePath);

        }

        private void dataReceivers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Find the row index in data grid
            int RowIndex = e.RowIndex;
            textBoxReceiver_ID.Text = dataReceivers.Rows[RowIndex].Cells[0].Value.ToString();
            textBoxFullName.Text = dataReceivers.Rows[RowIndex].Cells[1].Value.ToString();
            textBoxEmail.Text = dataReceivers.Rows[RowIndex].Cells[2].Value.ToString();
            textBoxPhone.Text = dataReceivers.Rows[RowIndex].Cells[3].Value.ToString();
            textBoxAddress.Text = dataReceivers.Rows[RowIndex].Cells[4].Value.ToString();
            comboBoxGender.Text = dataReceivers.Rows[RowIndex].Cells[5].Value.ToString();
            comboBoxBloodType.Text = dataReceivers.Rows[RowIndex].Cells[6].Value.ToString();
            imageName = dataReceivers.Rows[RowIndex].Cells[8].Value.ToString();

            rowHeaderImage = imageName;

            //Display the image of selected receiver
            string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

            if(imageName!= "placeholder.png")
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

        private void FrmReceivers_Load(object sender, EventArgs e)
        {
            //Display receiver when form is loaded
            DataTable dt = dal.Select();
            dataReceivers.DataSource = dt;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            r.Receiver_ID = int.Parse(textBoxReceiver_ID.Text);
            r.Full_Name = textBoxFullName.Text;
            r.Email = textBoxEmail.Text;
            r.Phone = textBoxPhone.Text;
            r.Address = textBoxAddress.Text;
            r.Gender = comboBoxGender.Text;
            r.Blood_Type = comboBoxBloodType.Text;
            r.Added_Date = DateTime.Now;
            r.Image_Name = imageName;

            //Upload new image
            if (imageName != "placeholder.png")
            {
                File.Copy(sourcePath, destinationPath);
            }

            bool success = dal.Update(r);

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
                dataReceivers.DataSource = dt;

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
            r.Receiver_ID = int.Parse(textBoxReceiver_ID.Text);

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

            bool success = dal.Delete(r);

            if (success == true)
            {
                MessageBox.Show("Deleted successfully.");

                DataTable dt = dal.Select();

                dataReceivers.DataSource = dt;

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

            //Display receivers based on keywords if textbox is not empty
            if (keywords != null)
            {
                DataTable dt = dal.Search(keywords);
                dataReceivers.DataSource = dt;

            }

            else
            {
                DataTable dt = dal.Select();
                dataReceivers.DataSource = dt;

            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open Home Form
            FrmHome home = new FrmHome();
            home.Show();
            this.Hide();

        }

        private void donorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDonors donors = new FrmDonors();
            donors.Show();
            this.Hide();
        }
    }
}
