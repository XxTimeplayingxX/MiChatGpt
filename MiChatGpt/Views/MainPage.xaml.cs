using MiChatGpt.ViewModels;

namespace MiChatGpt.Views;

public partial class MainPage : ContentPage
{
    //Inyectamos el viewmodel
    public MainPage(MainPageViewModel mainPageViewModel)
    {
        InitializeComponent();
        //Asignamos el viewModel
        BindingContext = mainPageViewModel;
    }

}