using AutomatedUITestingFrameworkDemo.Interfaces;

namespace SmartDataFramework.Pages
{
    public class CaseStudiesPage : IPage
    {
        public string Url => "https://www.smartdatasystems.com/work/";
        public string NavBarCssSelector => "#menu-item-30 > a";
    }
}
