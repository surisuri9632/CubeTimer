namespace CubeTimer
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.rootTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.recordDisplayPanel = new System.Windows.Forms.Panel();
            this.deleteAllButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.recordListBox = new System.Windows.Forms.ListBox();
            this.timerDisplayPanel = new System.Windows.Forms.Panel();
            this.timerLabel = new System.Windows.Forms.Label();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cubeTimer = new System.Windows.Forms.Timer(this.components);
            this.rootTableLayoutPanel.SuspendLayout();
            this.recordDisplayPanel.SuspendLayout();
            this.timerDisplayPanel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rootTableLayoutPanel
            // 
            this.rootTableLayoutPanel.ColumnCount = 1;
            this.rootTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rootTableLayoutPanel.Controls.Add(this.recordDisplayPanel, 0, 3);
            this.rootTableLayoutPanel.Controls.Add(this.timerDisplayPanel, 0, 1);
            this.rootTableLayoutPanel.Controls.Add(this.menuPanel, 0, 0);
            this.rootTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootTableLayoutPanel.Location = new System.Drawing.Point(5, 5);
            this.rootTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.rootTableLayoutPanel.Name = "rootTableLayoutPanel";
            this.rootTableLayoutPanel.RowCount = 4;
            this.rootTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rootTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 96.15385F));
            this.rootTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.846154F));
            this.rootTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rootTableLayoutPanel.Size = new System.Drawing.Size(774, 551);
            this.rootTableLayoutPanel.TabIndex = 0;
            // 
            // recordDisplayPanel
            // 
            this.recordDisplayPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recordDisplayPanel.Controls.Add(this.deleteAllButton);
            this.recordDisplayPanel.Controls.Add(this.deleteButton);
            this.recordDisplayPanel.Controls.Add(this.recordListBox);
            this.recordDisplayPanel.Location = new System.Drawing.Point(5, 315);
            this.recordDisplayPanel.Margin = new System.Windows.Forms.Padding(5);
            this.recordDisplayPanel.Name = "recordDisplayPanel";
            this.recordDisplayPanel.Size = new System.Drawing.Size(764, 231);
            this.recordDisplayPanel.TabIndex = 2;
            // 
            // deleteAllButton
            // 
            this.deleteAllButton.Location = new System.Drawing.Point(312, 53);
            this.deleteAllButton.Margin = new System.Windows.Forms.Padding(0);
            this.deleteAllButton.Name = "deleteAllButton";
            this.deleteAllButton.Size = new System.Drawing.Size(100, 30);
            this.deleteAllButton.TabIndex = 2;
            this.deleteAllButton.Text = "전체 삭제";
            this.deleteAllButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(312, 3);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(0);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 30);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "삭제";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // recordListBox
            // 
            this.recordListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.recordListBox.FormattingEnabled = true;
            this.recordListBox.ItemHeight = 16;
            this.recordListBox.Location = new System.Drawing.Point(4, 4);
            this.recordListBox.Margin = new System.Windows.Forms.Padding(5);
            this.recordListBox.Name = "recordListBox";
            this.recordListBox.Size = new System.Drawing.Size(300, 212);
            this.recordListBox.TabIndex = 0;
            // 
            // timerDisplayPanel
            // 
            this.timerDisplayPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timerDisplayPanel.Controls.Add(this.timerLabel);
            this.timerDisplayPanel.Location = new System.Drawing.Point(5, 45);
            this.timerDisplayPanel.Margin = new System.Windows.Forms.Padding(5);
            this.timerDisplayPanel.Name = "timerDisplayPanel";
            this.timerDisplayPanel.Size = new System.Drawing.Size(764, 250);
            this.timerDisplayPanel.TabIndex = 1;
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("나눔고딕코딩", 80F);
            this.timerLabel.Location = new System.Drawing.Point(45, 64);
            this.timerLabel.Margin = new System.Windows.Forms.Padding(0);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(681, 107);
            this.timerLabel.TabIndex = 0;
            this.timerLabel.Text = "00:00:00:000";
            this.timerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuPanel
            // 
            this.menuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuPanel.Controls.Add(this.menuStrip1);
            this.menuPanel.Location = new System.Drawing.Point(5, 5);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(5);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(764, 30);
            this.menuPanel.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(764, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.rootTableLayoutPanel);
            this.Font = new System.Drawing.Font("나눔고딕코딩", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "큐브 타이머";
            this.rootTableLayoutPanel.ResumeLayout(false);
            this.recordDisplayPanel.ResumeLayout(false);
            this.timerDisplayPanel.ResumeLayout(false);
            this.timerDisplayPanel.PerformLayout();
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel rootTableLayoutPanel;
        private System.Windows.Forms.Panel recordDisplayPanel;
        private System.Windows.Forms.Panel timerDisplayPanel;
        private System.Windows.Forms.Button deleteAllButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ListBox recordListBox;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.Timer cubeTimer;
        private System.Windows.Forms.Label timerLabel;
    }
}

