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

namespace CubeTimer
{
    /// <summary>
    /// 메인폼 클래스 입니다.
    /// </summary>
    public partial class MainForm : Form
    {
        //Constructor (Public)

        #region MainForm() - 생성자 입니다.
        
        /// <summary>
        /// 생성자 입니다.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            PrivateFontCollection privateFont = new PrivateFontCollection();

            privateFont.AddFontFile("digital-7.ttf");

            Font font = new Font(privateFont.Families[0], 50f);

            timerLabel.Font = font;
        }

        #endregion
    }
}
