
namespace Blot
{
    partial class FrmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.menuStripTop = new System.Windows.Forms.MenuStrip();
            this.receiversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.labelDev = new System.Windows.Forms.Label();
            this.labelAppName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDon = new System.Windows.Forms.Label();
            this.labelOPosCount = new System.Windows.Forms.Label();
            this.labelOPos = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelONegCount = new System.Windows.Forms.Label();
            this.labelONeg = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.labelANegCount = new System.Windows.Forms.Label();
            this.labelANeg = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.labelAPosCount = new System.Windows.Forms.Label();
            this.labelAPos = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.labelABNegCount = new System.Windows.Forms.Label();
            this.labelABNeg = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.labelBNegCount = new System.Windows.Forms.Label();
            this.labelBNeg = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.labelABPosCount = new System.Windows.Forms.Label();
            this.labelABPos = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.labelBPosCount = new System.Windows.Forms.Label();
            this.labelBPos = new System.Windows.Forms.Label();
            this.dataDonor = new System.Windows.Forms.DataGridView();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.pictureCloseHome = new System.Windows.Forms.PictureBox();
            this.labelUserTitle = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.menuStripTop.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDonor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCloseHome)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripTop
            // 
            this.menuStripTop.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.receiversToolStripMenuItem,
            this.donorsToolStripMenuItem});
            this.menuStripTop.Location = new System.Drawing.Point(0, 0);
            this.menuStripTop.Name = "menuStripTop";
            this.menuStripTop.Padding = new System.Windows.Forms.Padding(6, 10, 0, 10);
            this.menuStripTop.Size = new System.Drawing.Size(1135, 41);
            this.menuStripTop.TabIndex = 0;
            this.menuStripTop.Text = "menuStrip1";
            // 
            // receiversToolStripMenuItem
            // 
            this.receiversToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.receiversToolStripMenuItem.Name = "receiversToolStripMenuItem";
            this.receiversToolStripMenuItem.Size = new System.Drawing.Size(77, 21);
            this.receiversToolStripMenuItem.Text = "Receivers";
            this.receiversToolStripMenuItem.Click += new System.EventHandler(this.receiversToolStripMenuItem_Click);
            // 
            // donorsToolStripMenuItem
            // 
            this.donorsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.donorsToolStripMenuItem.Name = "donorsToolStripMenuItem";
            this.donorsToolStripMenuItem.Size = new System.Drawing.Size(65, 21);
            this.donorsToolStripMenuItem.Text = "Donors";
            this.donorsToolStripMenuItem.Click += new System.EventHandler(this.donorsToolStripMenuItem_Click);
            // 
            // panelFooter
            // 
            this.panelFooter.Controls.Add(this.labelDev);
            this.panelFooter.Controls.Add(this.labelAppName);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 569);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1135, 41);
            this.panelFooter.TabIndex = 1;
            // 
            // labelDev
            // 
            this.labelDev.AutoSize = true;
            this.labelDev.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.labelDev.Location = new System.Drawing.Point(423, 2);
            this.labelDev.Name = "labelDev";
            this.labelDev.Size = new System.Drawing.Size(290, 30);
            this.labelDev.TabIndex = 1;
            this.labelDev.Text = "- Developed by Bachar Sabra";
            // 
            // labelAppName
            // 
            this.labelAppName.AutoSize = true;
            this.labelAppName.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.labelAppName.Location = new System.Drawing.Point(378, 2);
            this.labelAppName.Name = "labelAppName";
            this.labelAppName.Size = new System.Drawing.Size(51, 30);
            this.labelAppName.TabIndex = 0;
            this.labelAppName.Text = "Blot";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.labelDon);
            this.panel1.Controls.Add(this.labelOPosCount);
            this.panel1.Controls.Add(this.labelOPos);
            this.panel1.Location = new System.Drawing.Point(12, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 2;
            // 
            // labelDon
            // 
            this.labelDon.AutoSize = true;
            this.labelDon.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelDon.Location = new System.Drawing.Point(118, 60);
            this.labelDon.Name = "labelDon";
            this.labelDon.Size = new System.Drawing.Size(60, 21);
            this.labelDon.TabIndex = 2;
            this.labelDon.Text = "Donors";
            // 
            // labelOPosCount
            // 
            this.labelOPosCount.AutoSize = true;
            this.labelOPosCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOPosCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.labelOPosCount.Location = new System.Drawing.Point(107, 16);
            this.labelOPosCount.Name = "labelOPosCount";
            this.labelOPosCount.Size = new System.Drawing.Size(71, 45);
            this.labelOPosCount.TabIndex = 1;
            this.labelOPosCount.Text = "100";
            // 
            // labelOPos
            // 
            this.labelOPos.AutoSize = true;
            this.labelOPos.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOPos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.labelOPos.Location = new System.Drawing.Point(3, 16);
            this.labelOPos.Name = "labelOPos";
            this.labelOPos.Size = new System.Drawing.Size(98, 65);
            this.labelOPos.TabIndex = 0;
            this.labelOPos.Text = "O+";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.labelONegCount);
            this.panel2.Controls.Add(this.labelONeg);
            this.panel2.Location = new System.Drawing.Point(241, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(118, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Donors";
            // 
            // labelONegCount
            // 
            this.labelONegCount.AutoSize = true;
            this.labelONegCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelONegCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.labelONegCount.Location = new System.Drawing.Point(107, 16);
            this.labelONegCount.Name = "labelONegCount";
            this.labelONegCount.Size = new System.Drawing.Size(71, 45);
            this.labelONegCount.TabIndex = 1;
            this.labelONegCount.Text = "100";
            // 
            // labelONeg
            // 
            this.labelONeg.AutoSize = true;
            this.labelONeg.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelONeg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.labelONeg.Location = new System.Drawing.Point(3, 16);
            this.labelONeg.Name = "labelONeg";
            this.labelONeg.Size = new System.Drawing.Size(83, 65);
            this.labelONeg.TabIndex = 0;
            this.labelONeg.Text = "O-";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.labelANegCount);
            this.panel3.Controls.Add(this.labelANeg);
            this.panel3.Location = new System.Drawing.Point(241, 213);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(118, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Donors";
            // 
            // labelANegCount
            // 
            this.labelANegCount.AutoSize = true;
            this.labelANegCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelANegCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.labelANegCount.Location = new System.Drawing.Point(107, 16);
            this.labelANegCount.Name = "labelANegCount";
            this.labelANegCount.Size = new System.Drawing.Size(71, 45);
            this.labelANegCount.TabIndex = 1;
            this.labelANegCount.Text = "100";
            // 
            // labelANeg
            // 
            this.labelANeg.AutoSize = true;
            this.labelANeg.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelANeg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.labelANeg.Location = new System.Drawing.Point(3, 16);
            this.labelANeg.Name = "labelANeg";
            this.labelANeg.Size = new System.Drawing.Size(81, 65);
            this.labelANeg.TabIndex = 0;
            this.labelANeg.Text = "A-";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.labelAPosCount);
            this.panel4.Controls.Add(this.labelAPos);
            this.panel4.Location = new System.Drawing.Point(12, 213);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(118, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Donors";
            // 
            // labelAPosCount
            // 
            this.labelAPosCount.AutoSize = true;
            this.labelAPosCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAPosCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.labelAPosCount.Location = new System.Drawing.Point(107, 16);
            this.labelAPosCount.Name = "labelAPosCount";
            this.labelAPosCount.Size = new System.Drawing.Size(71, 45);
            this.labelAPosCount.TabIndex = 1;
            this.labelAPosCount.Text = "100";
            // 
            // labelAPos
            // 
            this.labelAPos.AutoSize = true;
            this.labelAPos.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAPos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.labelAPos.Location = new System.Drawing.Point(3, 16);
            this.labelAPos.Name = "labelAPos";
            this.labelAPos.Size = new System.Drawing.Size(96, 65);
            this.labelAPos.TabIndex = 0;
            this.labelAPos.Text = "A+";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.labelABNegCount);
            this.panel5.Controls.Add(this.labelABNeg);
            this.panel5.Location = new System.Drawing.Point(241, 449);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 100);
            this.panel5.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(118, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 21);
            this.label10.TabIndex = 2;
            this.label10.Text = "Donors";
            // 
            // labelABNegCount
            // 
            this.labelABNegCount.AutoSize = true;
            this.labelABNegCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelABNegCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.labelABNegCount.Location = new System.Drawing.Point(107, 16);
            this.labelABNegCount.Name = "labelABNegCount";
            this.labelABNegCount.Size = new System.Drawing.Size(71, 45);
            this.labelABNegCount.TabIndex = 1;
            this.labelABNegCount.Text = "100";
            // 
            // labelABNeg
            // 
            this.labelABNeg.AutoSize = true;
            this.labelABNeg.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelABNeg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.labelABNeg.Location = new System.Drawing.Point(3, 16);
            this.labelABNeg.Name = "labelABNeg";
            this.labelABNeg.Size = new System.Drawing.Size(112, 65);
            this.labelABNeg.TabIndex = 0;
            this.labelABNeg.Text = "AB-";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gainsboro;
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.labelBNegCount);
            this.panel6.Controls.Add(this.labelBNeg);
            this.panel6.Location = new System.Drawing.Point(241, 330);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 100);
            this.panel6.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(118, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 21);
            this.label13.TabIndex = 2;
            this.label13.Text = "Donors";
            // 
            // labelBNegCount
            // 
            this.labelBNegCount.AutoSize = true;
            this.labelBNegCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBNegCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.labelBNegCount.Location = new System.Drawing.Point(107, 16);
            this.labelBNegCount.Name = "labelBNegCount";
            this.labelBNegCount.Size = new System.Drawing.Size(71, 45);
            this.labelBNegCount.TabIndex = 1;
            this.labelBNegCount.Text = "100";
            // 
            // labelBNeg
            // 
            this.labelBNeg.AutoSize = true;
            this.labelBNeg.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBNeg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.labelBNeg.Location = new System.Drawing.Point(3, 16);
            this.labelBNeg.Name = "labelBNeg";
            this.labelBNeg.Size = new System.Drawing.Size(78, 65);
            this.labelBNeg.TabIndex = 0;
            this.labelBNeg.Text = "B-";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gainsboro;
            this.panel7.Controls.Add(this.label16);
            this.panel7.Controls.Add(this.labelABPosCount);
            this.panel7.Controls.Add(this.labelABPos);
            this.panel7.Location = new System.Drawing.Point(12, 449);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 100);
            this.panel7.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(118, 60);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 21);
            this.label16.TabIndex = 2;
            this.label16.Text = "Donors";
            // 
            // labelABPosCount
            // 
            this.labelABPosCount.AutoSize = true;
            this.labelABPosCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelABPosCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.labelABPosCount.Location = new System.Drawing.Point(107, 16);
            this.labelABPosCount.Name = "labelABPosCount";
            this.labelABPosCount.Size = new System.Drawing.Size(71, 45);
            this.labelABPosCount.TabIndex = 1;
            this.labelABPosCount.Text = "100";
            // 
            // labelABPos
            // 
            this.labelABPos.AutoSize = true;
            this.labelABPos.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelABPos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.labelABPos.Location = new System.Drawing.Point(3, 16);
            this.labelABPos.Name = "labelABPos";
            this.labelABPos.Size = new System.Drawing.Size(127, 65);
            this.labelABPos.TabIndex = 0;
            this.labelABPos.Text = "AB+";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gainsboro;
            this.panel8.Controls.Add(this.label19);
            this.panel8.Controls.Add(this.labelBPosCount);
            this.panel8.Controls.Add(this.labelBPos);
            this.panel8.Location = new System.Drawing.Point(12, 330);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 100);
            this.panel8.TabIndex = 6;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(118, 60);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 21);
            this.label19.TabIndex = 2;
            this.label19.Text = "Donors";
            // 
            // labelBPosCount
            // 
            this.labelBPosCount.AutoSize = true;
            this.labelBPosCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBPosCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.labelBPosCount.Location = new System.Drawing.Point(107, 16);
            this.labelBPosCount.Name = "labelBPosCount";
            this.labelBPosCount.Size = new System.Drawing.Size(71, 45);
            this.labelBPosCount.TabIndex = 1;
            this.labelBPosCount.Text = "100";
            // 
            // labelBPos
            // 
            this.labelBPos.AutoSize = true;
            this.labelBPos.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBPos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.labelBPos.Location = new System.Drawing.Point(3, 16);
            this.labelBPos.Name = "labelBPos";
            this.labelBPos.Size = new System.Drawing.Size(93, 65);
            this.labelBPos.TabIndex = 0;
            this.labelBPos.Text = "B+";
            // 
            // dataDonor
            // 
            this.dataDonor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDonor.Location = new System.Drawing.Point(527, 156);
            this.dataDonor.Name = "dataDonor";
            this.dataDonor.Size = new System.Drawing.Size(596, 393);
            this.dataDonor.TabIndex = 10;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.labelSearch.Location = new System.Drawing.Point(527, 96);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(116, 21);
            this.labelSearch.TabIndex = 11;
            this.labelSearch.Text = "Search Donors";
            // 
            // textSearch
            // 
            this.textSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearch.Location = new System.Drawing.Point(668, 96);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(455, 29);
            this.textSearch.TabIndex = 12;
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            // 
            // pictureCloseHome
            // 
            this.pictureCloseHome.BackColor = System.Drawing.Color.White;
            this.pictureCloseHome.Image = ((System.Drawing.Image)(resources.GetObject("pictureCloseHome.Image")));
            this.pictureCloseHome.Location = new System.Drawing.Point(1107, 0);
            this.pictureCloseHome.Name = "pictureCloseHome";
            this.pictureCloseHome.Size = new System.Drawing.Size(28, 26);
            this.pictureCloseHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureCloseHome.TabIndex = 13;
            this.pictureCloseHome.TabStop = false;
            this.pictureCloseHome.Click += new System.EventHandler(this.pictureCloseHome_Click);
            this.pictureCloseHome.MouseEnter += new System.EventHandler(this.pictureCloseHome_MouseEnter);
            this.pictureCloseHome.MouseLeave += new System.EventHandler(this.pictureCloseHome_Leave);
            // 
            // labelUserTitle
            // 
            this.labelUserTitle.AutoSize = true;
            this.labelUserTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.labelUserTitle.Location = new System.Drawing.Point(23, 59);
            this.labelUserTitle.Name = "labelUserTitle";
            this.labelUserTitle.Size = new System.Drawing.Size(76, 13);
            this.labelUserTitle.TabIndex = 14;
            this.labelUserTitle.Text = "Logged in as:";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.Lime;
            this.labelUsername.Location = new System.Drawing.Point(105, 50);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(17, 25);
            this.labelUsername.TabIndex = 15;
            this.labelUsername.Text = ".";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.labelTitle.Location = new System.Drawing.Point(522, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(66, 25);
            this.labelTitle.TabIndex = 16;
            this.labelTitle.Text = "Home";
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1135, 610);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelUserTitle);
            this.Controls.Add(this.pictureCloseHome);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.dataDonor);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.menuStripTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripTop;
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Activated += new System.EventHandler(this.frmHome_Activated);
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.menuStripTop.ResumeLayout(false);
            this.menuStripTop.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDonor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCloseHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripTop;
        private System.Windows.Forms.ToolStripMenuItem receiversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donorsToolStripMenuItem;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label labelAppName;
        private System.Windows.Forms.Label labelDev;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelOPos;
        private System.Windows.Forms.Label labelOPosCount;
        private System.Windows.Forms.Label labelDon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelONegCount;
        private System.Windows.Forms.Label labelONeg;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelANegCount;
        private System.Windows.Forms.Label labelANeg;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelAPosCount;
        private System.Windows.Forms.Label labelAPos;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelABNegCount;
        private System.Windows.Forms.Label labelABNeg;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelBNegCount;
        private System.Windows.Forms.Label labelBNeg;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelABPosCount;
        private System.Windows.Forms.Label labelABPos;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label labelBPosCount;
        private System.Windows.Forms.Label labelBPos;
        private System.Windows.Forms.DataGridView dataDonor;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.PictureBox pictureCloseHome;
        private System.Windows.Forms.Label labelUserTitle;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelTitle;
    }
}

