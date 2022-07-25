
namespace Hotel_Management_System
{
    partial class FormNewGuestNext
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelGuestNext = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboID = new System.Windows.Forms.ComboBox();
            this.icnId = new FontAwesome.Sharp.IconButton();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.tblReservationDetails = new System.Windows.Forms.DataGridView();
            this.clmnReservation = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmnArrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDeparture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnWifi = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmnSatelliteTV = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmnHotWater = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmnExtraBed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmnPets = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnNext = new FontAwesome.Sharp.IconButton();
            this.btnPrevious = new FontAwesome.Sharp.IconButton();
            this.label16 = new System.Windows.Forms.Label();
            this.panelGuestNext.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblReservationDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGuestNext
            // 
            this.panelGuestNext.Controls.Add(this.label1);
            this.panelGuestNext.Controls.Add(this.comboID);
            this.panelGuestNext.Controls.Add(this.icnId);
            this.panelGuestNext.Controls.Add(this.btnSave);
            this.panelGuestNext.Controls.Add(this.tblReservationDetails);
            this.panelGuestNext.Controls.Add(this.btnNext);
            this.panelGuestNext.Controls.Add(this.btnPrevious);
            this.panelGuestNext.Controls.Add(this.label16);
            this.panelGuestNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGuestNext.Location = new System.Drawing.Point(0, 0);
            this.panelGuestNext.Name = "panelGuestNext";
            this.panelGuestNext.Size = new System.Drawing.Size(1003, 584);
            this.panelGuestNext.TabIndex = 262;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(709, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 20);
            this.label1.TabIndex = 274;
            this.label1.Text = "NIC or Passport No";
            // 
            // comboID
            // 
            this.comboID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboID.FormattingEnabled = true;
            this.comboID.Location = new System.Drawing.Point(712, 37);
            this.comboID.Name = "comboID";
            this.comboID.Size = new System.Drawing.Size(267, 39);
            this.comboID.TabIndex = 1;
            this.comboID.Enter += new System.EventHandler(this.comboID_Enter);
            // 
            // icnId
            // 
            this.icnId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.icnId.FlatAppearance.BorderSize = 0;
            this.icnId.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.icnId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icnId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.icnId.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.icnId.IconColor = System.Drawing.Color.Maroon;
            this.icnId.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icnId.IconSize = 40;
            this.icnId.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.icnId.Location = new System.Drawing.Point(669, 34);
            this.icnId.Name = "icnId";
            this.icnId.Size = new System.Drawing.Size(43, 36);
            this.icnId.TabIndex = 273;
            this.icnId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icnId.UseVisualStyleBackColor = false;
            this.icnId.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleDown;
            this.btnSave.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 40;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(631, 506);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 55);
            this.btnSave.TabIndex = 264;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tblReservationDetails
            // 
            this.tblReservationDetails.AllowUserToAddRows = false;
            this.tblReservationDetails.AllowUserToDeleteRows = false;
            this.tblReservationDetails.AllowUserToOrderColumns = true;
            this.tblReservationDetails.AllowUserToResizeColumns = false;
            this.tblReservationDetails.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            this.tblReservationDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.tblReservationDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblReservationDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.tblReservationDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tblReservationDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblReservationDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.tblReservationDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblReservationDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnReservation,
            this.clmnArrival,
            this.clmnDeparture,
            this.clmnWifi,
            this.clmnSatelliteTV,
            this.clmnHotWater,
            this.clmnExtraBed,
            this.clmnPets});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblReservationDetails.DefaultCellStyle = dataGridViewCellStyle13;
            this.tblReservationDetails.Location = new System.Drawing.Point(7, 104);
            this.tblReservationDetails.Name = "tblReservationDetails";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblReservationDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.tblReservationDetails.RowHeadersVisible = false;
            this.tblReservationDetails.RowHeadersWidth = 51;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            this.tblReservationDetails.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.tblReservationDetails.RowTemplate.Height = 40;
            this.tblReservationDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblReservationDetails.Size = new System.Drawing.Size(988, 345);
            this.tblReservationDetails.TabIndex = 2;
            this.tblReservationDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblReservationDetails_CellClick);
            // 
            // clmnReservation
            // 
            this.clmnReservation.FillWeight = 90F;
            this.clmnReservation.HeaderText = "Make a reservation";
            this.clmnReservation.MinimumWidth = 6;
            this.clmnReservation.Name = "clmnReservation";
            // 
            // clmnArrival
            // 
            this.clmnArrival.FillWeight = 140F;
            this.clmnArrival.HeaderText = "Arrival Date";
            this.clmnArrival.MinimumWidth = 6;
            this.clmnArrival.Name = "clmnArrival";
            // 
            // clmnDeparture
            // 
            this.clmnDeparture.FillWeight = 140F;
            this.clmnDeparture.HeaderText = "Departure Date";
            this.clmnDeparture.MinimumWidth = 6;
            this.clmnDeparture.Name = "clmnDeparture";
            // 
            // clmnWifi
            // 
            this.clmnWifi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmnWifi.FillWeight = 80F;
            this.clmnWifi.HeaderText = "Full Package";
            this.clmnWifi.MinimumWidth = 6;
            this.clmnWifi.Name = "clmnWifi";
            this.clmnWifi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmnWifi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clmnSatelliteTV
            // 
            this.clmnSatelliteTV.FillWeight = 70F;
            this.clmnSatelliteTV.HeaderText = "Satellite TV";
            this.clmnSatelliteTV.MinimumWidth = 6;
            this.clmnSatelliteTV.Name = "clmnSatelliteTV";
            this.clmnSatelliteTV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmnSatelliteTV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clmnHotWater
            // 
            this.clmnHotWater.FillWeight = 65F;
            this.clmnHotWater.HeaderText = "Hot Water";
            this.clmnHotWater.MinimumWidth = 6;
            this.clmnHotWater.Name = "clmnHotWater";
            this.clmnHotWater.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmnHotWater.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clmnExtraBed
            // 
            this.clmnExtraBed.FillWeight = 65F;
            this.clmnExtraBed.HeaderText = "Extra Bed";
            this.clmnExtraBed.MinimumWidth = 6;
            this.clmnExtraBed.Name = "clmnExtraBed";
            // 
            // clmnPets
            // 
            this.clmnPets.FillWeight = 70F;
            this.clmnPets.HeaderText = "Pets Allowed";
            this.clmnPets.MinimumWidth = 6;
            this.clmnPets.Name = "clmnPets";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnNext.FlatAppearance.BorderSize = 2;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnNext.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight;
            this.btnNext.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnNext.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNext.IconSize = 40;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(789, 506);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(190, 55);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnPrevious.FlatAppearance.BorderSize = 2;
            this.btnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPrevious.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            this.btnPrevious.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPrevious.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrevious.IconSize = 40;
            this.btnPrevious.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrevious.Location = new System.Drawing.Point(31, 506);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(190, 55);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label16.Location = new System.Drawing.Point(37, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(311, 35);
            this.label16.TabIndex = 262;
            this.label16.Text = "Reservation Details";
            // 
            // FormNewGuestNext
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1003, 584);
            this.Controls.Add(this.panelGuestNext);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Location = new System.Drawing.Point(307, 84);
            this.Name = "FormNewGuestNext";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "New Guest";
            this.Load += new System.EventHandler(this.FormNewGuestNext_Load);
            this.panelGuestNext.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblReservationDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGuestNext;
        private System.Windows.Forms.DataGridView tblReservationDetails;
        private FontAwesome.Sharp.IconButton btnNext;
        private FontAwesome.Sharp.IconButton btnPrevious;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboID;
        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton icnId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmnReservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnArrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDeparture;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmnWifi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmnSatelliteTV;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmnHotWater;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmnExtraBed;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmnPets;
        private System.Windows.Forms.Label label1;
    }
}