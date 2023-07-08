using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementApp
{
    public partial class fAddRoom : Form
    {
        public int Number { get; set; } = 1;
        public BedTypes BedType { get; set; }
        public int Capacity { get; set; }
        public bool SeaView { get; set; }
        public fAddRoom()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            DoubleBuffered = true;
            cbBedType.DataSource = Enum.GetValues(typeof(BedTypes));
        }

        public void LoadFields()
        {
            numRoomNumber.Value = Number;
            cbBedType.SelectedItem = BedType;
            numCapacity.Value = Capacity;
            cbSeaView.Checked = SeaView;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Number = (int)numRoomNumber.Value;
            BedType = (BedTypes)cbBedType.SelectedItem;
            Capacity = (int)numCapacity.Value;
            SeaView = cbSeaView.Checked;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
