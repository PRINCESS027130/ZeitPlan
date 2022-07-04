using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZeitPlan.Models;

namespace ZeitPlan.LoginSystem
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class login : ContentPage
    {
       

        public login()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                await DisplayAlert("ERROR", "Please fill the required field", "ok");
                return;
            }
            //App.db.CreateTable<user>();
            //var check = App.db.Table<user>().FirstOrDefault(x => x.Email == txtEmail.Text && x.Password == txtPassword.Text);
            try
            {
                LoadingInd.IsRunning = true;
                var check = (await App.firebaseDatabase.Child("user").OnceAsync<user>()).FirstOrDefault(x => x.Object.Email == txtEmail.Text && x.Object.Password == txtPassword.Text);
                if (check == null)
                {
                    LoadingInd.IsRunning = false;
                    await DisplayAlert("ERROR", "Email or Password are incorrect", "ok");
                    return;
                }
                else
                {
                    await Navigation.PushAsync(new UsersList());
                }
            }
            catch (Exception ex)
            {
                LoadingInd.IsRunning = false;

                await DisplayAlert("Error", "Somethimg went wrong,Please try again later\nError:" + ex.Message, "ok");
            }
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new register());
        }
    }
}