public class Website
{
    private string _websiteName;
    private string _pathToWebsite;
    private string _descriptionOfWebsite;
    private string _addressOfWebsite;

    public string WebsiteName
    {
        get { return _websiteName; }
        set { _websiteName = value; }
    }

    public string PathToWebsite
    {
        get { return _pathToWebsite; }
        set { _pathToWebsite = value; }
    }

    public string DescriptionOfWebsite
    {
        get { return _descriptionOfWebsite; }
        set { _descriptionOfWebsite = value; }
    }

    public string AddressOfWebsite
    {
        get { return _addressOfWebsite; }
        set { _addressOfWebsite = value; }
    }
    
    public Website(string websiteName, string pathToWebsite,
        string descriptionOfWebsite, string addressOfWebsite)
    {
        WebsiteName = websiteName;
        PathToWebsite = pathToWebsite;
        DescriptionOfWebsite = descriptionOfWebsite;
        AddressOfWebsite = addressOfWebsite;
    }

    class Program
    {
        static void Main()
        {

        }
    }
}
