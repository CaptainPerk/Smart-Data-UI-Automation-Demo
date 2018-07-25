using AutomatedUITestingFrameworkDemo.Interfaces;

namespace SmartDataFramework.Pages
{
    public class HomePage : IPage
    {
        public string Url => "https://www.smartdatasystems.com/";
        public string NavBarCssSelector => "body > header > div.header__main > div.logo > a > img";
    }
}
