using DevExpress.Mvvm;
using System.Collections.ObjectModel;

namespace FilterDuplicateRecords_Unbound
{
    public class MainViewModel : ViewModelBase
    {
        public ObservableCollection<Item> Source { get; } = new ObservableCollection<Item>(Item.GetData(1000));
    }
}
