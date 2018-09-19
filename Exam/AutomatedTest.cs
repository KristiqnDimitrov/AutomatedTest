
namespace Exam
{
    using FluentAssertions;
    using global::Exam.Pages;
    using global::Exam.Pages.Accordion;
    using global::Exam.Pages.AutomateThePlanet;
    using global::Exam.Pages.Draggable;
    using global::Exam.Pages.Droppable;
    using global::Exam.Pages.Factories;
    using global::Exam.Pages.IndexPage;
    using global::Exam.Pages.Models;
    using global::Exam.Pages.RegistrationPage;
    using global::Exam.Pages.SortablePage;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Interactions;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Threading;

    [TestFixture]

    public class AutomatedTest
    {
        private AutomateThePlanet _automateThePlanet;
        private BasePage _basePage;
        private Accordion _accordion;
        private Slider _slider;
        private IWebDriver _driver;
        private Draggable _draggable;
        private Droppable _droppable;
        private RegistrationPage _regPage;
        private RegistrationUser _user;
        private SortablePage _sortPage;

        [SetUp] 
        public void SetUp()
        {
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            _basePage = new BasePage(_driver);
            _slider = new Slider(_driver);
            _accordion = new Accordion(_driver);
            _automateThePlanet= new AutomateThePlanet(_driver);
            _driver.Manage().Window.Maximize();
            _draggable = new Draggable(_driver);
            _droppable = new Droppable(_driver);
            _user = UserFactory.GenerateRegUser();
            _regPage = new RegistrationPage(_driver);
            _sortPage = new SortablePage(_driver);

        }
        [TearDown] 
        public void TearDown()
        {
            _driver.Quit();
        }
        [Test]
        public void DropToTargetTest()
        {
            _basePage.NavigateTo();

            _droppable.DropToTarget();
            string classBefore = _droppable.Target.GetAttribute("class");
            Actions builder = new Actions(_driver);
            builder.DragAndDrop(_droppable.Source, _droppable.Target).Perform();
            string classAfter = _droppable.Target.GetAttribute("class");


            Assert.AreNotEqual(classBefore, classAfter);

        }
        [Test]
        public void Drag() // !!!!!!!!!!!!!!!
        {
            _basePage.NavigateTo();

            _draggable.DragArrownd();

           

        }
        [Test] // !!!!!!!!!!!   
        public void Sliders()
        {
            _basePage.NavigateTo();

            _slider.SlideToRight();
            _slider.SlideObjectToTarget();

           // StringAssert.Contains("2", _slider.ValueCheck.Text);
        }

