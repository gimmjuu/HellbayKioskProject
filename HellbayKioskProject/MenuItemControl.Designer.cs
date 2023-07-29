namespace HellbayKioskProject {
    partial class MenuItemControl {
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent() {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.lblMenuName = new System.Windows.Forms.Label();
            this.lblMenuPrice = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.picBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblMenuName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblMenuPrice, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(300, 380);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.Color.White;
            this.picBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBox.Location = new System.Drawing.Point(0, 0);
            this.picBox.Margin = new System.Windows.Forms.Padding(0);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(300, 280);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // lblMenuName
            // 
            this.lblMenuName.AutoSize = true;
            this.lblMenuName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMenuName.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMenuName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.lblMenuName.Location = new System.Drawing.Point(0, 280);
            this.lblMenuName.Margin = new System.Windows.Forms.Padding(0);
            this.lblMenuName.Name = "lblMenuName";
            this.lblMenuName.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.lblMenuName.Size = new System.Drawing.Size(300, 50);
            this.lblMenuName.TabIndex = 1;
            this.lblMenuName.Text = "메뉴 이름";
            this.lblMenuName.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblMenuPrice
            // 
            this.lblMenuPrice.AutoSize = true;
            this.lblMenuPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMenuPrice.Font = new System.Drawing.Font("나눔스퀘어 네오 Heavy", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMenuPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.lblMenuPrice.Location = new System.Drawing.Point(0, 330);
            this.lblMenuPrice.Margin = new System.Windows.Forms.Padding(0);
            this.lblMenuPrice.Name = "lblMenuPrice";
            this.lblMenuPrice.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblMenuPrice.Size = new System.Drawing.Size(300, 50);
            this.lblMenuPrice.TabIndex = 2;
            this.lblMenuPrice.Text = "0000원";
            this.lblMenuPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MenuItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "MenuItemControl";
            this.Size = new System.Drawing.Size(300, 380);
            this.Load += new System.EventHandler(this.MenuItemControll_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label lblMenuName;
        private System.Windows.Forms.Label lblMenuPrice;
    }
}
