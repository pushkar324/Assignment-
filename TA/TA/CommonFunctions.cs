using OpenQA.Selenium;

namespace DemoAutomation
{
    /// <summary>
    /// Creating Extension methods tpo perform action
    /// </summary>
    public static class CommonFunc 
    {
        public static void EnterText(this IWebElement element, string text)   //Extension method for SendKeys action
        {
            
            element.SendKeys(text);

        }

        public static void Clicks(this IWebElement element) //Extension method for Click
        {
            element.Click();
        }

        
    }
}