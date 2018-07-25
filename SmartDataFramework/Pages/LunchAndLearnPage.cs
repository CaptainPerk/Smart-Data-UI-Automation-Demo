using AutomatedUITestingFrameworkDemo.Interfaces;

namespace SmartDataFramework.Pages
{
    public class LunchAndLearnPage : IPage
    {
        public string Url => "https://lunchandlearn.smartdatasystems.com/";
        public string NavBarCssSelector => "#menu-item-1131 > a";
    }
}
