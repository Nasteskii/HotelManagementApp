namespace HotelManagementApp
{
    partial class fMakeReservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMakeReservation));
            this.btnBack = new System.Windows.Forms.Button();
            this.gbMakeReservation = new System.Windows.Forms.GroupBox();
            this.lCheckInDate = new System.Windows.Forms.Label();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.numNumberOfGuests = new System.Windows.Forms.NumericUpDown();
            this.lGuestsNumber = new System.Windows.Forms.Label();
            this.lGuestsAge = new System.Windows.Forms.Label();
            this.lFirstName = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lEmail = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btnMakeReservation = new System.Windows.Forms.Button();
            this.lLastName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numGuest4Age = new System.Windows.Forms.NumericUpDown();
            this.numGuest3Age = new System.Windows.Forms.NumericUpDown();
            this.numGuest2Age = new System.Windows.Forms.NumericUpDown();
            this.numGuest1Age = new System.Windows.Forms.NumericUpDown();
            this.gbMakeReservation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfGuests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGuest4Age)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGuest3Age)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGuest2Age)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGuest1Age)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(51, 546);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(240, 60);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gbMakeReservation
            // 
            this.gbMakeReservation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbMakeReservation.BackColor = System.Drawing.Color.Lavender;
            this.gbMakeReservation.Controls.Add(this.label2);
            this.gbMakeReservation.Controls.Add(this.lCheckInDate);
            this.gbMakeReservation.Controls.Add(this.dtpCheckOut);
            this.gbMakeReservation.Controls.Add(this.dtpCheckIn);
            this.gbMakeReservation.Controls.Add(this.numNumberOfGuests);
            this.gbMakeReservation.Controls.Add(this.lGuestsNumber);
            this.gbMakeReservation.Controls.Add(this.numGuest4Age);
            this.gbMakeReservation.Controls.Add(this.numGuest3Age);
            this.gbMakeReservation.Controls.Add(this.numGuest2Age);
            this.gbMakeReservation.Controls.Add(this.numGuest1Age);
            this.gbMakeReservation.Controls.Add(this.lGuestsAge);
            this.gbMakeReservation.Controls.Add(this.lFirstName);
            this.gbMakeReservation.Controls.Add(this.tbLastName);
            this.gbMakeReservation.Controls.Add(this.lEmail);
            this.gbMakeReservation.Controls.Add(this.tbFirstName);
            this.gbMakeReservation.Controls.Add(this.tbEmail);
            this.gbMakeReservation.Controls.Add(this.btnMakeReservation);
            this.gbMakeReservation.Controls.Add(this.lLastName);
            this.gbMakeReservation.Location = new System.Drawing.Point(249, 170);
            this.gbMakeReservation.Name = "gbMakeReservation";
            this.gbMakeReservation.Size = new System.Drawing.Size(419, 356);
            this.gbMakeReservation.TabIndex = 29;
            this.gbMakeReservation.TabStop = false;
            this.gbMakeReservation.Text = "Make Reservation";
            // 
            // lCheckInDate
            // 
            this.lCheckInDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lCheckInDate.AutoSize = true;
            this.lCheckInDate.BackColor = System.Drawing.Color.Transparent;
            this.lCheckInDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCheckInDate.Location = new System.Drawing.Point(44, 228);
            this.lCheckInDate.Name = "lCheckInDate";
            this.lCheckInDate.Size = new System.Drawing.Size(93, 23);
            this.lCheckInDate.TabIndex = 39;
            this.lCheckInDate.Text = "Check In:";
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Location = new System.Drawing.Point(161, 267);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(218, 22);
            this.dtpCheckOut.TabIndex = 38;
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Location = new System.Drawing.Point(161, 229);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(218, 22);
            this.dtpCheckIn.TabIndex = 37;
            // 
            // numNumberOfGuests
            // 
            this.numNumberOfGuests.Location = new System.Drawing.Point(217, 155);
            this.numNumberOfGuests.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numNumberOfGuests.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNumberOfGuests.Name = "numNumberOfGuests";
            this.numNumberOfGuests.Size = new System.Drawing.Size(46, 22);
            this.numNumberOfGuests.TabIndex = 36;
            this.numNumberOfGuests.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNumberOfGuests.ValueChanged += new System.EventHandler(this.numNumberOfGuests_ValueChanged);
            // 
            // lGuestsNumber
            // 
            this.lGuestsNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lGuestsNumber.AutoSize = true;
            this.lGuestsNumber.BackColor = System.Drawing.Color.Transparent;
            this.lGuestsNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGuestsNumber.Location = new System.Drawing.Point(44, 154);
            this.lGuestsNumber.Name = "lGuestsNumber";
            this.lGuestsNumber.Size = new System.Drawing.Size(171, 23);
            this.lGuestsNumber.TabIndex = 35;
            this.lGuestsNumber.Text = "Number of guests:";
            // 
            // lGuestsAge
            // 
            this.lGuestsAge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lGuestsAge.AutoSize = true;
            this.lGuestsAge.BackColor = System.Drawing.Color.Transparent;
            this.lGuestsAge.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGuestsAge.Location = new System.Drawing.Point(44, 190);
            this.lGuestsAge.Name = "lGuestsAge";
            this.lGuestsAge.Size = new System.Drawing.Size(119, 23);
            this.lGuestsAge.TabIndex = 30;
            this.lGuestsAge.Text = "Guests Age:";
            // 
            // lFirstName
            // 
            this.lFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lFirstName.AutoSize = true;
            this.lFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lFirstName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFirstName.Location = new System.Drawing.Point(44, 80);
            this.lFirstName.Name = "lFirstName";
            this.lFirstName.Size = new System.Drawing.Size(112, 23);
            this.lFirstName.TabIndex = 29;
            this.lFirstName.Text = "First Name:";
            // 
            // tbLastName
            // 
            this.tbLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbLastName.Location = new System.Drawing.Point(165, 80);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(214, 22);
            this.tbLastName.TabIndex = 1;
            // 
            // lEmail
            // 
            this.lEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lEmail.AutoSize = true;
            this.lEmail.BackColor = System.Drawing.Color.Transparent;
            this.lEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEmail.Location = new System.Drawing.Point(44, 41);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(64, 23);
            this.lEmail.TabIndex = 27;
            this.lEmail.Text = "Email:";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbFirstName.Location = new System.Drawing.Point(165, 41);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(214, 22);
            this.tbFirstName.TabIndex = 0;
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbEmail.Location = new System.Drawing.Point(165, 118);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(214, 22);
            this.tbEmail.TabIndex = 2;
            // 
            // btnMakeReservation
            // 
            this.btnMakeReservation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMakeReservation.BackColor = System.Drawing.SystemColors.Window;
            this.btnMakeReservation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMakeReservation.Location = new System.Drawing.Point(48, 309);
            this.btnMakeReservation.Name = "btnMakeReservation";
            this.btnMakeReservation.Size = new System.Drawing.Size(331, 30);
            this.btnMakeReservation.TabIndex = 4;
            this.btnMakeReservation.Text = "Make Reservation";
            this.btnMakeReservation.UseVisualStyleBackColor = false;
            this.btnMakeReservation.Click += new System.EventHandler(this.btnMakeReservation_Click);
            // 
            // lLastName
            // 
            this.lLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lLastName.AutoSize = true;
            this.lLastName.BackColor = System.Drawing.Color.Transparent;
            this.lLastName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLastName.Location = new System.Drawing.Point(44, 118);
            this.lLastName.Name = "lLastName";
            this.lLastName.Size = new System.Drawing.Size(111, 23);
            this.lLastName.TabIndex = 24;
            this.lLastName.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 40;
            this.label2.Text = "Check Out:";
            // 
            // numGuest4Age
            // 
            this.numGuest4Age.Location = new System.Drawing.Point(329, 191);
            this.numGuest4Age.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numGuest4Age.Name = "numGuest4Age";
            this.numGuest4Age.Size = new System.Drawing.Size(50, 22);
            this.numGuest4Age.TabIndex = 34;
            this.numGuest4Age.Visible = false;
            // 
            // numGuest3Age
            // 
            this.numGuest3Age.Location = new System.Drawing.Point(273, 191);
            this.numGuest3Age.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numGuest3Age.Name = "numGuest3Age";
            this.numGuest3Age.Size = new System.Drawing.Size(50, 22);
            this.numGuest3Age.TabIndex = 33;
            this.numGuest3Age.Visible = false;
            // 
            // numGuest2Age
            // 
            this.numGuest2Age.Location = new System.Drawing.Point(217, 191);
            this.numGuest2Age.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numGuest2Age.Name = "numGuest2Age";
            this.numGuest2Age.Size = new System.Drawing.Size(50, 22);
            this.numGuest2Age.TabIndex = 32;
            this.numGuest2Age.Visible = false;
            // 
            // numGuest1Age
            // 
            this.numGuest1Age.Location = new System.Drawing.Point(161, 191);
            this.numGuest1Age.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numGuest1Age.Name = "numGuest1Age";
            this.numGuest1Age.Size = new System.Drawing.Size(50, 22);
            this.numGuest1Age.TabIndex = 31;
            this.numGuest1Age.Visible = false;
            // 
            // fMakeReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(917, 690);
            this.Controls.Add(this.gbMakeReservation);
            this.Controls.Add(this.btnBack);
            this.Name = "fMakeReservation";
            this.Text = "fMakeReservation";
            this.Load += new System.EventHandler(this.fMakeReservation_Load);
            this.gbMakeReservation.ResumeLayout(false);
            this.gbMakeReservation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfGuests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGuest4Age)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGuest3Age)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGuest2Age)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGuest1Age)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox gbMakeReservation;
        private System.Windows.Forms.NumericUpDown numNumberOfGuests;
        private System.Windows.Forms.Label lGuestsNumber;
        private System.Windows.Forms.Label lGuestsAge;
        private System.Windows.Forms.Label lFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button btnMakeReservation;
        private System.Windows.Forms.Label lLastName;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.Label lCheckInDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numGuest4Age;
        private System.Windows.Forms.NumericUpDown numGuest3Age;
        private System.Windows.Forms.NumericUpDown numGuest2Age;
        private System.Windows.Forms.NumericUpDown numGuest1Age;
    }
}