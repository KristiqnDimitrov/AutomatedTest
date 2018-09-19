namespace Exam.Pages.Droppable
{
    using OpenQA.Selenium;

    public partial class Droppable
    {
        public IWebElement DroppableButton => Driver.FindElement(By.Id("menu-item-141"));

        public IWebElement Source => Driver.FindElement(By.Id("draggableview"));

        public IWebElement Target => Driver.FindElement(By.Id("droppableview"));
    }
}
