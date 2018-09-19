
namespace Exam.Pages.AutomateThePlanet
{
    using OpenQA.Selenium;
    public partial class AutomateThePlanet
    {
        public IWebElement DotNetCoreGuide => Driver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/nav[1]/div[1]/nav[1]/ul[1]/li[3]/a[1]"));

        public IWebElement Docker => Driver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/nav[1]/div[1]/nav[1]/ul[1]/li[3]/ul[1]/li[12]/a[1]"));

        public IWebElement Introduction => Driver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/nav[1]/div[1]/nav[1]/ul[1]/li[3]/ul[1]/li[12]/ul[1]/li[1]/a[1]"));

        public IWebElement PageIndicate => Driver.FindElement(By.Id("introduction-to-net-and-docker"));

        public IWebElement ScenarioBasedNavigate => Driver.FindElement(By.PartialLinkText("Scenario based guidance"));
        public IWebElement ExploringTheRichDockerNavigate => Driver.FindElement(By.PartialLinkText("Exploring the rich Docker development ecosystem"));
        public IWebElement NextStepsNavigate => Driver.FindElement(By.PartialLinkText("Next steps"));


        public IWebElement ScenarioBasedDisplayed => Driver.FindElement(By.Id("scenario-based-guidance"));
        public IWebElement ExploringTheRichDockerDisplayed => Driver.FindElement(By.Id("exploring-the-rich-docker-development-ecosystem"));
        public IWebElement NextStepsDisplayed => Driver.FindElement(By.Id("next-steps"));
        public IWebElement DockerPackaging => Driver.FindElement(By.Id("docker-packaging-your-apps-to-deploy-and-run-anywhere"));

    }
}
