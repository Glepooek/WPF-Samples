using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CustomWindowUI
{
    internal class WindowViewModel : INotifyPropertyChanged
    {
        private Visibility showMinBtn = Visibility.Visible;
        public Visibility ShowMinBtn
        {
            get { return showMinBtn; }
            set
            {
                showMinBtn = value;
                RaisePropertyChanged("ShowMinBtn");
            }
        }

        private Visibility showMaxBtn = Visibility.Visible;
        public Visibility ShowMaxBtn
        {
            get { return showMaxBtn; }
            set
            {
                showMaxBtn = value;
                RaisePropertyChanged("ShowMaxBtn");
            }
        }

        private int caption = 40;
        /// <summary>
        /// 可操作栏高度,0或40,0时禁用标题栏和windows交互
        /// </summary>
        public int Caption
        {
            get { return caption; }
            set
            {
                caption = value;
                RaisePropertyChanged("Caption");
            }
        }

        private int toolsHeight = 40;
        /// <summary>
        /// 标题(工具)栏高度
        /// </summary>
        public int ToolsHeight
        {
            get { return toolsHeight; }
            set
            {
                toolsHeight = value;
                RaisePropertyChanged("ToolsHeight");
            }
        }



        public WindowViewModel()
        {
            MinCommand = new RelayCommand<Window>(WinMin);
            MaxCommand = new RelayCommand<Window>(WinMax);
            CloseCommand = new RelayCommand<Window>(WinClose);
            BackCommand = new RelayCommand<Window>(WinBack);
        }

        protected virtual void WinBack(Window win)
        {
            win.Close();
        }

        protected virtual void WinClose(Window win)
        {
            //var win = (Window)Window.GetWindow(this);
            win.Close();
        }

        private void WinMax(Window win)
        {
            SetWindowState(win);
        }

        private void WinMin(Window win)
        {
            win.WindowState = WindowState.Minimized;
        }

        private void SetWindowState(Window win)
        {
            if (win.WindowState == WindowState.Maximized)
            {
                win.WindowState = WindowState.Normal;
                return;
            }

            win.WindowState = WindowState.Maximized;
        }

        public RelayCommand<Window> MinCommand { get; }

        public RelayCommand<Window> MaxCommand { get; }

        public RelayCommand<Window> CloseCommand { get; }

        public RelayCommand<Window> BackCommand { get; }

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
