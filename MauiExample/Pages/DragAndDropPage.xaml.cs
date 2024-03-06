using MauiExample.ViewModels;

namespace MauiExample.Pages;

public partial class DragAndDropPage : ContentPage
{
    public DragAndDropPage(DragAndDropViewModel viewModel)
    {
        InitializeComponent();

        BindingContext = viewModel;

        Loaded += async (sender, args) =>
        {
            var seconds = viewModel.Counter;

            for (var i = viewModel.Counter; i > 0; i--)
            {
                await Task.Delay(1_000);
                MainThread.BeginInvokeOnMainThread(() =>
                {
                    viewModel.Counter--;
                });
            }

            MainThread.BeginInvokeOnMainThread(async () =>
            {
                await Navigation.PopAsync();
            });
        };
    }
}