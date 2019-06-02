using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        /// 상태 모드 입니다.
        /// </summary>
        private StatusMode statusMode = StatusMode.Idle;

        /// <summary>
        /// 소스 리스트 입니다.
        /// </summary>
        private List<TimeModel> sourceList;

        #endregion

        // Constructor (Public)

        #region MainForm() - 생성자 입니다.

        /// <summary>
        /// 생성자 입니다.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            this.KeyPreview = true;

            this.cubeTimer.Interval = 1;

            this.sourceList = new List<TimeModel>();

            this.timerLabel.Left = this.timerDisplayPanel.Width / 2 - this.timerLabel.Width / 2;
            this.timerLabel.Top  = this.timerDisplayPanel.Height / 2 - this.timerLabel.Height / 2;

            GetDataListBox();

            this.cubeTimer.Tick        += cubeTimer_Tick;
            this.KeyDown               += mainForm_KeyDown;
            this.deleteButton.Click    += deleteButton_Click;
            this.deleteAllButton.Click += deleteAllButton_Click;
        }

        #endregion

        // Event Method (Private)

        #region mainForm_KeyDown(sender, e) - 키 입력시 동작합니다.

        /// <summary>
        /// 키 입력시 동작합니다.
        /// </summary>
        /// <param name="sender">이벤트 발생자 입니다.</param>
        /// <param name="e">이벤트 인자 입니다.</param>
        private void mainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if((e.KeyCode == Keys.Space || e.KeyCode == Keys.Enter) && statusMode == StatusMode.Idle)
            {
                this.cubeTimer.Start();
                this.stopwatch.Start();

                SetStatusMode(StatusMode.Start);

            }
            else if((e.KeyCode == Keys.Space || e.KeyCode == Keys.Enter) && statusMode == StatusMode.Start)
            { 
                this.cubeTimer.Stop();
                this.stopwatch.Stop();

                try
                {
                    TimeModel inputItem = GetItemFromControl();

                    QueryHelper.InsertItem(inputItem);

                    this.sourceList.Add(inputItem);

                    SetListBoxControlData(this.sourceList);
                    
                }
                catch(Exception exception)
                {
                    MessageBox.Show(exception.ToString());
                }
                finally
                { 
                    SetStatusMode(StatusMode.Stop);
                }
            }
            else if((e.KeyCode == Keys.Space || e.KeyCode == Keys.Enter) && statusMode == StatusMode.Stop)
            { 
                this.stopwatch.Reset();

                ClearLabelText();

                SetStatusMode(StatusMode.Idle);
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
            ClearLabelText();
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
            TimeModel focusItem = this.recordListBox.SelectedItem as TimeModel;

            try
            {
                QueryHelper.DeleteItem(focusItem.Time);

                this.sourceList.Remove(focusItem);

                SetListBoxControlData(this.sourceList);
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
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
            try
            {
                QueryHelper.DeleteAllItem();

                this.sourceList.Clear();

                SetListBoxControlData(this.sourceList);

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        #endregion

        // Method (Private)

        #region SetStatusMode(statusMode) - 상태 모드를 설정합니다.

        /// <summary>
        /// 상태 모드를 설정합니다.
        /// </summary>
        /// <param name="statusMode">상태 모드 입니다.</param>
        private void SetStatusMode(StatusMode statusMode)
        { 
            this.statusMode = statusMode;

            switch(statusMode)
            {
                case StatusMode.Idle:

                    this.deleteButton.Enabled    = true;
                    this.deleteAllButton.Enabled = true;

                    break;

                case StatusMode.Start:

                    this.deleteButton.Enabled    = false;
                    this.deleteAllButton.Enabled = false;

                    break;
                case StatusMode.Stop:

                    this.deleteButton.Enabled    = true;
                    this.deleteAllButton.Enabled = true;

                    break;
            }
        }

        #endregion

        #region SetListBoxControlData(sourceList) - 리스트 박스 컨트롤 데이터를 설정합니다.

        /// <summary>
        /// 리스트 박스 컨트롤 데이터를 설정합니다.
        /// </summary>
        /// <param name="sourceList">소스 리스트</param>
        private void SetListBoxControlData(List<TimeModel> sourceList)
        {
            this.recordListBox.DataSource = null;

            this.sourceList = sourceList;

            this.recordListBox.DataSource = this.sourceList;

            this.recordListBox.DisplayMember = "Time";

            this.recordListBox.Refresh();
        }

        #endregion

        #region ClearLabelText() - 라벨 데이터를 지웁니다.

        /// <summary>
        /// 라벨 데이터를 지웁니다.
        /// </summary>
        private void ClearLabelText()
        { 
            this.timerLabel.Text = string.Format("{0:00}:{1:00}:{2:00}:{3:00}", stopwatch.Elapsed.Hours, stopwatch.Elapsed.Minutes, stopwatch.Elapsed.Seconds, stopwatch.Elapsed.Milliseconds);
        }

        #endregion
         
        #region GetItemFromControl() - 컨트롤에서 항목을 구합니다.

        /// <summary>
        /// 컨트롤에서 항목을 구합니다.
        /// </summary>
        /// <returns>시간 모델 입니다.</returns>
        private TimeModel GetItemFromControl()
        {
            TimeModel item = new TimeModel();

            item.Time = this.timerLabel.Text;

            return item;
        }

        #endregion
        
        #region GetDataListBox() - 리스트 박스에 데이터를 가져옵니다.

        /// <summary>
        /// 리스트 박스에 데이터를 가져옵니다.
        /// </summary>
        private void GetDataListBox()
        {
            try
            {
                string labelTime = this.timerLabel.Text;

                SetListBoxControlData(null);

                List<TimeModel> sourceList = QueryHelper.GetList();

                SetListBoxControlData(sourceList);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                SetStatusMode(StatusMode.Idle);
            }
        }

        #endregion
    }
}
