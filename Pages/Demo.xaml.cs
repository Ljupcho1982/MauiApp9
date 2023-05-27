namespace MauiApp9.Pages;

public partial class Demo : ContentPage
{
	public Demo()
	{
		InitializeComponent();
	}

	private void Click(object sender, EventArgs e)
	{

		Navigation.PushModalAsync(new NewPage1());



	}
}