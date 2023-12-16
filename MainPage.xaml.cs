using System.Reflection.Metadata;
using Microsoft.Maui.Controls;
using Microsoft.Maui;

namespace KarteiKartenApp
{
    public partial class MainPage : ContentPage
    {
        //new NewContent1 NewContent1 = new NewContent1();
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {

            String user = TxtUser.Text;
            String password = TxtPassword.Text;
            if (user == "admin" && password == "admin")
            {
                Navigation.PushAsync(new SelectCategory());
            }
            else
            {
                DisplayAlert("Fehler", "Benutzername oder Passwort falsch", "OK");
            }
           
        }
        private void OnRegisterClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegisterPage());
        }


    }

}
