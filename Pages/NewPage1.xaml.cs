using MauiApp9.Pages.Fl;

namespace MauiApp9.Pages;

public partial class NewPage1 : ContentPage
{
    public NewPage1()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new NewPage());

    }
}