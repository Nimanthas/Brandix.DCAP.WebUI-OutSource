namespace Brandix.DCAP.WebUI.Services
{
    public class UIConfiguration : IUIConfiguration
    {
        /*
            Note that each property here needs to exactly match the 
            name of each property in my appsettings.json config object
        */
        public string APIURL { get; set; }
        public int SessionTimeOut { get; set; }
        public string WebUIURL { get; set; }
    }
}