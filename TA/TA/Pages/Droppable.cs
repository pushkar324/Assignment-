using OpenQA.Selenium;

namespace DemoAutomation.Pages
{
    /// <summary>
    /// Identifying Elements for Droppable Test Case
    /// </summary>
    public class Droppable : Base
    {
        //Droppable
        public IWebElement GetDroppable()
        {
            return driver.FindElement(By.XPath("//a[contains(text(),'Droppable')]"));
        }

        //Frame
        public IWebElement GetFrame()
        {
            return driver.FindElement(By.XPath("//*[@class='demo-frame']"));
        }

        //ItemToDrag
        public IWebElement ItemToDrag()
        {
            return driver.FindElement(By.XPath("//div[@id='draggable']"));
        }

        //DropLocation
        public IWebElement Drop()
        {
            return driver.FindElement(By.XPath("//div[@id='droppable']"));
        }
    }
}
