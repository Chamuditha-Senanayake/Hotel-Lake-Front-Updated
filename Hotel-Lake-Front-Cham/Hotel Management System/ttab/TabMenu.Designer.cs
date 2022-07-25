
namespace Hotel_Management_System
{
    partial class TabMenu
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
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnTabContact = new FontAwesome.Sharp.IconButton();
            this.btnTabPayment = new FontAwesome.Sharp.IconButton();
            this.btnTabServices = new FontAwesome.Sharp.IconButton();
            this.btnTabDetails = new FontAwesome.Sharp.IconButton();
            this.btnTabCleaning = new FontAwesome.Sharp.IconButton();
            this.btnTabFood = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1350, 50);
            this.panelMenu.TabIndex = 0;
            // 
            // btnTabContact
            // 
            this.btnTabContact.FlatAppearance.BorderSize = 0;
            this.btnTabContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabContact.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.btnTabContact.IconColor = System.Drawing.Color.Black;
            this.btnTabContact.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTabContact.IconSize = 150;
            this.btnTabContact.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTabContact.Location = new System.Drawing.Point(835, 363);
            this.btnTabContact.Name = "btnTabContact";
            this.btnTabContact.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTabContact.Size = new System.Drawing.Size(250, 250);
            this.btnTabContact.TabIndex = 8;
            this.btnTabContact.Text = "Contact";
            this.btnTabContact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTabContact.UseVisualStyleBackColor = true;
            this.btnTabContact.Click += new System.EventHandler(this.btnTabContact_Click);
            // 
            // btnTabPayment
            // 
            this.btnTabPayment.FlatAppearance.BorderSize = 0;
            this.btnTabPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabPayment.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.btnTabPayment.IconColor = System.Drawing.Color.Black;
            this.btnTabPayment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTabPayment.IconSize = 150;
            this.btnTabPayment.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTabPayment.Location = new System.Drawing.Point(275, 363);
            this.btnTabPayment.Name = "btnTabPayment";
            this.btnTabPayment.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTabPayment.Size = new System.Drawing.Size(250, 250);
            this.btnTabPayment.TabIndex = 7;
            this.btnTabPayment.Text = "Payment";
            this.btnTabPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTabPayment.UseVisualStyleBackColor = true;
            this.btnTabPayment.Click += new System.EventHandler(this.btnTabPayment_Click);
            // 
            // btnTabServices
            // 
            this.btnTabServices.FlatAppearance.BorderSize = 0;
            this.btnTabServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabServices.IconChar = FontAwesome.Sharp.IconChar.Mountain;
            this.btnTabServices.IconColor = System.Drawing.Color.Black;
            this.btnTabServices.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTabServices.IconSize = 150;
            this.btnTabServices.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTabServices.Location = new System.Drawing.Point(554, 363);
            this.btnTabServices.Name = "btnTabServices";
            this.btnTabServices.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTabServices.Size = new System.Drawing.Size(250, 250);
            this.btnTabServices.TabIndex = 6;
            this.btnTabServices.Text = "Services";
            this.btnTabServices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTabServices.UseVisualStyleBackColor = true;
            this.btnTabServices.Click += new System.EventHandler(this.btnTabServices_Click);
            // 
            // btnTabDetails
            // 
            this.btnTabDetails.FlatAppearance.BorderSize = 0;
            this.btnTabDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabDetails.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.btnTabDetails.IconColor = System.Drawing.Color.Black;
            this.btnTabDetails.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTabDetails.IconSize = 150;
            this.btnTabDetails.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTabDetails.Location = new System.Drawing.Point(835, 90);
            this.btnTabDetails.Name = "btnTabDetails";
            this.btnTabDetails.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTabDetails.Size = new System.Drawing.Size(250, 250);
            this.btnTabDetails.TabIndex = 5;
            this.btnTabDetails.Text = "Details";
            this.btnTabDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTabDetails.UseVisualStyleBackColor = true;
            this.btnTabDetails.Click += new System.EventHandler(this.btnTabDetails_Click);
            // 
            // btnTabCleaning
            // 
            this.btnTabCleaning.FlatAppearance.BorderSize = 0;
            this.btnTabCleaning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabCleaning.IconChar = FontAwesome.Sharp.IconChar.ConciergeBell;
            this.btnTabCleaning.IconColor = System.Drawing.Color.Black;
            this.btnTabCleaning.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTabCleaning.IconSize = 150;
            this.btnTabCleaning.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTabCleaning.Location = new System.Drawing.Point(554, 90);
            this.btnTabCleaning.Name = "btnTabCleaning";
            this.btnTabCleaning.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTabCleaning.Size = new System.Drawing.Size(250, 250);
            this.btnTabCleaning.TabIndex = 4;
            this.btnTabCleaning.Text = "Cleaning";
            this.btnTabCleaning.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTabCleaning.UseVisualStyleBackColor = true;
            this.btnTabCleaning.Click += new System.EventHandler(this.btnTabCleaning_Click);
            // 
            // btnTabFood
            // 
            this.btnTabFood.FlatAppearance.BorderSize = 0;
            this.btnTabFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabFood.IconChar = FontAwesome.Sharp.IconChar.Utensils;
            this.btnTabFood.IconColor = System.Drawing.Color.Black;
            this.btnTabFood.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTabFood.IconSize = 150;
            this.btnTabFood.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTabFood.Location = new System.Drawing.Point(275, 90);
            this.btnTabFood.Name = "btnTabFood";
            this.btnTabFood.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTabFood.Size = new System.Drawing.Size(250, 250);
            this.btnTabFood.TabIndex = 3;
            this.btnTabFood.Text = "Food";
            this.btnTabFood.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTabFood.UseVisualStyleBackColor = true;
            this.btnTabFood.Click += new System.EventHandler(this.btnTabFood_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 5);
            this.panel1.TabIndex = 1;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Controls.Add(this.btnTabContact);
            this.panelDesktop.Controls.Add(this.btnTabFood);
            this.panelDesktop.Controls.Add(this.btnTabPayment);
            this.panelDesktop.Controls.Add(this.btnTabCleaning);
            this.panelDesktop.Controls.Add(this.btnTabServices);
            this.panelDesktop.Controls.Add(this.btnTabDetails);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 55);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1350, 674);
            this.panelDesktop.TabIndex = 2;
            // 
            // TabMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TabMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TabMenu";
            this.Load += new System.EventHandler(this.New_Load);
            this.panelDesktop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnTabDetails;
        private FontAwesome.Sharp.IconButton btnTabCleaning;
        private FontAwesome.Sharp.IconButton btnTabFood;
        private FontAwesome.Sharp.IconButton btnTabContact;
        private FontAwesome.Sharp.IconButton btnTabPayment;
        private FontAwesome.Sharp.IconButton btnTabServices;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelDesktop;
    }
}