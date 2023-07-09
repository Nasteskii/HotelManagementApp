namespace HotelManagementApp
{
    partial class fRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fRegister));
            this.gbRegister = new System.Windows.Forms.GroupBox();
            this.lLastName = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lFirstName = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lEmail = new System.Windows.Forms.Label();
            this.lPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRegister
            // 
            this.gbRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbRegister.BackColor = System.Drawing.Color.Lavender;
            this.gbRegister.Controls.Add(this.lLastName);
            this.gbRegister.Controls.Add(this.tbLastName);
            this.gbRegister.Controls.Add(this.lFirstName);
            this.gbRegister.Controls.Add(this.tbFirstName);
            this.gbRegister.Controls.Add(this.tbEmail);
            this.gbRegister.Controls.Add(this.btnRegister);
            this.gbRegister.Controls.Add(this.lEmail);
            this.gbRegister.Controls.Add(this.lPassword);
            this.gbRegister.Controls.Add(this.tbPassword);
            this.gbRegister.Location = new System.Drawing.Point(270, 166);
            this.gbRegister.Name = "gbRegister";
            this.gbRegister.Size = new System.Drawing.Size(419, 271);
            this.gbRegister.TabIndex = 27;
            this.gbRegister.TabStop = false;
            this.gbRegister.Text = "Register";
            // 
            // lLastName
            // 
            this.lLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lLastName.AutoSize = true;
            this.lLastName.BackColor = System.Drawing.Color.Transparent;
            this.lLastName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLastName.Location = new System.Drawing.Point(45, 82);
            this.lLastName.Name = "lLastName";
            this.lLastName.Size = new System.Drawing.Size(111, 23);
            this.lLastName.TabIndex = 29;
            this.lLastName.Text = "Last Name:";
            // 
            // tbLastName
            // 
            this.tbLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbLastName.Location = new System.Drawing.Point(166, 82);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(214, 22);
            this.tbLastName.TabIndex = 1;
            this.tbLastName.Validating += new System.ComponentModel.CancelEventHandler(this.tbLastName_Validating);
            // 
            // lFirstName
            // 
            this.lFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lFirstName.AutoSize = true;
            this.lFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lFirstName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFirstName.Location = new System.Drawing.Point(45, 39);
            this.lFirstName.Name = "lFirstName";
            this.lFirstName.Size = new System.Drawing.Size(112, 23);
            this.lFirstName.TabIndex = 27;
            this.lFirstName.Text = "First Name:";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbFirstName.Location = new System.Drawing.Point(166, 39);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(214, 22);
            this.tbFirstName.TabIndex = 0;
            this.tbFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.tbFirstName_Validating);
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbEmail.Location = new System.Drawing.Point(166, 125);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(214, 22);
            this.tbEmail.TabIndex = 2;
            this.tbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.tbEmail_Validating);
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegister.BackColor = System.Drawing.SystemColors.Window;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegister.Location = new System.Drawing.Point(49, 207);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(331, 30);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lEmail
            // 
            this.lEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lEmail.AutoSize = true;
            this.lEmail.BackColor = System.Drawing.Color.Transparent;
            this.lEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEmail.Location = new System.Drawing.Point(45, 125);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(64, 23);
            this.lEmail.TabIndex = 24;
            this.lEmail.Text = "Email:";
            // 
            // lPassword
            // 
            this.lPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lPassword.AutoSize = true;
            this.lPassword.BackColor = System.Drawing.Color.Transparent;
            this.lPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPassword.Location = new System.Drawing.Point(45, 166);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(104, 23);
            this.lPassword.TabIndex = 25;
            this.lPassword.Text = "Password:";
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPassword.Location = new System.Drawing.Point(166, 166);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(214, 22);
            this.tbPassword.TabIndex = 3;
            this.tbPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbPassword_Validating);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(51, 530);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(240, 60);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // fRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(901, 618);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbRegister);
            this.Name = "fRegister";
            this.Text = "Register";
            this.gbRegister.ResumeLayout(false);
            this.gbRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRegister;
        private System.Windows.Forms.Label lLastName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lFirstName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnBack;
    }
}