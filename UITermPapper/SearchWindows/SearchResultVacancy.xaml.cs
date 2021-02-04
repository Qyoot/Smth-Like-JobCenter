using System.Collections.Generic;
using System.Windows;
using Models;

namespace UITermPapper.SearchWindows
{
    /// <summary>
    /// Interaction logic for SearchResultVacancy.xaml
    /// </summary>
    public partial class SearchResultVacancy : Window
    {
        public SearchResultVacancy(List<VacanciesModel> vacancies)
        {
            InitializeComponent();

            SearchResult_DataGrid_Vacancy.ItemsSource = vacancies;
        }
    }
}
