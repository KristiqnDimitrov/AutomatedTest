namespace Exam.Pages
{   
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;
    using System;

    public class BasePage
    {
        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get;  }

        public WebDriverWait Wait => new WebDriverWait(this.Driver, TimeSpan.FromSeconds(3));

        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl("http://demoqa.com/");
        }
    }
}
