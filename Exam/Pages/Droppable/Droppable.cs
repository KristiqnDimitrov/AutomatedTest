

namespace Exam.Pages.Droppable
{
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Interactions;

    public partial class Droppable : BasePage
    {
        public Droppable(IWebDriver driver) : base(driver)
        {

        }
        public void DropToTarget()
        {
            DroppableButton.Click();

            

            
        }
        public void assertTarget()
        {
           
        }      
      
    }
}
