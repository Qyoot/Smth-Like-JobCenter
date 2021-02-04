using System.Collections.Generic;
using System.Windows;
using Models;

namespace UITermPapper.AddWindows
{
    /// <summary>
    /// Interaction logic for AddResumeWin.xaml
    /// </summary>
    public partial class AddResumeWin : Window
    {
        List<PersonModel> person = new List<PersonModel>();
        List<ResumeModel> resume = new List<ResumeModel>();
        public AddResumeWin()
        {
            InitializeComponent();
            CV_Person_Add.ItemsSource = person;
            CV_Resume_Add.ItemsSource = resume;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < resume.Count; i++)
            {
                resume[i].Person = person[i];
            }
            MainWindow main = new MainWindow();
            main.CategoryResumeDefiner(resume);
            this.Hide();
            main.Show();
        }

        
    }
}
