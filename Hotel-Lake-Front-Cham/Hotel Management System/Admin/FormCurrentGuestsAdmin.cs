using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class FormCurrentGuestsAdmin : Form
    {
        public FormCurrentGuestsAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRoomDetails_Load(object sender, EventArgs e)
        {
            tblLuxuryRooms.Rows.Add("1", "0001", "Saman Kumara", false);
            tblLuxuryRooms.Rows.Add("2", "0004", "Kavindu Ramesh", false);
            tblLuxuryRooms.Rows.Add("3", "", "", true);
            tblLuxuryRooms.Rows.Add("4", "0005", "Samantha Kumara", false);
            tblLuxuryRooms.Rows.Add("5", "0010", "Vimal Ramesh", false);
            tblLuxuryRooms.Rows.Add("6", "0015", "Vinul Kumara", false);
            tblLuxuryRooms.Rows.Add("7", "0002", "Kavinda Ramesh", false);
            tblLuxuryRooms.Rows.Add("8", "", "", true);
            tblLuxuryRooms.Rows.Add("9", "0011", "Saman Ramesh", false);
            tblLuxuryRooms.Rows.Add("10", "0040", "Kavindu Kumara", false);
            tblLuxuryRooms.Rows.Add("11", "0015", "Vimal Kumara", false);

            tblNormalRooms.Rows.Add("1", "0001", "Saman Kumara", false);
            tblNormalRooms.Rows.Add("2", "", "", true);
            tblNormalRooms.Rows.Add("3", "", "", true);
            tblNormalRooms.Rows.Add("4", "0005", "Samantha Kumara", false);
            tblNormalRooms.Rows.Add("5", "0010", "Vimal Ramesh", false);
            tblNormalRooms.Rows.Add("6", "0015", "Vinul Kumara", false);
            tblNormalRooms.Rows.Add("7", "", "", true);
            tblNormalRooms.Rows.Add("8", "", "", true);
            tblNormalRooms.Rows.Add("9", "", "", true);
            tblNormalRooms.Rows.Add("10", "0040", "Kavindu Kumara", false);
            tblNormalRooms.Rows.Add("11", "0015", "Vimal Kumara", false);
        }
    }
}
