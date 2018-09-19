
namespace Exam.Pages.SortablePage
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Interactions;

    public partial class SortablePage : BasePage
    {
        private IWebDriver _driver;

        public SortablePage(IWebDriver driver) : base(driver)
        {
            this._driver = driver;
        }

        public void DragAndDropItemToOffset(IWebElement element, int xOffset, int yOffset)
        {
            Actions action = new Actions(_driver);
            action.DragAndDropToOffset(element, xOffset, yOffset);
            action.Build().Perform();
        }
    }
}
