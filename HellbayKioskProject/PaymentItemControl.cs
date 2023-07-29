using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HellbayKioskProject {
    public partial class PaymentItemControl : UserControl {

        #region Properties
        private int _id;
        private string _name;
        private int _count;
        private int _price;

        public int ItemId {
            get { return _id; }
            set { _id = value; }
        }

        [Category("Custom Props")]
        public string ItemName {
            get { return _name; }
            set { _name = value; lblItemName.Text = $"{value}"; }
        }

        [Category("Custom Props")]
        public int ItemCount {
            get { return _count; }
            set { _count = value; lblItemCount.Text = $"{value}"; }
        }

        [Category("Custom Props")]
        public int Price {
            get { return _price; }
            set { _price = value; lblItemPrice.Text = $"{value}원"; }
        }
        #endregion

        public PaymentItemControl() {
            InitializeComponent();
        }

        private void PaymentItemControl_Load(object sender, EventArgs e) {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 10, 10));
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

    }
}
