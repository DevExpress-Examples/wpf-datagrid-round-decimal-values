<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1128966)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# WPF Data Grid - How To Round Decimal Values In Grid Columns

It is possible to specify `DisplayFormat` for a column with decimal values. In this case, `GridControl` keeps using underlying unrounded values for filtering. For example, when both 1.2 and 1.1 are rounded down to 1, they are displayed in the filter popup as separate but indistinguishable options.

We offer three solutions to enable filtering by displayed values:
1. Using the `Binding` property of a column with a converter to round bound values.
2. Using [unbound expressions](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.ColumnBase.UnboundExpression) to round values. This option causes columns to become read-only.
3. Implementing unbound columns through [`CustomUnboundColumnData`](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl.CustomUnboundColumnData)(code behind) or [`CustomUnboundColumnDataCommand`](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl.CustomUnboundColumnDataCommand)(MVVM) to allow editing unbound columns.


## Documentation

- [GridControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl)
- [Unbound Columns](https://docs.devexpress.com/WPF/6124/controls-and-libraries/data-grid/grid-view-data-layout/columns-and-card-fields/unbound-columns)


## Files to Review
- [MainWindow.xaml](./CS/FilterDuplicateRecords_Converter/MainWindow.xaml)[RoundConverter.cs](./CS/FilterDuplicateRecords_Converter/RoundConverter.cs)
- [MainWindow.xaml](./CS/FilterDuplicateRecords_Unbound/MainWindow.xaml)
- [MainWindow.xaml](./CS/FilterDuplicateRecords_UnboundEditable/MainWindow.xaml) [MainViewModel.cs](./CS/FilterDuplicateRecords_UnboundEditable/MainViewModel.cs)