        [Test]
        public void ArrowCheck()
        {
            _basePage.NavigateTo();

            _accordion.OpenCustomizeIcon();
            Assert.IsNotNull(_accordion.Arrow.Displayed);
        }
        [Test]
        public void ArrowSection1()
        {
            _basePage.NavigateTo();

            _accordion.OpenCustomizeIcon();
            _accordion.Section1.Click();
            Assert.IsTrue(_accordion.Accordions.Displayed);
            StringAssert.Contains("Section 1", _accordion.Section1.Text);

        }
        [Test]
        public void DisplayedSection1()
        {
            _basePage.NavigateTo();

            _accordion.OpenCustomizeIcon();
            _accordion.Section1.Click();

            StringAssert.Contains("Section 1", _accordion.Section1.Text);

        }
        [Test]
        public void DisplayedSection2()
        {
            _basePage.NavigateTo();

            _accordion.OpenCustomizeIcon();
            _accordion.Section2.Click();

            StringAssert.Contains("Section 2", _accordion.Section2.Text);

        }
        [Test]
        public void DisplayedSection3()
        {
            _basePage.NavigateTo();

            _accordion.OpenCustomizeIcon();
            _accordion.Section3.Click();

            StringAssert.Contains("Section 3", _accordion.Section3.Text);

        }
        [Test]
        public void DisplayedSection4()
        {
            _basePage.NavigateTo();

            _accordion.OpenCustomizeIcon();
            _accordion.Section4.Click();

            StringAssert.Contains("Section 4", _accordion.Section4.Text);

        }
        [Test]
        public void PackagingYourApps()
        {
            _automateThePlanet.PrivateNavigateTo();
            
            _automateThePlanet.ScenarioBasedNavigate.Click();
            
            Assert.IsTrue(_automateThePlanet.DockerPackaging.Displayed);
            StringAssert.Contains("Docker: Packaging your apps to deploy and run anywhere", _automateThePlanet.DockerPackaging.Text);

        }
        [Test]
        public void ScenarioBased()
        {
            _automateThePlanet.PrivateNavigateTo();
            
            _automateThePlanet.ScenarioBasedNavigate.Click();

            Assert.IsTrue(_automateThePlanet.ScenarioBasedDisplayed.Displayed);
            StringAssert.Contains("Scenario based guidance", _automateThePlanet.ScenarioBasedDisplayed.Text);

        }
        [Test]
        public void ExploringTheRich()
        {
            _automateThePlanet.PrivateNavigateTo();

            _automateThePlanet.ExploringTheRichDockerNavigate.Click();

            Assert.IsTrue(_automateThePlanet.ExploringTheRichDockerDisplayed.Displayed);
            StringAssert.Contains("Exploring the rich Docker development ecosystem", _automateThePlanet.ExploringTheRichDockerDisplayed.Text);

        }
        [Test]
        public void NextSteps()
        {
            _automateThePlanet.PrivateNavigateTo();
            
            _automateThePlanet.NextStepsNavigate.Click();

            Assert.IsTrue(_automateThePlanet.NextStepsDisplayed.Displayed);
            StringAssert.Contains("Next steps", _automateThePlanet.NextStepsDisplayed.Text);

        }

        [Test]
        public void RegistrationWithValidData()
        {
            _regPage.NavigateTo();
            _user.Email = _regPage.RandomString(10) + "@dsds.ds";
            _user.UserName = _regPage.RandomString(10);
            _regPage.FillRegistrationForm(_user);

            var logs = _driver.Manage().Logs.GetLog(LogType.Browser);

            //FluentAssertions
            _regPage.ThankyouMessage.Displayed.Should().BeTrue();
            _regPage.ThankyouMessage.Text.Should().Contain("Thank you");
        }

        [Test]
        public void RegistrationWithExistingUserEmail()
        {
            _regPage.NavigateTo();
            _user.UserName = _regPage.RandomString(10);
            _regPage.FillRegistrationForm(_user);

            //FluentAssertions
            _regPage.ThankyouMessage.Displayed.Should().BeTrue();
            _regPage.ThankyouMessage.Text.Should().Contain("E-mail address already exists");
        }

        [Test]
        public void RegistrationWithExistingUserName()
        {
            _regPage.NavigateTo();
            _regPage.FillRegistrationForm(_user);

            //FluentAssertions
            _regPage.ErrorMessage.Displayed.Should().BeTrue();
            _regPage.ErrorMessage.Text.Should().Be("Error: Username already exists");
        }

        [Test]
        [TestCase("", "")]
        [TestCase("something", "")]
        public void RegistrateWithNoName(string firstName, string lastName)
        {
            _regPage.NavigateTo();
            _user.FirstName = firstName;
            _user.LastName = lastName;
            _regPage.FillRegistrationForm(_user);

            //FluentAssertions
            _regPage.NameError.Displayed.Should().BeTrue();
            _regPage.NameError.Text.Should().Be("* This field is required");
        }

        [Test]
        public void RegistrateWithNoHobbies()
        {
            _regPage.NavigateTo();
            _user.Hobbies = new List<bool> { false, false, false };
            _regPage.FillRegistrationForm(_user);

            Assert.IsTrue(_regPage.HobbiesError.Displayed);
            Assert.AreEqual("* This field is required", _regPage.HobbiesError.Text);
        }

        [Test]
        [TestCase("")]
        public void RegistrateWithNoPhone(string phone)
        {
            _regPage.NavigateTo();
            _user.Phone = phone;
            _regPage.FillRegistrationForm(_user);

            Assert.IsTrue(_regPage.PhoneError.Displayed);
            Assert.AreEqual("* This field is required", _regPage.PhoneError.Text);
        }

