using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Diagnostics;

namespace CubeTimer
{
    /// <summary>
    /// 메인폼 클래스 입니다.
    /// </summary>
    public partial class MainForm : Form
    {
        #region Fields
        
        private Stopwatch stopwatch = new Stopwatch();

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

            #region 폰트를 적용합니다.

            PrivateFontCollection privateFont = new PrivateFontCollection();

            privateFont.AddFontFile("digital-7.ttf");

            Font font = new Font(privateFont.Families[0], 100f);

            this.timerLabel.Font = font;

            this.timerLabel.Left = (this.timerDisplayPanel.Width - this.timerLabel.Width  ) / 2;
            this.timerLabel.Top  = (this.timerDisplayPanel.Height - this.timerLabel.Height) / 2;

            #endregion
            
            this.cubeTimer.Tick += cubeTimer_Tick;
            this.KeyDown += mainForm_KeyDown;
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
            Console.WriteLine("test");
            
            if(e.KeyCode == Keys.Space || e.KeyCode == Keys.Enter)
            {
                stopwatch.Start();
                this.cubeTimer.Start();
                Console.WriteLine(e.KeyCode.ToString());

            }
            else
            { 
                stopwatch.Stop();
                this.cubeTimer.Stop();
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
            this.timerLabel.Text = string.Format("{0:00} : {1:00} : {2:00}", stopwatch.Elapsed.Minutes, stopwatch.Elapsed.Seconds, stopwatch.Elapsed.Milliseconds / 10);
        }

        #endregion

    }
}
