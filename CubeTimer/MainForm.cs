using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace CubeTimer
{
    /// <summary>
    /// 메인폼 클래스 입니다.
    /// </summary>
    public partial class MainForm : Form
    {
        #region Fields
        
        /// <summary>
        /// 스톱워치 클래스 입니다.
        /// </summary>
        private Stopwatch stopwatch = new Stopwatch();

        /// <summary>
        /// 시작 여부 입니다.
        /// </summary>
        private bool isStart = false;

        #endregion

        //Constructor (Public)

        #region MainForm() - 생성자 입니다.

        /// <summary>
        /// 생성자 입니다.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            this.KeyPreview = true;

            this.cubeTimer.Interval = 1;

            this.timerLabel.Left = this.timerDisplayPanel.Width / 2 - this.timerLabel.Width / 2;
            this.timerLabel.Top  = this.timerDisplayPanel.Height / 2 - this.timerLabel.Height / 2;

            this.cubeTimer.Tick        += cubeTimer_Tick;
            this.KeyDown               += mainForm_KeyDown;
            this.deleteButton.Click    += deleteButton_Click;
            this.deleteAllButton.Click += deleteAllButton_Click;
        }

        #endregion

        #region mainForm_KeyDown(sender, e) - 키 입력시 동작합니다.

        /// <summary>
        /// 키 입력시 동작합니다.
        /// </summary>
        /// <param name="sender">이벤트 발생자 입니다.</param>
        /// <param name="e">이벤트 인자 입니다.</param>
        private void mainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if((e.KeyCode == Keys.Space || e.KeyCode == Keys.Enter) && isStart == false)
            {
                isStart = true;

                this.cubeTimer.Start();
                
                this.stopwatch.Start();
            }
            else if((e.KeyCode == Keys.Space || e.KeyCode == Keys.Enter) && isStart == true)
            { 
                isStart = false;

                this.cubeTimer.Stop();
                
                this.stopwatch.Stop();

                this.stopwatch.Reset();

                this.recordListBox.Items.Add(this.timerLabel.Text);
            }
        }

        #endregion

        #region cubeTimer_Tick(sender, e) - 지정된 타이머 간격이 경과되고 타이머를 사용할 수 있을 때 발생합니다.

        /// <summary>
        /// 지정된 타이머 간격이 경과되고 타이머를 사용할 수 있을 때 발생합니다.
        /// </summary>
        /// <param name="sender">이벤트 발생자 입니다.</param>
        /// <param name="e">이벤트 인자 입니다.</param>
        private void cubeTimer_Tick(object sender, EventArgs e)
        {
            this.timerLabel.Text = string.Format("{0:00}:{1:00}:{2:00}:{3:00}", stopwatch.Elapsed.Hours, stopwatch.Elapsed.Minutes, stopwatch.Elapsed.Seconds, stopwatch.Elapsed.Milliseconds);
        }

        #endregion

        #region deleteButton_Click(sender, e) - 삭제 버튼 클릭시 동작합니다.

        /// <summary>
        /// 삭제 버튼 클릭시 동작합니다.
        /// </summary>
        /// <param name="sender">이벤트 발생자 입니다.</param>
        /// <param name="e">이벤트 인자 입니다.</param>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            this.recordListBox.Items.Remove(this.recordListBox.SelectedItem);
        }

        #endregion
        #region deleteAllButton_Click(sender, e) - 삭제 버튼 클릭시 동작합니다.

        /// <summary>
        /// 전체 삭제 버튼 클릭시 동작합니다.
        /// </summary>
        /// <param name="sender">이벤트 발생자 입니다.</param>
        /// <param name="e">이벤트 인자 입니다.</param>
        private void deleteAllButton_Click(object sender, EventArgs e)
        {
            this.recordListBox.Items.Clear();
        }

        #endregion

    }
}
