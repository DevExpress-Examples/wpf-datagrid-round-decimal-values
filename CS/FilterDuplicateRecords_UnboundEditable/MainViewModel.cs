using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.Xpf;
using System;
using System.Collections.ObjectModel;

namespace FilterDuplicateRecords_UnboundEditable
{
    public class MainViewModel : ViewModelBase
    {
        public ObservableCollection<Item> Source { get; } = new ObservableCollection<Item>(Item.GetData(1000));

        [Command]
        public void UnboundColumnDataCommand(UnboundColumnRowArgs e) {
            if (e.FieldName == "GrowthUnbound") {
                if (e.IsGetData) {
                    e.Value = Math.Round(Source[e.SourceIndex].Growth, 2);
                    return;
                }

                if (e.IsSetData && e.Value is decimal number) {
                    Source[e.SourceIndex].Growth = number;
                }
            }
        }
    }
}
