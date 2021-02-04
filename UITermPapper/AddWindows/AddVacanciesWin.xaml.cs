using System.Collections.Generic;
using System.Windows;
using Models;

namespace UITermPapper.AddWindows
{
    /// <summary>
    /// Interaction logic for AddVacanciesWin.xaml
    /// </summary>
    public partial class AddVacanciesWin : Window
    {
        List<FirmModel> firm = new List<FirmModel>();
        List<VacanciesModel> vacancies = new List<VacanciesModel>();
        public AddVacanciesWin()
        {
            InitializeComponent();
            DataGrid_Add_Firm.ItemsSource = firm;
            DataGrid_Add_Vacancy.ItemsSource = vacancies;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < vacancies.Count; i++)
            {
                vacancies[i].Firm = firm[i];
            }
            MainWindow main = new MainWindow();
            main.CategoryVacancyDefiner(vacancies);
            this.Hide();
            main.Show();
        }
    }
}
