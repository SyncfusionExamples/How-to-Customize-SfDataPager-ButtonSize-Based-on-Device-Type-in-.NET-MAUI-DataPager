# How to Customize SfDataPager ButtonSize Based on Device Type in .NET MAUI DataPager?
This article explains how to customize the SfDataPager ButtonSize based on the device type in [.NET MAUI DataPager](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataPager.SfDataPager.html).

Using the OnIdiom markup extension, you can define different button sizes for desktop and phone devices to provide a responsive and user-friendly paging experience.

## Xaml
```
  <Grid>
     <Grid.RowDefinitions>
         <RowDefinition Height = "*" />
         <RowDefinition Height = "Auto" />
     </Grid.RowDefinitions>
     <Border Grid.Row = "1" Padding = "5">
         <pager:SfDataPager x:Name = "dataPager"
                            ButtonSize="{OnIdiom Desktop=35, Phone=25, Default=40}"
                            ButtonSpacing="10"
                            PageSize = "15" 
                            NumericButtonCount = "10"
                            Source = "{Binding OrderInfoCollection}">
         </pager:SfDataPager>
     </Border>
     <syncfusion:SfDataGrid x:Name = "dataGrid"
                            ColumnWidthMode="Fill"
                            Grid.Row = "0"
                            ItemsSource = "{Binding Source={x:Reference dataPager}, Path=PagedSource}">
     </syncfusion:SfDataGrid>
 </Grid>
```
### ScreenShot
<img src="" width=404/>

[View sample in GitHub](https://github.com/SyncfusionExamples/How-to-Customize-SfDataPager-ButtonSize-Based-on-Device-Type-in-.NET-MAUI-DataPager)

 Take a moment to explore this [documentation](https://help.syncfusion.com/maui/datagrid/overview), where you can find more information about Syncfusion .NET MAUI DataGrid (SfDataGrid) with code examples. Please refer to this [link](https://www.syncfusion.com/maui-controls/maui-datagrid) to learn about the essential features of Syncfusion .NET MAUI DataGrid (SfDataGrid).

### Conclusion
I hope you found this article helpful in learning how to customize the SfDataPager ButtonSize based on the device type in .NET MAUI DataPager.

You can refer to our [.NET MAUI DataGrid’s feature tour](https://www.syncfusion.com/maui-controls/maui-datagrid) page to learn about its other groundbreaking feature representations. You can also explore our [.NET MAUI DataGrid Documentation](https://help.syncfusion.com/maui/datagrid/getting-started) to understand how to present and manipulate data. For current customers, you can check out our .NET MAUI components on the [License and Downloads](https://www.syncfusion.com/sales/teamlicense) page. If you are new to Syncfusion, you can try our 30-day [free trial](https://www.syncfusion.com/downloads/maui) to explore our .NET MAUI DataGrid and other .NET MAUI components.

If you have any queries or require clarifications, please let us know in the comments below. You can also contact us through our [support forums](https://www.syncfusion.com/forums),[Direct-Trac](https://support.syncfusion.com/create) or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sfdatagrid), or the feedback portal. We are always happy to assist you!
