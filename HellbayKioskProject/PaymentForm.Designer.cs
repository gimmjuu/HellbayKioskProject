namespace HellbayKioskProject {
    partial class PaymentForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tb = new System.Windows.Forms.TableLayoutPanel();
            this.lblBottom = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPayLogo = new System.Windows.Forms.Label();
            this.flowPayList = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbTotalValue = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.btnCard = new HellbayKioskProject.RoundedButton();
            this.btnCash = new HellbayKioskProject.RoundedButton();
            this.tb.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tbTotalValue.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb
            // 
            this.tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.tb.ColumnCount = 2;
            this.tb.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82F));
            this.tb.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tb.Controls.Add(this.lblBottom, 0, 4);
            this.tb.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tb.Controls.Add(this.flowPayList, 0, 1);
            this.tb.Controls.Add(this.flowLayoutPanel2, 1, 1);
            this.tb.Controls.Add(this.tbTotalValue, 0, 2);
            this.tb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb.Location = new System.Drawing.Point(0, 0);
            this.tb.Margin = new System.Windows.Forms.Padding(0);
            this.tb.Name = "tb";
            this.tb.RowCount = 5;
            this.tb.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tb.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tb.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tb.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tb.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tb.Size = new System.Drawing.Size(979, 656);
            this.tb.TabIndex = 0;
            // 
            // lblBottom
            // 
            this.lblBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBottom.AutoSize = true;
            this.tb.SetColumnSpan(this.lblBottom, 2);
            this.lblBottom.Image = global::HellbayKioskProject.Properties.Resources.img_bottom;
            this.lblBottom.Location = new System.Drawing.Point(0, 580);
            this.lblBottom.Margin = new System.Windows.Forms.Padding(0);
            this.lblBottom.MaximumSize = new System.Drawing.Size(0, 76);
            this.lblBottom.MinimumSize = new System.Drawing.Size(0, 76);
            this.lblBottom.Name = "lblBottom";
            this.lblBottom.Size = new System.Drawing.Size(979, 76);
            this.lblBottom.TabIndex = 0;
            this.lblBottom.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tb.SetColumnSpan(this.tableLayoutPanel1, 2);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Controls.Add(this.lblPayLogo, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(979, 80);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblPayLogo
            // 
            this.lblPayLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPayLogo.AutoSize = true;
            this.lblPayLogo.Font = new System.Drawing.Font("EastMarket", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPayLogo.Location = new System.Drawing.Point(16, 10);
            this.lblPayLogo.Margin = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.lblPayLogo.Name = "lblPayLogo";
            this.lblPayLogo.Size = new System.Drawing.Size(130, 28);
            this.lblPayLogo.TabIndex = 0;
            this.lblPayLogo.Text = "Hellbay";
            // 
            // flowPayList
            // 
            this.flowPayList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowPayList.AutoScroll = true;
            this.flowPayList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(244)))), ((int)(((byte)(191)))));
            this.flowPayList.Location = new System.Drawing.Point(36, 112);
            this.flowPayList.Margin = new System.Windows.Forms.Padding(36, 32, 36, 3);
            this.flowPayList.Name = "flowPayList";
            this.flowPayList.Size = new System.Drawing.Size(730, 377);
            this.flowPayList.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.Controls.Add(this.btnCancel);
            this.flowLayoutPanel2.Controls.Add(this.btnCard);
            this.flowLayoutPanel2.Controls.Add(this.btnCash);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(802, 116);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 36, 0, 36);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(177, 340);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnCancel.BackgroundImage = global::HellbayKioskProject.Properties.Resources.btnCancel;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("나눔스퀘어 네오 Heavy", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.Location = new System.Drawing.Point(8, 0);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(8, 0, 0, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(132, 50);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "    취소";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbTotalValue
            // 
            this.tbTotalValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(244)))), ((int)(((byte)(191)))));
            this.tbTotalValue.ColumnCount = 4;
            this.tbTotalValue.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbTotalValue.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbTotalValue.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbTotalValue.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbTotalValue.Controls.Add(this.label1, 0, 0);
            this.tbTotalValue.Controls.Add(this.lblTotalCount, 1, 0);
            this.tbTotalValue.Controls.Add(this.label3, 2, 0);
            this.tbTotalValue.Controls.Add(this.lblTotalPrice, 3, 0);
            this.tbTotalValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTotalValue.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbTotalValue.Location = new System.Drawing.Point(36, 492);
            this.tbTotalValue.Margin = new System.Windows.Forms.Padding(36, 0, 36, 0);
            this.tbTotalValue.Name = "tbTotalValue";
            this.tbTotalValue.RowCount = 1;
            this.tbTotalValue.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbTotalValue.Size = new System.Drawing.Size(730, 52);
            this.tbTotalValue.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "총 수량";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTotalCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.lblTotalCount.Location = new System.Drawing.Point(202, 17);
            this.lblTotalCount.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(142, 17);
            this.lblTotalCount.TabIndex = 1;
            this.lblTotalCount.Text = "개";
            this.lblTotalCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.label3.Location = new System.Drawing.Point(384, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "총 결제금액";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.lblTotalPrice.Location = new System.Drawing.Point(566, 17);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(144, 17);
            this.lblTotalPrice.TabIndex = 3;
            this.lblTotalPrice.Text = "원";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCard
            // 
            this.btnCard.BackColor = System.Drawing.Color.White;
            this.btnCard.BackgroundColor = System.Drawing.Color.White;
            this.btnCard.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.btnCard.BorderRadius = 24;
            this.btnCard.BorderSize = 3;
            this.btnCard.FlatAppearance.BorderSize = 0;
            this.btnCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCard.Font = new System.Drawing.Font("나눔스퀘어 네오 Heavy", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.btnCard.Location = new System.Drawing.Point(8, 62);
            this.btnCard.Margin = new System.Windows.Forms.Padding(8, 0, 0, 12);
            this.btnCard.Name = "btnCard";
            this.btnCard.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.btnCard.Size = new System.Drawing.Size(128, 48);
            this.btnCard.TabIndex = 1;
            this.btnCard.Text = "카드결제";
            this.btnCard.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.btnCard.UseVisualStyleBackColor = false;
            // 
            // btnCash
            // 
            this.btnCash.BackColor = System.Drawing.Color.White;
            this.btnCash.BackgroundColor = System.Drawing.Color.White;
            this.btnCash.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.btnCash.BorderRadius = 24;
            this.btnCash.BorderSize = 3;
            this.btnCash.FlatAppearance.BorderSize = 0;
            this.btnCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCash.Font = new System.Drawing.Font("나눔스퀘어 네오 Heavy", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.btnCash.Location = new System.Drawing.Point(8, 122);
            this.btnCash.Margin = new System.Windows.Forms.Padding(8, 0, 0, 12);
            this.btnCash.Name = "btnCash";
            this.btnCash.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.btnCash.Size = new System.Drawing.Size(128, 48);
            this.btnCash.TabIndex = 2;
            this.btnCash.Text = "현금결제";
            this.btnCash.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.btnCash.UseVisualStyleBackColor = false;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(979, 656);
            this.Controls.Add(this.tb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PaymentForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hellbay Payment";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            this.tb.ResumeLayout(false);
            this.tb.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.tbTotalValue.ResumeLayout(false);
            this.tbTotalValue.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tb;
        private System.Windows.Forms.Label lblBottom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblPayLogo;
        private System.Windows.Forms.FlowLayoutPanel flowPayList;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnCancel;
        private RoundedButton btnCard;
        private RoundedButton btnCash;
        private System.Windows.Forms.TableLayoutPanel tbTotalValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalPrice;
    }
}