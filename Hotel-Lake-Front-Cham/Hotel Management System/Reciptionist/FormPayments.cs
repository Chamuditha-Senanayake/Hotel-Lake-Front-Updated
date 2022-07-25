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
    public partial class FormPayments : Form
    {
        public FormPayments()
        {
            InitializeComponent();
        }

        private void txtSearchFoodCashier_Enter(object sender, EventArgs e)
        {

        }

        private MySqlConnection dbQuery()
        {
            DBConnection dBclass = new DBConnection();
            MySqlConnection conn = dBclass.getConnection();
            return conn;
        }

        private void DataAdapter(String sql, MySqlConnection conn)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "food");
            tblGuestDetails.DataSource = ds.Tables["food"];
            conn.Close();
        }

        private void DataAdapter1(String sql, MySqlConnection conn)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "room_booking");
            tblRoomDetails.DataSource = ds.Tables["room_booking"];
            conn.Close();
        }

        private void DataAdapter2(String sql, MySqlConnection conn)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "service_booking");
            tblServiceDetails.DataSource = ds.Tables["service_booking"];
            conn.Close();
        }


        //data reader
        private string DataReader(string sql, MySqlConnection conn)
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


        private void DataReader2(string sql, MySqlConnection conn)
        {
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                comboID.Items.Add(dataReader.GetString("IDNumber"));
            }
        }

        private void DataAdder(string sql, MySqlConnection conn)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.InsertCommand = new MySqlCommand(sql, conn);
            adapter.InsertCommand.ExecuteNonQuery();
            conn.Close();
        }

        private void FormPayments_Load(object sender, EventArgs e)
        {
            lblFtotal.Text = "0";
            lblStotal.Text = "0";
            lblPaid.Text = "0";
            lblRtotal.Text = "0";
            lblTobePaid.Text = "0";
            lblTotal.Text = "0";
            txtpay.Text = "";
            dateTimePicker1.Font = new Font("Microsoft Sans Serif", 15);
            dateTimePicker2.Font = new Font("Microsoft Sans Serif", 15);
            dateTimePicker1.CustomFormat = "ddd dd MMM yyyy";
            dateTimePicker2.CustomFormat = "ddd dd MMM yyyy";
            tblGuestDetails.EnableHeadersVisualStyles = false;
            tblGuestDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 220);
            tblGuestDetails.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            tblGuestDetails.AlternatingRowsDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            tblGuestDetails.RowsDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);

            tblRoomDetails.EnableHeadersVisualStyles = false;
            tblRoomDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 220);
            tblRoomDetails.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            tblRoomDetails.AlternatingRowsDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            tblRoomDetails.RowsDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 13);

            tblServiceDetails.EnableHeadersVisualStyles = false;
            tblServiceDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 220);
            tblServiceDetails.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            tblServiceDetails.AlternatingRowsDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            tblServiceDetails.RowsDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);


            try
            {
                string Idvalues = "CALL getID";
                DataReader2(Idvalues, dbQuery());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.Value = DateTime.Now;
                dateTimePicker2.Value = DateTime.Now;
                string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm");

                string sql = "CALL getRoomsForPayment('" + comboID.Text + "','" + date + "')";
                DataAdapter(sql, dbQuery());

                lblRtotal.Text = "0";
                int rAmount = 0;

                for (int i = 0; i < tblGuestDetails.RowCount; i++)
                {

                    string room = tblGuestDetails.Rows[i].Cells["Room No"].Value.ToString();
                    string aDate = tblGuestDetails.Rows[i].Cells["Arrival"].Value.ToString();
                    string id = tblGuestDetails.Rows[i].Cells["ID No"].Value.ToString();

                    string gid = DataReader("CALL getGuestID ('" + id + "','"+date+"')", dbQuery());

                    string eDate = "'" + DataReader("SELECT DATE_FORMAT(EndDate, '%Y-%m-%d %T') FROM Room_booking WHERE RoomID='" + room + "' AND GuestID='" + gid + "'", dbQuery()) + "'";

                    if (eDate == "''")
                    {
                        eDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm");

                    }


                    int roomTotal = int.Parse(DataReader("CALL getReservationPayment(" + room + ",'" + aDate + "'," + eDate + ")", dbQuery()));

                    rAmount += roomTotal;
                    lblRtotal.Text = rAmount.ToString();
                    tblGuestDetails.Columns[0].Width = 200;
                    tblGuestDetails.Columns[2].Width = 80;
                    //MessageBox.Show(P.ToString());
                }



            }

            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

        }

        private void tblGuestDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnRelGuest.Visible = true;
            //comboID.Text= tblGuestDetails.Rows[e.RowIndex].Cells[1].Value.ToString();
            string sDate = tblGuestDetails.Rows[e.RowIndex].Cells[0].Value.ToString();
            string id = tblGuestDetails.Rows[e.RowIndex].Cells[1].Value.ToString();
            string room = tblGuestDetails.Rows[e.RowIndex].Cells[2].Value.ToString();
            string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            //comboID.Text = tblGuestDetails.Rows[e.RowIndex].Cells[1].Value.ToString();
            try
            {
                lblname.Text = DataReader("SELECT FullName FROM guest_details WHERE IDNumber='" + id + "'", dbQuery());

                string gid = DataReader("CALL getGuestID ('" + id + "','" + date + "')", dbQuery());
                string eDate = DataReader("SELECT DATE_FORMAT(EndDate, '%Y-%m-%d %T') FROM Room_booking WHERE RoomID='" + room + "' AND GuestID='" + gid + "'", dbQuery());
                //MessageBox.Show(eDate+gid+room);

                string roomDetails = "CALL getFoodPayment('" + room + "','" + sDate + "','" + eDate + "')";
                DataAdapter1(roomDetails, dbQuery());
                tblRoomDetails.Columns[0].Width = 80;
                tblRoomDetails.Columns[1].Width = 130;
                tblRoomDetails.Columns[2].Width = 130;
                tblRoomDetails.Columns[3].Width = 220;

                string serviceDetails = "CALL getServicePayment('" + room + "','" + sDate + "','" + eDate + "')";
                DataAdapter2(serviceDetails, dbQuery());
                tblServiceDetails.Columns[3].Width = 90;

                lblFtotal.Text = "0";
                lblStotal.Text = "0";
                int fAmount = 0;

                for (int i = 0; i < tblRoomDetails.RowCount; i++)
                {

                    int amount = int.Parse(tblRoomDetails.Rows[i].Cells["Price"].Value.ToString());
                    fAmount += amount;
                    lblFtotal.Text = fAmount.ToString();

                    //MessageBox.Show(fAmount.ToString());
                }

                int sAmount = 0;

                for (int i = 0; i < tblServiceDetails.RowCount; i++)
                {

                    int amount = int.Parse(tblServiceDetails.Rows[i].Cells["Charges"].Value.ToString());
                    sAmount += amount;
                    lblStotal.Text = sAmount.ToString();

                    //MessageBox.Show(sAmount.ToString());
                }

                lblTotal.Text = (int.Parse(lblRtotal.Text) + int.Parse(lblFtotal.Text) + int.Parse(lblStotal.Text)).ToString();
                lblPaid.Text = DataReader("SELECT SUM(Payment) FROM Payment WHERE GuestID ='"+gid+"'", dbQuery());
                if (lblPaid.Text == "")
                {
                    lblPaid.Text = "0";
                }
                lblTobePaid.Text = (int.Parse(lblTotal.Text) - int.Parse(lblPaid.Text)).ToString();
                
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }



        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string sDate = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm");
            string eDate = dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm");

            DataAdapter("CALL getRoomsPaymentByDate('" + sDate + "','" + eDate + "')", dbQuery());
            tblGuestDetails.Columns[0].Width = 200;
            tblGuestDetails.Columns[2].Width = 80;

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            string sDate = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm");
            string eDate = dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm");

            DataAdapter("CALL getRoomsPaymentByDate('" + sDate + "','" + eDate + "')", dbQuery());
            tblGuestDetails.Columns[0].Width = 200;
            tblGuestDetails.Columns[2].Width = 80;
        }

        private void dateTimePicker1_Enter(object sender, EventArgs e)
        {
            comboID.Items.Clear();
            try
            {
                tblGuestDetails.DataSource = false;
                tblRoomDetails.DataSource = false;
                tblServiceDetails.DataSource = false;
                lblFtotal.Text = "0";
                lblStotal.Text = "0";
                lblPaid.Text = "0";
                lblRtotal.Text = "0";
                lblTobePaid.Text = "0";
                lblTotal.Text = "0";
                txtpay.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dateTimePicker2_Enter(object sender, EventArgs e)
        {
            comboID.Items.Clear();
            try
            {
                tblGuestDetails.DataSource = false;
                tblRoomDetails.DataSource = false;
                tblServiceDetails.DataSource = false;
                lblFtotal.Text = "0";
                lblStotal.Text = "0";
                lblPaid.Text = "0";
                lblRtotal.Text = "0";
                lblTobePaid.Text = "0";
                lblTotal.Text = "0";
                txtpay.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboID_Enter(object sender, EventArgs e)
        {
            try
            {
                tblGuestDetails.DataSource = false;
                tblRoomDetails.DataSource = false;
                tblServiceDetails.DataSource = false;
                lblFtotal.Text = "0";
                lblStotal.Text = "0";
                lblPaid.Text = "0";
                lblRtotal.Text = "0";
                lblTobePaid.Text = "0";
                lblTotal.Text = "0";
                txtpay.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            comboID.Items.Clear();
            string Idvalues = "CALL getID";
            DataReader2(Idvalues, dbQuery());
            
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            if (txtpay.Text == "")
            {
                MessageBox.Show("Please Enter current payment amount", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                DialogResult reslult = MessageBox.Show("Is this a completed order?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (reslult == DialogResult.Yes)
                {
                    int toBePaid = int.Parse(lblTobePaid.Text);
                    int CurrentPay = int.Parse(txtpay.Text);
                    int dif = toBePaid - CurrentPay;

                    if (toBePaid > CurrentPay)
                    {
                        //lblFtotal.txt
                        MessageBox.Show("Payment Succeed. The amount to be paid is : " +" "+ dif, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                    {
                        MessageBox.Show("Payment Succeed", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        //string sql = "UPDATE room_booking SET room_booking.EndDate = '"+ eDate + "'   WHERE  reservation.IDNumber= '" + OID +"' AND ((room_booking.StartDate<= '"+ eDate + "' AND room_booking.EndDate>='" + eDate + "') OR (room_booking.StartDate<='" + eDate + "' AND room_booking.EndDate IS NULL));";
                        //DataAdder(sql,dbQuery());
                        //MessageBox.Show(eDate);


                    }

                    string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                    string id = tblGuestDetails.CurrentRow.Cells[1].Value.ToString();
                    string gid = DataReader("CALL getGuestID ('" + id + "','" + date + "')", dbQuery());

                    string sql = "INSERT INTO PAYMENT(GuestID, Payment, ToBePaid, date) VALUES ('" + gid + "'," + txtpay.Text + "," + ((int.Parse(lblTobePaid.Text)) - (int.Parse(txtpay.Text))) + ",'" + date + "')";
                    DataReader(sql, dbQuery());

                    lblPaid.Text = DataReader("SELECT SUM(Payment) FROM Payment WHERE GuestID ='" + gid + "'", dbQuery());
                    lblTobePaid.Text = (int.Parse(lblTotal.Text) - int.Parse(lblPaid.Text)).ToString();
                    txtpay.Text = "";
                    // MessageBox.Show(gid);

                    /*lblFtotal.Text = "0";
                    lblStotal.Text = "0";
                    lblPaid.Text = "0";
                    lblRtotal.Text = "0";
                    lblTobePaid.Text = "0";
                    lblTotal.Text = "0";
                    txtpay.Text = "";*/
                }


                try
                {


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
           
            
        }

        private void comboID_Leave(object sender, EventArgs e)
        {
           
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            try
            {
                tblGuestDetails.DataSource = false;
                tblRoomDetails.DataSource = false;
                tblServiceDetails.DataSource = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRelGuest_Click(object sender, EventArgs e)
        {
            DialogResult reslult = MessageBox.Show("Do you really want release this guest?", "Confirm Release", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (reslult == DialogResult.Yes)
            {
                string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                string id = tblGuestDetails.CurrentRow.Cells[1].Value.ToString();
                string gid = DataReader("CALL getGuestID ('" + id + "','" + date + "')", dbQuery());

                string RoomRel = "UPDATE Room_booking SET EndDate ='" + date + "'" + "WHERE GuestID =" + int.Parse(gid);
                DataReader(RoomRel,dbQuery());
                string ServiceRel = "UPDATE Service_booking SET EndDate ='"+date+"'"+"WHERE GuestID ="+int.Parse(gid);
                DataReader(ServiceRel, dbQuery());
                string GIDrel = "UPDATE Reservation SET EndDate ='" + date + "'" + "WHERE GuestID =" + int.Parse(gid);
                DataReader(ServiceRel, dbQuery());
                tblGuestDetails.DataSource = false;
                tblRoomDetails.DataSource = false;
                tblServiceDetails.DataSource = false;
                lblFtotal.Text = "0";
                lblStotal.Text = "0";
                lblPaid.Text = "0";
                lblRtotal.Text = "0";
                lblTobePaid.Text = "0";
                lblTotal.Text = "0";
                txtpay.Text = "";
            }
        }
    }
}

