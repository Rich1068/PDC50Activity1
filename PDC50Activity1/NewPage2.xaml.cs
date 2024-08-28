namespace PDC50Activity1;

public partial class NewPage2 : ContentPage
{
	public NewPage2()
	{
		InitializeComponent();
	}
    private async void OnGoPage3(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NewPage3());
    }
    private async void OnGoNewPage1(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//newpage1");
    }
}