namespace UWOsh_InteractiveMap
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(ListAllPlants), typeof(ListAllPlants));
            Routing.RegisterRoute(nameof(SearchHistory), typeof(SearchHistory));
        }
    }
}