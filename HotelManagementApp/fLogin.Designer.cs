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
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.lEmail = new System.Windows.Forms.Label();
            this.lPassword = new System.Windows.Forms.Label();
            this.gbLogIn = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbLogIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPassword.Location = new System.Drawing.Point(137, 73);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(214, 22);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbPassword_Validating);
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbEmail.Location = new System.Drawing.Point(137, 35);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(214, 22);
            this.tbEmail.TabIndex = 0;
            this.tbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.tbEmail_Validating);
            // 
            // btnLogIn
            // 
            this.btnLogIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogIn.BackColor = System.Drawing.SystemColors.Window;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogIn.Location = new System.Drawing.Point(31, 127);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(320, 30);
            this.btnLogIn.TabIndex = 2;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // lEmail
            // 
            this.lEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lEmail.AutoSize = true;
            this.lEmail.BackColor = System.Drawing.Color.Transparent;
            this.lEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEmail.Location = new System.Drawing.Point(27, 35);
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
            this.lPassword.Location = new System.Drawing.Point(27, 73);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(104, 23);
            this.lPassword.TabIndex = 25;
            this.lPassword.Text = "Password:";
            // 
            // gbLogIn
            // 
            this.gbLogIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbLogIn.BackColor = System.Drawing.Color.Lavender;
            this.gbLogIn.Controls.Add(this.tbEmail);
            this.gbLogIn.Controls.Add(this.btnLogIn);
            this.gbLogIn.Controls.Add(this.lEmail);
            this.gbLogIn.Controls.Add(this.lPassword);
            this.gbLogIn.Controls.Add(this.tbPassword);
            this.gbLogIn.Location = new System.Drawing.Point(270, 219);
            this.gbLogIn.Name = "gbLogIn";
            this.gbLogIn.Size = new System.Drawing.Size(376, 181);
            this.gbLogIn.TabIndex = 26;
            this.gbLogIn.TabStop = false;
            this.gbLogIn.Text = "Log In";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(51, 530);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(240, 60);
            this.btnBack.TabIndex = 27;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // fLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(888, 630);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbLogIn);
            this.Name = "fLogIn";
            this.Text = "Log in";
            this.gbLogIn.ResumeLayout(false);
            this.gbLogIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.GroupBox gbLogIn;
        private System.Windows.Forms.Button btnBack;
    }
}