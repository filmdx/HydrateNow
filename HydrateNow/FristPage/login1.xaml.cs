namespace HydrateNow.FristPage;

public partial class login1 : ContentPage
{
    public login1()
    {
        InitializeComponent();
    }
    private void GoTodatapage_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Alert());
    }
}