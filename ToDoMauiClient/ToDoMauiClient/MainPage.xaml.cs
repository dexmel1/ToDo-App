using ToDoMauiClient.Models;
using System.Diagnostics;
using ToDoMauiClient.DataServices;
using ToDoMauiClient.Pages;

namespace ToDoMauiClient
{
    public partial class MainPage : ContentPage
    {
        private readonly IRestDataService _dataService;

        public MainPage(IRestDataService dataService)
        {
            InitializeComponent();

            _dataService = dataService;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            collectionView.ItemsSource = await _dataService.GetAllToDosAsync();
        }

        async void OnAddToDoClicked(object sender, EventArgs e)
        {
            Debug.WriteLine("----> Add Button clicked");

            var navigationParameter = new Dictionary<string, object>
            {
                {nameof(ToDo), new ToDo()}
            };

            await Shell.Current.GoToAsync(nameof(ManageToDoPage), navigationParameter);
        }

        async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Debug.WriteLine("----> Selection changed");

            var navigationParameter = new Dictionary<string, object>
            {
                {nameof(ToDo), e.CurrentSelection.FirstOrDefault() as ToDo }
            };

            await Shell.Current.GoToAsync(nameof(ManageToDoPage), navigationParameter);
        }

    }
}