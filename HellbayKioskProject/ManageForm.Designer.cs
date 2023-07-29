namespace HellbayKioskProject {
    partial class ManageForm {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblManageTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTypeItem = new System.Windows.Forms.Label();
            this.lblTypeDate = new System.Windows.Forms.Label();
            this.cbBoxDate = new System.Windows.Forms.ComboBox();
            this.tbDetail = new System.Windows.Forms.TableLayoutPanel();
            this.lblDateTitle = new System.Windows.Forms.Label();
            this.lblUnderBar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOrdId = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flowOrdDataList = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblPayType = new System.Windows.Forms.Label();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            this.dataGridOrder = new System.Windows.Forms.DataGridView();
            this.orderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderPayType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tbDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.lblManageTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbBoxDate, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbDetail, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblDateTitle, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.dataGridOrder, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(979, 656);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblManageTitle
            // 
            this.lblManageTitle.AutoSize = true;
            this.lblManageTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.tableLayoutPanel1.SetColumnSpan(this.lblManageTitle, 6);
            this.lblManageTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblManageTitle.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblManageTitle.ForeColor = System.Drawing.Color.White;
            this.lblManageTitle.Location = new System.Drawing.Point(0, 0);
            this.lblManageTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblManageTitle.Name = "lblManageTitle";
            this.lblManageTitle.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.lblManageTitle.Size = new System.Drawing.Size(979, 46);
            this.lblManageTitle.TabIndex = 0;
            this.lblManageTitle.Text = "관리메뉴";
            this.lblManageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 6);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(this.lblTypeItem, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblTypeDate, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 46);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(979, 62);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // lblTypeItem
            // 
            this.lblTypeItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTypeItem.AutoSize = true;
            this.lblTypeItem.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTypeItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.lblTypeItem.Location = new System.Drawing.Point(765, 18);
            this.lblTypeItem.Margin = new System.Windows.Forms.Padding(0, 18, 0, 18);
            this.lblTypeItem.Name = "lblTypeItem";
            this.lblTypeItem.Size = new System.Drawing.Size(101, 26);
            this.lblTypeItem.TabIndex = 3;
            this.lblTypeItem.Text = "매출 상세";
            this.lblTypeItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTypeDate
            // 
            this.lblTypeDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTypeDate.AutoSize = true;
            this.lblTypeDate.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTypeDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.lblTypeDate.Location = new System.Drawing.Point(112, 18);
            this.lblTypeDate.Margin = new System.Windows.Forms.Padding(0, 18, 0, 18);
            this.lblTypeDate.Name = "lblTypeDate";
            this.lblTypeDate.Size = new System.Drawing.Size(101, 26);
            this.lblTypeDate.TabIndex = 2;
            this.lblTypeDate.Text = "매출 일자";
            this.lblTypeDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbBoxDate
            // 
            this.cbBoxDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBoxDate.FormattingEnabled = true;
            this.cbBoxDate.Location = new System.Drawing.Point(37, 130);
            this.cbBoxDate.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.cbBoxDate.Name = "cbBoxDate";
            this.cbBoxDate.Size = new System.Drawing.Size(121, 20);
            this.cbBoxDate.TabIndex = 8;
            // 
            // tbDetail
            // 
            this.tbDetail.BackColor = System.Drawing.Color.White;
            this.tbDetail.ColumnCount = 4;
            this.tableLayoutPanel1.SetColumnSpan(this.tbDetail, 2);
            this.tbDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.63158F));
            this.tbDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.63158F));
            this.tbDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.73684F));
            this.tbDetail.Controls.Add(this.lblUnderBar, 0, 1);
            this.tbDetail.Controls.Add(this.label2, 0, 0);
            this.tbDetail.Controls.Add(this.label4, 0, 3);
            this.tbDetail.Controls.Add(this.flowOrdDataList, 0, 2);
            this.tbDetail.Controls.Add(this.label6, 0, 5);
            this.tbDetail.Controls.Add(this.label7, 0, 4);
            this.tbDetail.Controls.Add(this.label5, 0, 6);
            this.tbDetail.Controls.Add(this.lblOrdId, 1, 0);
            this.tbDetail.Controls.Add(this.lblDateTime, 1, 4);
            this.tbDetail.Controls.Add(this.lblPayType, 1, 5);
            this.tbDetail.Controls.Add(this.lblTotalCount, 1, 6);
            this.tbDetail.Controls.Add(this.lblTotalPrice, 3, 6);
            this.tbDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDetail.Location = new System.Drawing.Point(664, 128);
            this.tbDetail.Margin = new System.Windows.Forms.Padding(12, 20, 36, 20);
            this.tbDetail.Name = "tbDetail";
            this.tbDetail.RowCount = 8;
            this.tableLayoutPanel1.SetRowSpan(this.tbDetail, 2);
            this.tbDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tbDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.tbDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.tbDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tbDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tbDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tbDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tbDetail.Size = new System.Drawing.Size(279, 508);
            this.tbDetail.TabIndex = 10;
            // 
            // lblDateTitle
            // 
            this.lblDateTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateTitle.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblDateTitle, 2);
            this.lblDateTitle.Font = new System.Drawing.Font("나눔스퀘어 네오 Heavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDateTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.lblDateTitle.Location = new System.Drawing.Point(624, 132);
            this.lblDateTitle.Margin = new System.Windows.Forms.Padding(0, 0, 28, 0);
            this.lblDateTitle.Name = "lblDateTitle";
            this.lblDateTitle.Size = new System.Drawing.Size(0, 18);
            this.lblDateTitle.TabIndex = 11;
            this.lblDateTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUnderBar
            // 
            this.lblUnderBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnderBar.AutoSize = true;
            this.lblUnderBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.tbDetail.SetColumnSpan(this.lblUnderBar, 4);
            this.lblUnderBar.Location = new System.Drawing.Point(12, 49);
            this.lblUnderBar.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.lblUnderBar.MaximumSize = new System.Drawing.Size(0, 1);
            this.lblUnderBar.Name = "lblUnderBar";
            this.lblUnderBar.Size = new System.Drawing.Size(255, 1);
            this.lblUnderBar.TabIndex = 0;
            this.lblUnderBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(12, 0, 0, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "결제 내역";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOrdId
            // 
            this.lblOrdId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrdId.AutoSize = true;
            this.tbDetail.SetColumnSpan(this.lblOrdId, 3);
            this.lblOrdId.Font = new System.Drawing.Font("나눔스퀘어 네오 ExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblOrdId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.lblOrdId.Location = new System.Drawing.Point(237, 27);
            this.lblOrdId.Margin = new System.Windows.Forms.Padding(0, 0, 14, 8);
            this.lblOrdId.Name = "lblOrdId";
            this.lblOrdId.Size = new System.Drawing.Size(28, 13);
            this.lblOrdId.TabIndex = 2;
            this.lblOrdId.Text = "No.";
            this.lblOrdId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.tbDetail.SetColumnSpan(this.label4, 4);
            this.label4.Location = new System.Drawing.Point(12, 393);
            this.label4.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label4.MaximumSize = new System.Drawing.Size(0, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 1);
            this.label4.TabIndex = 3;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowOrdDataList
            // 
            this.flowOrdDataList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowOrdDataList.AutoSize = true;
            this.tbDetail.SetColumnSpan(this.flowOrdDataList, 4);
            this.flowOrdDataList.Location = new System.Drawing.Point(12, 60);
            this.flowOrdDataList.Margin = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.flowOrdDataList.Name = "flowOrdDataList";
            this.flowOrdDataList.Size = new System.Drawing.Size(255, 324);
            this.flowOrdDataList.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.label5.Location = new System.Drawing.Point(12, 458);
            this.label5.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "합계";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.label6.Location = new System.Drawing.Point(12, 430);
            this.label6.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "결제수단";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.label7.Location = new System.Drawing.Point(12, 402);
            this.label7.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "결제일시";
            // 
            // lblDateTime
            // 
            this.lblDateTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDateTime.AutoSize = true;
            this.tbDetail.SetColumnSpan(this.lblDateTime, 3);
            this.lblDateTime.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.lblDateTime.Location = new System.Drawing.Point(267, 403);
            this.lblDateTime.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(0, 13);
            this.lblDateTime.TabIndex = 8;
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPayType
            // 
            this.lblPayType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPayType.AutoSize = true;
            this.tbDetail.SetColumnSpan(this.lblPayType, 3);
            this.lblPayType.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPayType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.lblPayType.Location = new System.Drawing.Point(267, 431);
            this.lblPayType.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.lblPayType.Name = "lblPayType";
            this.lblPayType.Size = new System.Drawing.Size(0, 13);
            this.lblPayType.TabIndex = 9;
            this.lblPayType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotalCount.AutoSize = true;
            this.tbDetail.SetColumnSpan(this.lblTotalCount, 2);
            this.lblTotalCount.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTotalCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.lblTotalCount.Location = new System.Drawing.Point(139, 459);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(0, 13);
            this.lblTotalCount.TabIndex = 10;
            this.lblTotalCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.lblTotalPrice.Location = new System.Drawing.Point(267, 459);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(0, 13);
            this.lblTotalPrice.TabIndex = 11;
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // npgsqlDataAdapter1
            // 
            this.npgsqlDataAdapter1.DeleteCommand = null;
            this.npgsqlDataAdapter1.InsertCommand = null;
            this.npgsqlDataAdapter1.SelectCommand = null;
            this.npgsqlDataAdapter1.UpdateCommand = null;
            // 
            // dataGridOrder
            // 
            this.dataGridOrder.AllowUserToAddRows = false;
            this.dataGridOrder.AllowUserToDeleteRows = false;
            this.dataGridOrder.AllowUserToResizeRows = false;
            this.dataGridOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridOrder.BackgroundColor = System.Drawing.Color.White;
            this.dataGridOrder.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("나눔스퀘어 네오 Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderId,
            this.orderDate,
            this.orderPrice,
            this.orderPayType});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridOrder, 4);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("나눔스퀘어 네오 Regular", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridOrder.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridOrder.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridOrder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.dataGridOrder.Location = new System.Drawing.Point(36, 160);
            this.dataGridOrder.Margin = new System.Windows.Forms.Padding(36, 10, 28, 0);
            this.dataGridOrder.Name = "dataGridOrder";
            this.dataGridOrder.ReadOnly = true;
            this.dataGridOrder.RowHeadersVisible = false;
            this.dataGridOrder.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridOrder.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridOrder.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("나눔스퀘어 네오 Regular", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dataGridOrder.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.dataGridOrder.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dataGridOrder.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridOrder.RowTemplate.Height = 23;
            this.dataGridOrder.RowTemplate.ReadOnly = true;
            this.dataGridOrder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridOrder.ShowCellErrors = false;
            this.dataGridOrder.ShowCellToolTips = false;
            this.dataGridOrder.ShowRowErrors = false;
            this.dataGridOrder.Size = new System.Drawing.Size(588, 496);
            this.dataGridOrder.TabIndex = 12;
            // 
            // orderId
            // 
            this.orderId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.orderId.DataPropertyName = "OrderId";
            this.orderId.HeaderText = "매출 번호";
            this.orderId.Name = "orderId";
            this.orderId.ReadOnly = true;
            this.orderId.Width = 79;
            // 
            // orderDate
            // 
            this.orderDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.orderDate.DataPropertyName = "OrderDate";
            this.orderDate.HeaderText = "매출 일시";
            this.orderDate.Name = "orderDate";
            this.orderDate.ReadOnly = true;
            this.orderDate.Width = 79;
            // 
            // orderPrice
            // 
            this.orderPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.orderPrice.DataPropertyName = "OrderPrice";
            this.orderPrice.HeaderText = "매출액";
            this.orderPrice.Name = "orderPrice";
            this.orderPrice.ReadOnly = true;
            this.orderPrice.Width = 65;
            // 
            // orderPayType
            // 
            this.orderPayType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.orderPayType.DataPropertyName = "PayType";
            this.orderPayType.HeaderText = "매출 구분";
            this.orderPayType.Name = "orderPayType";
            this.orderPayType.ReadOnly = true;
            this.orderPayType.Width = 79;
            // 
            // ManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(233)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(979, 656);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ManageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HELLBOY Manegement";
            this.Load += new System.EventHandler(this.ManageForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tbDetail.ResumeLayout(false);
            this.tbDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblManageTitle;
        private System.Windows.Forms.Label lblTypeDate;
        private System.Windows.Forms.Label lblTypeItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cbBoxDate;
        private System.Windows.Forms.TableLayoutPanel tbDetail;
        private System.Windows.Forms.Label lblDateTitle;
        private System.Windows.Forms.Label lblUnderBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOrdId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowOrdDataList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblPayType;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.DataGridView dataGridOrder;
        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderPayType;
    }
}