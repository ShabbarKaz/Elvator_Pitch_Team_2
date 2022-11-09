namespace UWOsh_InteractiveMap;

public partial class NavBar : ContentPage
{
	public NavBar()
	{
		InitializeComponent();
	}

    void OnTextChanged(object sender, EventArgs e)
    {
        SearchBar.Text = "TextChanged";
    }

    async void GoToListPlants(object sender, EventArgs args)
    {
        await Shell.Current.GoToAsync(nameof(ListAllPlants));
    }

    async void GetCompass(object sender, EventArgs args)
    { 
        await Shell.Current.GoToAsync(nameof(SearchHistory));
    }

    async void GiveFeedback(object sender, EventArgs args)
    {
        if (Email.Default.IsComposeSupported)
        {

            string subject = "Issue found";
            string body = "";
            string[] recipients = new[] { "Kazmis55@uwosh", "Kazmis55@Uwosh.edu" };

            var message = new EmailMessage
            {
                Subject = subject,
                Body = body,
                BodyFormat = EmailBodyFormat.PlainText,
                To = new List<string>(recipients)
            };

            FeedBack.Text = "Feed Back sent";

            // await Email.Default.ComposeAsync(message);
        }
    }
}