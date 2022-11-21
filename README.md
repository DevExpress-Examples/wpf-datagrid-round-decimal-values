# How To Round Decimal Values In Grid Columns

A customer can specify `DisplayFormat` for a column with decimal values, leaving the source intact. These underlying unrounded values can be used by certain `GridControl` functionality. For example, 1.2 and 1.1 could be rounded down to 1, which leads to filter popup displaying separate but indistinguishable options.

We offer three solutions:
1. Using the `Binding` property of a column with a converter to round bound values.
2. Using [unbound expressions](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.ColumnBase.UnboundExpression) to round values. This option causes columns to become read-only.
3. Implementing unbound columns through [`CustomUnboundColumnData`](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl.CustomUnboundColumnData)(code behind) or [`CustomUnboundColumnDataCommand`](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl.CustomUnboundColumnDataCommand)(MVVM).


## Documentation

- https://docs.devexpress.com/WindowsForms/1477/controls-and-libraries/data-grid/unbound-columns