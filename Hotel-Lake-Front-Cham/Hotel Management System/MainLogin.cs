using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotel_Management_System
{
    public partial class MainLogin : Form
    {
        public MainLogin()
        {
            InitializeComponent();
        }

        private MySqlConnection dbQuery()
        {
            DBConnection dBclass = new DBConnection();
            MySqlConnection conn = dBclass.getConnection();
            return conn;
        }

        private string DataReader1(string sql, MySqlConnection conn)
        {
            string output = "";
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                output += dataReader.GetValue(0).ToString();
            }
            conn.Close();
            return output;
        }

        private void DataAdder(string sql, MySqlConnection conn)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.InsertCommand = new MySqlCommand(sql, conn);
            adapter.InsertCommand.ExecuteNonQuery();
            conn.Close();
        }

        private void MainLogin_Load(object sender, EventArgs e)
        {
            btnUpdate.Visible = false;
        }


        private void iconButton2_Click(object sender, EventArgs e)
        {
            if ( txtUserNameLogin.Text.Length >= 3 && txtUserNameLogin.Text.Length <= 8 && txtPwLogin.Text != "")
            {
               try
                {
                    string user = DataReader1("getUserPw('" + txtUserNameLogin.Text + "')", dbQuery());
                    string level = txtUserNameLogin.Text.Substring(0, 3);
                    string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm");

                    if (user == txtPwLogin.Text) 
                    {
                        if (level == "ADM")
                        {

                            FormMainAdmin newFormAdmin = new FormMainAdmin();
                            newFormAdmin.Show();
                            this.Visible = false;
                            DataAdder("INSERT INTO userlogin(StaffID, LoginTime) VALUES ('"+ txtUserNameLogin.Text+"','"+date+"')", dbQuery());


                        }

                        else if (level == "RCP")
                        {
                            FormMain newFormMain = new FormMain();
                            newFormMain.Show();
                            this.Visible = false;
                            DataAdder("INSERT INTO userlogin (StaffID, LoginTime) VALUES ('" + txtUserNameLogin.Text + "','" + date + "')", dbQuery());

                        }

                        else if (level == "CSH")
                        {
                            FormMainCashier newFormMainCashier = new FormMainCashier();
                            newFormMainCashier.Show();
                            this.Visible = false;
                            DataAdder("INSERT INTO userlogin (StaffID, LoginTime) VALUES ('" + txtUserNameLogin.Text + "','" + date + "')", dbQuery());

                        }

                        else
                        {
                            MessageBox.Show("Access denied. You do not have permission to access this system.", "", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                        }

                    }

                    else
                    {
                        MessageBox.Show("Your Staff ID or Password is incorrect. Please try again", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch(Exception ex)
                {
                   MessageBox.Show("Your Staff ID or Password is incorrect. Please try again", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

               
            }

            else if(txtUserNameLogin.Text == "" || txtPwLogin.Text == "")
            {
                MessageBox.Show("Empty fields", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                MessageBox.Show("Your Staff ID or Password is incorrect. Please try again", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUserNameLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lnklblClearFields_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtUserNameLogin.Text = "";
            txtPwLogin.Text = "";
        }

        private void lnklblChangePw_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lnklblChangePw.Text == "Change Password") 
            { 
                lnklblClearFields.Visible = false;
                panel3.Visible = true;
                panel4.Visible = true;
                txtNewPwLogin.Visible = true;
                txtConfirmPwLogin.Visible = true;
                btnLogin.Visible = false;
                btnUpdate.Visible = true;
                icnUser.Visible = false;
                icnKey.Visible = false;
                lblUserName.Visible = true;
                lblCrntPw.Visible = true;
                lblNewPw.Visible = true;
                lblConfrimPw.Visible = true;
                lnklblChangePw.Text = "Log In";
                lnklblChangePw.Location = new Point(302, 631);
                txtUserNameLogin.Text = "";
                txtPwLogin.Text = "";
            }

            else if (lnklblChangePw.Text == "Log In")
            {
                lnklblClearFields.Visible = true;
                panel3.Visible = false;
                panel4.Visible = false;
                txtNewPwLogin.Visible = false;
                txtConfirmPwLogin.Visible = false;
                btnLogin.Visible = true;
                btnUpdate.Visible = false;
                icnUser.Visible = true;
                icnKey.Visible = true;
                lblUserName.Visible = false;
                lblCrntPw.Visible = false;
                lblNewPw.Visible = false;
                lblConfrimPw.Visible = false;
                lnklblChangePw.Text = "Change Password";
                lnklblChangePw.Location = new Point(279, 573);
                txtUserNameLogin.Text = "";
                txtPwLogin.Text = "";
                txtNewPwLogin.Text = "";
                txtConfirmPwLogin.Text = "";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string staffID = txtUserNameLogin.Text;
            string currntPw = txtPwLogin.Text;
            string newPw = txtNewPwLogin.Text;
            string confirmPw = txtConfirmPwLogin.Text;

            try
            {
                string userPw = DataReader1("getUserPw('" + txtUserNameLogin.Text + "')", dbQuery());

                if (userPw == currntPw)
                {
                    if (newPw == confirmPw)
                    {
                        DataAdder("UpdatePw('" + newPw +"','"+ staffID + "')", dbQuery());
                        MessageBox.Show("Password Changed", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtUserNameLogin.Text = "";
                        txtPwLogin.Text = "";
                        txtNewPwLogin.Text = "";
                        txtConfirmPwLogin.Text = "";
                    }

                    else
                    {
                        MessageBox.Show("Your confirmation Password does not match with the new password. Please try again", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                    MessageBox.Show("Your Staff ID or Current Password is incorrect. Please try again", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
