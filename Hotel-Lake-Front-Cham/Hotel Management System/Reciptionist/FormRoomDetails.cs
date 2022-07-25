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
    public partial class FormRoomDetails : Form
    {
        public FormRoomDetails()
        {
            InitializeComponent();
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
            adapter.Fill(ds, "room");
            tblbookedRooms.DataSource = ds.Tables["room"];
            conn.Close();
        }

        private void DataAdapter1(String sql, MySqlConnection conn)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "room");
            tblAvailableRooms.DataSource = ds.Tables["room"];
            conn.Close();
        }

        private void FormRoomDetails_Load(object sender, EventArgs e)
        {
            DateTimePicker date1 = new DateTimePicker();
            date1.Format = DateTimePickerFormat.Custom;
            date1.Value = DateTime.Now;

            string today = date1.Value.ToString("yyyy-MM-dd HH:mm:ss"); ;
            string bookedRooms = "CALL getBookedRooms('" + today + "')";
            DataAdapter(bookedRooms, dbQuery());

            tblbookedRooms.EnableHeadersVisualStyles = false;
            tblbookedRooms.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 220);
            tblbookedRooms.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 13);
            tblbookedRooms.AlternatingRowsDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 13);
            tblbookedRooms.RowsDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 13);
            tblbookedRooms.Columns[0].Width = 50;
            tblbookedRooms.Columns[1].Width = 150;
            tblbookedRooms.Columns[3].Width = 185;
            tblbookedRooms.Columns[4].Width = 205;

            string availableRooms = "CALL getFreeRooms('" + today + "')";
            DataAdapter1(availableRooms, dbQuery());

            tblAvailableRooms.EnableHeadersVisualStyles = false;
            tblAvailableRooms.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 220);
            tblAvailableRooms.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 13);
            tblAvailableRooms.AlternatingRowsDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 13);
            tblAvailableRooms.RowsDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 13);
            tblAvailableRooms.Columns[0].Width = 60;
            //tblAvailableRooms.Columns[1].Width = 120;




            /*tblLuxuryRooms.Rows.Add("1", "0001", "Saman Kumara",false);
            tblLuxuryRooms.Rows.Add("2", "0004", "Kavindu Ramesh", false);
            tblLuxuryRooms.Rows.Add("3", "", "",true);
            tblLuxuryRooms.Rows.Add("4", "0005", "Samantha Kumara", false);
            tblLuxuryRooms.Rows.Add("5", "0010", "Vimal Ramesh", false);
            tblLuxuryRooms.Rows.Add("6", "0015", "Vinul Kumara", false);
            tblLuxuryRooms.Rows.Add("7", "0002", "Kavinda Ramesh", false);
            tblLuxuryRooms.Rows.Add("8", "", "", true);
            tblLuxuryRooms.Rows.Add("9", "0011", "Saman Ramesh", false);
            tblLuxuryRooms.Rows.Add("10", "0040", "Kavindu Kumara", false);
            tblLuxuryRooms.Rows.Add("11", "0015", "Vimal Kumara", false);

            tblNormalRooms.Rows.Add("1", "0001", "Saman Kumara", false);
            tblNormalRooms.Rows.Add("2", "" , "" , true);
            tblNormalRooms.Rows.Add("3", "", "", true);
            tblNormalRooms.Rows.Add("4", "0005", "Samantha Kumara", false);
            tblNormalRooms.Rows.Add("5", "0010", "Vimal Ramesh", false);
            tblNormalRooms.Rows.Add("6", "0015", "Vinul Kumara", false);
            tblNormalRooms.Rows.Add("7", "","", true);
            tblNormalRooms.Rows.Add("8", "", "", true);
            tblNormalRooms.Rows.Add("9", "","", true);
            tblNormalRooms.Rows.Add("10", "0040", "Kavindu Kumara", false);
            tblNormalRooms.Rows.Add("11", "0015", "Vimal Kumara", false);*/

        }
    }
}
