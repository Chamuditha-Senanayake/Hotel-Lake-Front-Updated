
namespace Hotel_Management_System
{
    partial class FormFoodDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tblFoodDetails = new System.Windows.Forms.DataGridView();
            this.iconBttnFoodSearchCashier = new FontAwesome.Sharp.IconButton();
            this.txtSearchFoodCashier = new System.Windows.Forms.TextBox();
            this.radioAny = new System.Windows.Forms.RadioButton();
            this.radioSnacks = new System.Windows.Forms.RadioButton();
            this.radioBeve = new System.Windows.Forms.RadioButton();
            this.radioDinner = new System.Windows.Forms.RadioButton();
            this.radioLunch = new System.Windows.Forms.RadioButton();
            this.radioBreak = new System.Windows.Forms.RadioButton();
            this.radioDess = new System.Windows.Forms.RadioButton();
            this.grpFood = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblFoodDetails)).BeginInit();
            this.grpFood.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblFoodDetails
            // 
            this.tblFoodDetails.AllowUserToAddRows = false;
            this.tblFoodDetails.AllowUserToDeleteRows = false;
            this.tblFoodDetails.AllowUserToResizeColumns = false;
            this.tblFoodDetails.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.tblFoodDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.tblFoodDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblFoodDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.tblFoodDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblFoodDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.tblFoodDetails.ColumnHeadersHeight = 60;
            this.tblFoodDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblFoodDetails.DefaultCellStyle = dataGridViewCellStyle7;
            this.tblFoodDetails.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tblFoodDetails.Location = new System.Drawing.Point(32, 114);
            this.tblFoodDetails.Name = "tblFoodDetails";
            this.tblFoodDetails.ReadOnly = true;
            this.tblFoodDetails.RowHeadersVisible = false;
            this.tblFoodDetails.RowHeadersWidth = 51;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.tblFoodDetails.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.tblFoodDetails.RowTemplate.Height = 35;
            this.tblFoodDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblFoodDetails.Size = new System.Drawing.Size(940, 434);
            this.tblFoodDetails.TabIndex = 29;
            // 
            // iconBttnFoodSearchCashier
            // 
            this.iconBttnFoodSearchCashier.Enabled = false;
            this.iconBttnFoodSearchCashier.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconBttnFoodSearchCashier.IconColor = System.Drawing.Color.Black;
            this.iconBttnFoodSearchCashier.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBttnFoodSearchCashier.IconSize = 30;
            this.iconBttnFoodSearchCashier.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconBttnFoodSearchCashier.Location = new System.Drawing.Point(311, 34);
            this.iconBttnFoodSearchCashier.Name = "iconBttnFoodSearchCashier";
            this.iconBttnFoodSearchCashier.Size = new System.Drawing.Size(34, 31);
            this.iconBttnFoodSearchCashier.TabIndex = 38;
            this.iconBttnFoodSearchCashier.UseVisualStyleBackColor = true;
            // 
            // txtSearchFoodCashier
            // 
            this.txtSearchFoodCashier.ForeColor = System.Drawing.Color.Gray;
            this.txtSearchFoodCashier.Location = new System.Drawing.Point(12, 38);
            this.txtSearchFoodCashier.Name = "txtSearchFoodCashier";
            this.txtSearchFoodCashier.Size = new System.Drawing.Size(293, 22);
            this.txtSearchFoodCashier.TabIndex = 37;
            this.txtSearchFoodCashier.Text = "Search";
            this.txtSearchFoodCashier.TextChanged += new System.EventHandler(this.txtSearchFoodCashier_TextChanged);
            this.txtSearchFoodCashier.Enter += new System.EventHandler(this.txtSearchFoodCashier_Enter);
            // 
            // radioAny
            // 
            this.radioAny.AutoSize = true;
            this.radioAny.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAny.Location = new System.Drawing.Point(25, 13);
            this.radioAny.Name = "radioAny";
            this.radioAny.Size = new System.Drawing.Size(119, 33);
            this.radioAny.TabIndex = 39;
            this.radioAny.TabStop = true;
            this.radioAny.Text = "Anytime";
            this.radioAny.UseVisualStyleBackColor = true;
            this.radioAny.CheckedChanged += new System.EventHandler(this.radioAnytime_CheckedChanged);
            this.radioAny.MouseDown += new System.Windows.Forms.MouseEventHandler(this.radioAny_MouseDown);
            // 
            // radioSnacks
            // 
            this.radioSnacks.AutoSize = true;
            this.radioSnacks.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSnacks.Location = new System.Drawing.Point(150, 12);
            this.radioSnacks.Name = "radioSnacks";
            this.radioSnacks.Size = new System.Drawing.Size(112, 33);
            this.radioSnacks.TabIndex = 40;
            this.radioSnacks.TabStop = true;
            this.radioSnacks.Text = "Snacks";
            this.radioSnacks.UseVisualStyleBackColor = true;
            this.radioSnacks.CheckedChanged += new System.EventHandler(this.radioSnacks_CheckedChanged);
            this.radioSnacks.MouseDown += new System.Windows.Forms.MouseEventHandler(this.radioSnacks_MouseDown);
            // 
            // radioBeve
            // 
            this.radioBeve.AutoSize = true;
            this.radioBeve.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBeve.Location = new System.Drawing.Point(296, 8);
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
            this.radioDinner.Location = new System.Drawing.Point(150, 46);
            this.radioDinner.Name = "radioDinner";
            this.radioDinner.Size = new System.Drawing.Size(105, 33);
            this.radioDinner.TabIndex = 42;
            this.radioDinner.TabStop = true;
            this.radioDinner.Text = "Dinner";
            this.radioDinner.UseVisualStyleBackColor = true;
            this.radioDinner.CheckedChanged += new System.EventHandler(this.radioDinner_CheckedChanged);
            this.radioDinner.MouseDown += new System.Windows.Forms.MouseEventHandler(this.radioDinner_MouseDown);
            // 
            // radioLunch
            // 
            this.radioLunch.AutoSize = true;
            this.radioLunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioLunch.Location = new System.Drawing.Point(296, 46);
            this.radioLunch.Name = "radioLunch";
            this.radioLunch.Size = new System.Drawing.Size(98, 33);
            this.radioLunch.TabIndex = 43;
            this.radioLunch.TabStop = true;
            this.radioLunch.Text = "Lunch";
            this.radioLunch.UseVisualStyleBackColor = true;
            this.radioLunch.CheckedChanged += new System.EventHandler(this.radioLunch_CheckedChanged);
            this.radioLunch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.radioLunch_MouseDown);
            // 
            // radioBreak
            // 
            this.radioBreak.AutoSize = true;
            this.radioBreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBreak.Location = new System.Drawing.Point(457, 46);
            this.radioBreak.Name = "radioBreak";
            this.radioBreak.Size = new System.Drawing.Size(134, 33);
            this.radioBreak.TabIndex = 44;
            this.radioBreak.TabStop = true;
            this.radioBreak.Text = "Breakfast";
            this.radioBreak.UseVisualStyleBackColor = true;
            this.radioBreak.CheckedChanged += new System.EventHandler(this.radioBreak_CheckedChanged);
            this.radioBreak.MouseDown += new System.Windows.Forms.MouseEventHandler(this.radioBreak_MouseDown);
            // 
            // radioDess
            // 
            this.radioDess.AutoSize = true;
            this.radioDess.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDess.Location = new System.Drawing.Point(459, 12);
            this.radioDess.Name = "radioDess";
            this.radioDess.Size = new System.Drawing.Size(129, 33);
            this.radioDess.TabIndex = 45;
            this.radioDess.TabStop = true;
            this.radioDess.Text = "Desserts";
            this.radioDess.UseVisualStyleBackColor = true;
            this.radioDess.CheckedChanged += new System.EventHandler(this.radioDess_CheckedChanged);
            this.radioDess.MouseDown += new System.Windows.Forms.MouseEventHandler(this.radioDess_MouseDown);
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
            this.grpFood.Location = new System.Drawing.Point(394, 3);
            this.grpFood.Name = "grpFood";
            this.grpFood.Size = new System.Drawing.Size(597, 89);
            this.grpFood.TabIndex = 46;
            this.grpFood.TabStop = false;
            // 
            // FormFoodDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1003, 584);
            this.Controls.Add(this.grpFood);
            this.Controls.Add(this.iconBttnFoodSearchCashier);
            this.Controls.Add(this.txtSearchFoodCashier);
            this.Controls.Add(this.tblFoodDetails);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Name = "FormFoodDetails";
            this.Text = "Restaurant";
            this.Load += new System.EventHandler(this.FormFoodDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblFoodDetails)).EndInit();
            this.grpFood.ResumeLayout(false);
            this.grpFood.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblFoodDetails;
        private FontAwesome.Sharp.IconButton iconBttnFoodSearchCashier;
        private System.Windows.Forms.TextBox txtSearchFoodCashier;
        private System.Windows.Forms.RadioButton radioAny;
        private System.Windows.Forms.RadioButton radioSnacks;
        private System.Windows.Forms.RadioButton radioBeve;
        private System.Windows.Forms.RadioButton radioDinner;
        private System.Windows.Forms.RadioButton radioLunch;
        private System.Windows.Forms.RadioButton radioBreak;
        private System.Windows.Forms.RadioButton radioDess;
        private System.Windows.Forms.GroupBox grpFood;
    }
}