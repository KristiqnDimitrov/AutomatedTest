

using OpenQA.Selenium;

namespace Exam.Pages.Draggable
{
    public partial class Draggable
    {
        public IWebElement DraggableButton => Driver.FindElement(By.Id("menu-item-140"));

        public IWebElement DraggableObject => Driver.FindElement(By.Id("draggable")); 


    }
}
