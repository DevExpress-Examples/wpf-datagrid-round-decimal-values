using DevExpress.Mvvm;
using System.Collections.ObjectModel;

namespace FilterDuplicateRecords_Converter
{
    public class MainViewModel : ViewModelBase
    {
        public ObservableCollection<Item> Source { get; } = new(Item.GetData(1000));
    }
}
