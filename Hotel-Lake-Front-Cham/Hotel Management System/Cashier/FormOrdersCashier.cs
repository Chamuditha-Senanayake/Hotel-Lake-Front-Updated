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
    public partial class FormOrdersCashier : Form
    {
        public FormOrdersCashier()
        {
            InitializeComponent();
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
            adapter.Fill(ds, "food");
            tblGuestFoodDetails.DataSource = ds.Tables["food"];
            conn.Close();
        }

        private void FormOrdersCashier_Load(object sender, EventArgs e)
        {
            tblGuestDetails.EnableHeadersVisualStyles = false;
            tblGuestDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 220);
            tblGuestDetails.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 13);

            tblGuestFoodDetails.EnableHeadersVisualStyles = false;
            tblGuestFoodDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 220);
            tblGuestFoodDetails.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 13);

            try
            {
                string sql = "SELECT DISTINCT RoomID AS 'Room No', OrderID FROM food_order WHERE status = 0";
                DataAdapter(sql, dbQuery());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void tblGuestDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int Oid = int.Parse(tblGuestDetails.Rows[e.RowIndex].Cells[1].Value.ToString());
                string sql = "CALL getOrderDetails("+ Oid+")";
                DataAdapter1(sql, dbQuery());
                tblGuestFoodDetails.Columns[0].Width = 80;
                tblGuestFoodDetails.Columns[2].Width = 100;
                tblGuestFoodDetails.Columns[3].Width = 150;

                int P = 0;

                for (int i = 0; i < tblGuestFoodDetails.RowCount; i++)
                {
                       P += Convert.ToInt32(tblGuestFoodDetails.Rows[i].Cells[3].Value.ToString());
                       lblTotal.Text = P.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttnOrderPlaced_Click(object sender, EventArgs e)
        {
            DialogResult reslult = MessageBox.Show("Is this a completed order?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (reslult == DialogResult.Yes)
            {
                string OID = tblGuestDetails.CurrentRow.Cells[1].Value.ToString();
                string sql = "UPDATE food_order SET Status = 1 WHERE OrderID = " + OID;

                DataAdder(sql, dbQuery());
                MessageBox.Show("Order Placed", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }                
        }
    }
}
