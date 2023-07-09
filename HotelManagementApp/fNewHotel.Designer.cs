namespace HotelManagementApp
{
    partial class fNewHotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fNewHotel));
            this.gbNewHotel = new System.Windows.Forms.GroupBox();
            this.btnSubmitHotel = new System.Windows.Forms.Button();
            this.cbHotelStars = new System.Windows.Forms.ComboBox();
            this.tbHotelLocation = new System.Windows.Forms.TextBox();
            this.tbHotelName = new System.Windows.Forms.TextBox();
            this.lHotelLocation = new System.Windows.Forms.Label();
            this.lHotelName = new System.Windows.Forms.Label();
            this.lStars = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbNewHotel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbNewHotel
            // 
            this.gbNewHotel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbNewHotel.BackColor = System.Drawing.Color.Lavender;
            this.gbNewHotel.Controls.Add(this.btnSubmitHotel);
            this.gbNewHotel.Controls.Add(this.cbHotelStars);
            this.gbNewHotel.Controls.Add(this.tbHotelLocation);
            this.gbNewHotel.Controls.Add(this.tbHotelName);
            this.gbNewHotel.Controls.Add(this.lHotelLocation);
            this.gbNewHotel.Controls.Add(this.lHotelName);
            this.gbNewHotel.Controls.Add(this.lStars);
            this.gbNewHotel.Location = new System.Drawing.Point(255, 194);
            this.gbNewHotel.Name = "gbNewHotel";
            this.gbNewHotel.Size = new System.Drawing.Size(419, 252);
            this.gbNewHotel.TabIndex = 28;
            this.gbNewHotel.TabStop = false;
            this.gbNewHotel.Text = "New Hotel";
            // 
            // btnSubmitHotel
            // 
            this.btnSubmitHotel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmitHotel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmitHotel.Location = new System.Drawing.Point(41, 182);
            this.btnSubmitHotel.Name = "btnSubmitHotel";
            this.btnSubmitHotel.Size = new System.Drawing.Size(342, 38);
            this.btnSubmitHotel.TabIndex = 3;
            this.btnSubmitHotel.Text = "Save";
            this.btnSubmitHotel.UseVisualStyleBackColor = true;
            this.btnSubmitHotel.Click += new System.EventHandler(this.btnSubmitHotel_Click);
            // 
            // cbHotelStars
            // 
            this.cbHotelStars.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbHotelStars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHotelStars.FormattingEnabled = true;
            this.cbHotelStars.ItemHeight = 16;
            this.cbHotelStars.Location = new System.Drawing.Point(172, 125);
            this.cbHotelStars.Name = "cbHotelStars";
            this.cbHotelStars.Size = new System.Drawing.Size(115, 24);
            this.cbHotelStars.TabIndex = 2;
            // 
            // tbHotelLocation
            // 
            this.tbHotelLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbHotelLocation.Location = new System.Drawing.Point(172, 84);
            this.tbHotelLocation.Name = "tbHotelLocation";
            this.tbHotelLocation.Size = new System.Drawing.Size(211, 22);
            this.tbHotelLocation.TabIndex = 1;
            // 
            // tbHotelName
            // 
            this.tbHotelName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbHotelName.Location = new System.Drawing.Point(172, 45);
            this.tbHotelName.Name = "tbHotelName";
            this.tbHotelName.Size = new System.Drawing.Size(211, 22);
            this.tbHotelName.TabIndex = 0;
            // 
            // lHotelLocation
            // 
            this.lHotelLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lHotelLocation.AutoSize = true;
            this.lHotelLocation.BackColor = System.Drawing.Color.Transparent;
            this.lHotelLocation.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHotelLocation.Location = new System.Drawing.Point(37, 84);
            this.lHotelLocation.Name = "lHotelLocation";
            this.lHotelLocation.Size = new System.Drawing.Size(84, 23);
            this.lHotelLocation.TabIndex = 29;
            this.lHotelLocation.Text = "Location";
            // 
            // lHotelName
            // 
            this.lHotelName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lHotelName.AutoSize = true;
            this.lHotelName.BackColor = System.Drawing.Color.Transparent;
            this.lHotelName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHotelName.Location = new System.Drawing.Point(37, 45);
            this.lHotelName.Name = "lHotelName";
            this.lHotelName.Size = new System.Drawing.Size(61, 23);
            this.lHotelName.TabIndex = 27;
            this.lHotelName.Text = "Name";
            // 
            // lStars
            // 
            this.lStars.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lStars.AutoSize = true;
            this.lStars.BackColor = System.Drawing.Color.Transparent;
            this.lStars.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lStars.Location = new System.Drawing.Point(37, 125);
            this.lStars.Name = "lStars";
            this.lStars.Size = new System.Drawing.Size(57, 23);
            this.lStars.TabIndex = 24;
            this.lStars.Text = "Stars";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(51, 530);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(240, 60);
            this.btnBack.TabIndex = 29;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // fNewHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(871, 646);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbNewHotel);
            this.Name = "fNewHotel";
            this.Text = "fNewHotel";
            this.gbNewHotel.ResumeLayout(false);
            this.gbNewHotel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNewHotel;
        private System.Windows.Forms.Button btnSubmitHotel;
        private System.Windows.Forms.ComboBox cbHotelStars;
        private System.Windows.Forms.TextBox tbHotelLocation;
        private System.Windows.Forms.TextBox tbHotelName;
        private System.Windows.Forms.Label lHotelLocation;
        private System.Windows.Forms.Label lHotelName;
        private System.Windows.Forms.Label lStars;
        private System.Windows.Forms.Button btnBack;
    }
}