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
    public partial class FormFoodDetails : Form
    {
        public FormFoodDetails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearchFoodCashier_Enter(object sender, EventArgs e)
        {
            if (txtSearchFoodCashier.Text == "Search")
            {
                txtSearchFoodCashier.Text = "";
                txtSearchFoodCashier.ForeColor = Color.Black;
            }
        }

        private void txtSearchFoodCashier_Leave(object sender, EventArgs e)
        {
            if (txtSearchFoodCashier.Text == "")
            {
                txtSearchFoodCashier.Text = "Search";
                txtSearchFoodCashier.ForeColor = Color.Gray;
            }
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


        private void FormFoodDetails_Load(object sender, EventArgs e)
        {

            try
            {
                string sql = "CALL getAllFood";
                DataAdapter(sql, dbQuery());

                tblFoodDetails.EnableHeadersVisualStyles = false;
                tblFoodDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 220);
                tblFoodDetails.Columns[0].Width = 250;
                tblFoodDetails.Columns[2].Width = 250;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            /* tblFoodDetails.Rows.Add("F0001", "Chicken Kottu(S)", "450");
             tblFoodDetails.Rows.Add("F0002", "Chicken Cheese Masala Kottu(S)", "750");
             tblFoodDetails.Rows.Add("F0003", "Beef Kottu(S)", "750");
             tblFoodDetails.Rows.Add("F0004", "Chicken fried Rice(S)", "350");
             tblFoodDetails.Rows.Add("F0005", "Sea Food Special Buriyani(L)", "800");
             tblFoodDetails.Rows.Add("F0009", "Broccoli cheddar baked potato", "1250");*/


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
                string sql = "CALL getSelectedFoodbyName('%" + txtSearchFoodCashier.Text+"%')";
                DataAdapter(sql, dbQuery());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       
        private void radioAnytime_CheckedChanged(object sender, EventArgs e)
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

        private void radioSnacks_MouseDown(object sender, MouseEventArgs e)
        {
            txtSearchFoodCashier.Text = "Search";
            txtSearchFoodCashier.ForeColor = Color.Gray;
        }
    }
}
