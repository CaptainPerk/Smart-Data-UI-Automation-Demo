using AutomatedUITestingFrameworkDemo.Interfaces;

namespace SmartDataFramework.Pages
{
    public class ServicesPage : IPage
    {
        public string Url => "https://smartdata.net/what-we-do/";
        public string NavBarCssSelector => "#menu-item-31 > a";
    }
}
