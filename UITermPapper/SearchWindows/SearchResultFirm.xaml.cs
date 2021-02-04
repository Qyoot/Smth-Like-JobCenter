using System.Collections.Generic;
using System.Windows;
using Models;

namespace UITermPapper.SearchWindows
{
    /// <summary>
    /// Interaction logic for SearchResultFirm.xaml
    /// </summary>
    public partial class SearchResultFirm : Window
    {
        public SearchResultFirm(List<FirmModel> person)
        {
            InitializeComponent();

            DataGrid_Firm_Search.ItemsSource = person;
            
        }
    }
}
