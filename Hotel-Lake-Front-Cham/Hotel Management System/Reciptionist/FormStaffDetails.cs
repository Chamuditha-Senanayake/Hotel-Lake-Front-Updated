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
    public partial class FormStaffDetails : Form
    {
        public FormStaffDetails()
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
            adapter.Fill(ds, "food");
            tblFoodDetails.DataSource = ds.Tables["food"];
            conn.Close();
        }

        private void FormStaffDetails_Load(object sender, EventArgs e)
        {
            string sql = "select staff.EmpFullName as 'Name', employee_position.Position, staff.TP1 AS 'Contact'  from staff INNER JOIN employee_position ON staff.EmpPositionID=employee_position.PositionID;";
            DataAdapter(sql, dbQuery());

            tblFoodDetails.EnableHeadersVisualStyles = false;
            tblFoodDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 220);
            tblFoodDetails.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 16);
            tblFoodDetails.Columns[1].Width = 230;
            tblFoodDetails.Columns[2].Width = 275;
        }

        private void txtSearchFoodCashier_Enter(object sender, EventArgs e)
        {
            if (txtSearchFoodCashier.Text == "Search")
            {
                txtSearchFoodCashier.Text = "";
                txtSearchFoodCashier.ForeColor = Color.Black;
            }
        }

        private void txtSearchFoodCashier_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "select staff.EmpFullName as 'Name', employee_position.Position, staff.TP1 AS 'Contact' from staff INNER JOIN employee_position ON staff.EmpPositionID = employee_position.PositionID WHERE staff.EmpFullName LIKE '%" + txtSearchFoodCashier.Text + "%'";
                DataAdapter(sql, dbQuery());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