        [Test]
        public void RegistrateWithPhoneLowerThan10()
        {
            _regPage.NavigateTo();
            _user.Phone = "1234";
            _regPage.FillRegistrationForm(_user);

            Assert.IsTrue(_regPage.PhoneError.Displayed);
            Assert.AreEqual("* Minimum 10 Digits starting with Country Code", _regPage.PhoneError.Text);
        }

        public void RegistrateWithNoUserName()
        {
            _regPage.NavigateTo();
            _user.UserName = "";
            _regPage.FillRegistrationForm(_user);

            Assert.IsTrue(_regPage.UserNameError.Displayed);
            Assert.AreEqual("* This field is required", _regPage.UserNameError.Text);
        }

        public void RegistrateWithNoEmail()
        {
            _regPage.NavigateTo();
            _user.Email = "";
            _regPage.FillRegistrationForm(_user);

            Assert.IsTrue(_regPage.EmailError.Displayed);
            Assert.AreEqual("* This field is required", _regPage.EmailError.Text);
        }

        [Test]
        [TestCase("aaaa@aaaaaaa")]
        [TestCase("aaaaaaaaaaa")]
        [TestCase("aaaa@aaaaaaa@aaa.aaa")]

        public void RegistrateWithInvalidEmail(string email)
        {
            _regPage.NavigateTo();
            _user.Email = email;
            _regPage.FillRegistrationForm(_user);

            Assert.IsTrue(_regPage.EmailError.Displayed);
            Assert.AreEqual("* Invalid email address", _regPage.EmailError.Text);
        }

        [Test]
        public void RegistrateWithNoPassword()
        {

            _regPage.NavigateTo();
            _user.Password = "";
            _regPage.FillRegistrationForm(_user);

            Assert.IsTrue(_regPage.PassError.Displayed);
            Assert.AreEqual("* This field is required", _regPage.PassError.Text);
        }

        [Test]
        public void RegistrateWithPasswordLowerThan8Characters()
        {
            _regPage.NavigateTo();
            _user.Password = "1234";
            _regPage.FillRegistrationForm(_user);

            Assert.IsTrue(_regPage.PassError.Displayed);
            Assert.AreEqual("* Minimum 8 characters required", _regPage.PassError.Text);
        }

        [Test]
        public void RegistrateWithNoConfirmPassword()
        {
            _regPage.NavigateTo();
            _user.ConfirmPassword = "";
            _regPage.FillRegistrationForm(_user);

            Assert.IsTrue(_regPage.ConfirmPassError.Displayed);
            Assert.AreEqual("* This field is required", _regPage.ConfirmPassError.Text);
        }

        [Test]
        public void RegistrateWithDifferentConfirmationPassword()
        {
            _regPage.NavigateTo();
            _user.ConfirmPassword = "different";
            _regPage.FillRegistrationForm(_user);

            Assert.IsTrue(_regPage.ConfirmPassError.Displayed);
            Assert.AreEqual("* Fields do not match", _regPage.ConfirmPassError.Text);
        }
        [Test]
        public void SortableTest()
        {
            _sortPage.NavigateTo();

            _sortPage.DragAndDropItemToOffset(_sortPage.Select1,
            50, 100);

            Thread.Sleep(2000);

            Assert.AreEqual("Item 1", _sortPage.Select4.Text);
        }

        [Test]
        public void SortItemsBack()
        {
            _sortPage.NavigateTo();


            Thread.Sleep(1000);

            List<IWebElement> sortPageElements = new List<IWebElement>(){
                _sortPage.Select1,
                _sortPage.Select2,
                _sortPage.Select3,
                _sortPage.Select4,
                _sortPage.Select5,
                _sortPage.Select6,
                _sortPage.Select7
            };

            _sortPage.DragAndDropItemToOffset(_sortPage.Select1,
     50, 100);


            sortPageElements.OrderBy(x => x.Text).ToList();

            foreach (IWebElement element in sortPageElements)
            {
                Console.WriteLine(element.Text);
            }

            Thread.Sleep(2000);

            // Assert.AreEqual("Item 1", _sortPage.Select1.Text);
        }
    }
}
