
namespace Hotel_Management_System
{
    partial class FormPaymentsCashier
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.num1 = new System.Windows.Forms.NumericUpDown();
            this.grpFood = new System.Windows.Forms.GroupBox();
            this.radioSnacks = new System.Windows.Forms.RadioButton();
            this.radioAny = new System.Windows.Forms.RadioButton();
            this.radioBreak = new System.Windows.Forms.RadioButton();
            this.radioLunch = new System.Windows.Forms.RadioButton();
            this.radioBeve = new System.Windows.Forms.RadioButton();
            this.radioDinner = new System.Windows.Forms.RadioButton();
            this.radioDess = new System.Windows.Forms.RadioButton();
            this.iconBttnFoodSearchCashier = new FontAwesome.Sharp.IconButton();
            this.txtSearchFoodCashier = new System.Windows.Forms.TextBox();
            this.tblFoodDetails = new System.Windows.Forms.DataGridView();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.btnPay = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFTotal = new System.Windows.Forms.Label();
            this.iconBttnAddFoodCashier = new FontAwesome.Sharp.IconButton();
            this.lblFood = new System.Windows.Forms.Label();
            this.tbleOrderDetails = new System.Windows.Forms.DataGridView();
            this.FoodNamePayments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityPayments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodPricePayments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodSelectPayments = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num1)).BeginInit();
            this.grpFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblFoodDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbleOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblFTotal);
            this.panel1.Controls.Add(this.num1);
            this.panel1.Controls.Add(this.grpFood);
            this.panel1.Controls.Add(this.iconBttnFoodSearchCashier);
            this.panel1.Controls.Add(this.txtSearchFoodCashier);
            this.panel1.Controls.Add(this.tblFoodDetails);
            this.panel1.Controls.Add(this.iconButton3);
            this.panel1.Controls.Add(this.btnPay);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.iconBttnAddFoodCashier);
            this.panel1.Controls.Add(this.lblFood);
            this.panel1.Controls.Add(this.tbleOrderDetails);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1003, 584);
            this.panel1.TabIndex = 0;
            // 
            // num1
            // 
            this.num1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.num1.Location = new System.Drawing.Point(851, 78);
            this.num1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(50, 49);
            this.num1.TabIndex = 450;
            this.num1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // grpFood
            // 
            this.grpFood.Controls.Add(this.radioSnacks);
            this.grpFood.Controls.Add(this.radioAny);
            this.grpFood.Controls.Add(this.radioBreak);
            this.grpFood.Controls.Add(this.radioLunch);
            this.grpFood.Controls.Add(this.radioBeve);
            this.grpFood.Controls.Add(this.radioDinner);
            this.grpFood.Controls.Add(this.radioDess);
            this.grpFood.Location = new System.Drawing.Point(9, 72);
            this.grpFood.Name = "grpFood";
            this.grpFood.Size = new System.Drawing.Size(472, 76);
            this.grpFood.TabIndex = 449;
            this.grpFood.TabStop = false;
            // 
            // radioSnacks
            // 
            this.radioSnacks.AutoSize = true;
            this.radioSnacks.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSnacks.Location = new System.Drawing.Point(116, 12);
            this.radioSnacks.Name = "radioSnacks";
            this.radioSnacks.Size = new System.Drawing.Size(112, 33);
            this.radioSnacks.TabIndex = 40;
            this.radioSnacks.TabStop = true;
            this.radioSnacks.Text = "Snacks";
            this.radioSnacks.UseVisualStyleBackColor = true;
            this.radioSnacks.CheckedChanged += new System.EventHandler(this.radioSnacks_CheckedChanged);
            this.radioSnacks.MouseDown += new System.Windows.Forms.MouseEventHandler(this.radioSnacks_MouseDown);
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
            this.radioBreak.Location = new System.Drawing.Point(234, 42);
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
            this.radioLunch.Location = new System.Drawing.Point(116, 42);
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
            this.radioBeve.Location = new System.Drawing.Point(234, 12);
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
            this.radioDinner.Location = new System.Drawing.Point(7, 42);
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
            this.radioDess.Location = new System.Drawing.Point(368, 12);
            this.radioDess.Name = "radioDess";
            this.radioDess.Size = new System.Drawing.Size(129, 33);
            this.radioDess.TabIndex = 45;
            this.radioDess.TabStop = true;
            this.radioDess.Text = "Desserts";
            this.radioDess.UseVisualStyleBackColor = true;
            this.radioDess.CheckedChanged += new System.EventHandler(this.radioDess_CheckedChanged);
            this.radioDess.MouseDown += new System.Windows.Forms.MouseEventHandler(this.radioDess_MouseDown);
            // 
            // iconBttnFoodSearchCashier
            // 
            this.iconBttnFoodSearchCashier.Enabled = false;
            this.iconBttnFoodSearchCashier.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconBttnFoodSearchCashier.IconColor = System.Drawing.Color.Black;
            this.iconBttnFoodSearchCashier.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBttnFoodSearchCashier.IconSize = 30;
            this.iconBttnFoodSearchCashier.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconBttnFoodSearchCashier.Location = new System.Drawing.Point(392, 35);
            this.iconBttnFoodSearchCashier.Name = "iconBttnFoodSearchCashier";
            this.iconBttnFoodSearchCashier.Size = new System.Drawing.Size(34, 31);
            this.iconBttnFoodSearchCashier.TabIndex = 50;
            this.iconBttnFoodSearchCashier.UseVisualStyleBackColor = true;
            // 
            // txtSearchFoodCashier
            // 
            this.txtSearchFoodCashier.ForeColor = System.Drawing.Color.Gray;
            this.txtSearchFoodCashier.Location = new System.Drawing.Point(69, 39);
            this.txtSearchFoodCashier.Name = "txtSearchFoodCashier";
            this.txtSearchFoodCashier.Size = new System.Drawing.Size(293, 22);
            this.txtSearchFoodCashier.TabIndex = 49;
            this.txtSearchFoodCashier.Text = "Search";
            this.txtSearchFoodCashier.TextChanged += new System.EventHandler(this.txtSearchFoodCashier_TextChanged);
            this.txtSearchFoodCashier.Enter += new System.EventHandler(this.txtSearchFoodCashier_Enter);
            // 
            // tblFoodDetails
            // 
            this.tblFoodDetails.AllowUserToAddRows = false;
            this.tblFoodDetails.AllowUserToDeleteRows = false;
            this.tblFoodDetails.AllowUserToResizeColumns = false;
            this.tblFoodDetails.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
            this.tblFoodDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.tblFoodDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblFoodDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.tblFoodDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblFoodDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.tblFoodDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblFoodDetails.DefaultCellStyle = dataGridViewCellStyle19;
            this.tblFoodDetails.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tblFoodDetails.Location = new System.Drawing.Point(16, 174);
            this.tblFoodDetails.Name = "tblFoodDetails";
            this.tblFoodDetails.ReadOnly = true;
            this.tblFoodDetails.RowHeadersVisible = false;
            this.tblFoodDetails.RowHeadersWidth = 51;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.tblFoodDetails.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.tblFoodDetails.RowTemplate.Height = 35;
            this.tblFoodDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblFoodDetails.Size = new System.Drawing.Size(454, 377);
            this.tblFoodDetails.TabIndex = 48;
            this.tblFoodDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblFoodDetails_CellClick);
            // 
            // iconButton3
            // 
            this.iconButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Paypal;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 50;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton3.Location = new System.Drawing.Point(892, 456);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(100, 95);
            this.iconButton3.TabIndex = 7;
            this.iconButton3.Text = "Card";
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // btnPay
            // 
            this.btnPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnPay.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.btnPay.IconColor = System.Drawing.Color.Black;
            this.btnPay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPay.IconSize = 50;
            this.btnPay.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPay.Location = new System.Drawing.Point(786, 456);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(100, 95);
            this.btnPay.TabIndex = 6;
            this.btnPay.Text = "Cash";
            this.btnPay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Rockwell Condensed", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(502, 495);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 42);
            this.label2.TabIndex = 47;
            this.label2.Text = "LKR";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFTotal
            // 
            this.lblFTotal.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblFTotal.Location = new System.Drawing.Point(588, 477);
            this.lblFTotal.Name = "lblFTotal";
            this.lblFTotal.Size = new System.Drawing.Size(143, 66);
            this.lblFTotal.TabIndex = 46;
            this.lblFTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // iconBttnAddFoodCashier
            // 
            this.iconBttnAddFoodCashier.FlatAppearance.BorderSize = 0;
            this.iconBttnAddFoodCashier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconBttnAddFoodCashier.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconBttnAddFoodCashier.IconColor = System.Drawing.Color.White;
            this.iconBttnAddFoodCashier.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBttnAddFoodCashier.IconSize = 40;
            this.iconBttnAddFoodCashier.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconBttnAddFoodCashier.Location = new System.Drawing.Point(929, 77);
            this.iconBttnAddFoodCashier.Name = "iconBttnAddFoodCashier";
            this.iconBttnAddFoodCashier.Size = new System.Drawing.Size(40, 31);
            this.iconBttnAddFoodCashier.TabIndex = 4;
            this.iconBttnAddFoodCashier.UseVisualStyleBackColor = true;
            this.iconBttnAddFoodCashier.Click += new System.EventHandler(this.iconBttnAddFoodCashier_Click);
            // 
            // lblFood
            // 
            this.lblFood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFood.Location = new System.Drawing.Point(541, 72);
            this.lblFood.Name = "lblFood";
            this.lblFood.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFood.Size = new System.Drawing.Size(289, 43);
            this.lblFood.TabIndex = 43;
            this.lblFood.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbleOrderDetails
            // 
            this.tbleOrderDetails.AllowUserToOrderColumns = true;
            this.tbleOrderDetails.AllowUserToResizeColumns = false;
            this.tbleOrderDetails.AllowUserToResizeRows = false;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Black;
            this.tbleOrderDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.tbleOrderDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbleOrderDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tbleOrderDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.tbleOrderDetails.ColumnHeadersHeight = 55;
            this.tbleOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tbleOrderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoodNamePayments,
            this.QuantityPayments,
            this.FoodPricePayments,
            this.FoodSelectPayments});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbleOrderDetails.DefaultCellStyle = dataGridViewCellStyle23;
            this.tbleOrderDetails.Location = new System.Drawing.Point(541, 144);
            this.tbleOrderDetails.Name = "tbleOrderDetails";
            this.tbleOrderDetails.RowHeadersVisible = false;
            this.tbleOrderDetails.RowHeadersWidth = 51;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black;
            this.tbleOrderDetails.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.tbleOrderDetails.RowTemplate.Height = 35;
            this.tbleOrderDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbleOrderDetails.Size = new System.Drawing.Size(450, 279);
            this.tbleOrderDetails.TabIndex = 5;
            this.tbleOrderDetails.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tbleOrderDetails_CellMouseUp);
            this.tbleOrderDetails.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.tbleOrderDetails_RowsRemoved);
            // 
            // FoodNamePayments
            // 
            this.FoodNamePayments.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FoodNamePayments.HeaderText = "Name";
            this.FoodNamePayments.MinimumWidth = 6;
            this.FoodNamePayments.Name = "FoodNamePayments";
            // 
            // QuantityPayments
            // 
            this.QuantityPayments.HeaderText = "Quantity";
            this.QuantityPayments.MinimumWidth = 6;
            this.QuantityPayments.Name = "QuantityPayments";
            this.QuantityPayments.Width = 115;
            // 
            // FoodPricePayments
            // 
            this.FoodPricePayments.HeaderText = "Price";
            this.FoodPricePayments.MinimumWidth = 6;
            this.FoodPricePayments.Name = "FoodPricePayments";
            this.FoodPricePayments.Width = 99;
            // 
            // FoodSelectPayments
            // 
            this.FoodSelectPayments.HeaderText = "";
            this.FoodSelectPayments.MinimumWidth = 6;
            this.FoodSelectPayments.Name = "FoodSelectPayments";
            this.FoodSelectPayments.Width = 30;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel3.Location = new System.Drawing.Point(488, -12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 608);
            this.panel3.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Agency FB", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(720, 482);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 55);
            this.label1.TabIndex = 451;
            this.label1.Text = "/-";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormPaymentsCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1003, 584);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Name = "FormPaymentsCashier";
            this.Text = "Payments";
            this.Load += new System.EventHandler(this.FormPaymentsCashier_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num1)).EndInit();
            this.grpFood.ResumeLayout(false);
            this.grpFood.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblFoodDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbleOrderDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView tbleOrderDetails;
        private System.Windows.Forms.Label lblFood;
        private FontAwesome.Sharp.IconButton iconBttnAddFoodCashier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFTotal;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton btnPay;
        private FontAwesome.Sharp.IconButton iconBttnFoodSearchCashier;
        private System.Windows.Forms.TextBox txtSearchFoodCashier;
        private System.Windows.Forms.DataGridView tblFoodDetails;
        private System.Windows.Forms.GroupBox grpFood;
        private System.Windows.Forms.RadioButton radioAny;
        private System.Windows.Forms.RadioButton radioBreak;
        private System.Windows.Forms.RadioButton radioLunch;
        private System.Windows.Forms.RadioButton radioBeve;
        private System.Windows.Forms.RadioButton radioDinner;
        private System.Windows.Forms.RadioButton radioDess;
        private System.Windows.Forms.RadioButton radioSnacks;
        private System.Windows.Forms.NumericUpDown num1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodNamePayments;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityPayments;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodPricePayments;
        private System.Windows.Forms.DataGridViewCheckBoxColumn FoodSelectPayments;
        private System.Windows.Forms.Label label1;
    }
}