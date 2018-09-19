namespace Exam.Pages.RegistrationPage
{
    using System.Collections.Generic;
    using System.Linq;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;

    public partial class RegistrationPage
    {
        public IWebElement HeaderMessage => _driver.FindElement(By.ClassName("entry-title"));
        public IWebElement FirstName => _driver.FindElement(By.Id("name_3_firstname"));
        public IWebElement LastName => _driver.FindElement(By.Id("name_3_lastname"));
        public List<IWebElement> MaritalStatus => _driver.FindElements(By.Name("radio_4[]")).ToList();
        //radio buttons
        public List<IWebElement> Hobbies => _driver.FindElements(By.Name("checkbox_5[]")).ToList();
        //drop-down
        public SelectElement Country => new SelectElement(_driver.FindElement(By.Id("dropdown_7")));
        public SelectElement MonthBirth => new SelectElement(_driver.FindElement(By.Id("mm_date_8")));
        public SelectElement DayBirth => new SelectElement(_driver.FindElement(By.Id("dd_date_8")));
        public SelectElement YearBirth => new SelectElement(_driver.FindElement(By.Id("yy_date_8")));
        public IWebElement Phone => _driver.FindElement(By.Id("phone_9"));

        public IWebElement Username => _driver.FindElement(By.Id("username"));
        public IWebElement Email => _driver.FindElement(By.Id("email_1"));
        //upload
        public IWebElement UploadPictureButton => _driver.FindElement(By.Id("profile_pic_10"));
        public IWebElement AboutYourself => Wait.Until<IWebElement>(d => d.FindElement(By.Id("description")));
        public IWebElement Password => _driver.FindElement(By.Id("password_2"));
        public IWebElement ConfirmPassword => _driver.FindElement(By.Id("confirm_password_password_2"));
        public IWebElement Submit => _driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[14]/div/input"));

        public IWebElement ThankyouMessage => Wait.Until<IWebElement>(d => d.FindElement(By.XPath("//*[@id=\"post-49\"]/div/p")));



        public IWebElement ErrorMessage => _driver.FindElement(By.ClassName("piereg_login_error"));
        public IWebElement NameError => _driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[1]/div[1]/div[2]/span"));
        public IWebElement HobbiesError => _driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[3]/div/div[2]/span"));
        public IWebElement PhoneError => _driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[6]/div/div/span"));
        public IWebElement UserNameError => _driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[7]/div/div/span"));
        public IWebElement EmailError => _driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[8]/div/div/span"));
        public IWebElement PassError => _driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[11]/div/div/span"));
        public IWebElement ConfirmPassError => _driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[12]/div/div/span"));

    }
}
