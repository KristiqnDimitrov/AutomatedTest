namespace Exam.Pages.RegistrationPage
{
    using System.Collections.Generic;
    using OpenQA.Selenium;
    using System;
    using System.Linq;
    using global::Exam.Pages.Models;

    public partial class RegistrationPage : BasePage
    {
        private IWebDriver _driver;

        public RegistrationPage(IWebDriver driver) : base(driver)
        {
            this._driver = driver;
        }

        public void FillRegistrationForm(RegistrationUser user)
        {

            SureType(this.FirstName, user.FirstName);
            SureType(this.LastName, user.LastName);

            FillManyOptionElements(this.MaritalStatus, user.MatrialStatus);
            FillManyOptionElements(this.Hobbies, user.Hobbies);

            this.Country.SelectByText(user.Country);

            this.MonthBirth.SelectByValue(user.Month);
            this.DayBirth.SelectByValue(user.Day);
            this.YearBirth.SelectByValue(user.Year);

            SureType(this.Phone, user.Phone);
            SureType(this.Username, user.UserName);
            SureType(Email, user.Email);

            UploadPictureButton.Click();
            Driver.SwitchTo().ActiveElement().SendKeys(user.PicturePath);


            SureType(this.AboutYourself, user.AboutYourself);
            SureType(this.Password, user.Password);
            SureType(this.ConfirmPassword, user.ConfirmPassword);
            Submit.Click();

        }

        private void SureType(IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }

        private void FillManyOptionElements(List<IWebElement> elements, List<bool> values)
        {
            for (int i = 0; i < elements.Count; i++)
            {
                if (values[i])
                {
                    elements[i].Click();
                }
            }
        }

        public static Random random = new Random();
        public string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
