using System.Reflection.Metadata;
using Microsoft.Maui.Controls;
using Microsoft.Maui;
//using static Java.Util.Jar.Attributes;

namespace KarteiKartenApp
{
    public partial class MainPage : ContentPage
    {
        //new NewContent1 NewContent1 = new NewContent1();
        //DatabaseConection DBConect = new DatabaseConection();
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            //string sql = "CREATE TABLE IF NOT EXISTS TestTable(ID INT AUTO_INCREMENT PRIMARY KEY, Name VARCHAR(255), Age INT)";
            String user = TxtUser.Text;
            String password = TxtPassword.Text;
           // DBConect.ConectDB(sql);
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

        private void Hallo_Clicked(object sender, EventArgs e)
        {

        }
    }

}
