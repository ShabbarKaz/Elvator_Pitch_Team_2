namespace UWOsh_InteractiveMap;

public partial class Map : ContentPage
{
	public Map()
	{
		InitializeComponent();
	}

    private void OnTextChanged(object sender, EventArgs e)
    {
        SearchBar.Text = "Text Changed";

    }

    private void FilterClicked(object sender, EventArgs e)
    {
        SearchBar.Text = "Text Changed";
    }
}