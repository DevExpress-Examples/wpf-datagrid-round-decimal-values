<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1128966)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# WPF Data Grid - How To Round Decimal Values In Grid Columns

This example demonstrates how to solve problems with sorting or filtering when decimal values are rounded. You can specify only the [`DisplayFormat`](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.Settings.BaseEditSettings.DisplayFormat) for a column with decimal values. In this case, `GridControl` keeps using underlying unrounded values for filtering.

For example, when the 1.2 and 1.1 values are rounded down to 1, they are displayed in the filter popup as separate but indistinguishable options. Use one of the following solutions to eliminate data duplication:

* _Converter._ This example uses the `Binding` property of a column with a converter to round bound values.
* _Unbound_. This example uses non-editable unbound columns.
* _UnboundEditable_. This example uses editable unbound columns.

![Alt text](images/filtering.png)

## Implementation details

The _Converter_ solution implements the [IValueConverter.Convert](https://learn.microsoft.com/en-us/dotnet/api/system.windows.data.ivalueconverter.convert) method to round values in columns bound to the converter.

```xml
<dxg:GridColumn Header="Growth"
                Binding="{Binding Growth,
                Converter={StaticResource RoundConverter}, Mode=TwoWay}"/>
```

The _Unbound_ solution implements [unbound expressions](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.ColumnBase.UnboundExpression) to round values in columns. This option causes columns to become read-only.

```xml
<dxg:GridColumn Header="Growth" 
                FieldName="GrowthUnbound" 
                UnboundType="Decimal" 
                UnboundExpression="Round([Growth], 2)" 
                ReadOnly="True"/>
```

The _UnboundEditable_ solution implements [`CustomUnboundColumnData`](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl.CustomUnboundColumnData)(code behind) or [`CustomUnboundColumnDataCommand`](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl.CustomUnboundColumnDataCommand)(MVVM) to round values in columns.

```xml
<Grid>
    <dxg:GridControl ItemsSource="{Binding Source}" 
                     CustomUnboundColumnDataCommand="{Binding UnboundColumnDataCommand}">
        <dxg:GridControl.Columns>
            <dxg:GridColumn FieldName="Name"/>
            <dxg:GridColumn Header="Growth"
                            FieldName="GrowthUnbound"
                            UnboundType="Decimal"/>
        </dxg:GridControl.Columns>
    </dxg:GridControl>
</Grid>
```

## Documentation

- [GridControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl)
- [Unbound Columns](https://docs.devexpress.com/WPF/6124/controls-and-libraries/data-grid/grid-view-data-layout/columns-and-card-fields/unbound-columns)


## Files to Review
- [MainWindow.xaml](./CS/FilterDuplicateRecords_Converter/MainWindow.xaml)
  
  [RoundConverter.cs](./CS/FilterDuplicateRecords_Converter/RoundConverter.cs)

- [MainWindow.xaml](./CS/FilterDuplicateRecords_Unbound/MainWindow.xaml)
  
  [MainViewModel.cs](./CS/FilterDuplicateRecords_Unbound/MainWindow.xaml.cs)

- [MainWindow.xaml](./CS/FilterDuplicateRecords_UnboundEditable/MainWindow.xaml)
  
  [MainViewModel.cs](./CS/FilterDuplicateRecords_UnboundEditable/MainViewModel.cs)
