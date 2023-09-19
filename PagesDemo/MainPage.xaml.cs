namespace PagesDemo;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}


    /* "private void OnCounterClicked" the .xaml and .xaml.cs are linked similar to 
     * what we create in vue.js .Such as  vue.js these are the methods that we create 
     * and then these are called upon in .xaml file if you got line 39 will make more sense !
	 */

    private void OnCounterClicked(object sender, EventArgs e)
	{
		//Creating an instance of the contentPageDemo class
		//We are saying we want to add an element to the Navigation stack
		Navigation.PushAsync(new ContentPageDemo());



		//count++;

		//if (count == 1)
		//	CounterBtn.Text = $"Clicked {count} time";
		//else
		//	CounterBtn.Text = $"Clicked {count} times";

		//SemanticScreenReader.Announce(CounterBtn.Text);
	}
}


