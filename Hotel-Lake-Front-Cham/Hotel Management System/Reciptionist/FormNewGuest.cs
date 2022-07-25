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
    public partial class FormNewGuest : Form
    {

        Form currentForm;

        public FormNewGuest()
        {
            InitializeComponent();
        }


        private void OpenForm(Form childForm)
        {
            //open only form
            if (currentForm != null)
            {
                currentForm.Close();
            }
            currentForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            //panel1.Dock = DockStyle.Fill;
            panelGuest.Controls.Add(childForm);
            panelGuest.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //titleCurrent.Text = childForm.Text;

        }


        private void btnGuestFurther_Click(object sender, EventArgs e)
        {
            OpenForm(new FormNewGuestNext()); 
        }


        private void cbForeign_CheckedChanged(object sender, EventArgs e)
        {
            if (cbForeign.Checked)
            {
                lblNIC.Text = "Passport No";

                mtbTP1.Mask = "(+0) 000-000-0000";
                mtbTP2.Mask = "(+0) 000-000-0000";

                mtbNIC.Mask = null;

                radioMale.Visible = true;
                radioFemale.Visible = true;
                lblGender.Visible = false;
                icnId.Visible = false;

            }

            else
            {
                lblNIC.Text = "National ID";
                mtbTP1.Mask = "(\\000) 000-0000";
                mtbTP2.Mask = "(\\000) 000-0000";
                mtbNIC.Mask = "000000000AAA";

                radioMale.Visible = false;
                radioFemale.Visible = false;
                lblGender.Visible = true;
              
            }
        }

        private void mtbNIC_MouseClick(object sender, MouseEventArgs e)
        {
            if (cbForeign.Checked == false)
            {
                mtbNIC.SelectionStart = mtbNIC.Text.Length;
                // mtbNIC.SelectionStart = 0;
            }
        }


        private void mtbTP1_Click(object sender, EventArgs e)
        {
            mtbTP1.SelectionStart = 2;
        }


        private void mtbTP2_MouseClick(object sender, MouseEventArgs e)
        {
            mtbTP2.SelectionStart = 2;
        }


        private void mtbEmail_Enter(object sender, EventArgs e)
        {
            if (mtbEmail.Text == "example@gmail.com")
            {
                mtbEmail.Text = "";
                mtbEmail.ForeColor = Color.FromArgb(26, 25, 62);
            }
        }


        private void mtbEmail_Leave(object sender, EventArgs e)
        {
            if (mtbEmail.Text == "")
            {
                mtbEmail.Text = "example@gmail.com";
                mtbEmail.ForeColor = Color.Gray;
            }
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbForeign.Checked)
            {
                cbForeign.Checked = false;
            }

            mtbNIC.Text = "";
            txtFName.Text = "";
            txtFullName.Text = "";
            radioMale.Checked = true;
            lblGender.Text = "";
            rchtxtAddress.Text = "";
            mtbTP1.Text = "";
            mtbTP2.Text = "";
            mtbEmail.Text = "example@gmail.com";
            mtbEmail.ForeColor = Color.Gray;

        }

        //create connection
        private MySqlConnection dbQuery()
        {
            DBConnection dBclass = new DBConnection();
            MySqlConnection conn = dBclass.getConnection();
            return conn;
        }

        //data adapter
        private void DataAdder(string sql, MySqlConnection conn)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.InsertCommand = new MySqlCommand(sql, conn);
            adapter.InsertCommand.ExecuteNonQuery();
            conn.Close();
        }

        //data reader
        private string DataReader(string sql, MySqlConnection conn)
        {
            string output = "";
            MySqlCommand command = new MySqlCommand(sql,conn);
            //command.Parameters.AddWithValue(txtFName,)
            MySqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                output += dataReader.GetValue(0).ToString();
            }
            return output;
        }


        private void FormNewGuest_Load(object sender, EventArgs e)
        {

            string today = DateTime.Now.ToString("yyyy-MM-dd (HH:MM)");

            lblSingleNormalCount.Text = DataReader("CALL getroomcount('" + today + "','SN')",dbQuery());
            lblSingleLuxuryCount.Text = DataReader("CALL getroomcount('" + today + "','SL')", dbQuery());
            lblDoubleNormalCount.Text = DataReader("CALL getroomcount('" + today + "','DN')", dbQuery());
            lblDoubleLuxuryCount.Text = DataReader("CALL getroomcount('" + today + "','DL')", dbQuery()); 
            lblFamilyNormalCount.Text = DataReader("CALL getroomcount('" + today + "','FN')", dbQuery()); 
            lblFamilyLuxuryCount.Text = DataReader("CALL getroomcount('" + today + "','FL')", dbQuery()); 

            radioMale.Visible = false;
            radioFemale.Visible = false;
            lblGender.Visible = true;

        }



        private void btnGuestSave_Click(object sender, EventArgs e)
        {

            if (mtbNIC.Text=="" || txtFName.Text == "" || txtFullName.Text == "" || rchtxtAddress.Text == "" || mtbTP1.Text == "" || mtbTP1.Text == "(0  )    -" || icnId.Visible == true)
            {

                DialogResult reslult = MessageBox.Show("Please fill all fields","", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else { 

                try {

                    DataAdder("CALL delGuest('"+ mtbNIC.Text + "')", dbQuery());

                    string idType;
                    string gender;
                    string email;

                    if (cbForeign.Checked) {                       
                        idType = "PASS";
                    }

                    else
                    {
                        idType = "NIC";
                    }

                    
                    if (radioMale.Checked || lblGender.Text == "Male")
                    {
                        gender = "M";
                    }

                    else
                    {
                        gender = "F";
                    }


                    if (mtbEmail.Text == "example@gmail.com")
                    {
                        email = "";
                    }

                    else
                    {
                        email = mtbEmail.Text;
                    }

                    
                    
                    string sql = "CALL addNewGuest('" + idType + "','" + mtbNIC.Text + "','" + txtFName.Text + "','" + txtFullName.Text + "','" + gender + "','" + email + "','" + rchtxtAddress.Text + "')";
                    DataAdder(sql,dbQuery());

                    string tp1 = "CALL addNewTP('"+ mtbNIC.Text +"','"+mtbTP1.Text +"')";
                    DataAdder(tp1, dbQuery());

                    if(mtbTP2.Text != "(0  )    -")
                    {
                        string tp2 = "CALL addNewTP('" + mtbNIC.Text + "','" + mtbTP2.Text + "')";
                        DataAdder(tp2, dbQuery());
                    }


                    DialogResult reslult = MessageBox.Show("Successfully saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if(reslult== DialogResult.OK)
                    {
                        if (cbForeign.Checked)
                        {
                            cbForeign.Checked = false;
                        }

                        mtbNIC.Text = "";
                        txtFName.Text = "";
                        txtFullName.Text = "";
                        radioMale.Checked = true;
                        lblGender.Text = "";
                        rchtxtAddress.Text = "";
                        mtbTP1.Text = "";
                        mtbTP2.Text = "";
                        mtbEmail.Text = "example@gmail.com";
                        mtbEmail.ForeColor = Color.Gray;
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void mtbNIC_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string fName = DataReader("SELECT FName FROM guest_details WHERE IDNumber = '" + mtbNIC.Text + "';", dbQuery());


                //string sql = "CALL getValuesById('" + mtbNIC.Text +"',"+@fName+","+@fullName+ "," + @Gen + "," + @Email +"," + @Addr + "," + @IDCategory + ");";

                if (fName != "")
                {
                    DialogResult reslult = MessageBox.Show("This is a registered customer. Do you want to fill in the data automatically??", "Confirm Autofill", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (reslult == DialogResult.Yes)
                    {
                        string fullName = DataReader("SELECT FullName FROM guest_details WHERE IDNumber = '" + mtbNIC.Text + "';", dbQuery());
                        string Gen = DataReader("SELECT Gender FROM guest_details WHERE IDNumber = '" + mtbNIC.Text + "';", dbQuery());
                        string Email = DataReader("SELECT Email FROM guest_details WHERE IDNumber = '" + mtbNIC.Text + "';", dbQuery());
                        string Addr = DataReader("SELECT GuestAddress FROM guest_details WHERE IDNumber = '" + mtbNIC.Text + "';", dbQuery());
                        string IDCategory = DataReader("SELECT IDCategory FROM guest_details WHERE IDNumber = '" + mtbNIC.Text + "';", dbQuery());
                        string TP = DataReader("CALL getTPbyID('" + mtbNIC.Text + "');", dbQuery());

                        txtFName.Text = fName;
                        txtFullName.Text = fullName;
                        mtbEmail.Text = Email;
                        mtbEmail.ForeColor = Color.FromArgb(26, 25, 62);
                        rchtxtAddress.Text = Addr;
                        mtbTP1.Text = TP;

                        if (Gen == "F")
                        {
                            radioFemale.Checked=true;
                            lblGender.Text = "Female";
                        }

                        else
                        {
                            radioMale.Checked = true;
                            lblGender.Text = "Male";
                        }


                        if (IDCategory == "PASS")
                        {
                            cbForeign.Checked = true;
                            
                        }

                        else if (IDCategory == "NIC")
                        {
                            cbForeign.Checked = false;
                        }


                    }
                    
                }

            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }

        }

        private void mtbNIC_Leave(object sender, EventArgs e)
        {
            if (cbForeign.Checked==false)
            {
                
                if (mtbNIC.Text != "") {

                    if (mtbNIC.Text.Length == 10) {

                        icnId.Visible = false;
                        string id = mtbNIC.Text.Substring(2, 3);
                        int g = Convert.ToInt32(id);

                        if (g > 500)
                        {
                            lblGender.Text = "Female";
                            radioFemale.Checked = true;
                        }

                        else
                        {
                            lblGender.Text = "Male";
                            radioMale.Checked = true;
                        }
                    }

                    else if(mtbNIC.Text.Length == 12)
                    {
                        icnId.Visible = false;
                        string id = mtbNIC.Text.Substring(4, 3);
                        int g = Convert.ToInt32(id);

                        if (g > 500)
                        {
                            lblGender.Text = "Female";
                            radioFemale.Checked = true;
                        }

                        else
                        {
                            lblGender.Text = "Male";
                            radioMale.Checked = true;
                        }
                    }

                    else
                    {
                        icnId.Visible = true;

                        ToolTip tt = new ToolTip();
                        tt.IsBalloon = true;
                        tt.InitialDelay = 0;
                        tt.AutoPopDelay = 1000000;
                        tt.UseAnimation = true;
                        tt.ShowAlways = true;
                        tt.SetToolTip(mtbNIC,"National Identity Card number should have at least 10 digits.");

                    }
                    
                }

                else
                {
                    lblGender.Text = "";
                }
                
            }
        }

        
    }
}
