namespace HotelManagementApp
{
    partial class fLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogIn));
            this.pbPassword = new System.Windows.Forms.PictureBox();
            this.pbEmail = new System.Windows.Forms.PictureBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btnSubmitHotel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPassword
            // 
            this.pbPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbPassword.Location = new System.Drawing.Point(282, 326);
            this.pbPassword.Name = "pbPassword";
            this.pbPassword.Size = new System.Drawing.Size(125, 22);
            this.pbPassword.TabIndex = 19;
            this.pbPassword.TabStop = false;
            // 
            // pbEmail
            // 
            this.pbEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbEmail.Location = new System.Drawing.Point(282, 287);
            this.pbEmail.Name = "pbEmail";
            this.pbEmail.Size = new System.Drawing.Size(125, 22);
            this.pbEmail.TabIndex = 18;
            this.pbEmail.TabStop = false;
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPassword.Location = new System.Drawing.Point(432, 326);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(211, 22);
            this.tbPassword.TabIndex = 17;
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbEmail.Location = new System.Drawing.Point(432, 287);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(211, 22);
            this.tbEmail.TabIndex = 16;
            // 
            // btnSubmitHotel
            // 
            this.btnSubmitHotel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmitHotel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmitHotel.Location = new System.Drawing.Point(282, 370);
            this.btnSubmitHotel.Name = "btnSubmitHotel";
            this.btnSubmitHotel.Size = new System.Drawing.Size(361, 38);
            this.btnSubmitHotel.TabIndex = 23;
            this.btnSubmitHotel.Text = "Submit";
            this.btnSubmitHotel.UseVisualStyleBackColor = true;
            this.btnSubmitHotel.Click += new System.EventHandler(this.btnSubmitHotel_Click);
            // 
            // fLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(888, 630);
            this.Controls.Add(this.btnSubmitHotel);
            this.Controls.Add(this.pbPassword);
            this.Controls.Add(this.pbEmail);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbEmail);
            this.Name = "fLogIn";
            this.Text = "Log in";
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPassword;
        private System.Windows.Forms.PictureBox pbEmail;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button btnSubmitHotel;
    }
}