using SmartDataFramework;
using Xunit;

namespace SmartDataUserInterfaceTests
{
    public class SeleniumDemoTests : SmartDataUserInterfaceTestBase
    {
        [Fact]
        public void Can_Demonstrate_How_Selenium_Works()
        {
            // Navigation Demo
            Browser.NavigateTo("https://www.google.com");
            Assert.Contains("https://www.google.com", Browser.GetCurrentUrl());
            WaitForSeconds(10);
            Browser.NavigateTo("https://smartdata.net");
            Assert.Contains("https://smartdata.net", Browser.GetCurrentUrl());

            // Refresh Page Demo
            WaitForSeconds(3);
            Browser.RefreshPage();
            Assert.Contains("https://smartdata.net", Browser.GetCurrentUrl());
            WaitForSeconds(10);

            // Set Resolution Demo
            Browser.SetResolution(320, 180);
            WaitForSeconds(10);
            Browser.MaximizeWindow();

            // Scrolling Demo
            Browser.ScrollDown();
            WaitForSeconds(1);
            Browser.ScrollDown();
            WaitForSeconds(5);
            Browser.ScrollUp();
            WaitForSeconds(1);
            Browser.ScrollUp();
            WaitForSeconds(10);

            // Hover Over Demo
            var servicesNavigationLink = Browser.GetElementByCssSelector(Site.ServicesPage.NavBarCssSelector);
            Browser.HoverOver(servicesNavigationLink);
            Assert.True(Browser.GetElementByCssSelector("#menu-item-108 > a").Displayed());
            WaitForSeconds(10);

            // Double Click Demo (you really shouldn't do this)
            Browser.NavigateTo("https://unixpapa.com/js/testmouse.html");
            Assert.Contains("https://unixpapa.com/js/testmouse.html", Browser.GetCurrentUrl());
            WaitForSeconds(5);
            var testLink = Browser.GetElementByCssSelector("body > table > tbody > tr > td:nth-child(1) > a:nth-child(1)");
            Browser.DoubleClick(testLink);
            WaitForSeconds(5);
            var testArea = Browser.GetElementByCssSelector("body > table > tbody > tr > td:nth-child(1) > form > textarea");
            var testAreaContents = testArea.GetAttributeValue("value");
            Assert.Contains("dblclick", testAreaContents);
            WaitForSeconds(10);
        }
    }
}
