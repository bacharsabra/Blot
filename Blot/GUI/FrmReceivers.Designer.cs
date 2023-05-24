
namespace Blot.GUI
{
    partial class FrmReceivers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReceivers));
            this.labelProfilePicture = new System.Windows.Forms.Label();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.btnProfilePicture = new System.Windows.Forms.Button();
            this.labelUser_ID = new System.Windows.Forms.Label();
            this.textBoxReceiver_ID = new System.Windows.Forms.TextBox();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelBloodType = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataReceivers = new System.Windows.Forms.DataGridView();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.comboBoxBloodType = new System.Windows.Forms.ComboBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureCloseReceiver = new System.Windows.Forms.PictureBox();
            this.menuStripTop = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataReceivers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCloseReceiver)).BeginInit();
            this.menuStripTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelProfilePicture
            // 
            this.labelProfilePicture.AutoSize = true;
            this.labelProfilePicture.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.labelProfilePicture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.labelProfilePicture.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelProfilePicture.Location = new System.Drawing.Point(54, 77);
            this.labelProfilePicture.Name = "labelProfilePicture";
            this.labelProfilePicture.Size = new System.Drawing.Size(78, 13);
            this.labelProfilePicture.TabIndex = 1;
            this.labelProfilePicture.Text = "Profile Picture";
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxProfile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBoxProfile.Location = new System.Drawing.Point(158, 77);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(130, 111);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 2;
            this.pictureBoxProfile.TabStop = false;
            // 
            // btnProfilePicture
            // 
            this.btnProfilePicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.btnProfilePicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfilePicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfilePicture.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnProfilePicture.ForeColor = System.Drawing.Color.Black;
            this.btnProfilePicture.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnProfilePicture.Location = new System.Drawing.Point(295, 154);
            this.btnProfilePicture.Name = "btnProfilePicture";
            this.btnProfilePicture.Size = new System.Drawing.Size(114, 34);
            this.btnProfilePicture.TabIndex = 3;
            this.btnProfilePicture.Text = "Select Image";
            this.btnProfilePicture.UseVisualStyleBackColor = false;
            this.btnProfilePicture.Click += new System.EventHandler(this.btnProfilePicture_Click);
            // 
            // labelUser_ID
            // 
            this.labelUser_ID.AutoSize = true;
            this.labelUser_ID.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.labelUser_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.labelUser_ID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelUser_ID.Location = new System.Drawing.Point(54, 215);
            this.labelUser_ID.Name = "labelUser_ID";
            this.labelUser_ID.Size = new System.Drawing.Size(18, 13);
            this.labelUser_ID.TabIndex = 4;
            this.labelUser_ID.Text = "ID";
            // 
            // textBoxReceiver_ID
            // 
            this.textBoxReceiver_ID.AccessibleDescription = "";
            this.textBoxReceiver_ID.AccessibleName = "";
            this.textBoxReceiver_ID.BackColor = System.Drawing.Color.LightGray;
            this.textBoxReceiver_ID.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxReceiver_ID.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.textBoxReceiver_ID.Location = new System.Drawing.Point(158, 208);
            this.textBoxReceiver_ID.Name = "textBoxReceiver_ID";
            this.textBoxReceiver_ID.ReadOnly = true;
            this.textBoxReceiver_ID.Size = new System.Drawing.Size(397, 25);
            this.textBoxReceiver_ID.TabIndex = 5;
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.textBoxFullName.Location = new System.Drawing.Point(158, 249);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(397, 25);
            this.textBoxFullName.TabIndex = 7;
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.labelFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.labelFullName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelFullName.Location = new System.Drawing.Point(54, 256);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(58, 13);
            this.labelFullName.TabIndex = 6;
            this.labelFullName.Text = "Full Name";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.labelGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.labelGender.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelGender.Location = new System.Drawing.Point(54, 337);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(45, 13);
            this.labelGender.TabIndex = 10;
            this.labelGender.Text = "Gender";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.textBoxEmail.Location = new System.Drawing.Point(158, 290);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(397, 25);
            this.textBoxEmail.TabIndex = 9;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.labelEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.labelEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelEmail.Location = new System.Drawing.Point(54, 297);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(39, 13);
            this.labelEmail.TabIndex = 8;
            this.labelEmail.Text = "E-Mail";
            // 
            // labelBloodType
            // 
            this.labelBloodType.AutoSize = true;
            this.labelBloodType.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.labelBloodType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.labelBloodType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelBloodType.Location = new System.Drawing.Point(54, 378);
            this.labelBloodType.Name = "labelBloodType";
            this.labelBloodType.Size = new System.Drawing.Size(63, 13);
            this.labelBloodType.TabIndex = 12;
            this.labelBloodType.Text = "Blood Type";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.textBoxPhone.Location = new System.Drawing.Point(158, 413);
            this.textBoxPhone.MaxLength = 50;
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(397, 25);
            this.textBoxPhone.TabIndex = 15;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.labelPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.labelPhone.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelPhone.Location = new System.Drawing.Point(54, 420);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(84, 13);
            this.labelPhone.TabIndex = 14;
            this.labelPhone.Text = "Phone Number";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.textBoxAddress.Location = new System.Drawing.Point(158, 453);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(397, 69);
            this.textBoxAddress.TabIndex = 17;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.labelAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.labelAddress.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelAddress.Location = new System.Drawing.Point(54, 460);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(48, 13);
            this.labelAddress.TabIndex = 16;
            this.labelAddress.Text = "Address";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(199)))), ((int)(((byte)(83)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAdd.Location = new System.Drawing.Point(57, 537);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 42);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(86)))), ((int)(((byte)(139)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUpdate.Location = new System.Drawing.Point(186, 537);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(113, 42);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Goldenrod;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClear.Location = new System.Drawing.Point(314, 537);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(113, 42);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Firebrick;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDelete.Location = new System.Drawing.Point(442, 537);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 42);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataReceivers
            // 
            this.dataReceivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataReceivers.Location = new System.Drawing.Point(589, 154);
            this.dataReceivers.Name = "dataReceivers";
            this.dataReceivers.Size = new System.Drawing.Size(524, 425);
            this.dataReceivers.TabIndex = 22;
            this.dataReceivers.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataReceivers_RowHeaderMouseClick);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.labelSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.labelSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelSearch.Location = new System.Drawing.Point(586, 77);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(41, 13);
            this.labelSearch.TabIndex = 23;
            this.labelSearch.Text = "Search";
            // 
            // textSearch
            // 
            this.textSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textSearch.Location = new System.Drawing.Point(633, 77);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(480, 29);
            this.textSearch.TabIndex = 25;
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxGender.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxGender.Location = new System.Drawing.Point(158, 330);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(397, 25);
            this.comboBoxGender.TabIndex = 26;
            // 
            // comboBoxBloodType
            // 
            this.comboBoxBloodType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxBloodType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBloodType.FormattingEnabled = true;
            this.comboBoxBloodType.Items.AddRange(new object[] {
            "O+",
            "O-",
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-"});
            this.comboBoxBloodType.Location = new System.Drawing.Point(158, 371);
            this.comboBoxBloodType.Name = "comboBoxBloodType";
            this.comboBoxBloodType.Size = new System.Drawing.Size(397, 25);
            this.comboBoxBloodType.TabIndex = 27;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.labelTitle.Location = new System.Drawing.Point(522, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(193, 25);
            this.labelTitle.TabIndex = 30;
            this.labelTitle.Text = "Receiver Application";
            // 
            // pictureCloseReceiver
            // 
            this.pictureCloseReceiver.BackColor = System.Drawing.Color.White;
            this.pictureCloseReceiver.Image = ((System.Drawing.Image)(resources.GetObject("pictureCloseReceiver.Image")));
            this.pictureCloseReceiver.Location = new System.Drawing.Point(1107, 0);
            this.pictureCloseReceiver.Name = "pictureCloseReceiver";
            this.pictureCloseReceiver.Size = new System.Drawing.Size(28, 26);
            this.pictureCloseReceiver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureCloseReceiver.TabIndex = 29;
            this.pictureCloseReceiver.TabStop = false;
            this.pictureCloseReceiver.Click += new System.EventHandler(this.pictureCloseReceiver_Click);
            this.pictureCloseReceiver.MouseEnter += new System.EventHandler(this.pictureCloseReceiver_MouseEnter);
            this.pictureCloseReceiver.MouseLeave += new System.EventHandler(this.pictureCloseReceiver_Leave);
            // 
            // menuStripTop
            // 
            this.menuStripTop.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.donorsToolStripMenuItem});
            this.menuStripTop.Location = new System.Drawing.Point(0, 0);
            this.menuStripTop.Name = "menuStripTop";
            this.menuStripTop.Padding = new System.Windows.Forms.Padding(6, 10, 0, 10);
            this.menuStripTop.Size = new System.Drawing.Size(1135, 41);
            this.menuStripTop.TabIndex = 28;
            this.menuStripTop.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(57, 21);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // donorsToolStripMenuItem
            // 
            this.donorsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.donorsToolStripMenuItem.Name = "donorsToolStripMenuItem";
            this.donorsToolStripMenuItem.Size = new System.Drawing.Size(65, 21);
            this.donorsToolStripMenuItem.Text = "Donors";
            this.donorsToolStripMenuItem.Click += new System.EventHandler(this.donorsToolStripMenuItem_Click);
            // 
            // FrmReceivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1135, 610);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureCloseReceiver);
            this.Controls.Add(this.menuStripTop);
            this.Controls.Add(this.comboBoxBloodType);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.dataReceivers);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelBloodType);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.textBoxReceiver_ID);
            this.Controls.Add(this.labelUser_ID);
            this.Controls.Add(this.btnProfilePicture);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.labelProfilePicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReceivers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blot";
            this.Load += new System.EventHandler(this.FrmReceivers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataReceivers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCloseReceiver)).EndInit();
            this.menuStripTop.ResumeLayout(false);
            this.menuStripTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelProfilePicture;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Button btnProfilePicture;
        private System.Windows.Forms.Label labelUser_ID;
        private System.Windows.Forms.TextBox textBoxReceiver_ID;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelBloodType;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataReceivers;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.ComboBox comboBoxBloodType;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureCloseReceiver;
        private System.Windows.Forms.MenuStrip menuStripTop;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donorsToolStripMenuItem;
    }
}