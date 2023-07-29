using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HellbayKioskProject {
    public partial class PaymentForm : Form {

        private DBConnect db = new DBConnect();
        private int totalPrice = 0;

        public PaymentForm(Control.ControlCollection orderList) {
            InitializeComponent();

            // 결제 화면 선언 시 주문 내역 생성
            foreach (OrderItemControl item in orderList) {
                PaymentItemControl paymentItem = new PaymentItemControl();
                paymentItem.ItemId = item.ItemId;
                paymentItem.ItemName = item.ItemName;
                paymentItem.ItemCount = item.ItemCount;
                paymentItem.Price = item.Price;
                flowPayList.Controls.Add(paymentItem);  // 레이아웃에 컨트롤 추가
                totalPrice += paymentItem.Price;    // 결제 금액 합산
            }

            // 총 금액, 총 수량 출력
            lblTotalCount.Text = $"{orderList.Count} 개";
            lblTotalPrice.Text = $"{totalPrice} 원";
        }

        private void PaymentForm_Load(object sender, EventArgs e) {
            flowPayList.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, flowPayList.Width, flowPayList.Height, 10, 10)); ;
            tbTotalValue.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, tbTotalValue.Width, tbTotalValue.Height, 10, 10));

            btnCard.Click += BtnPayment_Click;
            btnCash.Click += BtnPayment_Click;
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);


        // 뒤로가기
        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        /// <summary>
        /// 카드결제, 현금결제 버튼 클릭 시 DB 저장으로 연결
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPayment_Click(object sender, EventArgs e) {
            // 결제 타입 확인
            var typeString = ((Button)sender).Text;

            // TB_ORDER INSERT
            var ret = false;

            if (typeString == "카드결제") {
                ret = SaveOrderInfo("card");
            }
            else if (typeString == "현금결제") {
                ret = SaveOrderInfo("cash");
            }

            if (ret == true) {
                ret = SaveOrderItemInfo();
            }

            // 저장이 잘 이루어진 경우 결제 진행 다이얼로그 출력
            if (ret) {
                PaymentModal insertCardModal = new PaymentModal();
                insertCardModal.FormClosed += InsertCardModal_FormClosed;
                insertCardModal.ShowDialog();
            }
            else {
                // MessageBox.Show("안내 문구", "창 타이틀", 버튼 타입, 아이콘 타입);
                MessageBox.Show("결제 오류가 발생했습니다. 잠시 후 다시 시도해주세요.", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertCardModal_FormClosed(object sender, FormClosedEventArgs e) {
            this.Close();
        }

        // 결제 정보 저장
        bool SaveOrderInfo(string payType) {
            // data 객체 선언
            DataHolder orderInfo = new DataHolder();
            orderInfo.DataPrice = totalPrice;
            orderInfo.DataCategory = payType;

            // insert 수행
            var insertRet = db.InsertRow(orderInfo, "ORDER");
            return insertRet;
        }

        // 매출 내역 저장
        bool SaveOrderItemInfo() {
            var ret = true;
            foreach (PaymentItemControl item in flowPayList.Controls) {
                DataHolder orderItem = new DataHolder();
                orderItem.DataId = item.ItemId;
                orderItem.DataCount = item.ItemCount;

                // DB 저장 
                var insertRet = db.InsertRow(orderItem, "ORDER_ITEM");
                if (insertRet == false) {
                    ret = false;
                    break;
                }
            }
            return ret;
        }

        private void label3_Click(object sender, EventArgs e) {

        }
    }
}
