using AutomatedUITestingFrameworkDemo.Interfaces;

namespace SmartDataFramework.Pages
{
    public class ContactPage : IPage
    {
        public string Url => "https://www.smartdatasystems.com/contact/";
        public string NavBarCssSelector => "body > header > div.header__main > div.header__nav > a.header__cta-btn";
    }
}
