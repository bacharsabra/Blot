
namespace Blot.GUI
{
    partial class FrmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegister));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelBlot = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.pictureCloseRegister = new System.Windows.Forms.PictureBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelAlrdReg = new System.Windows.Forms.Label();
            this.labelGoLog = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCloseRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(173, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.labelTitle.Location = new System.Drawing.Point(169, 282);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(249, 17);
            this.labelTitle.TabIndex = 43;
            this.labelTitle.Text = "Blood Bank Management Software";
            // 
            // labelBlot
            // 
            this.labelBlot.AutoSize = true;
            this.labelBlot.Font = new System.Drawing.Font("Lucida Calligraphy", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBlot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.labelBlot.Location = new System.Drawing.Point(162, 229);
            this.labelBlot.Name = "labelBlot";
            this.labelBlot.Size = new System.Drawing.Size(135, 62);
            this.labelBlot.TabIndex = 42;
            this.labelBlot.Text = "Blot";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Green;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(498, 356);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(240, 50);
            this.btnRegister.TabIndex = 41;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(498, 298);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(240, 29);
            this.textBoxPassword.TabIndex = 40;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.labelPassword.Location = new System.Drawing.Point(495, 268);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(64, 17);
            this.labelPassword.TabIndex = 39;
            this.labelPassword.Text = "Password";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(498, 215);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(240, 29);
            this.textBoxEmail.TabIndex = 38;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.labelEmail.Location = new System.Drawing.Point(495, 185);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(45, 17);
            this.labelEmail.TabIndex = 37;
            this.labelEmail.Text = "E-Mail";
            // 
            // pictureCloseRegister
            // 
            this.pictureCloseRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.pictureCloseRegister.Image = ((System.Drawing.Image)(resources.GetObject("pictureCloseRegister.Image")));
            this.pictureCloseRegister.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureCloseRegister.Location = new System.Drawing.Point(812, 1);
            this.pictureCloseRegister.Name = "pictureCloseRegister";
            this.pictureCloseRegister.Size = new System.Drawing.Size(28, 26);
            this.pictureCloseRegister.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureCloseRegister.TabIndex = 36;
            this.pictureCloseRegister.TabStop = false;
            this.pictureCloseRegister.Click += new System.EventHandler(this.pictureCloseRegister_Click);
            this.pictureCloseRegister.MouseEnter += new System.EventHandler(this.pictureCloseRegister_MouseEnter);
            this.pictureCloseRegister.MouseLeave += new System.EventHandler(this.pictureCloseRegister_Leave);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(498, 143);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(240, 29);
            this.textBoxUsername.TabIndex = 48;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.labelUsername.Location = new System.Drawing.Point(495, 113);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(67, 17);
            this.labelUsername.TabIndex = 47;
            this.labelUsername.Text = "Username";
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFullName.Location = new System.Drawing.Point(498, 60);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(240, 29);
            this.textBoxFullName.TabIndex = 46;
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.labelFullName.Location = new System.Drawing.Point(495, 30);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(66, 17);
            this.labelFullName.TabIndex = 45;
            this.labelFullName.Text = "Full Name";
            // 
            // labelAlrdReg
            // 
            this.labelAlrdReg.AutoSize = true;
            this.labelAlrdReg.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlrdReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.labelAlrdReg.Location = new System.Drawing.Point(499, 425);
            this.labelAlrdReg.Name = "labelAlrdReg";
            this.labelAlrdReg.Size = new System.Drawing.Size(129, 13);
            this.labelAlrdReg.TabIndex = 49;
            this.labelAlrdReg.Text = "Already have an account?";
            // 
            // labelGoLog
            // 
            this.labelGoLog.AutoSize = true;
            this.labelGoLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelGoLog.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoLog.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelGoLog.Location = new System.Drawing.Point(634, 425);
            this.labelGoLog.Name = "labelGoLog";
            this.labelGoLog.Size = new System.Drawing.Size(36, 13);
            this.labelGoLog.TabIndex = 50;
            this.labelGoLog.Text = "Login";
            this.labelGoLog.Click += new System.EventHandler(this.labelGoLog_Click);
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(838, 511);
            this.Controls.Add(this.labelGoLog);
            this.Controls.Add(this.labelAlrdReg);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelBlot);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.pictureCloseRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRegister";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCloseRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelBlot;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.PictureBox pictureCloseRegister;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label labelAlrdReg;
        private System.Windows.Forms.Label labelGoLog;
    }
}