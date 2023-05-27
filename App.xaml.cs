using MauiApp9.Pages;

namespace MauiApp9;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new Demo();
	}
}
