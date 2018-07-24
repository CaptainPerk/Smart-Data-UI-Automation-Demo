using AutomatedUITestingFrameworkDemo.Interfaces;
using OpenQA.Selenium;

namespace AutomatedUITestingFrameworkDemo.Adapters
{
    public class SeleniumElement : IPageElement
    {
        public SeleniumElement(IWebElement element)
        {
            Element = element;
        }

        internal IWebElement Element { get; }

        public void Click()
        {
            Element.Click();
        }

        public bool Displayed()
        {
            return Element.Displayed;
        }

        public string GetAttributeValue(string attributeName)
        {
            return Element.GetAttribute(attributeName);
        }
    }
}
