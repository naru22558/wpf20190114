using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Threading;
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
using System.ComponentModel;

namespace BackgroundWorkerTest
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        private BackgroundWorker myThread;

        int sum = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);

            myThread = new BackgroundWorker()
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };

            myThread.DoWork += myThread_DoWork;

            myThread.WorkerReportsProgress += myThread_ProgressChanged;

            myThread.RunWorkerCompleted += myThread_RunWorkerCompleted;

            MessageBox.Show("Worker 초기화");
        }

        private void myThread_DoWork(object sender, DoWorkEventArgs e)
        {
            int count = (int)e.Argument;

            for (int i = 1; i <= count; i++)
            {
                if (myThread.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                else
                {
                    Thread.Sleep(100);
                    this.Dispatcher.BeginInvoke(DispatcherPriority.Normal, (ThreadStart)delegate ()
                    {
                        if

                    }






                }
                  
            }

        }

    }

}
