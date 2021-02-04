using System.Collections.Generic;
using System.Windows;
using Models;

namespace UITermPapper.SearchWindows
{
    /// <summary>
    /// Interaction logic for SearchResultResume.xaml
    /// </summary>
    public partial class SearchResultResume : Window
    {
        public SearchResultResume(List<ResumeModel> resumes)
        {
            InitializeComponent();

            SearchResult_DataGrid_CV.ItemsSource = resumes;
        }
    }
}
