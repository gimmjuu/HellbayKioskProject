using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HellbayKioskProject {
    public partial class MenuForm : Form {

        private DBConnect db = new DBConnect();

        // Constructor
        public MenuForm() {
            InitializeComponent();
        }

        // Methods
        private void MenuForm_Load(object sender, System.EventArgs e) {
            lblMenuAll.Click += MenuCategory_Click;
            lblMenuMain.Click += MenuCategory_Click;
            lblMenuSub.Click += MenuCategory_Click;

            // TB_MENU 메뉴 데이터 컨트롤에 적용
            foreach (var data in db.GetMenuInfo()) {
                MenuItemControl menuItem = new MenuItemControl();
                menuItem.ItemId = data.DataId;
                menuItem.ItemName = data.DataName;
                menuItem.Price = data.DataPrice;
                menuItem.Image = (Image)Properties.Resources.ResourceManager.GetObject($"img_menu_{menuItem.ItemId}", System.Globalization.CultureInfo.CurrentCulture);
                menuItem.Category = data.DataCategory;
                flowMenuList.Controls.Add(menuItem);
                menuItem.Click += MenuItem_Click;
            }
        }

        // 카테고리 전환
        private void MenuCategory_Click(object sender, EventArgs e) {
            var control = (Label)sender;
            var category = control.Text;

            switch (category) {
                case "MAIN":
                    lblUnderAll.Visible = false;
                    lblUnderMain.Visible = true;
                    lblUnderSub.Visible = false;

                    var typeMain = new List<string> { "noodle", "rice" };

                    foreach (MenuItemControl item in flowMenuList.Controls) {
                        if (typeMain.Contains(item.Category)) {
                            item.Visible = true;
                        }
                        else { item.Visible = false; }
                    }
                    break;

                case "SIDE":
                    lblUnderAll.Visible = false;
                    lblUnderMain.Visible = false;
                    lblUnderSub.Visible = true;

                    var typeSub = new List<string> { "side", "beverage" };

                    foreach (MenuItemControl item in flowMenuList.Controls) {
                        if (typeSub.Contains(item.Category)) {
                            item.Visible = true;
                        }
                        else { item.Visible = false; }
                    }
                    break;

                default:
                    lblUnderAll.Visible = true;
                    lblUnderMain.Visible = false;
                    lblUnderSub.Visible = false;

                    foreach (MenuItemControl item in flowMenuList.Controls) {
                        item.Visible = true;
                    }
                    break;
            }
        }

        /// <summary>
        /// 메뉴 컨트롤 클릭 메소드
        /// </summary>
        private void MenuItem_Click(object sender, EventArgs e) {
            Control control = null;

            if (sender is Label) {
                Label childControl = (Label)sender;
                control = childControl.Parent.Parent;
            }
            else {
                PictureBox childControl = (PictureBox)sender;
                control = childControl.Parent.Parent;
            }

            // 클릭한 아이템 주문 내역으로 이동
            var clickedItem = (MenuItemControl)control;

            if (flowOrderList.HasChildren) {
                foreach (OrderItemControl order in flowOrderList.Controls) {
                    // 주문 내역에 이미 존재하는 메뉴를 추가한 경우
                    if (clickedItem.ItemId == order.ItemId) {
                        order.ItemCount++;

                        var currentPrice = order.Price;
                        currentPrice += clickedItem.Price;
                        order.Price = currentPrice;

                        Console.WriteLine("현재 상품 가격", order.Price);
                        return;
                    }
                }
            }

            // 새로운 주문 메뉴 추가
            OrderItemControl orderItem = new OrderItemControl();
            orderItem.ItemId = clickedItem.ItemId;
            orderItem.ItemName = clickedItem.ItemName;
            orderItem.Price = clickedItem.Price;
            orderItem.ItemCount = 1;
            flowOrderList.Controls.Add(orderItem);
        }

        private void btnOrder_Click(object sender, EventArgs e) {
            PaymentForm payform = new PaymentForm(flowOrderList.Controls);
            payform.FormClosed += PayClose;
            payform.ShowDialog();
        }

        private void PayClose(object sender, EventArgs e) {
            this.Close();
        }
    }
}