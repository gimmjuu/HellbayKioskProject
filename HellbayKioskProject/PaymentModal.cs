using System;
using System.Windows.Forms;

namespace HellbayKioskProject {
    public partial class PaymentModal : Form {
        public PaymentModal() {
            InitializeComponent();
            timerClose.Start();
        }

        private void timerClose_Tick(object sender, EventArgs e) {
            timerClose.Stop();
            this.Close();
            FirstView firstView = new FirstView();
            firstView.ShowDialog();
        }
    }
}
