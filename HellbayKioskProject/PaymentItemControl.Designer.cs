namespace HellbayKioskProject {
    partial class PaymentItemControl {
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
            this.tblPaymentItem = new System.Windows.Forms.TableLayoutPanel();
            this.lblItemCount = new System.Windows.Forms.Label();
            this.lblItemPrice = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.tblPaymentItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblPaymentItem
            // 
            this.tblPaymentItem.ColumnCount = 5;
            this.tblPaymentItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblPaymentItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblPaymentItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblPaymentItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblPaymentItem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblPaymentItem.Controls.Add(this.lblItemCount, 3, 0);
            this.tblPaymentItem.Controls.Add(this.lblItemPrice, 4, 0);
            this.tblPaymentItem.Controls.Add(this.lblItemName, 0, 0);
            this.tblPaymentItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPaymentItem.Location = new System.Drawing.Point(0, 0);
            this.tblPaymentItem.Margin = new System.Windows.Forms.Padding(0);
            this.tblPaymentItem.Name = "tblPaymentItem";
            this.tblPaymentItem.RowCount = 1;
            this.tblPaymentItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPaymentItem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblPaymentItem.Size = new System.Drawing.Size(670, 60);
            this.tblPaymentItem.TabIndex = 0;
            // 
            // lblItemCount
            // 
            this.lblItemCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemCount.AutoSize = true;
            this.lblItemCount.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblItemCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.lblItemCount.Location = new System.Drawing.Point(412, 20);
            this.lblItemCount.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblItemCount.Name = "lblItemCount";
            this.lblItemCount.Size = new System.Drawing.Size(114, 20);
            this.lblItemCount.TabIndex = 0;
            this.lblItemCount.Text = "0";
            this.lblItemCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblItemPrice
            // 
            this.lblItemPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemPrice.AutoSize = true;
            this.lblItemPrice.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblItemPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.lblItemPrice.Location = new System.Drawing.Point(546, 20);
            this.lblItemPrice.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblItemPrice.Name = "lblItemPrice";
            this.lblItemPrice.Size = new System.Drawing.Size(114, 20);
            this.lblItemPrice.TabIndex = 1;
            this.lblItemPrice.Text = "0원";
            this.lblItemPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblItemName
            // 
            this.lblItemName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemName.AutoSize = true;
            this.tblPaymentItem.SetColumnSpan(this.lblItemName, 2);
            this.lblItemName.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.lblItemName.Location = new System.Drawing.Point(10, 20);
            this.lblItemName.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(248, 20);
            this.lblItemName.TabIndex = 2;
            this.lblItemName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PaymentItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tblPaymentItem);
            this.Margin = new System.Windows.Forms.Padding(28, 24, 0, 0);
            this.Name = "PaymentItemControl";
            this.Size = new System.Drawing.Size(670, 60);
            this.Load += new System.EventHandler(this.PaymentItemControl_Load);
            this.tblPaymentItem.ResumeLayout(false);
            this.tblPaymentItem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblPaymentItem;
        private System.Windows.Forms.Label lblItemCount;
        private System.Windows.Forms.Label lblItemPrice;
        private System.Windows.Forms.Label lblItemName;
    }
}
