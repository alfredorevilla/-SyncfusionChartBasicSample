using System;
using System.Windows;
using System.Windows.Threading;
using Syncfusion.UI.Xaml.Charts;
using SyncfusionChartBasicSample.Models;

namespace SyncfusionChartBasicSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            viewModel = new MainWindowViewModel();

            var timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(10);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            viewModel.Data.Add(new ChartItem { X = random.Next(0, 11), Y = random.Next(0, 101) });
        }

        private readonly Random random = new Random();
        private readonly MainWindowViewModel viewModel;

        protected override void OnActivated(EventArgs e)
        {
            Chart.Series.Add(new LineSeries { Name = "Default", ItemsSource = viewModel.Data, XBindingPath = "X", YBindingPath = "Y" });

            base.OnActivated(e);
        }
    }
}