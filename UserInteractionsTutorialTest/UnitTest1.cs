using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace UserInteractionsTutorialTest
{
    [TestFixture]
    public class InteractionsDemo
    {
        [Test]
        public void Example1()
        {
            var driver = new FirefoxDriver();
            var actions =new Actions(driver);
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(6));


            driver.Navigate().GoToUrl("http://jqueryui.com/droppable/");
            wait.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt(By.ClassName("demo-frame")));
            IWebElement targetElement = driver.FindElement(By.Id("droppable")); 
            IWebElement sourceElement = driver.FindElement(By.Id("draggable"));
            actions.DragAndDrop(sourceElement, targetElement).Perform();

            Assert.AreEqual("Dropped!", targetElement.Text);

        }

        
        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}