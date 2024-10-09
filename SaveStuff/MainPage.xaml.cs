namespace SaveStuff;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }


    private void Save_OnClicked(object sender, EventArgs e)
    {
        Preferences.Set("user", TxtUser.Text);
    }

    private void Read_OnClicked(object sender, EventArgs e)
    {
        TxtUser.Text=Preferences.Get("user", "");
    }

    private void Clear_OnClicked(object sender, EventArgs e)
    {
        TxtUser.Text = "";
        
    }
}