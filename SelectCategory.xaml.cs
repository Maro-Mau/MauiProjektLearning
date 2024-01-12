namespace KarteiKartenApp;

public partial class SelectCategory : ContentPage
{
	public SelectCategory()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		btn4.BackgroundColor = Microsoft.Maui.Graphics.Colors.DeepPink;
    }
}