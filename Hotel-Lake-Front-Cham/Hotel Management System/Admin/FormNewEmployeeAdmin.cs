using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace Hotel_Management_System
{
    public partial class FormNewEmployeeAdmin : Form
    {


        public FormNewEmployeeAdmin()
        {
            InitializeComponent();
        }


        private void mtbNIC_MouseClick(object sender, MouseEventArgs e)
        {
            mtbNIC.SelectionStart = mtbNIC.Text.Length;
           //MessageBox.Show(mtbNIC.Text.Length.ToString());
        }

        private void mtbTP1_MouseClick(object sender, MouseEventArgs e)
        {
            mtbTP1.SelectionStart = 2;
        }

        private void mtbTP2_MouseClick_1(object sender, MouseEventArgs e)
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

        private MySqlConnection dbQuery()
        {
            DBConnection dBclass = new DBConnection();
            MySqlConnection conn = dBclass.getConnection();
            return conn;
        }

        //data adder
        private void DataAdder(string sql, MySqlConnection conn)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.InsertCommand = new MySqlCommand(sql, conn);
            adapter.InsertCommand.ExecuteNonQuery();
            conn.Close();
        }

        private void DataReader(string sql, MySqlConnection conn)
        {
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                comboPID.Items.Add(dataReader.GetString("Position"));
            }
        }

        //data reader
        private string DataReader1(string sql, MySqlConnection conn)
        {
            string output = "";
            MySqlCommand command = new MySqlCommand(sql, conn);
            //command.Parameters.AddWithValue(txtFName,)
            MySqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                output += dataReader.GetValue(0).ToString();
            }
            return output;
        }


        private void FormNewEmployeeAdmin_Load(object sender, EventArgs e)
        {
            comboPID.Text = "";
            lblStaffID.ReadOnly = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (mtbNIC.Text == "" || txtFName.Text == "" || txtFullName.Text == "" || rchtxtAddress.Text == "" || mtbTP1.Text == "(0  )    -" || comboPID.Text=="" ||icnId.Visible == true)
            {

                DialogResult reslult = MessageBox.Show("Please fill all fields", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                DialogResult reslult = MessageBox.Show("Do you want to save New Staff Member?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (reslult == DialogResult.Yes)
                {
                    try
                    {

                        //DataAdder("CALL delGuest('" + mtbNIC.Text + "')", dbQuery());

                        string gender;
                        string email;
                        string tp2;

                        MemoryStream ms = new MemoryStream();
                        pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                        pictureBox2.Image.Save(ms, pictureBox2.Image.RawFormat);
                        byte[] img1 = ms.ToArray();
                        byte[] img2 = ms.ToArray();
                        



                        if (lblGender.Text == "Male")
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

                        if (mtbTP2.Text != "(0  )    -")
                        {
                            tp2 = "'" + mtbTP2.Text + "'";
                        }

                        else
                        {
                            tp2 = "NULL";
                        }

                        string Jdate = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
                        string PosID = DataReader1("SELECT PositionID from employee_position WHERE position = '" + comboPID.Text + "'", dbQuery());
                        string sql = "CALL addNewEmp('" + lblStaffID.Text + "','" + txtFName.Text + "','" + txtFullName.Text + "','" + PosID + "','" + mtbNIC.Text + "','" + gender + "','" + mtbTP1.Text + "'," + tp2 + ",'" + rchtxtAddress.Text + "','" + lblPw.Text + "','" + email + "','" + Jdate +"','"+ pictureBox1.Image + "','"+pictureBox2.Image + "')";
                        DataAdder(sql, dbQuery());

                        //string photo1 = "Update staff set " + img1 + " WHERE EmpID='" + lblStaffID.Text + "'";
                        //DataAdder(photo1, dbQuery());

                        //string photo2 = "INSERT INTO staff (CopyNIC) VALUES (" + img2 + ") WHERE EmpID='"+lblStaffID.Text+"'";
                       // DataAdder(photo2, dbQuery());

                        DialogResult reslult1 = MessageBox.Show("Successfully saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (reslult1 == DialogResult.OK)
                        {
                            mtbNIC.Text = "";
                            txtFName.Text = "";
                            txtFullName.Text = "";
                            lblGender.Text = "";
                            rchtxtAddress.Text = "";
                            mtbTP1.Text = "";
                            mtbTP2.Text = "";
                            mtbEmail.Text = "example@gmail.com";
                            mtbEmail.ForeColor = Color.Gray;
                            comboPID.Items.Clear();
                            lblStaffID.Text = "";
                            lblPw.Text = "";
                            dateTimePicker1.Value = DateTime.Now;
                            lblStaffID.ReadOnly = true;
                            pictureBox1.Image = null;
                            pictureBox2.Image = null;

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }       
        }

        private void comboFID_Enter(object sender, EventArgs e)
        {
            comboPID.Items.Clear();
            DataReader("SELECT Position FROM employee_position", dbQuery());
        }

        private void mtbNIC_Leave(object sender, EventArgs e)
        {

            if (mtbNIC.Text != "")
            {
                string idsub1 = "";

                if (mtbNIC.Text.Length == 10)
                {

                    icnId.Visible = false;
                    idsub1 = mtbNIC.Text.Substring(4, 4);
                    string idsub2 = mtbNIC.Text.Substring(2, 3);
                    int g = Convert.ToInt32(idsub2);

                    if (g > 500)
                    {
                        lblGender.Text = "Female";
                    }

                    else
                    {
                        lblGender.Text = "Male";
                    }

                    if (comboPID.Text != "")
                    {
                        string PosID = DataReader1("SELECT PositionID from employee_position WHERE position = '" + comboPID.Text + "'", dbQuery());
                        lblStaffID.Text = PosID + idsub1;
                        lblPw.Text = PosID + idsub1;
                    }
                }

                else if (mtbNIC.Text.Length == 12)
                {
                    icnId.Visible = false;
                    idsub1 = mtbNIC.Text.Substring(7, 4);
                    string idsub2 = mtbNIC.Text.Substring(4, 3);
                    int g = Convert.ToInt32(idsub2);

                    if (g > 500)
                    {
                        lblGender.Text = "Female";
                    }

                    else
                    {
                        lblGender.Text = "Male";
                    }

                    if (comboPID.Text != "")
                    {
                        string PosID = DataReader1("SELECT PositionID from employee_position WHERE position = '" + comboPID.Text + "'", dbQuery());
                        lblStaffID.Text = PosID + idsub1;
                        lblPw.Text = PosID + idsub1;

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
                    tt.SetToolTip(mtbNIC, "National Identity Card number should have at least 10 digits.");
                }
            }

            else
            {
                lblGender.Text = "";
            }
        }



        private void comboPID_TextChanged(object sender, EventArgs e)
        {
            if (comboPID.Text != "")
            {
                if (mtbNIC.Text.Length == 10)
                {
                    string idsub1 = mtbNIC.Text.Substring(4, 4);
                    string PosID = DataReader1("SELECT PositionID from employee_position WHERE position = '" + comboPID.Text + "'", dbQuery());
                    lblStaffID.Text = PosID + idsub1;
                    lblPw.Text = PosID + idsub1;
                }

                else if (mtbNIC.Text.Length == 12)
                {
                    string idsub1 = mtbNIC.Text.Substring(7, 4);
                    string PosID = DataReader1("SELECT PositionID from employee_position WHERE position = '" + comboPID.Text + "'", dbQuery());
                    lblStaffID.Text = PosID + idsub1;
                    lblPw.Text = PosID + idsub1;

                }
            }
        }

        private void lblStaffID_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lblStaffID.ReadOnly = false;
        }

        private void btnBcak_Click(object sender, EventArgs e)
        {
            if (mtbNIC.Text != "" || txtFName.Text != "" || txtFullName.Text != "" || rchtxtAddress.Text != "" || mtbTP1.Text != "(0  )    -")
            {

                DialogResult reslult = MessageBox.Show("Changes are not saved. Do you really want to close this form ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (reslult == DialogResult.Yes)
                {
                    this.Close();
                }

            }
            else
            {
                this.Close();
            }
        }

        private void btnPhotoUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image Files(*.jpg,*.jpeg,*.png)|*.jpg;*.jpeg;*.png";
            if (op.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(op.FileName);
            }

        }

        private void btnNICUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image Files(*.jpg,*.jpeg,*.png)|*.jpg;*.jpeg;*.png";
            if (op.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(op.FileName);
            }
        }
    }
}
