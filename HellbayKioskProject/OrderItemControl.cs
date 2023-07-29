using System.ComponentModel;
using System.Windows.Forms;

namespace HellbayKioskProject {
    public partial class OrderItemControl : UserControl {
        public OrderItemControl() {
            InitializeComponent();
        }

        #region Properties
        private int _id;
        private string _name;
        private int _price;
        private int _count;

        public int ItemId {
            get { return _id; }
            set { _id = value; }
        }

        [Category("Custom Props")]
        public string ItemName {
            get { return _name; }
            set { _name = value; lblOrderName.Text = value; }
        }

        [Category("Custom Props")]
        public int Price {
            get { return _price; }
            set { _price = value; lblOrderPrice.Text = $"{value}원"; }
        }

        [Category("Custom Props")]
        public int ItemCount {
            get { return _count; }
            set { _count = value; lblOrderCount.Text = $"{value}"; }
        }
        #endregion

        // metnods
        private void btnMinus_Click(object sender, System.EventArgs e) {
            var currentCount = this.ItemCount;
            currentCount--;

            // 수량이 0 이면 아이템 삭제
            if (currentCount == 0) {
                itemDelete();
                return;
            }

            ItemCount = currentCount;
        }

        private void btnPlus_Click(object sender, System.EventArgs e) {
            // 재고 잔여 여부 확인 필요 !!!
            var currentCount = this.ItemCount;
            currentCount++;
            this.ItemCount = currentCount;
        }

        private void lblDelete_Click(object sender, System.EventArgs e) {
            //// 이벤트 핸들러 삭제
            //this.btnMinus.Click -= btnMinus_Click;
            //this.btnPlus.Click -= btnPlus_Click;
            //this.lblDelete.Click -= lblDelete_Click;
            //// 컨트롤 삭제
            //this.Controls.Clear();
            //// 리소스 릴리즈
            //this.Dispose();
            itemDelete();
        }

        void itemDelete() {
            // 이벤트 핸들러 삭제
            this.btnMinus.Click -= btnMinus_Click;
            this.btnPlus.Click -= btnPlus_Click;
            this.lblDelete.Click -= lblDelete_Click;
            // 컨트롤 삭제
            this.Controls.Clear();
            // 리소스 릴리즈
            this.Dispose();
        }
    }
}
