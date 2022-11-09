namespace UWOsh_InteractiveMap
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
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
}