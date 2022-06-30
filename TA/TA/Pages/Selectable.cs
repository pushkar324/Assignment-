using OpenQA.Selenium;

namespace DemoAutomation.Pages
{

    /// <summary>
    /// Identifying Elements for Selectable test case
    /// </summary>
    public class Selectable : Base
    {
        //Selectable
        public IWebElement GetSelectable()
        {
            return driver.FindElement(By.XPath("//a[contains(text(),'Selectable')]"));
        }

        //Frame
        public IWebElement GetFrame()
        {
            return driver.FindElement(By.XPath("//*[@class='demo-frame']"));
        }

        //Item1
        public IWebElement GetItem1() 
        { 

            return driver.FindElement(By.XPath("//ol/li[contains(text(),'Item 1')]"));
        }

        //Item3
        public IWebElement GetItem3()
        {

            return driver.FindElement(By.XPath("//ol/li[contains(text(),'Item 3')]"));
        }

        //Item7
        public IWebElement GetItem7()
        {

            return driver.FindElement(By.XPath("//ol/li[contains(text(),'Item 7')]"));
        }

        
        
    }
}
