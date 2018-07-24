using AutomatedUITestingFrameworkDemo.Interfaces;

namespace SmartDataFramework.Pages
{
    public class AboutUsPage : IPage
    {
        public string Url => "https://www.smartdatasystems.com/about/";
        public string NavBarCssSelector => "#menu-item-26 > a";
    }
}
