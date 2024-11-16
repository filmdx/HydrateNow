namespace HydrateNow.FristPage;

public partial class Alert : ContentPage
{
    public Alert()
    {
        InitializeComponent();
    }
    private void Switch_Toggled(object sender, ToggledEventArgs e)
    {
        var switchControl = sender as Switch;

        // Example: Manually reapply the colors when toggled
        if (switchControl != null)
        {
            switchControl.ThumbColor = Color.FromArgb("#FFFDA0E4"); // Reapply ThumbColor
            switchControl.OnColor = Colors.LightGreen; // Reapply OnColor
        }
    }
    private void GoTodatapage_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new datapage());
    }

    private void GoToProfile_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Profile());
    }
}