namespace MauiTestApp;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);

        botImage.Opacity = 1;

        Animation animation = new(v => botImage.Opacity = v, botImage.Opacity, 0);
        animation.StartDelay = 10000;
        animation.Commit(botImage, nameof(botImage));
    }
}

