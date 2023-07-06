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
            this.pbHotelLocation = new System.Windows.Forms.PictureBox();
            this.pbHotelName = new System.Windows.Forms.PictureBox();
            this.tbHotelLocation = new System.Windows.Forms.TextBox();
            this.tbHotelName = new System.Windows.Forms.TextBox();
            this.cbHotelStars = new System.Windows.Forms.ComboBox();
            this.pbHotelStars = new System.Windows.Forms.PictureBox();
            this.btnSubmitHotel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbHotelLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHotelName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHotelStars)).BeginInit();
            this.SuspendLayout();
            // 
            // pbHotelLocation
            // 
            this.pbHotelLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbHotelLocation.Location = new System.Drawing.Point(255, 332);
            this.pbHotelLocation.Name = "pbHotelLocation";
            this.pbHotelLocation.Size = new System.Drawing.Size(125, 22);
            this.pbHotelLocation.TabIndex = 19;
            this.pbHotelLocation.TabStop = false;
            // 
            // pbHotelName
            // 
            this.pbHotelName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbHotelName.Location = new System.Drawing.Point(255, 293);
            this.pbHotelName.Name = "pbHotelName";
            this.pbHotelName.Size = new System.Drawing.Size(125, 22);
            this.pbHotelName.TabIndex = 18;
            this.pbHotelName.TabStop = false;
            // 
            // tbHotelLocation
            // 
            this.tbHotelLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbHotelLocation.Location = new System.Drawing.Point(405, 332);
            this.tbHotelLocation.Name = "tbHotelLocation";
            this.tbHotelLocation.Size = new System.Drawing.Size(211, 22);
            this.tbHotelLocation.TabIndex = 17;
            // 
            // tbHotelName
            // 
            this.tbHotelName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbHotelName.Location = new System.Drawing.Point(405, 293);
            this.tbHotelName.Name = "tbHotelName";
            this.tbHotelName.Size = new System.Drawing.Size(211, 22);
            this.tbHotelName.TabIndex = 16;
            // 
            // cbHotelStars
            // 
            this.cbHotelStars.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbHotelStars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHotelStars.FormattingEnabled = true;
            this.cbHotelStars.Location = new System.Drawing.Point(405, 373);
            this.cbHotelStars.Name = "cbHotelStars";
            this.cbHotelStars.Size = new System.Drawing.Size(115, 24);
            this.cbHotelStars.TabIndex = 20;
            // 
            // pbHotelStars
            // 
            this.pbHotelStars.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbHotelStars.Location = new System.Drawing.Point(255, 375);
            this.pbHotelStars.Name = "pbHotelStars";
            this.pbHotelStars.Size = new System.Drawing.Size(125, 22);
            this.pbHotelStars.TabIndex = 21;
            this.pbHotelStars.TabStop = false;
            // 
            // btnSubmitHotel
            // 
            this.btnSubmitHotel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmitHotel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmitHotel.Location = new System.Drawing.Point(255, 415);
            this.btnSubmitHotel.Name = "btnSubmitHotel";
            this.btnSubmitHotel.Size = new System.Drawing.Size(361, 38);
            this.btnSubmitHotel.TabIndex = 22;
            this.btnSubmitHotel.Text = "Submit";
            this.btnSubmitHotel.UseVisualStyleBackColor = true;
            this.btnSubmitHotel.Click += new System.EventHandler(this.btnSubmitHotel_Click);
            // 
            // fNewHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(871, 646);
            this.Controls.Add(this.btnSubmitHotel);
            this.Controls.Add(this.pbHotelStars);
            this.Controls.Add(this.cbHotelStars);
            this.Controls.Add(this.pbHotelLocation);
            this.Controls.Add(this.pbHotelName);
            this.Controls.Add(this.tbHotelLocation);
            this.Controls.Add(this.tbHotelName);
            this.Name = "fNewHotel";
            this.Text = "fNewHotel";
            ((System.ComponentModel.ISupportInitialize)(this.pbHotelLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHotelName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHotelStars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbHotelLocation;
        private System.Windows.Forms.PictureBox pbHotelName;
        private System.Windows.Forms.TextBox tbHotelLocation;
        private System.Windows.Forms.TextBox tbHotelName;
        private System.Windows.Forms.ComboBox cbHotelStars;
        private System.Windows.Forms.PictureBox pbHotelStars;
        private System.Windows.Forms.Button btnSubmitHotel;
    }
}