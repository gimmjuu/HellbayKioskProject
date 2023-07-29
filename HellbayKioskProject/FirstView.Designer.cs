namespace HellbayKioskProject {
    partial class FirstView {
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
            this.lblFirstLogo = new System.Windows.Forms.Label();
            this.tblFirstView = new System.Windows.Forms.TableLayoutPanel();
            this.btnStore = new HellbayKioskProject.RoundedButton();
            this.tblFirstView.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFirstLogo
            // 
            this.lblFirstLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFirstLogo.AutoSize = true;
            this.lblFirstLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstLogo.Font = new System.Drawing.Font("EastMarket", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFirstLogo.Location = new System.Drawing.Point(101, 90);
            this.lblFirstLogo.Name = "lblFirstLogo";
            this.lblFirstLogo.Size = new System.Drawing.Size(139, 38);
            this.lblFirstLogo.TabIndex = 1;
            this.lblFirstLogo.Text = "Hellbay";
            this.lblFirstLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFirstLogo.Click += new System.EventHandler(this.lblFirstLogo_Click);
            // 
            // tblFirstView
            // 
            this.tblFirstView.BackgroundImage = global::HellbayKioskProject.Properties.Resources.bg_vietnam;
            this.tblFirstView.ColumnCount = 3;
            this.tblFirstView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tblFirstView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblFirstView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tblFirstView.Controls.Add(this.lblFirstLogo, 0, 0);
            this.tblFirstView.Controls.Add(this.btnStore, 2, 2);
            this.tblFirstView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblFirstView.Location = new System.Drawing.Point(0, 0);
            this.tblFirstView.Name = "tblFirstView";
            this.tblFirstView.RowCount = 3;
            this.tblFirstView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblFirstView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblFirstView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblFirstView.Size = new System.Drawing.Size(979, 656);
            this.tblFirstView.TabIndex = 2;
            // 
            // btnStore
            // 
            this.btnStore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStore.BackColor = System.Drawing.Color.Transparent;
            this.btnStore.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnStore.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnStore.BorderRadius = 30;
            this.btnStore.BorderSize = 3;
            this.btnStore.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnStore.FlatAppearance.BorderSize = 0;
            this.btnStore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(244)))), ((int)(((byte)(191)))));
            this.btnStore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(244)))), ((int)(((byte)(191)))));
            this.btnStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStore.Font = new System.Drawing.Font("나눔스퀘어 네오 Heavy", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnStore.Location = new System.Drawing.Point(717, 516);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(180, 60);
            this.btnStore.TabIndex = 3;
            this.btnStore.Text = "주문 하러 가기";
            this.btnStore.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnStore.UseVisualStyleBackColor = false;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // FirstView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 656);
            this.Controls.Add(this.tblFirstView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FirstView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HELLBAY";
            this.tblFirstView.ResumeLayout(false);
            this.tblFirstView.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblFirstLogo;
        private System.Windows.Forms.TableLayoutPanel tblFirstView;
        private RoundedButton btnStore;
    }
}