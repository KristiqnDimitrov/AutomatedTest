namespace Exam.Pages.AutomateThePlanet
{
    using OpenQA.Selenium;
    public partial class AutomateThePlanet : BasePage
    {
        public AutomateThePlanet(IWebDriver driver) : base(driver)
        {

        }
       
        public void PrivateNavigateTo()
        {
            this.Driver.Navigate().GoToUrl("https://docs.microsoft.com/en-us/dotnet/csharp/");
            DotNetCoreGuide.Click();
            Docker.Click();
            Introduction.Click();           
        }

    }
}
