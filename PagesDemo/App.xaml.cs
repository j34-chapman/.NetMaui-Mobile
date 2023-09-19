namespace PagesDemo;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		var navPage = new NavigationPage(new MainPage());

		navPage.BarBackground = Colors.Chocolate;
		navPage.BarTextColor = Colors.White;

		MainPage = navPage;

		//MainPage declares what is Initial page upon startup
		//Therefor mainpage() (MainPage.xaml) is the initial page
	}
}

