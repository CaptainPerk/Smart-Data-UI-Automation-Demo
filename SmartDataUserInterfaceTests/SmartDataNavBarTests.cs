using SmartDataFramework;
using Xunit;

namespace SmartDataUserInterfaceTests
{
    public class SmartDataNavBarTests : SmartDataUserInterfaceTestBase
    {
        [Fact]
        public void Can_Navigate_Using_The_Navigation_Bar()
        {
            Site.UseNavigationBarToNavigateTo(Browser, Site.ServicesPage);
            Assert.Contains(Site.ServicesPage.Url, Browser.GetCurrentUrl());
            Site.UseNavigationBarToNavigateTo(Browser, Site.CaseStudiesPage);
            Assert.Contains(Site.CaseStudiesPage.Url, Browser.GetCurrentUrl());
            Site.UseNavigationBarToNavigateTo(Browser, Site.CareersPage);
            Assert.Contains(Site.CareersPage.Url, Browser.GetCurrentUrl());
            Site.UseNavigationBarToNavigateTo(Browser, Site.IncubatorPage);
            Assert.Contains(Site.IncubatorPage.Url, Browser.GetCurrentUrl());
            Site.UseNavigationBarToNavigateTo(Browser, Site.AboutUsPage);
            Assert.Contains(Site.AboutUsPage.Url, Browser.GetCurrentUrl());
            Site.UseNavigationBarToNavigateTo(Browser, Site.ContactPage);
            Assert.Contains(Site.ContactPage.Url, Browser.GetCurrentUrl());
            Site.UseNavigationBarToNavigateTo(Browser, Site.HomePage);
            Assert.Contains(Site.HomePage.Url, Browser.GetCurrentUrl());
            Site.UseNavigationBarToNavigateTo(Browser, Site.LunchAndLearnPage);
            Assert.Contains(Site.LunchAndLearnPage.Url, Browser.GetCurrentUrl());
        }
    }
}
