namespace PSDThumbnailsSetup
{
    partial class FormMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonPreviewWithOverlay = new System.Windows.Forms.Button();
            this.buttonPreviewNoOverlay = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonPhotoshopSaver = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabelHomepage = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "탐색기 PSD 미리보기 도구";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "다음 중 하나를 고르세요.";
            // 
            // buttonPreviewWithOverlay
            // 
            this.buttonPreviewWithOverlay.BackColor = System.Drawing.Color.White;
            this.buttonPreviewWithOverlay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonPreviewWithOverlay.Image = ((System.Drawing.Image)(resources.GetObject("buttonPreviewWithOverlay.Image")));
            this.buttonPreviewWithOverlay.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonPreviewWithOverlay.Location = new System.Drawing.Point(17, 77);
            this.buttonPreviewWithOverlay.Name = "buttonPreviewWithOverlay";
            this.buttonPreviewWithOverlay.Size = new System.Drawing.Size(180, 184);
            this.buttonPreviewWithOverlay.TabIndex = 0;
            this.buttonPreviewWithOverlay.Text = "미리보기 + 아이콘";
            this.buttonPreviewWithOverlay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPreviewWithOverlay.UseVisualStyleBackColor = false;
            this.buttonPreviewWithOverlay.Click += new System.EventHandler(this.buttonPreviewWithOverlay_Click);
            // 
            // buttonPreviewNoOverlay
            // 
            this.buttonPreviewNoOverlay.BackColor = System.Drawing.Color.White;
            this.buttonPreviewNoOverlay.Image = ((System.Drawing.Image)(resources.GetObject("buttonPreviewNoOverlay.Image")));
            this.buttonPreviewNoOverlay.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonPreviewNoOverlay.Location = new System.Drawing.Point(203, 77);
            this.buttonPreviewNoOverlay.Name = "buttonPreviewNoOverlay";
            this.buttonPreviewNoOverlay.Size = new System.Drawing.Size(180, 184);
            this.buttonPreviewNoOverlay.TabIndex = 1;
            this.buttonPreviewNoOverlay.Text = "미리보기만";
            this.buttonPreviewNoOverlay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPreviewNoOverlay.UseVisualStyleBackColor = false;
            this.buttonPreviewNoOverlay.Click += new System.EventHandler(this.buttonPreviewNoOverlay_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.White;
            this.buttonRemove.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemove.Image")));
            this.buttonRemove.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonRemove.Location = new System.Drawing.Point(389, 77);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(180, 184);
            this.buttonRemove.TabIndex = 2;
            this.buttonRemove.Text = "설정 해제";
            this.buttonRemove.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonPhotoshopSaver
            // 
            this.buttonPhotoshopSaver.BackColor = System.Drawing.Color.White;
            this.buttonPhotoshopSaver.Image = ((System.Drawing.Image)(resources.GetObject("buttonPhotoshopSaver.Image")));
            this.buttonPhotoshopSaver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPhotoshopSaver.Location = new System.Drawing.Point(92, 346);
            this.buttonPhotoshopSaver.Name = "buttonPhotoshopSaver";
            this.buttonPhotoshopSaver.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.buttonPhotoshopSaver.Size = new System.Drawing.Size(409, 57);
            this.buttonPhotoshopSaver.TabIndex = 3;
            this.buttonPhotoshopSaver.Text = "포토샵이 갑자기 멈춰서 작업을 날린 적이 있나요?\r\n무료 포토샵 자동 저장 도구, PhotoshopSaver를 사용해 보세요.";
            this.buttonPhotoshopSaver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPhotoshopSaver.UseVisualStyleBackColor = false;
            this.buttonPhotoshopSaver.Click += new System.EventHandler(this.buttonPhotoshopSaver_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(89, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(412, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "© 2018 Kyungjae Park\r\nSpecial Thanks to Jisung Han";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabelHomepage
            // 
            this.linkLabelHomepage.AutoSize = true;
            this.linkLabelHomepage.Location = new System.Drawing.Point(256, 321);
            this.linkLabelHomepage.Name = "linkLabelHomepage";
            this.linkLabelHomepage.Size = new System.Drawing.Size(66, 15);
            this.linkLabelHomepage.TabIndex = 5;
            this.linkLabelHomepage.TabStop = true;
            this.linkLabelHomepage.Text = "Homepage";
            this.linkLabelHomepage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelHomepage_LinkClicked);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(578, 415);
            this.Controls.Add(this.linkLabelHomepage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonPhotoshopSaver);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonPreviewNoOverlay);
            this.Controls.Add(this.buttonPreviewWithOverlay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "탐색기 PSD 미리보기 도구";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonPreviewWithOverlay;
        private System.Windows.Forms.Button buttonPreviewNoOverlay;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonPhotoshopSaver;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabelHomepage;
    }
}

