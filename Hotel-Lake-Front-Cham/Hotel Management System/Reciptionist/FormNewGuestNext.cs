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
    public partial class FormNewGuestNext : Form
    {
        DateTimePicker Datetp = new DateTimePicker();
        Rectangle rectangle1;
        Form currentForm;

        public FormNewGuestNext()
        {
            InitializeComponent();
            
            tblReservationDetails.Controls.Add(Datetp);
            Datetp.Visible = false;
            Datetp.Format = DateTimePickerFormat.Custom;
            Datetp.Value = DateTime.Now;
            Datetp.MinDate = DateTime.Today;
            Datetp.CustomFormat = "yyyy-MM-dd HH:mm";
            Datetp.TextChanged += new EventHandler(Datetp_TextChange);

        }


        private void OpenForm(Form childForm)
        {
            //open only form
            if (currentForm != null)
            {
                currentForm.Close();
            }
            currentForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelGuestNext.Controls.Add(childForm);
            panelGuestNext.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }


        //create connection
        private MySqlConnection dbQuery()
        {
            DBConnection dBclass = new DBConnection();
            MySqlConnection conn = dBclass.getConnection();
            return conn;
        }

        //data adapter
        private void DataAdapter(string sql, MySqlConnection conn)
        {
            /*MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.InsertCommand = new MySqlCommand(sql, conn);
            adapter.InsertCommand.ExecuteNonQuery();
            conn.Close();*/

            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "room");
            tblReservationDetails.DataSource = ds.Tables["room"];
            conn.Close();
        }

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



        private void FormNewGuestNext_Load(object sender, EventArgs e)
        {
            tblReservationDetails.EnableHeadersVisualStyles = false;
            tblReservationDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 220);
            tblReservationDetails.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif",12);

            try
            {
                string today = DateTime.Now.ToString("yyyy-MM-dd HH:mm");

                string sql = "CALL getFreeRooms('"+today+"')";
                string Idvalues = "CALL getID";
                DataAdapter(sql, dbQuery());
                DataReader(Idvalues, dbQuery());

                
                tblReservationDetails.Columns["No"].ReadOnly = true;
                tblReservationDetails.Columns["No"].DisplayIndex = 0;
                tblReservationDetails.Columns["No"].Width = 60;
                tblReservationDetails.Columns["No"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tblReservationDetails.Columns["Room Type"].ReadOnly = true;
                tblReservationDetails.Columns["Room Type"].DisplayIndex = 1;
                tblReservationDetails.Columns["Room Type"].Width = 200;
                //MessageBox.Show(tblReservationDetails.Columns[1].Name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            /*tblReservationDetails.Rows.Add(6, "Single Luxury");
            tblReservationDetails.Rows.Add(8, "Single Luxury");
            tblReservationDetails.Rows.Add(9, "Single Luxury");
            tblReservationDetails.Rows.Add(10, "Single Luxury");
            tblReservationDetails.Rows.Add(11, "Double Normal");
            tblReservationDetails.Rows.Add(12, "Double Normal");
            tblReservationDetails.Rows.Add(13, "Double Normal");
            tblReservationDetails.Rows.Add(14, "Double Normal");
            tblReservationDetails.Rows.Add(15, "Double Normal");*/



        }


        private void DPTextchange(Object sender, EventHandler e)
        {
            //tblReservationDetails.CurrentCell.Value = DateTimePicker1.Text.ToString();
        }

        private void DPClose(object sender, EventArgs e)
        {
           // DateTimePicker1.Visible = false;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (comboID.Text != "")
            {
                DialogResult reslult = MessageBox.Show("Unsaved details will be not stored. Do you really want to load other guest details form without saving?", "Confirm Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (comboID.Text != "")
            {
                DialogResult reslult = MessageBox.Show("Unsaved details will be not stored. Do you really want to load other guest details form without saving?", "Confirm Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (reslult == DialogResult.Yes)
                {
                    OpenForm(new FormNewGuestNext2());
                    //this.Close();
                }
            }

            else
            {
                OpenForm(new FormNewGuestNext2());
            }
           
        }

        private void tblReservationDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //reservation check box value
                bool cbResrvation = Convert.ToBoolean(tblReservationDetails.Rows[e.RowIndex].Cells[0].Value);

                int column = tblReservationDetails.CurrentCell.ColumnIndex;
                string headertext = tblReservationDetails.Columns[column].HeaderText;

                for (int i = 0; i < tblReservationDetails.Rows.Count - 1; i++)
                {
                    

                    if (cbResrvation == true)
                    {
                        //datepicker
                        if ((e.ColumnIndex == 1 && e.RowIndex >= 0) || (e.ColumnIndex == 2 && e.RowIndex >= 0))
                        {

                            rectangle1 = tblReservationDetails.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                            Datetp.Size = new Size(rectangle1.Width, rectangle1.Height);
                            Datetp.Location = new Point(rectangle1.X, rectangle1.Y);
                            Datetp.Visible = true;



                            /* DateTimePicker DateTimePicker1 = new DateTimePicker();
                            tblReservationDetails.Controls.Add(DateTimePicker1);
                            DateTimePicker1.Format = DateTimePickerFormat.Custom;
                            DateTimePicker1.CustomFormat = "yyyy-MM-dd ";

                            Rectangle displayCalendar = tblReservationDetails.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                            DateTimePicker1.Size = new Size(displayCalendar.Width, displayCalendar.Height);
                            DateTimePicker1.Location = new Point(displayCalendar.X, displayCalendar.Y);
                            DateTimePicker1.BringToFront();*/

                        }

                        //if reservation check box checked, other check boxes will be clickable
                        for (int n = 3; n < 8; n++)
                        {
                            if (Convert.ToBoolean(tblReservationDetails.Rows[e.RowIndex].Cells[n].ReadOnly) == true)
                            {
                                tblReservationDetails.Rows[e.RowIndex].Cells[n].ReadOnly = false;
                            }
                        }

                    }
                }


                if (cbResrvation == false)
                {

                    tblReservationDetails.Rows[e.RowIndex].Cells[1].Value = "";
                    tblReservationDetails.Rows[e.RowIndex].Cells[2].Value = "";
                    tblReservationDetails.Rows[e.RowIndex].Cells[1].ReadOnly = true;
                    tblReservationDetails.Rows[e.RowIndex].Cells[2].ReadOnly = true;

                    //if reservation check box unchecked, other check boxes will be disabled
                    for (int i = 3; i < 8; i++)
                    {
                        if (Convert.ToBoolean(tblReservationDetails.Rows[e.RowIndex].Cells[i].Value) == true)
                        {
                            tblReservationDetails.Rows[e.RowIndex].Cells[i].Value = false;
                        }
                    }

                    //if reservation check box unchecked, other check boxes will be unclickable
                    for (int i = 3; i < 8; i++)
                    {
                        if (Convert.ToBoolean(tblReservationDetails.Rows[e.RowIndex].Cells[i].ReadOnly) == false)
                        {
                            tblReservationDetails.Rows[e.RowIndex].Cells[i].ReadOnly = true;
                           
                        }
                    }

                }

            }
            catch(Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
        }


        private void Datetp_TextChange(object sender, EventArgs e)
        {
            for (int i = 0; i < tblReservationDetails.Rows.Count-1 ; i++)
            {
                tblReservationDetails.CurrentCell.Value = Datetp.Text.ToString();
                Datetp.Visible = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string IDNo = comboID.Text;
                bool controler = false;

                if (IDNo == "")
                {
                    DialogResult reslult = MessageBox.Show("Please Select ID number", "Empty ID number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    icnId.Visible = true;
                }
                else
                {
                    DialogResult reslult1 = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (reslult1 == DialogResult.Yes)
                    {
                        //data in the each row will be added to the db, if reservation cb checked
                        for (int i = 0; i < tblReservationDetails.Rows.Count; i++)
                        {
                            bool cbResrvation = Convert.ToBoolean(tblReservationDetails.Rows[i].Cells[0].Value);

                            if (cbResrvation == true)
                            {
                                string startDate = tblReservationDetails.Rows[i].Cells[1].Value.ToString();
                                string endDate = tblReservationDetails.Rows[i].Cells[2].Value.ToString();
                                string strRoom = tblReservationDetails.Rows[i].Cells[8].Value.ToString();
                                int room = int.Parse(strRoom);

                                //MessageBox.Show(endDate);
                                string lastGID1 = "SELECT MAX(GuestID) FROM reservation";
                                string lastGID2 = DataReader1(lastGID1, dbQuery());
                                int GID = (int.Parse(lastGID2)) + 1;
                                //MessageBox.Show(GID.ToString());

                                if (endDate == "")
                                {
                                    string sqlRoom = "CALL addRoomBooking2('" + GID + "','" + room + "','" + startDate + "')";
                                    DataAdder(sqlRoom, dbQuery());

                                    for (int j = 3; j < 8; j++)
                                    {
                                        if (Convert.ToBoolean(tblReservationDetails.Rows[i].Cells[j].Value))
                                        {

                                            int sID = j;
                                            string sqlService = "CALL addServiceBooking2('" + GID + "','" + room + "','" + sID + "','" + startDate + "')";
                                            DataAdder(sqlService, dbQuery());
                                        }
                                    }

                                    controler = true;

                                }

                                else
                                {
                                    string sqlRoom = "CALL addRoomBooking('" + GID + "','" + room + "','" + startDate + "','" + endDate + "')";
                                    DataAdder(sqlRoom, dbQuery());

                                    for (int j = 3; j < 8; j++)
                                    {
                                        if (Convert.ToBoolean(tblReservationDetails.Rows[i].Cells[j].Value))
                                        {

                                            int sID = j;
                                            string sqlService = "CALL addServiceBooking('" + GID + "','" + room + "','" + sID + "','" + startDate + "','" + endDate + "')";
                                            DataAdder(sqlService, dbQuery());
                                        }
                                    }

                                    controler = true;
                                }

                            }

                        }
                        if (controler == false && IDNo != "")
                        {
                            DialogResult reslult = MessageBox.Show("Empty Selection", "Nothing to save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                        else if (controler == true && IDNo != "")
                        {

                            string lastGID1 = "SELECT MAX(GuestID) FROM reservation";
                            string lastGID2 = DataReader1(lastGID1, dbQuery());
                            int GID = (int.Parse(lastGID2)) + 1;

                            string today = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                            //string sql = "INSERT INTO reservation(GuestID,IDNumber,StartDate) VALUES ('"+GID+"','"+IDNo+"','"+today+"')";
                            //DataAdder(sql, dbQuery());
                            string sqlResrv = "CALL addReservation('" + GID + "','" + IDNo + "','" + today + "')";
                            DataAdder(sqlResrv, dbQuery());

                            MessageBox.Show("Successfully saved!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            OpenForm(new FormNewGuestNext());

                        }
                    }
                }
                               
            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message);
            }

        }

        private void comboID_Enter(object sender, EventArgs e)
        {
            icnId.Visible = false;
        }

    }
    
}
