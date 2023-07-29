using System.Windows.Forms;

namespace HellbayKioskProject {
    public partial class FirstView : Form {
        public FirstView() {
            InitializeComponent();
        }

        // 메뉴화면으로 전환
        private void btnStore_Click(object sender, System.EventArgs e) {
            MenuForm menuForm = new MenuForm();
            menuForm.ShowDialog();
            this.Close();
        }

        // 관리자화면으로 전환
        private void lblFirstLogo_Click(object sender, System.EventArgs e) {
            ManageForm manageForm = new ManageForm();
            manageForm.ShowDialog();
            this.Close();
        }
    }
}
