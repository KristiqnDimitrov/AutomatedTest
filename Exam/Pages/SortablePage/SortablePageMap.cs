
namespace Exam.Pages.SortablePage
{
    using OpenQA.Selenium;


    public partial class SortablePage
    {
        public IWebElement HeaderMessage => _driver.FindElement(By.ClassName("entry-title"));

        public IWebElement Select1 => _driver.FindElement(By.XPath(@"//*[@id=""sortable""]/li[1]"));

        public IWebElement Select2 => _driver.FindElement(By.XPath(@"//*[@id=""sortable""]/li[2]"));

        public IWebElement Select3 => _driver.FindElement(By.XPath(@"//*[@id=""sortable""]/li[3]"));

        public IWebElement Select4 => _driver.FindElement(By.XPath(@"//*[@id=""sortable""]/li[4]"));

        public IWebElement Select5 => _driver.FindElement(By.XPath(@"//*[@id=""sortable""]/li[5]"));

        public IWebElement Select6 => _driver.FindElement(By.XPath(@"//*[@id=""sortable""]/li[6]"));

        public IWebElement Select7 => _driver.FindElement(By.XPath(@"//*[@id=""sortable""]/li[7]"));
    }
}
