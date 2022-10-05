namespace MauiAuth;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}
	private async void Button_Clicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("MainPage");
	}

	private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync("RegistrationPage");
    }
}