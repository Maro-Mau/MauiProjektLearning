namespace KarteiKartenApp;

public partial class RegisterPage : ContentPage
{
	public RegisterPage()
	{
		InitializeComponent();
	}
	private void CmdBackToLogin(object sender, EventArgs e)
	{
        Navigation.PushAsync(new MainPage());
    }
}