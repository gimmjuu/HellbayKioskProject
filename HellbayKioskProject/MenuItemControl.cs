using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HellbayKioskProject {
    public partial class MenuItemControl : UserControl {
        public MenuItemControl() {
            InitializeComponent();
        }

        // Rouned Controll
        private void MenuItemControll_Load(object sender, EventArgs e) {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 15, 15));
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        # region Properties

        private int _itemId;
        private string _name;
        private int _price;
        private string _type;
        private Image _image;

        [Category("Custom Props")]
        public string ItemName {
            get { return _name; }
            set { _name = value; lblMenuName.Text = value; }
        }
        [Category("Custom Props")]
        public int Price {
            get { return _price; }
            set { _price = value; lblMenuPrice.Text = $"{value}원"; }
        }

        [Category("Custom Props")]
        public Image Image {
            get { return _image; }
            set { _image = value; picBox.Image = value; }
        }

        //[Category("Custom Props")]
        public int ItemId {
            get { return _itemId; }
            set { _itemId = value; }
        }

        public string Category {
            get { return _type; }
            set { _type = value; }
        }

        #endregion

        //private void Control_Click(object sender, EventArgs e) {
        //    this.OnClick(e);
        //}

        public new event EventHandler Click {
            add {
                base.Click += value;
                foreach (Control control in tableLayoutPanel1.Controls) {
                    control.Click += value;
                    foreach (Control con in control.Controls) {
                        con.Click += value;
                    }
                }
            }

            remove {
                base.Click -= value;
                foreach (Control control in Controls) {
                    control.Click -= value;
                    foreach (Control con in control.Controls) {
                        con.Click -= value;
                    }
                }
            }
        }
    }
}
