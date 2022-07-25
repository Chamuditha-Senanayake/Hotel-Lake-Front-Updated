
namespace Hotel_Management_System
{
    partial class FormFoodDetailsAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddnewFood = new FontAwesome.Sharp.IconButton();
            this.label39 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSearchFoodCashier = new System.Windows.Forms.TextBox();
            this.iconBttnFoodSearchCashier = new FontAwesome.Sharp.IconButton();
            this.grpFood = new System.Windows.Forms.GroupBox();
            this.radioAny = new System.Windows.Forms.RadioButton();
            this.radioBreak = new System.Windows.Forms.RadioButton();
            this.radioLunch = new System.Windows.Forms.RadioButton();
            this.radioBeve = new System.Windows.Forms.RadioButton();
            this.radioDinner = new System.Windows.Forms.RadioButton();
            this.radioDess = new System.Windows.Forms.RadioButton();
            this.radioSnacks = new System.Windows.Forms.RadioButton();
            this.tblFoodDetails = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.btnReset = new FontAwesome.Sharp.IconButton();
            this.txtFprice = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.comboFID = new System.Windows.Forms.ComboBox();
            this.comboFID2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFnameNew = new System.Windows.Forms.TextBox();
            this.txtFpriceNew = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFID = new System.Windows.Forms.Label();
            this.grpFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblFoodDetails)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel2.Location = new System.Drawing.Point(642, -6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 597);
            this.panel2.TabIndex = 262;
            // 
            // btnAddnewFood
            // 
            this.btnAddnewFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnAddnewFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddnewFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddnewFood.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAddnewFood.IconColor = System.Drawing.Color.Black;
            this.btnAddnewFood.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddnewFood.Location = new System.Drawing.Point(677, 485);
            this.btnAddnewFood.Name = "btnAddnewFood";
            this.btnAddnewFood.Size = new System.Drawing.Size(295, 84);
            this.btnAddnewFood.TabIndex = 375;
            this.btnAddnewFood.Text = "&Add New Food Item";
            this.btnAddnewFood.UseVisualStyleBackColor = false;
            this.btnAddnewFood.Click += new System.EventHandler(this.btnAddnewFood_Click);
            // 
            // label39
            // 
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(26, 416);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(143, 31);
            this.label39.TabIndex = 385;
            this.label39.Text = "Food ID :";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 31);
            this.label1.TabIndex = 386;
            this.label1.Text = "Food Name :";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 499);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 31);
            this.label3.TabIndex = 388;
            this.label3.Text = "Food Price :";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 538);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 31);
            this.label2.TabIndex = 406;
            this.label2.Text = "Availability :";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(650, 145);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(143, 31);
            this.label14.TabIndex = 414;
            this.label14.Text = "Food Name :";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(650, 242);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(143, 31);
            this.label13.TabIndex = 415;
            this.label13.Text = "Food Price :";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(650, 339);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 31);
            this.label11.TabIndex = 417;
            this.label11.Text = "Availability :";
            // 
            // txtSearchFoodCashier
            // 
            this.txtSearchFoodCashier.ForeColor = System.Drawing.Color.Gray;
            this.txtSearchFoodCashier.Location = new System.Drawing.Point(135, 26);
            this.txtSearchFoodCashier.Name = "txtSearchFoodCashier";
            this.txtSearchFoodCashier.Size = new System.Drawing.Size(293, 22);
            this.txtSearchFoodCashier.TabIndex = 446;
            this.txtSearchFoodCashier.Text = "Search";
            this.txtSearchFoodCashier.TextChanged += new System.EventHandler(this.txtSearchFoodCashier_TextChanged);
            this.txtSearchFoodCashier.Enter += new System.EventHandler(this.txtSearchFoodCashier_Enter);
            // 
            // iconBttnFoodSearchCashier
            // 
            this.iconBttnFoodSearchCashier.Enabled = false;
            this.iconBttnFoodSearchCashier.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconBttnFoodSearchCashier.IconColor = System.Drawing.Color.Black;
            this.iconBttnFoodSearchCashier.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBttnFoodSearchCashier.IconSize = 30;
            this.iconBttnFoodSearchCashier.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconBttnFoodSearchCashier.Location = new System.Drawing.Point(454, 22);
            this.iconBttnFoodSearchCashier.Name = "iconBttnFoodSearchCashier";
            this.iconBttnFoodSearchCashier.Size = new System.Drawing.Size(34, 31);
            this.iconBttnFoodSearchCashier.TabIndex = 447;
            this.iconBttnFoodSearchCashier.UseVisualStyleBackColor = true;
            // 
            // grpFood
            // 
            this.grpFood.Controls.Add(this.radioAny);
            this.grpFood.Controls.Add(this.radioBreak);
            this.grpFood.Controls.Add(this.radioLunch);
            this.grpFood.Controls.Add(this.radioBeve);
            this.grpFood.Controls.Add(this.radioDinner);
            this.grpFood.Controls.Add(this.radioDess);
            this.grpFood.Controls.Add(this.radioSnacks);
            this.grpFood.Location = new System.Drawing.Point(36, 59);
            this.grpFood.Name = "grpFood";
            this.grpFood.Size = new System.Drawing.Size(557, 76);
            this.grpFood.TabIndex = 448;
            this.grpFood.TabStop = false;
            // 
            // radioAny
            // 
            this.radioAny.AutoSize = true;
            this.radioAny.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAny.Location = new System.Drawing.Point(7, 12);
            this.radioAny.Name = "radioAny";
            this.radioAny.Size = new System.Drawing.Size(119, 33);
            this.radioAny.TabIndex = 39;
            this.radioAny.TabStop = true;
            this.radioAny.Text = "Anytime";
            this.radioAny.UseVisualStyleBackColor = true;
            this.radioAny.CheckedChanged += new System.EventHandler(this.radioAny_CheckedChanged);
            this.radioAny.MouseDown += new System.Windows.Forms.MouseEventHandler(this.radioAny_MouseDown);
            // 
            // radioBreak
            // 
            this.radioBreak.AutoSize = true;
            this.radioBreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBreak.Location = new System.Drawing.Point(140, 11);
            this.radioBreak.Name = "radioBreak";
            this.radioBreak.Size = new System.Drawing.Size(134, 33);
            this.radioBreak.TabIndex = 44;
            this.radioBreak.TabStop = true;
            this.radioBreak.Text = "Breakfast";
            this.radioBreak.UseVisualStyleBackColor = true;
            this.radioBreak.CheckedChanged += new System.EventHandler(this.radioBreak_CheckedChanged);
            this.radioBreak.MouseDown += new System.Windows.Forms.MouseEventHandler(this.radioBreak_MouseDown);
            // 
            // radioLunch
            // 
            this.radioLunch.AutoSize = true;
            this.radioLunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioLunch.Location = new System.Drawing.Point(71, 42);
            this.radioLunch.Name = "radioLunch";
            this.radioLunch.Size = new System.Drawing.Size(98, 33);
            this.radioLunch.TabIndex = 43;
            this.radioLunch.TabStop = true;
            this.radioLunch.Text = "Lunch";
            this.radioLunch.UseVisualStyleBackColor = true;
            this.radioLunch.CheckedChanged += new System.EventHandler(this.radioLunch_CheckedChanged);
            this.radioLunch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.radioLunch_MouseDown);
            // 
            // radioBeve
            // 
            this.radioBeve.AutoSize = true;
            this.radioBeve.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBeve.Location = new System.Drawing.Point(284, 11);
            this.radioBeve.Name = "radioBeve";
            this.radioBeve.Size = new System.Drawing.Size(150, 33);
            this.radioBeve.TabIndex = 41;
            this.radioBeve.TabStop = true;
            this.radioBeve.Text = "Beverages";
            this.radioBeve.UseVisualStyleBackColor = true;
            this.radioBeve.CheckedChanged += new System.EventHandler(this.radioBeve_CheckedChanged);
            this.radioBeve.MouseDown += new System.Windows.Forms.MouseEventHandler(this.radioBeve_MouseDown);
            // 
            // radioDinner
            // 
            this.radioDinner.AutoSize = true;
            this.radioDinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDinner.Location = new System.Drawing.Point(222, 42);
            this.radioDinner.Name = "radioDinner";
            this.radioDinner.Size = new System.Drawing.Size(105, 33);
            this.radioDinner.TabIndex = 42;
            this.radioDinner.TabStop = true;
            this.radioDinner.Text = "Dinner";
            this.radioDinner.UseVisualStyleBackColor = true;
            this.radioDinner.CheckedChanged += new System.EventHandler(this.radioDinner_CheckedChanged);
            this.radioDinner.MouseDown += new System.Windows.Forms.MouseEventHandler(this.radioDinner_MouseDown);
            // 
            // radioDess
            // 
            this.radioDess.AutoSize = true;
            this.radioDess.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDess.Location = new System.Drawing.Point(440, 11);
            this.radioDess.Name = "radioDess";
            this.radioDess.Size = new System.Drawing.Size(129, 33);
            this.radioDess.TabIndex = 45;
            this.radioDess.TabStop = true;
            this.radioDess.Text = "Desserts";
            this.radioDess.UseVisualStyleBackColor = true;
            this.radioDess.CheckedChanged += new System.EventHandler(this.radioDess_CheckedChanged);
            this.radioDess.MouseDown += new System.Windows.Forms.MouseEventHandler(this.radioDess_MouseDown);
            // 
            // radioSnacks
            // 
            this.radioSnacks.AutoSize = true;
            this.radioSnacks.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSnacks.Location = new System.Drawing.Point(376, 42);
            this.radioSnacks.Name = "radioSnacks";
            this.radioSnacks.Size = new System.Drawing.Size(112, 33);
            this.radioSnacks.TabIndex = 40;
            this.radioSnacks.TabStop = true;
            this.radioSnacks.Text = "Snacks";
            this.radioSnacks.UseVisualStyleBackColor = true;
            this.radioSnacks.CheckedChanged += new System.EventHandler(this.radioSnacks_CheckedChanged);
            this.radioSnacks.MouseDown += new System.Windows.Forms.MouseEventHandler(this.radioSnacks_MouseDown);
            // 
            // tblFoodDetails
            // 
            this.tblFoodDetails.AllowUserToAddRows = false;
            this.tblFoodDetails.AllowUserToDeleteRows = false;
            this.tblFoodDetails.AllowUserToResizeColumns = false;
            this.tblFoodDetails.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.tblFoodDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tblFoodDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblFoodDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.tblFoodDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblFoodDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tblFoodDetails.ColumnHeadersHeight = 50;
            this.tblFoodDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblFoodDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.tblFoodDetails.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tblFoodDetails.Location = new System.Drawing.Point(21, 147);
            this.tblFoodDetails.Name = "tblFoodDetails";
            this.tblFoodDetails.ReadOnly = true;
            this.tblFoodDetails.RowHeadersVisible = false;
            this.tblFoodDetails.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.tblFoodDetails.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tblFoodDetails.RowTemplate.Height = 35;
            this.tblFoodDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblFoodDetails.Size = new System.Drawing.Size(600, 243);
            this.tblFoodDetails.TabIndex = 449;
            this.tblFoodDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblFoodDetails_CellClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnUpdate.IconColor = System.Drawing.Color.Black;
            this.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdate.Location = new System.Drawing.Point(522, 513);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 52);
            this.btnUpdate.TabIndex = 451;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnReset.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnReset.IconColor = System.Drawing.Color.Black;
            this.btnReset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReset.Location = new System.Drawing.Point(426, 513);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(90, 52);
            this.btnReset.TabIndex = 450;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtFprice
            // 
            this.txtFprice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtFprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFprice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtFprice.Location = new System.Drawing.Point(189, 494);
            this.txtFprice.Name = "txtFprice";
            this.txtFprice.Size = new System.Drawing.Size(182, 41);
            this.txtFprice.TabIndex = 453;
            this.txtFprice.Enter += new System.EventHandler(this.txtFprice_Enter);
            // 
            // txtFname
            // 
            this.txtFname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtFname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtFname.Location = new System.Drawing.Point(189, 454);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(339, 41);
            this.txtFname.TabIndex = 455;
            this.txtFname.Enter += new System.EventHandler(this.txtFname_Enter);
            // 
            // comboFID
            // 
            this.comboFID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFID.FormattingEnabled = true;
            this.comboFID.Location = new System.Drawing.Point(189, 538);
            this.comboFID.Name = "comboFID";
            this.comboFID.Size = new System.Drawing.Size(182, 39);
            this.comboFID.TabIndex = 456;
            this.comboFID.Enter += new System.EventHandler(this.comboFID_Enter);
            // 
            // comboFID2
            // 
            this.comboFID2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFID2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFID2.FormattingEnabled = true;
            this.comboFID2.Location = new System.Drawing.Point(655, 377);
            this.comboFID2.Name = "comboFID2";
            this.comboFID2.Size = new System.Drawing.Size(336, 39);
            this.comboFID2.TabIndex = 458;
            this.comboFID2.Enter += new System.EventHandler(this.comboFID2_Enter);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(685, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(328, 49);
            this.label4.TabIndex = 459;
            this.label4.Text = "Add New Food Item";
            // 
            // txtFnameNew
            // 
            this.txtFnameNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtFnameNew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFnameNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFnameNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtFnameNew.Location = new System.Drawing.Point(655, 179);
            this.txtFnameNew.Name = "txtFnameNew";
            this.txtFnameNew.Size = new System.Drawing.Size(339, 41);
            this.txtFnameNew.TabIndex = 460;
            this.txtFnameNew.Enter += new System.EventHandler(this.txtFnameNew_Enter);
            // 
            // txtFpriceNew
            // 
            this.txtFpriceNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtFpriceNew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFpriceNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFpriceNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtFpriceNew.Location = new System.Drawing.Point(655, 276);
            this.txtFpriceNew.Name = "txtFpriceNew";
            this.txtFpriceNew.Size = new System.Drawing.Size(339, 41);
            this.txtFpriceNew.TabIndex = 461;
            this.txtFpriceNew.Enter += new System.EventHandler(this.txtFpriceNew_Enter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtFpriceNew);
            this.panel1.Controls.Add(this.txtFnameNew);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboFID2);
            this.panel1.Controls.Add(this.lblFID);
            this.panel1.Controls.Add(this.comboFID);
            this.panel1.Controls.Add(this.txtFname);
            this.panel1.Controls.Add(this.txtFprice);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.tblFoodDetails);
            this.panel1.Controls.Add(this.grpFood);
            this.panel1.Controls.Add(this.iconBttnFoodSearchCashier);
            this.panel1.Controls.Add(this.txtSearchFoodCashier);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label39);
            this.panel1.Controls.Add(this.btnAddnewFood);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1003, 584);
            this.panel1.TabIndex = 0;
            // 
            // lblFID
            // 
            this.lblFID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFID.Location = new System.Drawing.Point(184, 416);
            this.lblFID.Name = "lblFID";
            this.lblFID.Size = new System.Drawing.Size(344, 31);
            this.lblFID.TabIndex = 457;
            // 
            // FormFoodDetailsAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1003, 584);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Name = "FormFoodDetailsAdmin";
            this.Text = "Food Details";
            this.Load += new System.EventHandler(this.FormFoodDetailsAdmin_Load);
            this.grpFood.ResumeLayout(false);
            this.grpFood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblFoodDetails)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnAddnewFood;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSearchFoodCashier;
        private FontAwesome.Sharp.IconButton iconBttnFoodSearchCashier;
        private System.Windows.Forms.GroupBox grpFood;
        private System.Windows.Forms.RadioButton radioAny;
        private System.Windows.Forms.RadioButton radioBreak;
        private System.Windows.Forms.RadioButton radioLunch;
        private System.Windows.Forms.RadioButton radioBeve;
        private System.Windows.Forms.RadioButton radioDinner;
        private System.Windows.Forms.RadioButton radioDess;
        private System.Windows.Forms.RadioButton radioSnacks;
        private System.Windows.Forms.DataGridView tblFoodDetails;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnReset;
        private System.Windows.Forms.TextBox txtFprice;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.ComboBox comboFID;
        private System.Windows.Forms.ComboBox comboFID2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFnameNew;
        private System.Windows.Forms.TextBox txtFpriceNew;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFID;
    }
}