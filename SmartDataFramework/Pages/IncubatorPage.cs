using AutomatedUITestingFrameworkDemo.Interfaces;

namespace SmartDataFramework.Pages
{
    public class IncubatorPage : IPage
    {
        public string Url => "https://www.smartdatasystems.com/incubator/";
        public string NavBarCssSelector => "#menu-item-1057 > a";
    }
}
