using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using MySql.Data.MySqlClient;



namespace Hotel_Management_System
{
    public partial class GuestHistoryAdmin : Form
    {
        public static string strID;
        public GuestHistoryAdmin()
        {
            InitializeComponent();
            
        }

        private MySqlConnection dbQuery()
        {
            DBConnection dBclass = new DBConnection();
            MySqlConnection conn = dBclass.getConnection();
            return conn;
        }

        //data adapter
        private void DataAdapter(string sql, MySqlConnection conn)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "room");
            tblGuestDetails.DataSource = ds.Tables["room"];
            conn.Close();
        }

        //data adder
        private void DataAdder(string sql, MySqlConnection conn)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.InsertCommand = new MySqlCommand(sql, conn);
            adapter.InsertCommand.ExecuteNonQuery();
            conn.Close();
        }

        //data reader
        private void DataReader(string sql, MySqlConnection conn)
        {
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                comboID.Items.Add(dataReader.GetString("IDNumber"));
            }
            conn.Close();
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


        private void FormGuestDetails_Load(object sender, EventArgs e)
        {
            cbForeign.Visible = false;
            dateTimePicker1.Font = new Font("Microsoft Sans Serif", 18);
            tblGuestDetails.EnableHeadersVisualStyles = false;
            tblGuestDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 220);
            tblGuestDetails.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 13);
            tblGuestDetails.AlternatingRowsDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 13);
            tblGuestDetails.RowsDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 13);


            try
            {
                string Idvalues = "CALL getID";
                DataReader(Idvalues, dbQuery());
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

        }

        private void comboID_TextChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            string sql = "CALL getGuestDetailsByID('" + comboID.Text + "')";
            DataAdapter(sql, dbQuery());
            tblGuestDetails.Columns[0].Width = 220;
            tblGuestDetails.Columns[2].Width = 80;
        }

        private void dateTimePicker1_Enter(object sender, EventArgs e)
        {
            comboID.Text = null;
 
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd HH:mm");

            string sql = "CALL getGuestDetailsByDate('" + date + "')";
            DataAdapter(sql, dbQuery());
            tblGuestDetails.Columns[0].Width = 220;
            tblGuestDetails.Columns[2].Width = 80;
        }

        private void tblGuestDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cbForeign.Visible = true;
                btnReset.Visible = false;
                btnUpdate.Visible = false;
                //string date1 = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd HH:mm");
                string date = tblGuestDetails.Rows[e.RowIndex].Cells[0].Value.ToString();
                string id = tblGuestDetails.Rows[e.RowIndex].Cells[1].Value.ToString();
                string strRoomID = tblGuestDetails.Rows[e.RowIndex].Cells[2].Value.ToString();
                int roomID = int.Parse(strRoomID);

                lblRoomType.Text = DataReader1("Call getRoomCategorybyRoomID(" + roomID + ")", dbQuery());
                txtID.Text = id;
                strID = id;
                txtFName.Text = DataReader1("SELECT FName FROM guest_details WHERE IDNumber = (" + id + ")", dbQuery());
                txtFullName.Text = DataReader1("SELECT FullName FROM guest_details WHERE IDNumber = (" + id + ")", dbQuery());
                txtTP.Text = DataReader1("CALL getTPbyId (" + id + ")", dbQuery());
                txtAddress.Text = DataReader1("SELECT GuestAddress FROM guest_details WHERE IDNumber = (" + id + ")", dbQuery());
                txtEmail.Text = DataReader1("SELECT Email FROM guest_details WHERE IDNumber = (" + id + ")", dbQuery());
                lblAdate.Text = date;
                lblDdate.Text = DataReader1("CALL getDdate(" + roomID + ",'" + date + "')", dbQuery());
                lblCount.Text = DataReader1("SELECT (DATEDIFF(EndDate,  StartDate)) AS 'a' FROM room_booking WHERE RoomID = " + roomID + " AND StartDate ='" + date + "'", dbQuery());

                string foreign = DataReader1("SELECT IDCategory FROM guest_details WHERE IDNumber = (" + id + ")", dbQuery());

                if (foreign == "NIC")
                {
                    cbForeign.Checked = false;
                }

                else
                {
                    cbForeign.Checked = true;
                }

                string gender = DataReader1("SELECT Gender FROM guest_details WHERE IDNumber = (" + id + ")", dbQuery());
                if (gender == "M")
                {
                    radioMale.Checked = true;
                }

                else
                {
                    radioFemale.Checked = true;
                }


            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            btnReset.Visible = true;
            btnUpdate.Visible = true;
            string ID = txtID.Text;
        }


        private void cbForeign_Enter(object sender, EventArgs e)
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

        private void txtTP_Enter(object sender, EventArgs e)
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            tblGuestDetails_CellClick(this.tblGuestDetails, new DataGridViewCellEventArgs(this.tblGuestDetails.CurrentCell.ColumnIndex, this.tblGuestDetails.CurrentRow.Index));
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string gender;
            string IDtype;
            
            if (radioMale.Checked)
            {
                gender = "M";
            }

            else
            {
                gender = "F";
            }

            if (cbForeign.Checked)
            {
                IDtype = "PASS";
            }

            else
            {
                IDtype = "NIC";
            }

            try 
            {
                
                DialogResult reslult = MessageBox.Show("Do you want to save changes?", "Confirm changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (reslult == DialogResult.Yes)
                {
                    string sql = "CALL updateGuestDetails('" + txtID.Text + "','" + IDtype + "','" + txtFName.Text + "','" + txtFullName.Text + "','" + gender + "','" + txtEmail.Text + "','" + strID + "','" + txtAddress.Text + "')";
                    DataAdder(sql, dbQuery());
                    MessageBox.Show("Successfully Updated ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            
        }

        
    }
}
