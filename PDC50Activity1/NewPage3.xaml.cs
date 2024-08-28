namespace PDC50Activity1;

public partial class NewPage3 : ContentPage
{
	public NewPage3()
	{
		InitializeComponent();
	}
    private async void OnGoToPage2(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}