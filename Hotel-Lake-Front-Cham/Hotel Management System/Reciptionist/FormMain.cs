using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using MySql.Data.MySqlClient;


namespace Hotel_Management_System
{
    public partial class FormMain : Form
    {
        //fields
        private IconButton currentBtn;
        private Panel leftBoarderBtn;
        private Form currentForm;


        //constructor
        public FormMain()
        {
            InitializeComponent();
            leftBoarderBtn = new Panel();
            leftBoarderBtn.Size = new Size(7, 84);
            panelMenu.Controls.Add(leftBoarderBtn);

            //form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea; 

        }


        //structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172,126,247);
            public static Color color2 = Color.FromArgb(249,118,176);
            public static Color color3 = Color.FromArgb(253,138,114);
            public static Color color4 = Color.FromArgb(95,77,221);
            public static Color color5 = Color.FromArgb(249,88,155);
            public static Color color6 = Color.FromArgb(24,161,251);
            public static Color color7 = Color.FromArgb(253, 138, 114);
            public static Color color8 = Color.FromArgb(95, 77, 221);

        }


        
        //method to highlight
        public void ActivateButton(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //left boarder button
                leftBoarderBtn.BackColor = color;
                leftBoarderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBoarderBtn.Visible = true;
                leftBoarderBtn.BringToFront();
                //Icon current
                iconCurrent.IconChar = currentBtn.IconChar;
                iconCurrent.IconColor = color;

            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31,30,68);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        public void OpenForm(Form childForm)
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
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            titleCurrent.Text = childForm.Text;

            
        }

       

        private void btnNewGuest_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenForm(new FormNewGuest());
            lblTime.Visible = true;
            lblDate.Visible = true;

        }

        private MySqlConnection dbQuery()
        {
            DBConnection dBclass = new DBConnection();
            MySqlConnection conn = dBclass.getConnection();
            return conn;
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

        private void btnGuestDetails_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenForm(new FormRoomDetails());
            lblTime.Visible = true;
            lblDate.Visible = true;
        }

        private void btnRoomDetails_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenForm(new FormGuestDetails());
            lblTime.Visible = true;
            lblDate.Visible = true;
        }

        private void btnFoodDetails_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenForm(new FormFoodDetails());
            lblTime.Visible = true;
            lblDate.Visible = true;
        }

        private void btnStaffDetails_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenForm(new FormStaffDetails());
            lblTime.Visible = true;
            lblDate.Visible = true;
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
            OpenForm(new FormPayments());
            lblTime.Visible = true;
            lblDate.Visible = true;

        }
        private void btnNotifications_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color8);
            OpenForm(new FormNotifications());
            lblTime.Visible = true;
            lblDate.Visible = true;
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            lblTime.Visible = false;
            lblDate.Visible = false;
            OpenForm(new FormMain());
            if (currentForm != null)
            {
                currentForm.Close();
                Reset();
                
            }    
        }


        private void Reset()
        {
            DisableButton();
            leftBoarderBtn.Visible = false;
            iconCurrent.IconChar = IconChar.Home;
            iconCurrent.IconColor = Color.White;
            titleCurrent.Text = "Home"; 
        }

        //Drag Form

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void New_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblTimeM.Text = DateTime.Now.ToLongTimeString();
            lblDateM.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Visible = false;
            lblDate.Visible = false;
            /*string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            string gid = DataReader1("SELECT StaffID FROM userlogin WHERE StaffID LIKE '%RCP12%' AND LoginTime = '"+date+"'", dbQuery());
            string name = DataReader1("SELECT EmpFullName FROM staff WHERE EmpID ='"+gid+"'", dbQuery());
            lblID.Text = gid;
            lblName.Text = name;*/
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblTimeM.Text = DateTime.Now.ToLongTimeString();

        }


        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogoutReciptionist_Click(object sender, EventArgs e)
        {
            DialogResult reslult = MessageBox.Show("Are you sure you want to log out?", "Confirm log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (reslult == DialogResult.Yes)
            {
                this.Close();
                MainLogin newMainLogin = new MainLogin();
                newMainLogin.Show();
            }
        }

    }
}
