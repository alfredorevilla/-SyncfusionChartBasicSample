using System.Collections.ObjectModel;

namespace SyncfusionChartBasicSample.Models
{
    public class MainWindowViewModel
    {
        public ObservableCollection<ChartItem> Data { get; set; } = new ObservableCollection<ChartItem>();
    }
}