using AutomatedUITestingFrameworkDemo.Interfaces;
using SmartDataFramework.Pages;

namespace SmartDataFramework
{
    public class SmartDataWebsite
    {
        public AboutUsPage AboutUsPage = new AboutUsPage();
        public CareersPage CareersPage = new CareersPage();
        public CaseStudiesPage CaseStudiesPage = new CaseStudiesPage();
        public ContactPage ContactPage = new ContactPage();
        public HomePage HomePage = new HomePage();
        public IncubatorPage IncubatorPage = new IncubatorPage();
        public LunchAndLearnPage LunchAndLearnPage = new LunchAndLearnPage();
        public ServicesPage ServicesPage = new ServicesPage();

        public void UseNavigationBarToNavigateTo(IBrowserAutomator automator, IPage page)
        {
            automator.GetElementByCssSelector(page.NavBarCssSelector).Click();
        }
    }
}
