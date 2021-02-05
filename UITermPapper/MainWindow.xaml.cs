using System.Collections.Generic;
using System.Windows;
using PresentationLayer.Controllers;
using Models;
using UITermPapper.SearchWindows;
using UITermPapper.AddWindows;

namespace UITermPapper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    //  All interaction were implemented it XAML by DataGrid,buttons and SubWindows  , Sorting works by typing on name of column.
    //  Adding item by window or by click on free row without paramemters and if u enter some info with error, tool tip will tell u want u did wrong.
    // To Delete some item u just should select in and press "delete" on ur keyboard.
    // To Search some item u should enter string to search in sperial field above button "Search"

    public partial class MainWindow : Window
    {
       private PersonController personController = new PersonController();
        private FirmController firmController = new FirmController();
        private ResumeController resumeController = new ResumeController();
        private VacanciesController vacanciesController = new VacanciesController();

        private List<ResumeModel> ITresumes = new List<ResumeModel>();
        private List<ResumeModel> DesignResumes = new List<ResumeModel>();
        private List<ResumeModel> MarketingResumes = new List<ResumeModel>();
        private List<ResumeModel> ManagementResumes = new List<ResumeModel>();

        private List<VacanciesModel> ITvacancies = new List<VacanciesModel>();
        private List<VacanciesModel> DesignVacancies = new List<VacanciesModel>();
        private List<VacanciesModel> MarketingVacancies = new List<VacanciesModel>();
        private List<VacanciesModel> ManagementVacancies = new List<VacanciesModel>();

        private AddResumeWin addResume = new AddResumeWin();
        private AddVacanciesWin addVacancies = new AddVacanciesWin();


        private string pathPerson = @"PeopleData";
        private string pathFirm = @"FirmData";

        private string pathITResume = @"ITResumeData";
        private string pathDesignResume = @"DesignResumeData";
        private string pathMarketingResume = @"MarketingResumeData";
        private string pathManagementResume = @"ManagementResumeData";

        private string pathITVacancy = @"ITVacancyData";
        private string pathDesignVacancy = @"DesignVacancyData";
        private string pathMarketingVacancy = @"MarketingVacancyData";
        private string pathManagementVacancy = @"ManagementVacancyData";


        private List<FirmModel> firms = new List<FirmModel>();
        private List<PersonModel> people = new List<PersonModel>();
        private List<CategoryModel> categories = new List<CategoryModel>
        {
            new CategoryModel("IT",null,null),
            new CategoryModel("Design",null,null),
            new CategoryModel("Marketing",null,null),
            new CategoryModel("Management",null,null)
        };

        public MainWindow()
        {
            InitializeComponent();

            // Reading info from files in order to get info which users save before close app 
            ITresumes = resumeController.ToDeserialzie(pathITResume);
            DesignResumes = resumeController.ToDeserialzie(pathDesignResume);
            MarketingResumes = resumeController.ToDeserialzie(pathMarketingResume);
            ManagementResumes = resumeController.ToDeserialzie(pathManagementResume);

            ITvacancies = vacanciesController.ToDeserialzie(pathITVacancy);
            DesignVacancies = vacanciesController.ToDeserialzie(pathDesignVacancy);
            MarketingVacancies = vacanciesController.ToDeserialzie(pathMarketingVacancy);
            ManagementVacancies = vacanciesController.ToDeserialzie(pathManagementVacancy);

            InitGrids();            
        }
        private void InitGrids()  // initializing grid when programm start
        {
            IT_DataGrid_Vacancy.ItemsSource = ITvacancies;
            Design_DataGrid_Vacancy.ItemsSource = DesignVacancies;
            Marketing_DataGrid_Vacancy.ItemsSource = MarketingVacancies;
            Management_DataGrid_Vacancy.ItemsSource = ManagementVacancies;
            IT_DataGrid_CV.ItemsSource = ITresumes;
            Design_DataGrid_CV.ItemsSource = DesignResumes;
            Marketing_DataGrid_CV.ItemsSource = MarketingResumes;
            Managment_DataGrid_CV.ItemsSource = ManagementResumes;

            DataGrid_Person.ItemsSource = people;
            DataGrid_Firm.ItemsSource = firms;
        }
        private void RefreshGrids()  // Updating grid after adding new element
        {
            IT_DataGrid_Vacancy.Items.Refresh();
            Design_DataGrid_Vacancy.Items.Refresh();
            Marketing_DataGrid_Vacancy.Items.Refresh();
            Management_DataGrid_Vacancy.Items.Refresh();
            IT_DataGrid_CV.Items.Refresh();
            Design_DataGrid_CV.Items.Refresh();
            Marketing_DataGrid_CV.Items.Refresh();
            Managment_DataGrid_CV.Items.Refresh();
            DataGrid_Person.Items.Refresh();
            DataGrid_Firm.Items.Refresh();
        }
        public void CategoryResumeDefiner(List<ResumeModel> resumes)   // Defines to witch category resume belongs
        {
            foreach (var resume in resumes)
            {
                if (resume.Sphere == categories[0].Name)
                {
                    ITresumes.Add(resume);
                }
                else if (resume.Sphere == categories[1].Name)
                {
                    DesignResumes.Add(resume);
                }
                else if (resume.Sphere == categories[2].Name)
                {
                    MarketingResumes.Add(resume);
                }
                else if (resume.Sphere == categories[3].Name)
                {
                    ManagementResumes.Add(resume);
                }
            }
            RefreshGrids();
            addResume.Hide();
        }
       public void CategoryVacancyDefiner(List<VacanciesModel> vacancies)  // Defines to witch category vacancy belongs
        {
            foreach (var vacancy in vacancies)
            {
                if (vacancy.Sphere == categories[0].Name)
                {
                    ITvacancies.Add(vacancy);
                }
                else if (vacancy.Sphere == categories[1].Name)
                {
                    DesignVacancies.Add(vacancy);
                }
                else if (vacancy.Sphere == categories[2].Name)
                {
                    MarketingVacancies.Add(vacancy);
                }
                else if (vacancy.Sphere == categories[3].Name)
                {
                    ManagementVacancies.Add(vacancy);
                }
            }
            RefreshGrids();
            addVacancies.Hide();
        }

        private void IT_Search_Resume_Click(object sender, RoutedEventArgs e)   // Search for Resume in IT catergory
        {
            List<ResumeModel> temp = new List<ResumeModel>();
            string ToSearch = Search_CV_IT_DataGrid.Text;
            foreach (var item in ITresumes)
            {
                if (item.String.Contains(ToSearch))
                {
                    temp.Add(item);
                }
            }
            SearchResultResume SearchResume = new SearchResultResume(temp);
            SearchResume.Show();
            
        }
        private void IT_Save_Resume_Click(object sender, RoutedEventArgs e)
        {
            
            resumeController.Save(pathITResume,ITresumes);
        }

        private void IT_Search_Vacancies_Click(object sender, RoutedEventArgs e) // Search for Vacancy in IT catergory
        {
            List<VacanciesModel> temp = new List<VacanciesModel>();
            string ToSearch = Search_Vacancy_IT_DataGrid.Text;
            foreach (var item in ITvacancies)
            {
                if (item.String.Contains(ToSearch))
                {
                    temp.Add(item);
                }
            }
            SearchResultVacancy SearchVacancy = new SearchResultVacancy(temp);
            SearchVacancy.Show();
        }

        private void IT_Save_Vacancies_Click(object sender, RoutedEventArgs e)
        {
            
            vacanciesController.Save(pathITVacancy,ITvacancies);
        }
        private void Design_Search_Resume_Click(object sender, RoutedEventArgs e) // Search for Resume in Design catergory
        {
            List<ResumeModel> temp = new List<ResumeModel>();
            string ToSearch = Search_CV_Design_DataGrid.Text;
            foreach (var item in DesignResumes)
            {
                if (item.String.Contains(ToSearch))
                {
                    temp.Add(item);
                }
            }
            SearchResultResume SearchResume = new SearchResultResume(temp);
            SearchResume.Show();

        }

        private void Design_Save_Resume_Click(object sender, RoutedEventArgs e)
        {
            
            
            resumeController.Save(pathDesignResume,DesignResumes);
        }

        private void Desing_Search_Vacancies_Click(object sender, RoutedEventArgs e) // Search for Vacancy in Design catergory
        {
            List<VacanciesModel> temp = new List<VacanciesModel>();
            string ToSearch = Search_Vacancy_Design_DataGrid.Text;
            foreach (var item in DesignVacancies)
            {
                if (item.String.Contains(ToSearch))
                {
                    temp.Add(item);
                }
            }
            SearchResultVacancy SearchVacancy = new SearchResultVacancy(temp);
            SearchVacancy.Show();
        }

        private void Desing_Save_Vacancies_Click(object sender, RoutedEventArgs e)
        {
            
            vacanciesController.Save(pathDesignVacancy,DesignVacancies);
        }

        private void Marketing_Search_Resume_Click(object sender, RoutedEventArgs e) // Search for Resume in Marketing catergory
        {
            List<ResumeModel> temp = new List<ResumeModel>();
            string ToSearch = Search_CV_Marketing_DataGrid.Text;
            foreach (var item in MarketingResumes)
            {
                if (item.String.Contains(ToSearch))
                {
                    temp.Add(item);
                }
            }
            SearchResultResume SearchResume = new SearchResultResume(temp);
            SearchResume.Show();

        }

        private void Marketing_Save_Resume_Click(object sender, RoutedEventArgs e)
        {
            
            resumeController.Save(pathMarketingResume,MarketingResumes);
        }

        private void Marketing_Search_Vacancies_Click(object sender, RoutedEventArgs e) // Search for Vacancy in Marketing catergory
        {
            List<VacanciesModel> temp = new List<VacanciesModel>();
            string ToSearch = Search_Vacancy_Marketing_DataGrid.Text;
            foreach (var item in MarketingVacancies)
            {
                if (item.String.Contains(ToSearch))
                {
                    temp.Add(item);
                }
            }
            SearchResultVacancy SearchVacancy = new SearchResultVacancy(temp);
            SearchVacancy.Show();
        }

        private void Marketing_Save_Vacancies_Click(object sender, RoutedEventArgs e)
        {
            
            vacanciesController.Save(pathMarketingVacancy,MarketingVacancies);
        }
        private void Managment_Search_Resume_Click(object sender, RoutedEventArgs e) // Search for Resume in Management catergory
        {
            List<ResumeModel> temp = new List<ResumeModel>();
            string ToSearch = Search_CV_Management_DataGrid.Text;
            foreach (var item in ManagementResumes)
            {
                if (item.String.Contains(ToSearch))
                {
                    temp.Add(item);
                }
            }
            SearchResultResume SearchResume = new SearchResultResume(temp);
            SearchResume.Show();

        }

        private void Managment_Save_Resume_Click(object sender, RoutedEventArgs e)
        {
            
            resumeController.Save(pathManagementResume,ManagementResumes);
        }

        private void Managment_Search_Vacancies_Click(object sender, RoutedEventArgs e) // Search for Vacancies in Management catergory
        {
            List<VacanciesModel> temp = new List<VacanciesModel>();
            string ToSearch = Search_Vacancy_Management_DataGrid.Text;
            foreach (var item in ManagementVacancies)
            {
                if (item.String.Contains(ToSearch))
                {
                    temp.Add(item);
                }
            }
            SearchResultVacancy SearchVacancy = new SearchResultVacancy(temp);
            SearchVacancy.Show();
        }

        private void Managment_Save_Vacancies_Click(object sender, RoutedEventArgs e)
        {
            
            vacanciesController.Save(pathManagementVacancy,ManagementVacancies);
        }

        private void Search_Person_Click(object sender, RoutedEventArgs e)  // Search for unemployed people
        {
            List<PersonModel> temp = new List<PersonModel>();
            string ToSearch = Search_Person_DataGrid.Text;
            foreach (var item in people)
            {
                if (item.String.Contains(ToSearch))
                {
                    temp.Add(item);
                }
            }
            SearchResultPerson searchResultPerson = new SearchResultPerson(temp);
            searchResultPerson.Show();
        }

        private void Save_Person_Click(object sender, RoutedEventArgs e)
        {
            
            personController.Save(pathPerson,people);
        }

        private void Search_Firm_Click(object sender, RoutedEventArgs e) // Search for firm
        {
            List<FirmModel> temp = new List<FirmModel>();
            string ToSearch = Search_Firm_DataGrid.Text;
            foreach (var item in firms)
            {
                if (item.String.Contains(ToSearch))
                {
                    temp.Add(item);
                }
            }
            SearchResultFirm searchResultFirm = new SearchResultFirm(temp);
            searchResultFirm.Show();
        }

        private void Save_Firm_Click(object sender, RoutedEventArgs e)
        {
            
            firmController.Save(pathFirm,firms);
        }

        private void Add_Resume_Click(object sender, RoutedEventArgs e)   // calling AddResume window
        {
            this.Hide();
            addResume.Show();
        }

        private void Add_Vacancy_Click(object sender, RoutedEventArgs e) // calling Vacancy window
        {
            this.Hide();
            addVacancies.Show();
        }
    }  
}
