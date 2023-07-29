using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HellbayKioskProject {
    public partial class ManageForm : Form {

        private DBConnect db = new DBConnect();

        public ManageForm() {
            InitializeComponent();
        }

        private void ManageForm_Load(object sender, EventArgs e) {
            // combobox add value
            var ret = db.GetOrderDate();

            foreach (string str in ret) {
                cbBoxDate.Items.Add(str);
            }

            // Rounded Controll
            tbDetail.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, tbDetail.Width, tbDetail.Height, 15, 15));
            //dataGridOrder.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, dataGridOrder.Width, dataGridOrder.Height + 20, 15, 15));
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

    }
}
