using AutomatedUITestingFrameworkDemo.Adapters;
using AutomatedUITestingFrameworkDemo.Enumerations;
using AutomatedUITestingFrameworkDemo.Interfaces;
using System;
using System.Threading;

namespace SmartDataFramework
{
    public class SmartDataUserInterfaceTestBase : IDisposable
    {
        protected IBrowserAutomator Browser;
        protected SmartDataWebsite Site;

        public SmartDataUserInterfaceTestBase()
        {
            Browser = new SeleniumAutomator();
            Site = new SmartDataWebsite();
            Browser.InstantiateNewBrowser(BrowserType.Chrome, "https://smartdata.net");
            Browser.MaximizeWindow();
        }

        public void WaitForSeconds(int seconds)
        {
            Thread.Sleep(seconds * 1000);
        }

        public void Dispose()
        {
            Browser.Close();
        }
    }
}
