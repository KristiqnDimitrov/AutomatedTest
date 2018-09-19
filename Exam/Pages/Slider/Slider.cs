namespace Exam.Pages.IndexPage
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Interactions;
    
    public partial class Slider : BasePage 

    {
        public Slider(IWebDriver driver) : base(driver)
        {
               
        }
        public void SlideToRight()
        {
            SliderNavigation.Click();
           

        }
       public void SlideObjectToTarget()
       {
           Actions action = new Actions(this.Driver);
           action.MoveByOffset(22 , 31);
           action.Perform();
       
       }
       
      
       //Actions ac = new Actions(Driver);
       //ac.DragAndDrop(SliderFromDefault, SliderToDestination);
       //ac.Build().Perform();
       //public void DragObjectToTarget()
       //{
       //    Actions action = new Actions(this.Driver);
       //    action.DragAndDrop(this.SliderFromDefault, 11, 88);
       //    action.Perform();
       //
       //}
    }
}
