using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;

namespace CatTimer_WpfProject
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {

        System.Windows.Forms.NotifyIcon ni = new System.Windows.Forms.NotifyIcon();
        public MainWindow()
        {
            InitializeComponent();

            ni.Icon = CatTimer_WpfProject.Properties.Resources.Icon;
            ni.Visible = false;
            ni.DoubleClick +=
                delegate (object sender, EventArgs args)
                {
                    show();
                };

            System.Windows.Forms.ContextMenu contextMenu = new System.Windows.Forms.ContextMenu();
            System.Windows.Forms.MenuItem menuItem1 = new System.Windows.Forms.MenuItem();
            System.Windows.Forms.MenuItem menuItem2 = new System.Windows.Forms.MenuItem();
            // Initialize contextMenu1
            contextMenu.MenuItems.Add(menuItem1);
            contextMenu.MenuItems.Add(menuItem2);
            

            // Initialize menuItem1
            menuItem1.Index = 0;
            menuItem1.Text = "S&how";
            menuItem1.Click += new System.EventHandler(this.menuItem1_Click);


            // Initialize menuItem2
            menuItem2.Index = 1;
            menuItem2.Text = "E&xit";
            menuItem2.Click += new System.EventHandler(this.menuItem2_Click);


            ni.ContextMenu = contextMenu;

        }

        // Minimize to system tray when application is closed.
        protected override void OnClosing(CancelEventArgs e)
        {
            // setting cancel to true will cancel the close request
            // so the application is not closed
            e.Cancel = true;

            this.Hide();
            ni.Visible = true;

            base.OnClosing(e);
        }

        //当窗口初始化时，触发此方法
        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            //赋值
            AppManager.MainWindow = this;

            //初始化
            AppManager.Start();
        }

        private void menuItem1_Click(object Sender, EventArgs e)
        {
            show();
        }

        public void show()
        {
            ni.Visible = false;
            this.Show();
            this.WindowState = WindowState.Normal;
            this.Activate();
        }
        private void menuItem2_Click(object Sender, EventArgs e)
        {
            // Close the form, which closes the application.
            Environment.Exit(0);
        }

        private void ThumbButtonInfo_Click(object sender, EventArgs e)
        {
            /* 通知窗口 相关 */
            AppManager.AppSystems.NotificationSystem.CloseAllNotification();//关闭所有的通知窗口

            /* 如果当前的按钮是[暂停按钮] */
            if (YellowCatUserControl.IsPauseButton == true)
            {
                // 就打开暂停界面，并且让倒计时暂停
                AppManager.AppSystems.TimeSystem.PauseHandle();
                AppManager.MainWindow.PausedUiUserControl.OpenOrClose(true);

                // 然后把猫咪的按钮，变成[恢复按钮]
                YellowCatUserControl.IsPauseButton = false;

                // 进度条变红
                AppManager.AppSystems.TaskbarSystem.SetProgressState(TaskbarItemProgressState.Error);
            }

            /* 如果当前的按钮是[恢复按钮] */
            else
            {
                // 就关闭暂停界面，并且让倒计时继续
                AppManager.AppSystems.TimeSystem.UnPauseHandle();
                AppManager.MainWindow.PausedUiUserControl.OpenOrClose(false);

                // 然后把猫咪的按钮，变成[暂停按钮]
                YellowCatUserControl.IsPauseButton = true;

                // 进度条变黄
                AppManager.AppSystems.TaskbarSystem.SetProgressState(TaskbarItemProgressState.Paused);
            }

            //播放音效
            AppManager.AppSystems.AudioSystem.PlayAudio(AudioType.DefaultButtonUp);
        }
        
        #region 拖动窗口

        /// <summary>
        /// 当在窗口顶部的矩形中，按下鼠标左键的时候：拖动窗口的时候
        /// </summary>
        private void WindowTitleBorder_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();//拖动窗口
        }




        /// <summary>
        /// 当点击[关闭窗口]的按钮时
        /// </summary>
        private void CloseWindowButton_Click(object sender, RoutedPropertyChangedEventArgs<bool> e)
        {
            this.Close();//关闭此窗口
        }

        /// <summary>
        /// 当点击[最小化窗口]的按钮时
        /// </summary>
        private void MinimumWindowButtonControl_OnClick(object sender, RoutedPropertyChangedEventArgs<bool> e)
        {
            this.WindowState = WindowState.Minimized; //最小化此窗口
        }
        #endregion

        #region 注册事件 -[其他]
        //当点击了[键盘上的按键]时
        private void MainWindow_OnPreviewKeyDown(object sender, KeyEventArgs e)
        {
            //如果点击的是[回车]键，并且[计时（设定时间）]的界面是开启的
            if (e.KeyStates == Keyboard.GetKeyStates(Key.Return) && AppManager.MainWindow.TimingUserControl.Visibility == Visibility.Visible)
            {

                //播放音效
                AppManager.AppSystems.AudioSystem.PlayAudio(AudioType.DefaultButtonUp);

                //开始计时
                AppManager.MainWindow.TimingUserControl.StartTimer();
            }
        }
        #endregion
    }
}
