namespace MAUIApp5;

public partial class MainPage : ContentPage
{


	public MainPage()
	{
		InitializeComponent();
	}

	public void OnVerticalStart(object sender, EventArgs e)
	{
		target.VerticalOptions = LayoutOptions.Start;
	}

    public void OnVerticalCenter(object sender, EventArgs e)
    {
        target.VerticalOptions = LayoutOptions.Center;
    }
    public void OnVerticalEnd(object sender, EventArgs e)
    {
        target.VerticalOptions = LayoutOptions.End;
    }

    public void OnHorizontalStart(object sender, EventArgs e)
    {
        target.HorizontalOptions = LayoutOptions.Start;
    }
    public void OnHorizontalCenter(object sender, EventArgs e)
    {
        target.HorizontalOptions = LayoutOptions.Center;
    }
    public void OnHorizontalEnd(object sender, EventArgs e)
    {
        target.HorizontalOptions = LayoutOptions.End;
    }
}

