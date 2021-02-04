using System.Collections.Generic;
using System.Windows;
using Models;

namespace UITermPapper.SearchWindows
{
    /// <summary>
    /// Interaction logic for SearchResultPerson.xaml
    /// </summary>
    public partial class SearchResultPerson : Window
    {
        public SearchResultPerson(List<PersonModel> person)
        {
            InitializeComponent();

            DataGrid_Person_Search.ItemsSource = person;
        }

      
    }
}
