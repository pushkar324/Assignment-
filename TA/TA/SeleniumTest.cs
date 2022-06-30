using DemoAutomation.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;


namespace DemoAutomation
{
    /// <summary>
    /// Class created to run Selenium Tests
    /// </summary>
    public class SeleniumTest : Base           
    {

        //Droppable Test Case
        [Test]
        public void Test1()
        {
            Droppable drop1 = new Droppable();

            drop1.GetDroppable().Clicks();
            
            driver.SwitchTo().Frame(drop1.GetFrame());

            Actions actions = new Actions(driver);

            actions.ClickAndHold(drop1.ItemToDrag()).MoveToElement(drop1.Drop()).Release().Build().Perform();

        }

        //Selectable Test Case
        [Test]
        public void Test2()
        {

            Selectable select = new Selectable();

            select.GetSelectable().Clicks();

            driver.SwitchTo().Frame(select.GetFrame());

            select.GetItem1().Clicks();

            Actions actions = new Actions(driver);
            actions.KeyDown(Keys.Control).Build().Perform();

            select.GetItem3().Clicks();

            select.GetItem7().Clicks();

            
        }

        //ControlGroup Test Case
        [Test]
        public void Test3()
        {

            ControlGroup ctrl = new ControlGroup();

            ctrl.GetControlGroup().Clicks();

            driver.SwitchTo().Frame(ctrl.GetFrame());

            ctrl.GetCarType().Clicks();

            ctrl.SUV().Clicks();

            ctrl.TransAutomatic().Clicks();

            ctrl.Insurance().Clicks();

            ctrl.NoOfCars().EnterText("2");

            ctrl.Select().Clicks();

            ctrl.Truck().Clicks();

            ctrl.Standard().Clicks();

            ctrl.InsuranceV().Clicks();

            ctrl.NoOfCarsV().EnterText("1");

            ctrl.BookNow().Clicks();
            
        }
    }
    }
