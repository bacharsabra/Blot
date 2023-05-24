
namespace Blot.GUI
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.pictureCloseLogin = new System.Windows.Forms.PictureBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.labelBlot = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelGoReg = new System.Windows.Forms.Label();
            this.labelNotReg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCloseLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureCloseLogin
            // 
            this.pictureCloseLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.pictureCloseLogin.Image = ((System.Drawing.Image)(resources.GetObject("pictureCloseLogin.Image")));
            this.pictureCloseLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureCloseLogin.Location = new System.Drawing.Point(773, 1);
            this.pictureCloseLogin.Name = "pictureCloseLogin";
            this.pictureCloseLogin.Size = new System.Drawing.Size(28, 26);
            this.pictureCloseLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureCloseLogin.TabIndex = 27;
            this.pictureCloseLogin.TabStop = false;
            this.pictureCloseLogin.Click += new System.EventHandler(this.pictureCloseLogin_Click);
            this.pictureCloseLogin.MouseEnter += new System.EventHandler(this.pictureCloseLogin_MouseEnter);
            this.pictureCloseLogin.MouseLeave += new System.EventHandler(this.pictureCloseLogin_Leave);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.labelUsername.Location = new System.Drawing.Point(456, 102);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(67, 17);
            this.labelUsername.TabIndex = 28;
            this.labelUsername.Text = "Username";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(459, 132);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(240, 29);
            this.textBoxUsername.TabIndex = 29;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(459, 215);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(240, 29);
            this.textBoxPassword.TabIndex = 31;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.labelPassword.Location = new System.Drawing.Point(456, 185);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(64, 17);
            this.labelPassword.TabIndex = 30;
            this.labelPassword.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Green;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(459, 266);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(240, 50);
            this.btnLogin.TabIndex = 32;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // labelBlot
            // 
            this.labelBlot.AutoSize = true;
            this.labelBlot.Font = new System.Drawing.Font("Lucida Calligraphy", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBlot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.labelBlot.Location = new System.Drawing.Point(123, 227);
            this.labelBlot.Name = "labelBlot";
            this.labelBlot.Size = new System.Drawing.Size(135, 62);
            this.labelBlot.TabIndex = 33;
            this.labelBlot.Text = "Blot";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.labelTitle.Location = new System.Drawing.Point(130, 280);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(249, 17);
            this.labelTitle.TabIndex = 34;
            this.labelTitle.Text = "Blood Bank Management Software";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(134, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // labelGoReg
            // 
            this.labelGoReg.AutoSize = true;
            this.labelGoReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelGoReg.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoReg.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelGoReg.Location = new System.Drawing.Point(591, 328);
            this.labelGoReg.Name = "labelGoReg";
            this.labelGoReg.Size = new System.Drawing.Size(49, 13);
            this.labelGoReg.TabIndex = 52;
            this.labelGoReg.Text = "Register";
            this.labelGoReg.Click += new System.EventHandler(this.labelGoReg_Click);
            // 
            // labelNotReg
            // 
            this.labelNotReg.AutoSize = true;
            this.labelNotReg.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.labelNotReg.Location = new System.Drawing.Point(456, 328);
            this.labelNotReg.Name = "labelNotReg";
            this.labelNotReg.Size = new System.Drawing.Size(136, 13);
            this.labelNotReg.TabIndex = 51;
            this.labelNotReg.Text = "Don\'t have an account yet?";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelGoReg);
            this.Controls.Add(this.labelNotReg);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelBlot);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.pictureCloseLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureCloseLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureCloseLogin;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label labelBlot;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelGoReg;
        private System.Windows.Forms.Label labelNotReg;
    }
}