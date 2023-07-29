namespace HellbayKioskProject {
    partial class MenuForm {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent() {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlMenuTop = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMenuLogo = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMenuAll = new System.Windows.Forms.Label();
            this.lblUnderAll = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.lblUnderMain = new System.Windows.Forms.Label();
            this.lblMenuMain = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.lblUnderSub = new System.Windows.Forms.Label();
            this.lblMenuSub = new System.Windows.Forms.Label();
            this.flowMenuList = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnOrder = new HellbayKioskProject.RoundedButton();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblBasketTitle = new System.Windows.Forms.Label();
            this.flowOrderList = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlMenuTop.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.pnlMenuTop, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowMenuList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowOrderList, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(979, 656);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlMenuTop
            // 
            this.pnlMenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.pnlMenuTop.Controls.Add(this.tableLayoutPanel2);
            this.pnlMenuTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenuTop.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuTop.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMenuTop.Name = "pnlMenuTop";
            this.pnlMenuTop.Size = new System.Drawing.Size(685, 85);
            this.pnlMenuTop.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.lblMenuLogo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel7, 6, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(685, 85);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // lblMenuLogo
            // 
            this.lblMenuLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMenuLogo.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.lblMenuLogo, 2);
            this.lblMenuLogo.Font = new System.Drawing.Font("EastMarket", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMenuLogo.Location = new System.Drawing.Point(12, 10);
            this.lblMenuLogo.Margin = new System.Windows.Forms.Padding(12, 0, 3, 0);
            this.lblMenuLogo.Name = "lblMenuLogo";
            this.lblMenuLogo.Size = new System.Drawing.Size(117, 32);
            this.lblMenuLogo.TabIndex = 0;
            this.lblMenuLogo.Text = "Hellbay";
            this.lblMenuLogo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.lblMenuAll, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblUnderAll, 0, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(388, 42);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(97, 43);
            this.tableLayoutPanel5.TabIndex = 5;
            // 
            // lblMenuAll
            // 
            this.lblMenuAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMenuAll.AutoSize = true;
            this.lblMenuAll.Font = new System.Drawing.Font("나눔스퀘어 네오 Regular", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMenuAll.ForeColor = System.Drawing.Color.White;
            this.lblMenuAll.Location = new System.Drawing.Point(0, 21);
            this.lblMenuAll.Margin = new System.Windows.Forms.Padding(0);
            this.lblMenuAll.Name = "lblMenuAll";
            this.lblMenuAll.Size = new System.Drawing.Size(97, 13);
            this.lblMenuAll.TabIndex = 1;
            this.lblMenuAll.Text = "ALL";
            this.lblMenuAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUnderAll
            // 
            this.lblUnderAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnderAll.AutoSize = true;
            this.lblUnderAll.BackColor = System.Drawing.Color.White;
            this.lblUnderAll.Location = new System.Drawing.Point(12, 40);
            this.lblUnderAll.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.lblUnderAll.MaximumSize = new System.Drawing.Size(0, 3);
            this.lblUnderAll.MinimumSize = new System.Drawing.Size(0, 3);
            this.lblUnderAll.Name = "lblUnderAll";
            this.lblUnderAll.Size = new System.Drawing.Size(73, 3);
            this.lblUnderAll.TabIndex = 4;
            this.lblUnderAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.lblUnderMain, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.lblMenuMain, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(485, 42);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(97, 43);
            this.tableLayoutPanel6.TabIndex = 6;
            // 
            // lblUnderMain
            // 
            this.lblUnderMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnderMain.AutoSize = true;
            this.lblUnderMain.BackColor = System.Drawing.Color.White;
            this.lblUnderMain.Location = new System.Drawing.Point(12, 40);
            this.lblUnderMain.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.lblUnderMain.MaximumSize = new System.Drawing.Size(0, 3);
            this.lblUnderMain.MinimumSize = new System.Drawing.Size(0, 3);
            this.lblUnderMain.Name = "lblUnderMain";
            this.lblUnderMain.Size = new System.Drawing.Size(73, 3);
            this.lblUnderMain.TabIndex = 8;
            this.lblUnderMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUnderMain.Visible = false;
            // 
            // lblMenuMain
            // 
            this.lblMenuMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMenuMain.AutoSize = true;
            this.lblMenuMain.Font = new System.Drawing.Font("나눔스퀘어 네오 Regular", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMenuMain.ForeColor = System.Drawing.Color.White;
            this.lblMenuMain.Location = new System.Drawing.Point(0, 21);
            this.lblMenuMain.Margin = new System.Windows.Forms.Padding(0);
            this.lblMenuMain.Name = "lblMenuMain";
            this.lblMenuMain.Size = new System.Drawing.Size(97, 13);
            this.lblMenuMain.TabIndex = 2;
            this.lblMenuMain.Text = "MAIN";
            this.lblMenuMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.lblUnderSub, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.lblMenuSub, 0, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(582, 42);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(97, 43);
            this.tableLayoutPanel7.TabIndex = 7;
            // 
            // lblUnderSub
            // 
            this.lblUnderSub.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnderSub.AutoSize = true;
            this.lblUnderSub.BackColor = System.Drawing.Color.White;
            this.lblUnderSub.Location = new System.Drawing.Point(12, 40);
            this.lblUnderSub.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.lblUnderSub.MaximumSize = new System.Drawing.Size(0, 3);
            this.lblUnderSub.MinimumSize = new System.Drawing.Size(0, 3);
            this.lblUnderSub.Name = "lblUnderSub";
            this.lblUnderSub.Size = new System.Drawing.Size(73, 3);
            this.lblUnderSub.TabIndex = 8;
            this.lblUnderSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUnderSub.Visible = false;
            // 
            // lblMenuSub
            // 
            this.lblMenuSub.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMenuSub.AutoSize = true;
            this.lblMenuSub.Font = new System.Drawing.Font("나눔스퀘어 네오 Regular", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMenuSub.ForeColor = System.Drawing.Color.White;
            this.lblMenuSub.Location = new System.Drawing.Point(0, 21);
            this.lblMenuSub.Margin = new System.Windows.Forms.Padding(0);
            this.lblMenuSub.Name = "lblMenuSub";
            this.lblMenuSub.Size = new System.Drawing.Size(97, 13);
            this.lblMenuSub.TabIndex = 3;
            this.lblMenuSub.Text = "SIDE";
            this.lblMenuSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowMenuList
            // 
            this.flowMenuList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowMenuList.AutoScroll = true;
            this.flowMenuList.Location = new System.Drawing.Point(0, 85);
            this.flowMenuList.Margin = new System.Windows.Forms.Padding(0);
            this.flowMenuList.Name = "flowMenuList";
            this.flowMenuList.Padding = new System.Windows.Forms.Padding(12, 12, 12, 0);
            this.tableLayoutPanel1.SetRowSpan(this.flowMenuList, 2);
            this.flowMenuList.Size = new System.Drawing.Size(685, 571);
            this.flowMenuList.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(233)))), ((int)(((byte)(201)))));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.btnOrder, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(685, 577);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(294, 79);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // btnOrder
            // 
            this.btnOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(233)))), ((int)(((byte)(201)))));
            this.btnOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(233)))), ((int)(((byte)(201)))));
            this.btnOrder.BackgroundImage = global::HellbayKioskProject.Properties.Resources.btnOrder;
            this.btnOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOrder.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnOrder.BorderRadius = 26;
            this.btnOrder.BorderSize = 0;
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Location = new System.Drawing.Point(68, 15);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(0);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Padding = new System.Windows.Forms.Padding(20, 1, 0, 0);
            this.btnOrder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnOrder.Size = new System.Drawing.Size(158, 48);
            this.btnOrder.TabIndex = 0;
            this.btnOrder.Text = "0";
            this.btnOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.TextColor = System.Drawing.Color.White;
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(233)))), ((int)(((byte)(201)))));
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.lblBasketTitle, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(685, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(294, 85);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // lblBasketTitle
            // 
            this.lblBasketTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBasketTitle.AutoSize = true;
            this.lblBasketTitle.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblBasketTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.lblBasketTitle.Location = new System.Drawing.Point(16, 32);
            this.lblBasketTitle.Margin = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.lblBasketTitle.Name = "lblBasketTitle";
            this.lblBasketTitle.Size = new System.Drawing.Size(278, 21);
            this.lblBasketTitle.TabIndex = 0;
            this.lblBasketTitle.Text = "주문내역";
            // 
            // flowOrderList
            // 
            this.flowOrderList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowOrderList.AutoScroll = true;
            this.flowOrderList.BackColor = System.Drawing.Color.White;
            this.flowOrderList.Location = new System.Drawing.Point(685, 85);
            this.flowOrderList.Margin = new System.Windows.Forms.Padding(0);
            this.flowOrderList.Name = "flowOrderList";
            this.flowOrderList.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.flowOrderList.Size = new System.Drawing.Size(294, 492);
            this.flowOrderList.TabIndex = 7;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 656);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MenuForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HELLBAY";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlMenuTop.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlMenuTop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblMenuLogo;
        private System.Windows.Forms.Label lblMenuAll;
        private System.Windows.Forms.Label lblMenuMain;
        private System.Windows.Forms.Label lblMenuSub;
        private System.Windows.Forms.FlowLayoutPanel flowMenuList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblBasketTitle;
        private System.Windows.Forms.Label lblUnderAll;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label lblUnderMain;
        private System.Windows.Forms.Label lblUnderSub;
        private System.Windows.Forms.FlowLayoutPanel flowOrderList;
        private RoundedButton btnOrder;
    }
}

