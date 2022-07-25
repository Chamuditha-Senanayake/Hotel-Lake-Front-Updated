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
    public partial class FormNewGuestNext2 : Form
    {

        DateTimePicker DateTimePicker1;
        Form currentForm;

        public FormNewGuestNext2()
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
            panelGuestNext.Controls.Add(childForm);
            panelGuestNext.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //titleCurrent.Text = childForm.Text;

        }

        private MySqlConnection dbQuery()
        {
            DBConnection dBclass = new DBConnection();
            MySqlConnection conn = dBclass.getConnection();
            return conn;
        }


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
                output += dataReader.GetValue(0).ToString();//+" - "+ dataReader.GetValue(1).ToString() + " - " + dataReader.GetValue(2).ToString()+" - " + dataReader.GetValue(3).ToString() + " - " + dataReader.GetValue(4).ToString() + " - " + dataReader.GetValue(5).ToString() + " - " + dataReader.GetValue(6).ToString();
            }
            return output;
            conn.Close();
        }

  
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (comboID.Text != "")
            {
                DialogResult reslult = MessageBox.Show("Unsaved details will be not stored. Do you really want to load reservation details form without saving?", "Confirm Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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


        private void FormNewGuestNext_Load(object sender, EventArgs e)
        {
            
            tblReservationDetails.EnableHeadersVisualStyles = false;
            tblReservationDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 220);
            tblReservationDetails.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 13);
            tblReservationDetails.AlternatingRowsDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 13);
            tblReservationDetails.RowsDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 13);
            tblReservationDetails.ColumnHeadersHeight = 50;

            try
            {
                string Idvalues = "CALL getID";
                DataReader(Idvalues, dbQuery());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            /*tblReservationDetails.Rows.Add("983256985V", "Nawoda Jayasinghe");
            tblReservationDetails.Rows.Add("974569871V", "Sanju Hasintha");
            tblReservationDetails.Rows.Add("974569871V", "Sanju Hasintha");
            tblReservationDetails.Rows.Add("974569871V", "Sanju Hasintha");*/
        }

        private void comboID_Enter(object sender, EventArgs e)
        {
            icnId.Visible = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                string IDNo = comboID.Text;
                bool controler = false;

                //data in the each row will be added to the db
                for (int i = 0; i < tblReservationDetails.Rows.Count-1 ; i++)
                {

                    if (IDNo == "")
                    {
                        DialogResult reslult = MessageBox.Show("Please Select ID number", "Empty ID number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        icnId.Visible = true;
                        break;
                    }
                    else
                    {

                        string lastGID1 = "SELECT MAX(GuestID) FROM reservation";
                        string lastGID2 = DataReader1(lastGID1, dbQuery());
                        int GID = (int.Parse(lastGID2)) ;
                        //MessageBox.Show(GID.ToString());

                        string MID = tblReservationDetails.Rows[i].Cells[0].Value.ToString();
                        string MName = tblReservationDetails.Rows[i].Cells[1].Value.ToString();

                        string sqlResrv = "CALL addOtherGuest('" + GID + "','" + MID + "','" + MName + "')";
                        DataAdder(sqlResrv, dbQuery());

                        controler = true;

                    }
                }

                if (controler == false )
                {
                    DialogResult reslult = MessageBox.Show("Nothing to save", "Nothing to save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else if (controler == true && IDNo != "")
                {

                    MessageBox.Show("Successfully saved!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OpenForm(new FormNewGuestNext2());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    
}
