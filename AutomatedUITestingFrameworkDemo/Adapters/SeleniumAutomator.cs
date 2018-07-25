using AutomatedUITestingFrameworkDemo.Enumerations;
using AutomatedUITestingFrameworkDemo.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;
using System;
using System.Drawing;
using System.IO;

namespace AutomatedUITestingFrameworkDemo.Adapters
{
    public class SeleniumAutomator : IBrowserAutomator
    {
        private IWebDriver WebDriver;

        public void InstantiateNewBrowser(BrowserType browserType, string url)
        {
            switch (browserType)
            {
                case BrowserType.InternetExplorer:
                    var internetExplorerOptions = new InternetExplorerOptions { IntroduceInstabilityByIgnoringProtectedModeSettings = true };
                    WebDriver = new InternetExplorerDriver(internetExplorerOptions);
                    break;
                case BrowserType.Chrome:
                    var chromeOptions = new ChromeOptions();
                    chromeOptions.AddArgument("disable-extensions");
                    WebDriver = new ChromeDriver(Directory.GetCurrentDirectory(), chromeOptions);
                    break;
                case BrowserType.Firefox:
                    WebDriver = new FirefoxDriver();
                    break;
                case BrowserType.Edge:
                    WebDriver = new EdgeDriver();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(browserType), browserType, null);
            }

            NavigateTo(url);
        }

        public string GetCurrentUrl()
        {
            return WebDriver.Url;
        }

        public void NavigateTo(string url)
        {
            WebDriver.Navigate().GoToUrl(url);
        }

        public void RefreshPage()
        {
            WebDriver.Navigate().Refresh();
        }

        public void MaximizeWindow()
        {
            WebDriver.Manage().Window.Maximize();
        }

        public void SetResolution(int width, int height)
        {
            WebDriver.Manage().Window.Size = new Size(width, height);
        }

        public void ScrollUp()
        {
            new Actions(WebDriver).SendKeys(Keys.PageUp).Perform();
        }

        public void ScrollDown()
        {
            new Actions(WebDriver).SendKeys(Keys.PageDown).Perform();
        }

        public void DoubleClick(IPageElement element)
        {
            var seleniumElement = GetSeleniumElement(element);
            new Actions(WebDriver).DoubleClick(seleniumElement.Element).Perform();
        }

        public void HoverOver(IPageElement element)
        {
            var seleniumElement = GetSeleniumElement(element);
            new Actions(WebDriver).MoveToElement(seleniumElement.Element).Perform();
        }

        public IPageElement GetElementByCssSelector(string cssSelector)
        {
            return new SeleniumElement(WebDriver.FindElement(By.CssSelector(cssSelector)));
        }

        public void Close()
        {
            WebDriver.Quit();
        }

        private SeleniumElement GetSeleniumElement(IPageElement element)
        {
            if (!(element is SeleniumElement seleniumElement))
            {
                throw new ArgumentException("Element is not compatible with a SeleniumFramework");
            }
            return seleniumElement;
        }
    }
}
