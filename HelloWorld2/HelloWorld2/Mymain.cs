using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace HelloWorld2
{
    class Mymain : Application
    {
        [STAThread]
        public static void Main()
        {
            Mymain app = new Mymain();
            app.ShutdownMode = ShutdownMode.OnMainWindowClose;
            app.Run();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Window mainWindow = new Window();
            mainWindow.Title = "WPF Sample(Main)";
            mainWindow.MouseDown += WinMouseDown;
            mainWindow.Show();
            for (int i = 0; i < 2; i++)
            {
                Window win = new Window();
                win.Title = "Extra Window No." + (i + 1);
                win.ShowInTaskbar = false;
                ///this.MainWindow = win;
                win.Owner = mainWindow;
                win.Show();
            }
        }
        void WinMouseDown(Object sender, MouseEventArgs args)
        {
            Window win = new Window();
            win.Title = "Modal DialogBox";
            win.Width = 400;
            win.Height = 200;
            Button b = new Button();
            b.Content = "Click Me!";
            b.Click += Button_Click;
            win.Content = b;
            win.ShowDialog(); //Modal 형태            
        }
        private void Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button Click!", sender.ToString());
        }
    }
}
