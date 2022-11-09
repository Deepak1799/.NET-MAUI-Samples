namespace AndroidImageIssue;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void AddImageSource_Clicked(object sender, EventArgs e)
	{
		Stream imageStream= this.GetType().Assembly.GetManifestResourceStream("AndroidImageIssue.Resources.Raw.dotnet.png");
		imageStream.Position = 0;
		MyImage.WidthRequest = 3000;
        MyImage.HeightRequest = 3000;
        MyImage.Source = ImageSource.FromStream(() => imageStream);
    }
}

