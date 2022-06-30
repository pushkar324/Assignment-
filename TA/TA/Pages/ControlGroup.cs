using OpenQA.Selenium;

namespace DemoAutomation.Pages
{
    /// <summary>
    /// Identifying Elements for ControlGroup Test
    /// </summary>
    public class ControlGroup : Base
    {
        //ControlGrouop
        public IWebElement GetControlGroup()
        { 
            return driver.FindElement(By.XPath("//a[contains(text(),'Controlgroup')]"));
        }

        //Frame
        public IWebElement GetFrame()
        {
            return driver.FindElement(By.XPath("//*[@class='demo-frame']"));
        }

        //switching to fieldset1 elements
        //SUV
        public IWebElement GetCarType()
        {
            return driver.FindElement(By.XPath("//fieldset[1]/div/descendant::*[@id='car-type-button']"));
        }
        
        public IWebElement SUV()
        {
            return driver.FindElement(By.XPath("//*[@id='ui-id-4']"));
        }
        

        //Automatic
        public IWebElement TransAutomatic()
        {
            return driver.FindElement(By.XPath("//fieldset[1]/div/descendant::label[@for='transmission-automatic']"));
        }
        
        //Insurance
        public IWebElement Insurance()
        {
            return driver.FindElement(By.XPath("//fieldset[1]/div/descendant::label[@for='insurance']"));
        }
        

        //No of cars
        public IWebElement NoOfCars()
        {
            return driver.FindElement(By.XPath("//fieldset[1]/div/descendant::*[@id='horizontal-spinner']"));
        }
        
        //switch to fieldset2 elements
        //Truck

        public IWebElement Select()
        {
            return driver.FindElement(By.XPath("//fieldset[2]/div/descendant::*[@class='ui-selectmenu-text']"));
        }

        public IWebElement Truck()
        {
            return driver.FindElement(By.XPath("//*[@id='ui-id-14']"));
        }
        
        
        //Standard

        public IWebElement Standard()
        {
            return driver.FindElement(By.XPath("//fieldset[2]/div/descendant::label[@for='transmission-standard-v']"));
        }
        

        //Insurance

        public IWebElement InsuranceV()
        {
            return driver.FindElement(By.XPath("//fieldset[2]/div/descendant::label[@for='insurance-v']"));
        }
        

        //No of cars

        public IWebElement NoOfCarsV()
        {
            return driver.FindElement(By.XPath("//fieldset[2]/div/descendant::*[@id='vertical-spinner']"));
        }
       
        //Book Now 

        public IWebElement BookNow()
        {
            return driver.FindElement(By.XPath("//fieldset[2]/div/descendant::*[@id='book']"));
        }
    }
}
