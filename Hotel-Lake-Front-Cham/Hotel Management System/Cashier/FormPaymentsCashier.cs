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
    public partial class FormPaymentsCashier : Form
    {
        public FormPaymentsCashier()
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
        private void DataAdapter(String sql, MySqlConnection conn)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "food");
            tblFoodDetails.DataSource = ds.Tables["food"];
            conn.Close();
        }

        //data reader
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

        //data adder
        private void DataAdder(string sql, MySqlConnection conn)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.InsertCommand = new MySqlCommand(sql, conn);
            adapter.InsertCommand.ExecuteNonQuery();
            conn.Close();
        }



        private void txtSearchFoodCashier_Enter(object sender, EventArgs e)
        {
            if (txtSearchFoodCashier.Text == "Search")
            {
                txtSearchFoodCashier.Text = "";
                txtSearchFoodCashier.ForeColor = Color.Black;
            }
        }

        private void FormPaymentsCashier_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "CALL getAllFood";
                DataAdapter(sql, dbQuery());

                tbleOrderDetails.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tblFoodDetails.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                tblFoodDetails.EnableHeadersVisualStyles = false;
                tblFoodDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 220);
                tbleOrderDetails.EnableHeadersVisualStyles = false;
                tbleOrderDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 220);
                tblFoodDetails.Columns[0].Width = 50;
                tblFoodDetails.Columns[2].Width = 100;
                lblFTotal.Text = "0.00";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            /* tbleFoodOrderDetailsCashier.Rows.Add("F0005", "Sea Food Special Buriyani(L)", "1", "800");
             tbleFoodOrderDetailsCashier.Rows.Add("F0009", "Broccoli cheddar baked potato", "2", "2500");
             tbleFoodOrderDetailsCashier.Rows.Add("F0002", "Chicken Cheese Masala Kottu(S)", "1", "750");*/
        }


        private void tbleFoodOrderDetailsCashier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in tbleOrderDetails.Rows)
            {
                row.Cells[FoodSelectPayments.Name].Value = true;
            }
        }



        private void txtSearchFoodCashier_TextChanged(object sender, EventArgs e)
        {
            radioAny.Checked = false;
            radioBreak.Checked = false;
            radioLunch.Checked = false;
            radioDinner.Checked = false;
            radioBeve.Checked = false;
            radioDess.Checked = false;
            radioSnacks.Checked = false;

            try
            {
                string sql = "CALL getSelectedFoodbyName('%" + txtSearchFoodCashier.Text + "%')";
                DataAdapter(sql, dbQuery());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioAny_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAny.Checked)
            {

                try
                {
                    string sql = "CALL getSelectedFood('123')";
                    DataAdapter(sql, dbQuery());

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void radioBreak_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBreak.Checked)
            {

                try
                {
                    string sql = "CALL getSelectedFood('%1%')";
                    DataAdapter(sql, dbQuery());

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void radioBeve_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBeve.Checked)
            {
                try
                {
                    string sql = "CALL getSelectedFood('4')";
                    DataAdapter(sql, dbQuery());

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void radioDess_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDess.Checked)
            {
                try
                {
                    string sql = "CALL getSelectedFood('5')";
                    DataAdapter(sql, dbQuery());

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void radioLunch_CheckedChanged(object sender, EventArgs e)
        {
            if (radioLunch.Checked)
            {

                try
                {
                    string sql = "CALL getSelectedFood('%2%')";
                    DataAdapter(sql, dbQuery());

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void radioDinner_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDinner.Checked)
            {
                try
                {
                    string sql = "CALL getSelectedFood('%3%')";
                    DataAdapter(sql, dbQuery());

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void radioSnacks_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSnacks.Checked)
            {
                try
                {
                    string sql = "CALL getSelectedFood('6')";
                    DataAdapter(sql, dbQuery());

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void radioAny_MouseDown(object sender, MouseEventArgs e)
        {
            txtSearchFoodCashier.Text = "Search";
            txtSearchFoodCashier.ForeColor = Color.Gray;
        }

        private void radioBreak_MouseDown(object sender, MouseEventArgs e)
        {
            txtSearchFoodCashier.Text = "Search";
            txtSearchFoodCashier.ForeColor = Color.Gray;
        }

        private void radioBeve_MouseDown(object sender, MouseEventArgs e)
        {
            txtSearchFoodCashier.Text = "Search";
            txtSearchFoodCashier.ForeColor = Color.Gray;
        }

        private void radioDess_MouseDown(object sender, MouseEventArgs e)
        {
            txtSearchFoodCashier.Text = "Search";
            txtSearchFoodCashier.ForeColor = Color.Gray;
        }

        private void radioLunch_MouseDown(object sender, MouseEventArgs e)
        {
            txtSearchFoodCashier.Text = "Search";
            txtSearchFoodCashier.ForeColor = Color.Gray;
        }

        private void radioDinner_MouseDown(object sender, MouseEventArgs e)
        {
            txtSearchFoodCashier.Text = "Search";
            txtSearchFoodCashier.ForeColor = Color.Gray;
        }

        private void radioSnacks_MouseDown(object sender, MouseEventArgs e)
        {
            txtSearchFoodCashier.Text = "Search";
            txtSearchFoodCashier.ForeColor = Color.Gray;
        }

        private void tblFoodDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string FID = tblFoodDetails.Rows[e.RowIndex].Cells[0].Value.ToString();
            lblFood.Text = tblFoodDetails.Rows[e.RowIndex].Cells[1].Value.ToString();

        }

        private void iconBttnAddFoodCashier_Click(object sender, EventArgs e)
        {
            if (lblFood.Text == "") 
            {
                MessageBox.Show("Select Food Item ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                string fPrice = DataReader1("SELECT FoodPrice FROM food WHERE FoodName = '" + lblFood.Text + "'", dbQuery());
                tbleOrderDetails.Rows.Add(lblFood.Text, num1.Value, fPrice, true);

                int P = 0;

                for (int i=0; i < tbleOrderDetails.RowCount; i++)
                {
                    bool x = Convert.ToBoolean(tbleOrderDetails.Rows[i].Cells[3].Value);
                    if (x == true)
                    {  
                        P +=  Convert.ToInt32(tbleOrderDetails.Rows[i].Cells["FoodPricePayments"].Value.ToString()) * Convert.ToInt32(tbleOrderDetails.Rows[i].Cells["QuantityPayments"].Value.ToString()) ;
                        lblFTotal.Text = P.ToString() ;
                    }
                }

                num1.Value = 1;
                
            }
        }

        private void tbleOrderDetails_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int P = 0;

                for (int i = 0; i < tbleOrderDetails.RowCount; i++)
                {
                    bool x = Convert.ToBoolean(tbleOrderDetails.Rows[i].Cells[3].Value);

                    if (x == true)
                    {
                        P += Convert.ToInt32(tbleOrderDetails.Rows[i].Cells["FoodPricePayments"].Value.ToString()) * Convert.ToInt32(tbleOrderDetails.Rows[i].Cells["QuantityPayments"].Value.ToString()) ;
                        lblFTotal.Text = P.ToString();
                    }

                    else
                    {
                        tbleOrderDetails.Rows.Remove(tbleOrderDetails.Rows[i]);
                    }
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void tbleOrderDetails_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

            int P = 0;

            for (int i = 0; i < tbleOrderDetails.RowCount; i++)
            {
                bool x = Convert.ToBoolean(tbleOrderDetails.Rows[i].Cells[3].Value);
                if (x == true)
                {
                    P += Convert.ToInt32(tbleOrderDetails.Rows[i].Cells["FoodPricePayments"].Value.ToString()) * Convert.ToInt32(tbleOrderDetails.Rows[i].Cells["QuantityPayments"].Value.ToString());
                    lblFTotal.Text = P.ToString();
                }
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            DialogResult reslult = MessageBox.Show("Do you want to complete the order?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            string billID = "SELECT MAX(FoodBillID) FROM food_bill";
            string billID2 = DataReader1(billID, dbQuery());
            int BID = (int.Parse(billID2)) + 1;

            if (reslult == DialogResult.Yes)
            {
                for (int i = 0; i < tbleOrderDetails.RowCount; i++)
                {
                    bool x = Convert.ToBoolean(tbleOrderDetails.Rows[i].Cells[3].Value);
                    if (x == true)
                    {
                        string foodID = DataReader1("SELECT FoodID FROM food WHERE FoodName = '" + tbleOrderDetails.Rows[i].Cells["FoodNamePayments"].Value.ToString() + "'", dbQuery()); 

                        DateTimePicker dateTimePicker1 = new DateTimePicker();
                        string date = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd HH:mm");

                        int Quantity = Convert.ToInt32(tbleOrderDetails.Rows[i].Cells["QuantityPayments"].Value.ToString());

                        string sql = "CALL addFBill('" +BID +"','"+ foodID + "'," + Quantity + ",'" + date + "')";
                        DataAdder(sql, dbQuery());
                    }
                }
                DialogResult reslult1 = MessageBox.Show("Order Completed", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (reslult1 == DialogResult.OK)
                {
                    lblFood.Text = "";
                    lblFTotal.Text = "0.00";
                    num1.Value = 1;
                    tbleOrderDetails.Rows.Clear();


                }
            }
            
        }
    }
}
