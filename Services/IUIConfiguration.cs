namespace Brandix.DCAP.WebUI.Services
{
    public interface IUIConfiguration
    {
        /*
            Note that each property here needs to exactly match the 
            name of each property in my appsettings.json config object
        */
        string APIURL { get; set; }
        int SessionTimeOut { get; set; }
        string WebUIURL { get; set; }
    }
}