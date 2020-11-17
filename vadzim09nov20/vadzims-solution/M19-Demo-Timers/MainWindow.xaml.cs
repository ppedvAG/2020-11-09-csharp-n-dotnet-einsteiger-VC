using System;
using System.Windows;
using System.Windows.Threading;

namespace M19_Demo_Timers
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer
        {
            Interval = TimeSpan.FromSeconds(1)
        };
        public MainWindow()
        {
            InitializeComponent();
        }
        int seconds;
        private void startBtn_Click(object sender, RoutedEventArgs e)
        {
            seconds = int.Parse(secondsTxtBx.Text);
            timer.Tick += Countdown;
            timer.Start();
        }
        void Countdown(object sender, EventArgs args)
        {
            seconds--;
            ausgabeTxtBlck.Text = seconds.ToString();
            if (seconds == 0)
            {
                timer.Stop();
                timer.Tick -= Countdown; // sonst wird bei jedem neuen Klick Countdown zweimal, dreimal usw ausgeführt

            }
        }

    }
}
