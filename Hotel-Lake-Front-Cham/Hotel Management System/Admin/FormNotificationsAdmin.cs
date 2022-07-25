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
    public partial class FormNotificationsAdmin : Form
    {
        public FormNotificationsAdmin()
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

        private void button1_Click(object sender, EventArgs e)
        {

            string sql = "INSERT INTO Notification(Note) VALUES ('"+txtNot.Text+"')";
            MessageBox.Show("Message sent ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtNot.Text = "";
            DataAdder(sql,dbQuery());
        }
    }
}
