namespace PDC50Activity1;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}
	private async void OnGoBackMainpage(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("//MainPage");
	}
    private async void OnGoPage2(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//newpage2");
    }
}