
namespace Hotel_Management_System
{
    partial class FormSalaryDetailsAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtPname = new System.Windows.Forms.TextBox();
            this.txtPprice = new System.Windows.Forms.TextBox();
            this.btnReset = new FontAwesome.Sharp.IconButton();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.tblFacilityDetails = new System.Windows.Forms.DataGridView();
            this.iconBttnFoodSearchCashier = new FontAwesome.Sharp.IconButton();
            this.txtSearchFacility = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.txtPNameNew = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddnewJob = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPID = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPpriceNew = new System.Windows.Forms.MaskedTextBox();
            this.txtPIDNew = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblFacilityDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPname
            // 
            this.txtPname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtPname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPname.Location = new System.Drawing.Point(204, 451);
            this.txtPname.Name = "txtPname";
            this.txtPname.Size = new System.Drawing.Size(339, 41);
            this.txtPname.TabIndex = 478;
            this.txtPname.Enter += new System.EventHandler(this.txtFname_Enter);
            // 
            // txtPprice
            // 
            this.txtPprice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtPprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPprice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPprice.Location = new System.Drawing.Point(204, 491);
            this.txtPprice.Name = "txtPprice";
            this.txtPprice.Size = new System.Drawing.Size(182, 41);
            this.txtPprice.TabIndex = 477;
            this.txtPprice.Enter += new System.EventHandler(this.txtFprice_Enter);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnReset.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnReset.IconColor = System.Drawing.Color.Black;
            this.btnReset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReset.Location = new System.Drawing.Point(413, 517);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(90, 52);
            this.btnReset.TabIndex = 475;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnUpdate.IconColor = System.Drawing.Color.Black;
            this.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdate.Location = new System.Drawing.Point(516, 520);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 52);
            this.btnUpdate.TabIndex = 476;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tblFacilityDetails
            // 
            this.tblFacilityDetails.AllowUserToAddRows = false;
            this.tblFacilityDetails.AllowUserToDeleteRows = false;
            this.tblFacilityDetails.AllowUserToResizeColumns = false;
            this.tblFacilityDetails.AllowUserToResizeRows = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.Black;
            this.tblFacilityDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.tblFacilityDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblFacilityDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.tblFacilityDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblFacilityDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.tblFacilityDetails.ColumnHeadersHeight = 50;
            this.tblFacilityDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblFacilityDetails.DefaultCellStyle = dataGridViewCellStyle27;
            this.tblFacilityDetails.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tblFacilityDetails.Location = new System.Drawing.Point(45, 106);
            this.tblFacilityDetails.Name = "tblFacilityDetails";
            this.tblFacilityDetails.ReadOnly = true;
            this.tblFacilityDetails.RowHeadersVisible = false;
            this.tblFacilityDetails.RowHeadersWidth = 51;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle28.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.tblFacilityDetails.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.tblFacilityDetails.RowTemplate.Height = 35;
            this.tblFacilityDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblFacilityDetails.Size = new System.Drawing.Size(543, 227);
            this.tblFacilityDetails.TabIndex = 474;
            this.tblFacilityDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblFoodDetails_CellClick);
            // 
            // iconBttnFoodSearchCashier
            // 
            this.iconBttnFoodSearchCashier.Enabled = false;
            this.iconBttnFoodSearchCashier.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconBttnFoodSearchCashier.IconColor = System.Drawing.Color.Black;
            this.iconBttnFoodSearchCashier.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBttnFoodSearchCashier.IconSize = 30;
            this.iconBttnFoodSearchCashier.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconBttnFoodSearchCashier.Location = new System.Drawing.Point(413, 31);
            this.iconBttnFoodSearchCashier.Name = "iconBttnFoodSearchCashier";
            this.iconBttnFoodSearchCashier.Size = new System.Drawing.Size(34, 31);
            this.iconBttnFoodSearchCashier.TabIndex = 472;
            this.iconBttnFoodSearchCashier.UseVisualStyleBackColor = true;
            // 
            // txtSearchFacility
            // 
            this.txtSearchFacility.ForeColor = System.Drawing.Color.Gray;
            this.txtSearchFacility.Location = new System.Drawing.Point(88, 31);
            this.txtSearchFacility.Name = "txtSearchFacility";
            this.txtSearchFacility.Size = new System.Drawing.Size(293, 22);
            this.txtSearchFacility.TabIndex = 471;
            this.txtSearchFacility.Text = "Search";
            this.txtSearchFacility.TextChanged += new System.EventHandler(this.txtSearchFoodCashier_TextChanged);
            this.txtSearchFacility.Enter += new System.EventHandler(this.txtSearchFoodCashier_Enter);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 499);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 31);
            this.label3.TabIndex = 466;
            this.label3.Text = "Salary:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 31);
            this.label1.TabIndex = 465;
            this.label1.Text = "Postion :";
            // 
            // label39
            // 
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(25, 416);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(143, 31);
            this.label39.TabIndex = 464;
            this.label39.Text = "Position ID :";
            // 
            // txtPNameNew
            // 
            this.txtPNameNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtPNameNew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPNameNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPNameNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPNameNew.Location = new System.Drawing.Point(644, 276);
            this.txtPNameNew.Name = "txtPNameNew";
            this.txtPNameNew.Size = new System.Drawing.Size(339, 41);
            this.txtPNameNew.TabIndex = 489;
            this.txtPNameNew.Enter += new System.EventHandler(this.txtPNameNew_Enter);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(674, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(328, 49);
            this.label4.TabIndex = 487;
            this.label4.Text = "Add New Job Position";
            // 
            // btnAddnewJob
            // 
            this.btnAddnewJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnAddnewJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddnewJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddnewJob.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAddnewJob.IconColor = System.Drawing.Color.Black;
            this.btnAddnewJob.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddnewJob.Location = new System.Drawing.Point(666, 485);
            this.btnAddnewJob.Name = "btnAddnewJob";
            this.btnAddnewJob.Size = new System.Drawing.Size(295, 84);
            this.btnAddnewJob.TabIndex = 482;
            this.btnAddnewJob.Text = "&Add New Job Position";
            this.btnAddnewJob.UseVisualStyleBackColor = false;
            this.btnAddnewJob.Click += new System.EventHandler(this.btnAddnewJob_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel2.Location = new System.Drawing.Point(631, -6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 597);
            this.panel2.TabIndex = 481;
            // 
            // txtPID
            // 
            this.txtPID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtPID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPID.Location = new System.Drawing.Point(207, 410);
            this.txtPID.Mask = "AAA";
            this.txtPID.Name = "txtPID";
            this.txtPID.Size = new System.Drawing.Size(113, 34);
            this.txtPID.TabIndex = 490;
            this.txtPID.Enter += new System.EventHandler(this.txtPID_Enter);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(639, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 31);
            this.label2.TabIndex = 491;
            this.label2.Text = "Position ID :";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(639, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 31);
            this.label5.TabIndex = 492;
            this.label5.Text = "Postion :";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(639, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 31);
            this.label6.TabIndex = 493;
            this.label6.Text = "Salary:";
            // 
            // txtPpriceNew
            // 
            this.txtPpriceNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtPpriceNew.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPpriceNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPpriceNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPpriceNew.Location = new System.Drawing.Point(644, 370);
            this.txtPpriceNew.Mask = "9999999";
            this.txtPpriceNew.Name = "txtPpriceNew";
            this.txtPpriceNew.Size = new System.Drawing.Size(339, 34);
            this.txtPpriceNew.TabIndex = 495;
            this.txtPpriceNew.Enter += new System.EventHandler(this.txtPpriceNew_Enter);
            // 
            // txtPIDNew
            // 
            this.txtPIDNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtPIDNew.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPIDNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPIDNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPIDNew.Location = new System.Drawing.Point(644, 179);
            this.txtPIDNew.Mask = "AAA";
            this.txtPIDNew.Name = "txtPIDNew";
            this.txtPIDNew.Size = new System.Drawing.Size(150, 34);
            this.txtPIDNew.TabIndex = 496;
            this.txtPIDNew.Enter += new System.EventHandler(this.txtPIDNew_Enter);
            // 
            // FormSalaryDetailsAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1003, 584);
            this.Controls.Add(this.txtPIDNew);
            this.Controls.Add(this.txtPpriceNew);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPID);
            this.Controls.Add(this.txtPNameNew);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddnewJob);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtPname);
            this.Controls.Add(this.txtPprice);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tblFacilityDetails);
            this.Controls.Add(this.iconBttnFoodSearchCashier);
            this.Controls.Add(this.txtSearchFacility);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label39);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Name = "FormSalaryDetailsAdmin";
            this.Text = "Salary Details";
            this.Load += new System.EventHandler(this.FormRestaurant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblFacilityDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPname;
        private System.Windows.Forms.TextBox txtPprice;
        private FontAwesome.Sharp.IconButton btnReset;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private System.Windows.Forms.DataGridView tblFacilityDetails;
        private FontAwesome.Sharp.IconButton iconBttnFoodSearchCashier;
        private System.Windows.Forms.TextBox txtSearchFacility;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox txtPNameNew;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnAddnewJob;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox txtPID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtPpriceNew;
        private System.Windows.Forms.MaskedTextBox txtPIDNew;
    }
}