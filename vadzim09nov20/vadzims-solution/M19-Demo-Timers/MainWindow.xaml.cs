using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace M19_Demo_Timers
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private System.Timers.Timer timer = new System.Timers.Timer();
        public MainWindow()
        {
            InitializeComponent();
            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}");
            timer.Elapsed += new ElapsedEventHandler(Countdown);
            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}");
            timer.Interval = 1000;
            timer.Start();
        }

        private void startBtn_Click(object sender, RoutedEventArgs e)
        {
            timer.Elapsed += new ElapsedEventHandler(Countdown);
            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}");
            timer.Interval = 1000;
            timer.Start();
        }
        //Invoke(() =>
        //{
        //    int seconds = int.Parse(secondsTxtBx.Text);
        //    return true;
        //});
        void Countdown(object sender, ElapsedEventArgs args)
        {
            // Timers laufen in einem anderen Thread, 
            // welches auf die Steuerelemente von der Oberfläche nicht zugreifen kann
            //invoke(new Action(
            //    () =>
            //    {
            //        int seconds = int.Parse(secondsTxtBx.Text);
            //    }));
            int seconds = int.Parse(secondsTxtBx.Text);
            seconds--;
            ausgabeTxtBlck.Text = seconds.ToString();
            if (seconds <= 0)
            {
                timer.Stop();
            }
        }

    }
}
