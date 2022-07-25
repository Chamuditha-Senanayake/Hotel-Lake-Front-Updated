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
    public partial class FormGuestDetails : Form
    {

        public FormGuestDetails()
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

        //data reader
        private void DataReader(string sql, MySqlConnection conn)
        {
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                comboID.Items.Add(dataReader.GetString("IDNumber"));
            }
        }

        private string DataReader1(string sql, MySqlConnection conn)
        {
            string output = "";
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                output += dataReader.GetValue(0).ToString();//+" - "+ dataReader.GetValue(1).ToString() + " - " + dataReader.GetValue(2).ToString()+" - " + dataReader.GetValue(3).ToString() + " - " + dataReader.GetValue(4).ToString() + " - " + dataReader.GetValue(5).ToString() + " - " + dataReader.GetValue(6).ToString();
            }
            return output;
        }

        private void FormGuestDetails_Load(object sender, EventArgs e)
        {
            lblForeign.Visible = false;
            dateTimePicker1.Font= new Font("Microsoft Sans Serif", 18);
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
                MessageBox.Show(ex.Message);
            }

            /*tblGuestDetails.Rows.Add("983256985V", "Nawoda Jayasinghe", "Nawoda Jayasinghe");
            tblGuestDetails.Rows.Add("974569871V", "Sanju Hasintha", "Nawoda Jayasinghe");
            tblGuestDetails.Rows.Add("974569871V", "Sanju Hasintha", "Nawoda Jayasinghe");
            tblGuestDetails.Rows.Add("974569871V", "Sanju Hasintha", "Nawoda Jayasinghe");*/
        }


        private void iconButton3_Click_1(object sender, EventArgs e)
        {

            FormMain newFormMain = new FormMain();
            this.Close();
            newFormMain.Visible = true;
            newFormMain.OpenForm(new FormPayments());
            newFormMain.ActivateButton(newFormMain.btnPayments, Color.FromArgb(253,138,114));

        }

        private void comboID_TextChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            string sql = "CALL getGuestDetailsByID('"+comboID.Text+"')";
            DataAdapter(sql, dbQuery());
            tblGuestDetails.Columns[1].Width = 140;
            tblGuestDetails.Columns[2].Width = 80;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            string date = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd HH:mm");

            string sql = "CALL getGuestDetailsByDate('" + date + "')";
            DataAdapter(sql, dbQuery());
            tblGuestDetails.Columns[1].Width = 140;
            tblGuestDetails.Columns[2].Width = 80;
        }

        private void dateTimePicker1_Enter(object sender, EventArgs e)
        {
            comboID.Text = null;
        }

        private void tblGuestDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //string date1 = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd HH:mm");
                string date = tblGuestDetails.Rows[e.RowIndex].Cells[0].Value.ToString();
                string id = tblGuestDetails.Rows[e.RowIndex].Cells[1].Value.ToString();
                string strRoomID = tblGuestDetails.Rows[e.RowIndex].Cells[2].Value.ToString();
                int roomID = int.Parse(strRoomID);

                lblRoomType.Text = DataReader1("Call getRoomCategorybyRoomID('" + roomID + "')", dbQuery());
                lblID.Text = id;
                lblFName.Text = DataReader1("SELECT FName FROM guest_details WHERE IDNumber = ('" + id + "')", dbQuery());
                lblFullName.Text = DataReader1("SELECT FullName FROM guest_details WHERE IDNumber = ('" + id + "')", dbQuery());
                lblGender.Text = DataReader1("SELECT Gender FROM guest_details WHERE IDNumber = ('" + id + "')", dbQuery());
                lblTP.Text = DataReader1("CALL getTPbyId ('" + id + "')", dbQuery());
                lblAddress.Text = DataReader1("SELECT GuestAddress FROM guest_details WHERE IDNumber = ('" + id + "')", dbQuery());
                lblEmail.Text = DataReader1("SELECT Email FROM guest_details WHERE IDNumber = ('" + id + "')", dbQuery());
                lblAdate.Text = date;
                lblDdate.Text = DataReader1("CALL getDdate(" + roomID + ",'" + date + "')", dbQuery());
                string foreign = DataReader1("SELECT IDCategory FROM guest_details WHERE IDNumber = ('" + id + "')", dbQuery());
                lblCount.Text= DataReader1("SELECT (DATEDIFF(EndDate,  StartDate)) AS 'a' FROM room_booking WHERE RoomID = "+roomID+ " AND StartDate ='" +date + "'", dbQuery());
                cbHotW.Checked = true;
                cbSatTV.Checked = true;

                if (foreign == "NIC")
                {
                    lblForeign.Visible = false;
                }

                else
                {
                    lblForeign.Visible = true;
                }

                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
