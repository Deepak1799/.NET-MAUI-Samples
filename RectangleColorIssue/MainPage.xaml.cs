using Microsoft.Maui.Controls.Shapes;

namespace RectangleColorIssue;

public partial class MainPage : ContentPage
{
    Rectangle rectangle;
	public MainPage()
	{
		InitializeComponent();
	}

    private void Rectangle_Clicked(object sender, EventArgs e)
    {
        rectangle = new Rectangle();
        rectangle.BackgroundColor = Colors.Yellow;
        AbsoluteLayout.SetLayoutBounds(rectangle, new Rect(0, 0, 200, 50));
        MyLayout.Children.Add(rectangle);
    }

    private void Color_Clicked(object sender, EventArgs e)
    {
        rectangle.BackgroundColor = Colors.Red;
    }
}

