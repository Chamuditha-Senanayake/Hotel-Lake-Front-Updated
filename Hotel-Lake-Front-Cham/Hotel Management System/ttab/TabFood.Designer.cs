
namespace Hotel_Management_System
{
    partial class TabFood
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnNotifications = new FontAwesome.Sharp.IconButton();
            this.btnPayments = new FontAwesome.Sharp.IconButton();
            this.btnStaffDetails = new FontAwesome.Sharp.IconButton();
            this.btnFoodDetails = new FontAwesome.Sharp.IconButton();
            this.btnRoomDetails = new FontAwesome.Sharp.IconButton();
            this.btnGuestDetails = new FontAwesome.Sharp.IconButton();
            this.btnNewGuest = new FontAwesome.Sharp.IconButton();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMenu.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnNotifications);
            this.panelMenu.Controls.Add(this.btnPayments);
            this.panelMenu.Controls.Add(this.btnStaffDetails);
            this.panelMenu.Controls.Add(this.btnFoodDetails);
            this.panelMenu.Controls.Add(this.btnRoomDetails);
            this.panelMenu.Controls.Add(this.btnGuestDetails);
            this.panelMenu.Controls.Add(this.btnNewGuest);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(230, 609);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // btnNotifications
            // 
            this.btnNotifications.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNotifications.FlatAppearance.BorderSize = 0;
            this.btnNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotifications.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotifications.ForeColor = System.Drawing.Color.White;
            this.btnNotifications.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.btnNotifications.IconColor = System.Drawing.Color.White;
            this.btnNotifications.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNotifications.IconSize = 32;
            this.btnNotifications.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotifications.Location = new System.Drawing.Point(0, 408);
            this.btnNotifications.Margin = new System.Windows.Forms.Padding(2);
            this.btnNotifications.Name = "btnNotifications";
            this.btnNotifications.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnNotifications.Size = new System.Drawing.Size(230, 68);
            this.btnNotifications.TabIndex = 7;
            this.btnNotifications.Text = "Notifications";
            this.btnNotifications.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotifications.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNotifications.UseVisualStyleBackColor = true;
            this.btnNotifications.Click += new System.EventHandler(this.btnNotifications_Click);
            // 
            // btnPayments
            // 
            this.btnPayments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPayments.FlatAppearance.BorderSize = 0;
            this.btnPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayments.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayments.ForeColor = System.Drawing.Color.White;
            this.btnPayments.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.btnPayments.IconColor = System.Drawing.Color.White;
            this.btnPayments.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPayments.IconSize = 32;
            this.btnPayments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayments.Location = new System.Drawing.Point(0, 340);
            this.btnPayments.Margin = new System.Windows.Forms.Padding(2);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnPayments.Size = new System.Drawing.Size(230, 68);
            this.btnPayments.TabIndex = 6;
            this.btnPayments.Text = "Beverage";
            this.btnPayments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPayments.UseVisualStyleBackColor = true;
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // btnStaffDetails
            // 
            this.btnStaffDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStaffDetails.FlatAppearance.BorderSize = 0;
            this.btnStaffDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffDetails.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffDetails.ForeColor = System.Drawing.Color.White;
            this.btnStaffDetails.IconChar = FontAwesome.Sharp.IconChar.PeopleArrows;
            this.btnStaffDetails.IconColor = System.Drawing.Color.White;
            this.btnStaffDetails.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStaffDetails.IconSize = 32;
            this.btnStaffDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaffDetails.Location = new System.Drawing.Point(0, 272);
            this.btnStaffDetails.Margin = new System.Windows.Forms.Padding(2);
            this.btnStaffDetails.Name = "btnStaffDetails";
            this.btnStaffDetails.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnStaffDetails.Size = new System.Drawing.Size(230, 68);
            this.btnStaffDetails.TabIndex = 5;
            this.btnStaffDetails.Text = "dessert";
            this.btnStaffDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaffDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStaffDetails.UseVisualStyleBackColor = true;
            this.btnStaffDetails.Click += new System.EventHandler(this.btnStaffDetails_Click);
            // 
            // btnFoodDetails
            // 
            this.btnFoodDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFoodDetails.FlatAppearance.BorderSize = 0;
            this.btnFoodDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoodDetails.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoodDetails.ForeColor = System.Drawing.Color.White;
            this.btnFoodDetails.IconChar = FontAwesome.Sharp.IconChar.Utensils;
            this.btnFoodDetails.IconColor = System.Drawing.Color.White;
            this.btnFoodDetails.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFoodDetails.IconSize = 32;
            this.btnFoodDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFoodDetails.Location = new System.Drawing.Point(0, 204);
            this.btnFoodDetails.Margin = new System.Windows.Forms.Padding(2);
            this.btnFoodDetails.Name = "btnFoodDetails";
            this.btnFoodDetails.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnFoodDetails.Size = new System.Drawing.Size(230, 68);
            this.btnFoodDetails.TabIndex = 4;
            this.btnFoodDetails.Text = "Snacks";
            this.btnFoodDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFoodDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFoodDetails.UseVisualStyleBackColor = true;
            this.btnFoodDetails.Click += new System.EventHandler(this.btnFoodDetails_Click);
            // 
            // btnRoomDetails
            // 
            this.btnRoomDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoomDetails.FlatAppearance.BorderSize = 0;
            this.btnRoomDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomDetails.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomDetails.ForeColor = System.Drawing.Color.White;
            this.btnRoomDetails.IconChar = FontAwesome.Sharp.IconChar.HouseUser;
            this.btnRoomDetails.IconColor = System.Drawing.Color.White;
            this.btnRoomDetails.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRoomDetails.IconSize = 32;
            this.btnRoomDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoomDetails.Location = new System.Drawing.Point(0, 136);
            this.btnRoomDetails.Margin = new System.Windows.Forms.Padding(2);
            this.btnRoomDetails.Name = "btnRoomDetails";
            this.btnRoomDetails.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnRoomDetails.Size = new System.Drawing.Size(230, 68);
            this.btnRoomDetails.TabIndex = 3;
            this.btnRoomDetails.Text = "Dinner";
            this.btnRoomDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoomDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRoomDetails.UseVisualStyleBackColor = true;
            this.btnRoomDetails.Click += new System.EventHandler(this.btnRoomDetails_Click);
            // 
            // btnGuestDetails
            // 
            this.btnGuestDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGuestDetails.FlatAppearance.BorderSize = 0;
            this.btnGuestDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuestDetails.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuestDetails.ForeColor = System.Drawing.Color.White;
            this.btnGuestDetails.IconChar = FontAwesome.Sharp.IconChar.UserTag;
            this.btnGuestDetails.IconColor = System.Drawing.Color.White;
            this.btnGuestDetails.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuestDetails.IconSize = 32;
            this.btnGuestDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuestDetails.Location = new System.Drawing.Point(0, 68);
            this.btnGuestDetails.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuestDetails.Name = "btnGuestDetails";
            this.btnGuestDetails.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnGuestDetails.Size = new System.Drawing.Size(230, 68);
            this.btnGuestDetails.TabIndex = 2;
            this.btnGuestDetails.Text = "Lunch";
            this.btnGuestDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuestDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuestDetails.UseVisualStyleBackColor = true;
            this.btnGuestDetails.Click += new System.EventHandler(this.btnGuestDetails_Click);
            // 
            // btnNewGuest
            // 
            this.btnNewGuest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewGuest.FlatAppearance.BorderSize = 0;
            this.btnNewGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewGuest.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGuest.ForeColor = System.Drawing.Color.White;
            this.btnNewGuest.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnNewGuest.IconColor = System.Drawing.Color.White;
            this.btnNewGuest.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNewGuest.IconSize = 32;
            this.btnNewGuest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewGuest.Location = new System.Drawing.Point(0, 0);
            this.btnNewGuest.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewGuest.Name = "btnNewGuest";
            this.btnNewGuest.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnNewGuest.Size = new System.Drawing.Size(230, 68);
            this.btnNewGuest.TabIndex = 1;
            this.btnNewGuest.Text = "Breakfast";
            this.btnNewGuest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewGuest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewGuest.UseVisualStyleBackColor = true;
            this.btnNewGuest.Click += new System.EventHandler(this.btnNewGuest_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.AutoSize = true;
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Controls.Add(this.button1);
            this.panelDesktop.Controls.Add(this.checkBox1);
            this.panelDesktop.Controls.Add(this.label3);
            this.panelDesktop.Controls.Add(this.dataGridView2);
            this.panelDesktop.Controls.Add(this.label2);
            this.panelDesktop.Controls.Add(this.label1);
            this.panelDesktop.Controls.Add(this.dataGridView1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDesktop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelDesktop.Location = new System.Drawing.Point(230, 0);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(798, 609);
            this.panelDesktop.TabIndex = 3;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelD_Paint);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(494, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "Order";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(431, 353);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(243, 28);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Add this amount to my bill";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rs 1600";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView2.Location = new System.Drawing.Point(378, 68);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(344, 97);
            this.dataGridView2.TabIndex = 3;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Name";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Quanitity";
            this.Column5.Name = "Column5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(554, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "001";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(440, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order No";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(21, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 441);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Price";
            this.Column2.Name = "Column2";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Quantity";
            this.Column6.Name = "Column6";
            // 
            // TabFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TabFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TabFood";
            this.Load += new System.EventHandler(this.New_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnNewGuest;
        private FontAwesome.Sharp.IconButton btnStaffDetails;
        private FontAwesome.Sharp.IconButton btnFoodDetails;
        private FontAwesome.Sharp.IconButton btnRoomDetails;
        private FontAwesome.Sharp.IconButton btnGuestDetails;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btnNotifications;
        private FontAwesome.Sharp.IconButton btnPayments;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}