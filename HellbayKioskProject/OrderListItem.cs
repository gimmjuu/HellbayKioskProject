using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace HellbayKioskProject {
    public partial class OrderListItem : UserControl {

        public OrderListItem() {
            InitializeComponent();
        }

        #region Properties

        private string _name;
        private int _price;
        private int _itemCount;

        [Category("Custom Props")]
        public string MenuName {
            get { return _name; }
            set { _name = value; lblName.Text = value; }
        }
        [Category("Custom Props")]
        public int Price {
            get { return _price; }
            set { _price = value; lblPrice.Text = $"{value}원"; }

        }
        [Category("Custom Props")]
        public int ItemCount {
            get { return _itemCount; }
            set { _itemCount = value; lblCount.Text = $"{value}"; }
        }
        #endregion

        private void btnMinus_Click(object sender, System.EventArgs e) {
            var currentCount = Convert.ToInt32(this.lblCount.Text);
            currentCount--;
            this.ItemCount = currentCount;
        }

        private void btnPlus_Click(object sender, EventArgs e) {
            var currentCount = Convert.ToInt32(this.lblCount.Text);
            currentCount++;
            this.ItemCount = currentCount;
        }
    }
}
