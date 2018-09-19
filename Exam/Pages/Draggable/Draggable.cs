
namespace Exam.Pages.Draggable
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Interactions;

    public partial class Draggable : BasePage
    {
        public Draggable(IWebDriver driver) : base(driver)
        {

        }
        public void DragArrownd()
        {
            DraggableButton.Click();
            Actions action = new Actions(this.Driver);
            action.DragAndDropToOffset(this.DraggableObject, 25, 88);
            action.Perform();
        }

    }
}
