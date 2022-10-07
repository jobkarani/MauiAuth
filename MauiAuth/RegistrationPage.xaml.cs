namespace MauiAuth;


public partial class RegistrationPage : ContentPage
{
	public RegistrationPage()
	{
		InitializeComponent();
	}
    private async void Buttonn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("MainPage");
    }
    public async void BackToLogin(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("LoginPage");
    }
}