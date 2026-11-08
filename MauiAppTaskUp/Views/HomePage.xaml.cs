using System.Windows.Input;

namespace MauiAppTaskUp.Views;

public partial class HomePage : ContentPage
{
    // פקודה לכפתור ההתחברות
    //public ICommand LoginCommand { get; }

    //// פקודה לכפתור ההרשמה
    //public ICommand RegisterCommand { get; }
    public HomePage()
	{
        InitializeComponent();
        BindingContext = this;
        //LoginCommand = new Command(async () => await OnLoginClicked());
        //RegisterCommand = new Command(async () => await OnRegisterClicked());
	}
    //private async Task OnLoginClicked()
    //{
    //    // מעבר למסך התחברות (לפי בחירתך - דרך Shell או Navigation רגיל)
    //    await Application.Current.MainPage.Navigation.PushAsync(new Views.LoginPage());
    //}

    //private async Task OnRegisterClicked()
    //{
    //    // מעבר למסך הרשמה
    //    await Application.Current.MainPage.Navigation.PushAsync(new Views.RegisterPage());
    //}
}