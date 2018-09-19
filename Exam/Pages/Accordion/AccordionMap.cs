

namespace Exam.Pages.Accordion
{
    using OpenQA.Selenium;
    public partial class Accordion
    {
        public IWebElement AcordationClick => Driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[2]/aside[3]/div[2]/div[1]/ul[1]/li[1]/a[1]"));

        public IWebElement CustomizeIcons => Driver.FindElement(By.Id("ui-id-2"));

        public IWebElement Toggle => Driver.FindElement(By.Id("toggle"));

        public IWebElement Section1 => Driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/main[1]/article[1]/div[1]/div[1]/div[2]/div[1]/div[1]/h3[1]"));

        public IWebElement Section2 => Driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/main[1]/article[1]/div[1]/div[1]/div[2]/div[1]/div[1]/h3[2]"));

        public IWebElement Section3 => Driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/main[1]/article[1]/div[1]/div[1]/div[2]/div[1]/div[1]/h3[3]/span[1]"));

        public IWebElement Section4 => Driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/main[1]/article[1]/div[1]/div[1]/div[2]/div[1]/div[1]/h3[4]/span[1]"));

        public IWebElement Accordions => Driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/main[1]/article[1]/header[1]/h1[1]"));

        public IWebElement Arrow => Driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/main[1]/article[1]/div[1]/div[1]/div[2]/div[1]/div[1]/h3[1]/span[1]"));
    }
}
