
namespace Hotel_Management_System
{
    partial class MainLogin
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
            this.btnLogin = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginClose = new FontAwesome.Sharp.IconButton();
            this.lnklblChangePw = new System.Windows.Forms.LinkLabel();
            this.txtUserNameLogin = new System.Windows.Forms.TextBox();
            this.txtPwLogin = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.icnUser = new FontAwesome.Sharp.IconButton();
            this.icnKey = new FontAwesome.Sharp.IconButton();
            this.lnklblClearFields = new System.Windows.Forms.LinkLabel();
            this.txtNewPwLogin = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtConfirmPwLogin = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblCrntPw = new System.Windows.Forms.Label();
            this.lblNewPw = new System.Windows.Forms.Label();
            this.lblConfrimPw = new System.Windows.Forms.Label();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnLogin.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLogin.IconColor = System.Drawing.Color.Black;
            this.btnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogin.Location = new System.Drawing.Point(54, 500);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(370, 52);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hotel_Management_System.Properties.Resources.Asset_1_8;
            this.pictureBox1.Location = new System.Drawing.Point(54, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Khaki;
            this.label1.Location = new System.Drawing.Point(169, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 45);
            this.label1.TabIndex = 9;
            this.label1.Text = "LOG IN";
            // 
            // LoginClose
            // 
            this.LoginClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.LoginClose.FlatAppearance.BorderSize = 0;
            this.LoginClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.LoginClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LoginClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LoginClose.IconSize = 25;
            this.LoginClose.Location = new System.Drawing.Point(432, 12);
            this.LoginClose.Name = "LoginClose";
            this.LoginClose.Size = new System.Drawing.Size(28, 26);
            this.LoginClose.TabIndex = 11;
            this.LoginClose.UseVisualStyleBackColor = false;
            this.LoginClose.Click += new System.EventHandler(this.LoginClose_Click);
            // 
            // lnklblChangePw
            // 
            this.lnklblChangePw.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(90)))));
            this.lnklblChangePw.AutoSize = true;
            this.lnklblChangePw.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lnklblChangePw.Location = new System.Drawing.Point(279, 573);
            this.lnklblChangePw.Name = "lnklblChangePw";
            this.lnklblChangePw.Size = new System.Drawing.Size(122, 17);
            this.lnklblChangePw.TabIndex = 8;
            this.lnklblChangePw.TabStop = true;
            this.lnklblChangePw.Text = "Change Password";
            this.lnklblChangePw.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnklblChangePw.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblChangePw_LinkClicked);
            // 
            // txtUserNameLogin
            // 
            this.txtUserNameLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtUserNameLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserNameLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserNameLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtUserNameLogin.Location = new System.Drawing.Point(114, 295);
            this.txtUserNameLogin.Name = "txtUserNameLogin";
            this.txtUserNameLogin.Size = new System.Drawing.Size(289, 38);
            this.txtUserNameLogin.TabIndex = 1;
            this.txtUserNameLogin.TextChanged += new System.EventHandler(this.txtUserNameLogin_TextChanged);
            // 
            // txtPwLogin
            // 
            this.txtPwLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtPwLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPwLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPwLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPwLogin.Location = new System.Drawing.Point(114, 353);
            this.txtPwLogin.Name = "txtPwLogin";
            this.txtPwLogin.PasswordChar = '*';
            this.txtPwLogin.Size = new System.Drawing.Size(289, 42);
            this.txtPwLogin.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(114, 328);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 1);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Location = new System.Drawing.Point(114, 386);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 1);
            this.panel2.TabIndex = 5;
            // 
            // icnUser
            // 
            this.icnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.icnUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.icnUser.FlatAppearance.BorderSize = 0;
            this.icnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnUser.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.icnUser.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.icnUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icnUser.IconSize = 40;
            this.icnUser.Location = new System.Drawing.Point(47, 291);
            this.icnUser.Name = "icnUser";
            this.icnUser.Size = new System.Drawing.Size(57, 52);
            this.icnUser.TabIndex = 60;
            this.icnUser.UseVisualStyleBackColor = false;
            // 
            // icnKey
            // 
            this.icnKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.icnKey.FlatAppearance.BorderSize = 0;
            this.icnKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnKey.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.icnKey.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.icnKey.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icnKey.IconSize = 40;
            this.icnKey.Location = new System.Drawing.Point(43, 347);
            this.icnKey.Name = "icnKey";
            this.icnKey.Size = new System.Drawing.Size(57, 52);
            this.icnKey.TabIndex = 70;
            this.icnKey.UseVisualStyleBackColor = false;
            // 
            // lnklblClearFields
            // 
            this.lnklblClearFields.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(90)))));
            this.lnklblClearFields.AutoSize = true;
            this.lnklblClearFields.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lnklblClearFields.Location = new System.Drawing.Point(321, 399);
            this.lnklblClearFields.Name = "lnklblClearFields";
            this.lnklblClearFields.Size = new System.Drawing.Size(82, 17);
            this.lnklblClearFields.TabIndex = 7;
            this.lnklblClearFields.TabStop = true;
            this.lnklblClearFields.Text = "Clear Fields";
            this.lnklblClearFields.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblClearFields_LinkClicked);
            // 
            // txtNewPwLogin
            // 
            this.txtNewPwLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtNewPwLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPwLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPwLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNewPwLogin.Location = new System.Drawing.Point(114, 405);
            this.txtNewPwLogin.Name = "txtNewPwLogin";
            this.txtNewPwLogin.PasswordChar = '*';
            this.txtNewPwLogin.Size = new System.Drawing.Size(289, 42);
            this.txtNewPwLogin.TabIndex = 3;
            this.txtNewPwLogin.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Location = new System.Drawing.Point(114, 439);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(289, 1);
            this.panel3.TabIndex = 15;
            this.panel3.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel4.Location = new System.Drawing.Point(114, 495);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(289, 1);
            this.panel4.TabIndex = 16;
            this.panel4.Visible = false;
            // 
            // txtConfirmPwLogin
            // 
            this.txtConfirmPwLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtConfirmPwLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPwLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPwLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtConfirmPwLogin.Location = new System.Drawing.Point(114, 464);
            this.txtConfirmPwLogin.Name = "txtConfirmPwLogin";
            this.txtConfirmPwLogin.PasswordChar = '*';
            this.txtConfirmPwLogin.Size = new System.Drawing.Size(289, 42);
            this.txtConfirmPwLogin.TabIndex = 4;
            this.txtConfirmPwLogin.Visible = false;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblUserName.Location = new System.Drawing.Point(12, 313);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(55, 17);
            this.lblUserName.TabIndex = 18;
            this.lblUserName.Text = "Sraff ID";
            this.lblUserName.Visible = false;
            // 
            // lblCrntPw
            // 
            this.lblCrntPw.AutoSize = true;
            this.lblCrntPw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblCrntPw.Location = new System.Drawing.Point(12, 364);
            this.lblCrntPw.Name = "lblCrntPw";
            this.lblCrntPw.Size = new System.Drawing.Size(69, 34);
            this.lblCrntPw.TabIndex = 19;
            this.lblCrntPw.Text = "Current \r\nPassword";
            this.lblCrntPw.Visible = false;
            // 
            // lblNewPw
            // 
            this.lblNewPw.AutoSize = true;
            this.lblNewPw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblNewPw.Location = new System.Drawing.Point(12, 418);
            this.lblNewPw.Name = "lblNewPw";
            this.lblNewPw.Size = new System.Drawing.Size(69, 34);
            this.lblNewPw.TabIndex = 20;
            this.lblNewPw.Text = "New \r\nPassword";
            this.lblNewPw.Visible = false;
            // 
            // lblConfrimPw
            // 
            this.lblConfrimPw.AutoSize = true;
            this.lblConfrimPw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblConfrimPw.Location = new System.Drawing.Point(12, 474);
            this.lblConfrimPw.Name = "lblConfrimPw";
            this.lblConfrimPw.Size = new System.Drawing.Size(69, 34);
            this.lblConfrimPw.TabIndex = 21;
            this.lblConfrimPw.Text = "Confirm \r\nPassword";
            this.lblConfrimPw.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnUpdate.IconColor = System.Drawing.Color.Black;
            this.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdate.Location = new System.Drawing.Point(54, 555);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(370, 52);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update Password";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // MainLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(469, 673);
            this.Controls.Add(this.lblConfrimPw);
            this.Controls.Add(this.lblNewPw);
            this.Controls.Add(this.lblCrntPw);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtConfirmPwLogin);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtNewPwLogin);
            this.Controls.Add(this.lnklblClearFields);
            this.Controls.Add(this.LoginClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.icnKey);
            this.Controls.Add(this.icnUser);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtPwLogin);
            this.Controls.Add(this.txtUserNameLogin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lnklblChangePw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainLogin";
            this.Load += new System.EventHandler(this.MainLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton LoginClose;
        private System.Windows.Forms.LinkLabel lnklblChangePw;
        private System.Windows.Forms.TextBox txtUserNameLogin;
        private System.Windows.Forms.TextBox txtPwLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton icnUser;
        private FontAwesome.Sharp.IconButton icnKey;
        private System.Windows.Forms.LinkLabel lnklblClearFields;
        private System.Windows.Forms.TextBox txtNewPwLogin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtConfirmPwLogin;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblCrntPw;
        private System.Windows.Forms.Label lblNewPw;
        private System.Windows.Forms.Label lblConfrimPw;
        private FontAwesome.Sharp.IconButton btnUpdate;
    }
}