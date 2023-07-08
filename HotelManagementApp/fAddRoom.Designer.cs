namespace HotelManagementApp
{
    partial class fAddRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAddRoom));
            this.gbRoomInfo = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lBedType = new System.Windows.Forms.Label();
            this.lCapacity = new System.Windows.Forms.Label();
            this.lRoomNumber = new System.Windows.Forms.Label();
            this.lSeaView = new System.Windows.Forms.Label();
            this.cbBedType = new System.Windows.Forms.ComboBox();
            this.numCapacity = new System.Windows.Forms.NumericUpDown();
            this.cbSeaView = new System.Windows.Forms.CheckBox();
            this.numRoomNumber = new System.Windows.Forms.NumericUpDown();
            this.gbRoomInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRoomNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // gbRoomInfo
            // 
            this.gbRoomInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbRoomInfo.BackColor = System.Drawing.Color.Lavender;
            this.gbRoomInfo.Controls.Add(this.numRoomNumber);
            this.gbRoomInfo.Controls.Add(this.cbSeaView);
            this.gbRoomInfo.Controls.Add(this.numCapacity);
            this.gbRoomInfo.Controls.Add(this.cbBedType);
            this.gbRoomInfo.Controls.Add(this.lSeaView);
            this.gbRoomInfo.Controls.Add(this.lRoomNumber);
            this.gbRoomInfo.Controls.Add(this.btnAdd);
            this.gbRoomInfo.Controls.Add(this.lBedType);
            this.gbRoomInfo.Controls.Add(this.lCapacity);
            this.gbRoomInfo.Location = new System.Drawing.Point(264, 195);
            this.gbRoomInfo.Name = "gbRoomInfo";
            this.gbRoomInfo.Size = new System.Drawing.Size(376, 280);
            this.gbRoomInfo.TabIndex = 27;
            this.gbRoomInfo.TabStop = false;
            this.gbRoomInfo.Text = "Room Information";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.SystemColors.Window;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(31, 213);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(320, 30);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lBedType
            // 
            this.lBedType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lBedType.AutoSize = true;
            this.lBedType.BackColor = System.Drawing.Color.Transparent;
            this.lBedType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBedType.Location = new System.Drawing.Point(27, 84);
            this.lBedType.Name = "lBedType";
            this.lBedType.Size = new System.Drawing.Size(100, 23);
            this.lBedType.TabIndex = 24;
            this.lBedType.Text = "Bed Type:";
            // 
            // lCapacity
            // 
            this.lCapacity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lCapacity.AutoSize = true;
            this.lCapacity.BackColor = System.Drawing.Color.Transparent;
            this.lCapacity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCapacity.Location = new System.Drawing.Point(27, 125);
            this.lCapacity.Name = "lCapacity";
            this.lCapacity.Size = new System.Drawing.Size(93, 23);
            this.lCapacity.TabIndex = 25;
            this.lCapacity.Text = "Capacity:";
            // 
            // lRoomNumber
            // 
            this.lRoomNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lRoomNumber.AutoSize = true;
            this.lRoomNumber.BackColor = System.Drawing.Color.Transparent;
            this.lRoomNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRoomNumber.Location = new System.Drawing.Point(27, 41);
            this.lRoomNumber.Name = "lRoomNumber";
            this.lRoomNumber.Size = new System.Drawing.Size(84, 23);
            this.lRoomNumber.TabIndex = 26;
            this.lRoomNumber.Text = "Number:";
            // 
            // lSeaView
            // 
            this.lSeaView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lSeaView.AutoSize = true;
            this.lSeaView.BackColor = System.Drawing.Color.Transparent;
            this.lSeaView.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSeaView.Location = new System.Drawing.Point(27, 164);
            this.lSeaView.Name = "lSeaView";
            this.lSeaView.Size = new System.Drawing.Size(100, 23);
            this.lSeaView.TabIndex = 27;
            this.lSeaView.Text = "Sea View:";
            // 
            // cbBedType
            // 
            this.cbBedType.FormattingEnabled = true;
            this.cbBedType.Location = new System.Drawing.Point(137, 84);
            this.cbBedType.Name = "cbBedType";
            this.cbBedType.Size = new System.Drawing.Size(121, 24);
            this.cbBedType.TabIndex = 1;
            // 
            // numCapacity
            // 
            this.numCapacity.Location = new System.Drawing.Point(137, 126);
            this.numCapacity.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numCapacity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCapacity.Name = "numCapacity";
            this.numCapacity.Size = new System.Drawing.Size(120, 22);
            this.numCapacity.TabIndex = 2;
            this.numCapacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbSeaView
            // 
            this.cbSeaView.AutoSize = true;
            this.cbSeaView.Location = new System.Drawing.Point(137, 167);
            this.cbSeaView.Name = "cbSeaView";
            this.cbSeaView.Size = new System.Drawing.Size(18, 17);
            this.cbSeaView.TabIndex = 3;
            this.cbSeaView.UseVisualStyleBackColor = true;
            // 
            // numRoomNumber
            // 
            this.numRoomNumber.Location = new System.Drawing.Point(137, 42);
            this.numRoomNumber.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numRoomNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRoomNumber.Name = "numRoomNumber";
            this.numRoomNumber.Size = new System.Drawing.Size(120, 22);
            this.numRoomNumber.TabIndex = 0;
            this.numRoomNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // fAddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(904, 662);
            this.Controls.Add(this.gbRoomInfo);
            this.Name = "fAddRoom";
            this.Text = "Add Room";
            this.gbRoomInfo.ResumeLayout(false);
            this.gbRoomInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRoomNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRoomInfo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lBedType;
        private System.Windows.Forms.Label lCapacity;
        private System.Windows.Forms.Label lSeaView;
        private System.Windows.Forms.Label lRoomNumber;
        private System.Windows.Forms.ComboBox cbBedType;
        private System.Windows.Forms.NumericUpDown numCapacity;
        private System.Windows.Forms.CheckBox cbSeaView;
        private System.Windows.Forms.NumericUpDown numRoomNumber;
    }
}