namespace AutomatedUITestingFrameworkDemo.Interfaces
{
    public interface IPageElement
    {
        void Click();
        bool Displayed();
        string GetAttributeValue(string attributeName);
    }
}
