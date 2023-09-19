namespace PagesDemo;

public partial class ContentPageDemo : ContentPage
{
	public ContentPageDemo()
	{
		InitializeComponent();
	}

	//1b)Here we have created how the method should work this is simliar in all coding
	//such as calling a method . In this we are telling it to go to the main page

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
		Navigation.PushAsync(new MainPage());
    }
}
