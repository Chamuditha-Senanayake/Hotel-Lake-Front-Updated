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
    public partial class FormSalaryDetailsAdmin : Form
    {
        public static string strPID;
        public FormSalaryDetailsAdmin()
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
            adapter.Fill(ds, "employee_position");
            tblFacilityDetails.DataSource = ds.Tables["employee_position"];
            conn.Close();
        }

        private void DataAdder(string sql, MySqlConnection conn)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.InsertCommand = new MySqlCommand(sql, conn);
            adapter.InsertCommand.ExecuteNonQuery();
            conn.Close();
        }

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


        private void FormRestaurant_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT * FROM employee_position";
                DataAdapter(sql, dbQuery());

                tblFacilityDetails.EnableHeadersVisualStyles = false;
                tblFacilityDetails.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 220);
                tblFacilityDetails.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 16);

                tblFacilityDetails.Columns[0].Width = 150;
                tblFacilityDetails.Columns[2].Width = 175;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearchFoodCashier_Enter(object sender, EventArgs e)
        {
            if (txtSearchFacility.Text == "Search")
            {
                txtSearchFacility.Text = "";
                txtSearchFacility.ForeColor = Color.Black;
            }
        }


        private void txtSearchFoodCashier_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "CALL getSelectedPosition('%" + txtSearchFacility.Text + "%')";
                DataAdapter(sql, dbQuery());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tblFoodDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnUpdate.Visible = false;
                btnReset.Visible = false;
                btnUpdate.Visible = false;

                string PID = tblFacilityDetails.Rows[e.RowIndex].Cells[0].Value.ToString();

                txtPID.Text = PID;
                txtPname.Text = DataReader1("SELECT Position FROM employee_position WHERE PositionID = ('" + PID + "')", dbQuery());
                txtPprice.Text = DataReader1("SELECT Salary FROM employee_position WHERE PositionID = ('" + PID + "')", dbQuery());
                strPID = PID;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPID_Enter(object sender, EventArgs e)
        {
            btnReset.Visible = true;
            btnUpdate.Visible = true;

            txtPIDNew.Text = "";
            txtPNameNew.Text = "";
            txtPpriceNew.Text = "";
        }

        private void txtFname_Enter(object sender, EventArgs e)
        {
            btnReset.Visible = true;
            btnUpdate.Visible = true;

            txtPIDNew.Text = "";
            txtPNameNew.Text = "";
            txtPpriceNew.Text = "";
        }

        private void txtFprice_Enter(object sender, EventArgs e)
        {
            btnReset.Visible = true;
            btnUpdate.Visible = true;

            txtPIDNew.Text = "";
            txtPNameNew.Text = "";
            txtPpriceNew.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tblFoodDetails_CellClick(this.tblFacilityDetails, new DataGridViewCellEventArgs(this.tblFacilityDetails.CurrentCell.ColumnIndex, this.tblFacilityDetails.CurrentRow.Index));

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtPID.Text == "" || txtPname.Text == "" || txtPprice.Text == "")
            {
                MessageBox.Show("Fill all the fields before update ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            else
            {
                try
                {
                    DialogResult reslult = MessageBox.Show("Do you want to save changes?", "Confirm changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (reslult == DialogResult.Yes)
                    {
                        string sql = "CALL updatePosition('" + txtPID.Text + "','" + txtPname.Text + "','" + txtPprice.Text + "','"+ strPID +"')";
                        DataAdder(sql, dbQuery());
                        MessageBox.Show("Successfully Updated ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void txtPpriceNew_Enter(object sender, EventArgs e)
        {
            txtPID.Text = "";
            txtPname.Text = "";
            txtPprice.Text = "";
        }

        private void txtPIDNew_Enter(object sender, EventArgs e)
        {
            txtPID.Text = "";
            txtPname.Text = "";
            txtPprice.Text = "";
        }

        private void txtPNameNew_Enter(object sender, EventArgs e)
        {
            txtPID.Text = "";
            txtPname.Text = "";
            txtPprice.Text = ""; 
        }



        private void btnAddnewJob_Click(object sender, EventArgs e)
        {

            if (txtPNameNew.Text == "" || txtPpriceNew.Text == "" || txtPIDNew.Text == "")
            {
                MessageBox.Show("Fill all the fields ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                DialogResult reslult = MessageBox.Show("Do you want to add this item?", "Confirm ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (reslult == DialogResult.Yes)
                {
                    string sql = "CALL addNewPosition('" + txtPIDNew.Text + "','" + txtPNameNew.Text + "','" + txtPpriceNew.Text + "')";
                    DataAdder(sql, dbQuery());
                    MessageBox.Show("Successfully Updated ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        
    }
}
