using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using MySql.Data.MySqlClient;

namespace Hotel_Management_System
{
    public partial class FormEmployeeAdmin : Form
    {

        Form currentForm;

        static string OldSid;

        public FormEmployeeAdmin()
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
    

        private void iconButton1_Click(object sender, EventArgs e)
        {
            OpenForm(new FormNewEmployeeAdmin());
        }


        private void txtSearchFoodCashier_Enter(object sender, EventArgs e)
        {
            if (txtSearchFoodCashier.Text == "Search")
            {
                txtSearchFoodCashier.Text = "";
                txtSearchFoodCashier.ForeColor = Color.Black;
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
            conn.Close();
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
            conn.Close();
            return output;
            
        }

        private void DataAdapter(String sql, MySqlConnection conn)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "food");
            tblFoodDetails.DataSource = ds.Tables["food"];
            conn.Close();
        }


        public void FormEmployeeAdmin_Load(object sender, EventArgs e)
        {

            comboPID.Text = "";

            string sql = "CALL getAllStaff";
            DataAdapter(sql, dbQuery());

            tblFoodDetails.EnableHeadersVisualStyles = false;
            tblFoodDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 220);
            tblFoodDetails.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 16);
            tblFoodDetails.Columns[0].Width = 160;
            tblFoodDetails.Columns[2].Width = 240;
        }

        private void txtSearchFoodCashier_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "CALL getStaffByName('%" + txtSearchFoodCashier.Text + "%')";
                DataAdapter(sql, dbQuery());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tblFoodDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnUpdate.Visible = false;
                btnReset.Visible = false;
                btnUpdate.Visible = false;

                string SID = tblFoodDetails.Rows[e.RowIndex].Cells[0].Value.ToString();

                lblSID.Text = SID;
                OldSid = SID;
                txtID.Text = DataReader1("SELECT EmpNIC FROM staff WHERE EmpID = ('" + SID + "')", dbQuery());
                txtFName.Text = DataReader1("SELECT EmpFName FROM staff WHERE EmpID = ('" + SID + "')", dbQuery());
                txtFullName.Text = DataReader1("SELECT EmpFullName FROM staff WHERE EmpID = ('" + SID + "')", dbQuery());
                txtTP1.Text = DataReader1("SELECT EmpFullName FROM staff WHERE EmpID = ('" + SID + "')", dbQuery());
                txtEmail.Text = DataReader1("SELECT EmpEmail FROM staff WHERE EmpID = ('" + SID + "')", dbQuery());
                txtAddress.Text = DataReader1("SELECT EmpAddress FROM staff WHERE EmpID = ('" + SID + "')", dbQuery());
                txtTP1.Text = DataReader1("SELECT TP1 FROM staff WHERE EmpID = ('" + SID + "')", dbQuery());
                txtTP2.Text = DataReader1("SELECT TP2 FROM staff WHERE EmpID = ('" + SID + "')", dbQuery());
                lblDate.Text= DataReader1("SELECT DATE_FORMAT(JoiningDate, '%Y-%m-%d') FROM staff WHERE EmpID = ('" + SID + "')", dbQuery());
                string gen = DataReader1("SELECT Gender FROM staff WHERE EmpID = ('" + SID + "')", dbQuery());

                if(gen == "M")
                {
                    radioMale.Checked = true;
                }

                else
                {
                    radioFemale.Checked = true;
                }

                comboPID.Items.Clear(); 
                comboPID.Items.Add(tblFoodDetails.Rows[e.RowIndex].Cells[2].Value.ToString());
                comboPID.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            btnReset.Visible = true;
            btnUpdate.Visible = true;
        }

        private void txtFName_Enter(object sender, EventArgs e)
        {
            btnReset.Visible = true;
            btnUpdate.Visible = true;
        }

        private void txtFullName_Enter(object sender, EventArgs e)
        {
            btnReset.Visible = true;
            btnUpdate.Visible = true;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            btnReset.Visible = true;
            btnUpdate.Visible = true;
        }

        private void txtTP1_Enter(object sender, EventArgs e)
        {
            btnReset.Visible = true;
            btnUpdate.Visible = true;
        }

        private void txtTP2_Enter(object sender, EventArgs e)
        {
            btnReset.Visible = true;
            btnUpdate.Visible = true;
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            btnReset.Visible = true;
            btnUpdate.Visible = true;
        }

        private void txtAddress_Enter(object sender, EventArgs e)
        {
            btnReset.Visible = true;
            btnUpdate.Visible = true;
        }

        private void comboPID_Enter(object sender, EventArgs e)
        {
            comboPID.Items.Clear();
            DataReader("SELECT Position FROM employee_position", dbQuery());
            btnReset.Visible = true;
            btnUpdate.Visible = true;
        }

        private void comboPID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string SubSid = lblSID.Text.Substring(3, 4);

                string posID = DataReader1("SELECT PositionID FROM employee_position WHERE Position = ('" + comboPID.Text + "')", dbQuery());
                lblSID.Text = posID + SubSid;
            }
            catch(Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tblFoodDetails_CellClick(this.tblFoodDetails, new DataGridViewCellEventArgs(this.tblFoodDetails.CurrentCell.ColumnIndex, this.tblFoodDetails.CurrentRow.Index));

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtFName.Text == "" || txtFullName.Text == "" || txtTP1.Text == "" || txtAddress.Text == "" || comboPID.Text=="")
            {
                MessageBox.Show("Fill all the fields before update ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                try
                {
                    DialogResult reslult = MessageBox.Show("Do you want to save changes?", "Confirm changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (reslult == DialogResult.Yes)
                    {
                        string sid = lblSID.Text;
                        string gen = "";

                        if (radioMale.Checked == true)
                        {
                            gen = "M";
                        }

                        else
                        {
                            gen = "F";
                        }

                        string posID = lblSID.Text.Substring(0, 3);
      
                        string sql = "CALL updateStaff('"+ lblSID.Text+"','"+ txtFName.Text + "','" +txtFullName.Text + "','" + posID + "','" + gen + "','" + txtTP1.Text + "','" + txtTP2.Text + "','" + txtAddress.Text + "','" + txtEmail.Text + "','" + OldSid + "')";
                        DataAdder(sql, dbQuery());

                        if (OldSid != lblSID.Text)
                        {
                            MessageBox.Show("Successfully Updated.\n\n New Staff ID : " + lblSID.Text, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        else 
                        {
                            MessageBox.Show("Successfully Updated", "" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

    }
}
