
namespace Exam.Pages.Accordion
{
    using OpenQA.Selenium;
    public partial class Accordion : BasePage
    {
        public Accordion(IWebDriver driver) : base(driver)
        {

        }
        public void OpenCustomizeIcon()
        {
            AcordationClick.Click();
            CustomizeIcons.Click();
            Toggle.Click();

        }
    }
}
