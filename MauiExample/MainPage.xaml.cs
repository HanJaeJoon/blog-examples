using MauiExample.Pages;
using MauiExample.ViewModels;

namespace MauiExample;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnMovePageClicked(object sender, EventArgs e)
    {
        var viewModel = new DragAndDropViewModel(3);
        await Navigation.PushAsync(new DragAndDropPage(viewModel));
    }
}
