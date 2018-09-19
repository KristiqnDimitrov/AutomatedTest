namespace Exam.Pages.IndexPage
{
    using OpenQA.Selenium;


    public partial class Slider 
    {
        public IWebElement SliderNavigation => Driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[2]/aside[3]/div[2]/div[1]/ul[1]/li[5]/a[1]"));

        public IWebElement SliderFromDefault => Driver.FindElement(By.XPath("//*[@id='slider - range - max']/span"));

        public IWebElement SliderToDestination => Driver.FindElement(By.ClassName("ui-corner-all"));

        public IWebElement ValueCheck => Driver.FindElement(By.Id("amount1"));
    }
}
