namespace UWOsh_InteractiveMap
{
    public partial class App : Application
    {
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NzUzMjE2QDMyMzAyZTMzMmUzME15cWY2YTRVM2M0Nk1SMXVYdW5wY0R4M1Vmc25WUTh4ckxrNFBwYzlDTFk9");
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}