using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Threading;

namespace Sonic_Admin
{
    class FirstMile
    {
        [SetUp]
        public void Setup()
        {
            Login obj = new Login();
            obj.OpenChrome();
            obj.SignIn();
        }
        [Test]
        public void FM()
        {
            //Click on Side Bar
            IWebElement Menu = Properties.Driver.FindElement(By.XPath("//a[@id = 'sidebar_menu']"));
            Menu.Click();

            //Click on First Mile
            Properties.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            IWebElement FirstMile = Properties.Driver.FindElement(By.XPath("//i[@class= 'la la-cubes']/parent::span[contains(text(), 'First Mile')]"));
            FirstMile.Click();

            //Click on Pickups
            Properties.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            IWebElement PickUps = Properties.Driver.FindElement(By.XPath("//a[@href='#']/child::span[contains(@class, 'menu-title') and contains(text(), 'Pickups')]"));
            PickUps.Click();

            //Click on Individual Arrival
            Properties.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            IWebElement IndividualArrival = Properties.Driver.FindElement(By.XPath("//a[contains(@href, 'https://app.sonic.pk/admin/v2_pickups/arrival/individual') and contains(text(), 'Individual Arrival')]"));
            IndividualArrival.Click();

            //Input Tracking Number
            Properties.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            IWebElement TrackingNum = Properties.Driver.FindElement(By.XPath("//input[@placeholder= 'Tracking Number*']"));
            Database track = new Database();
            track.Tracking_Number();
            TrackingNum.Click();
            TrackingNum.SendKeys(track.num);

            //Input Weight
            Properties.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            IWebElement Weight = Properties.Driver.FindElement(By.XPath("//div[@class='form-group ']/child::input[contains(@name, 'weight') and contains(@placeholder, 'Weight (kg)*')]"));
            
            Weight.Click();
            Weight.SendKeys("5");

            //Click on Add
            Properties.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            IWebElement Add = Properties.Driver.FindElement(By.XPath("//button[@id = 'add']"));
            Add.Submit();

            //Click on Confirm
            WebDriverWait Wait = new WebDriverWait(Properties.Driver, TimeSpan.FromSeconds(60));
            Wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[@name = 'confirm']")));
            IWebElement Confirm = Properties.Driver.FindElement(By.XPath("//button[@name = 'confirm']"));
            Confirm.Submit();

            //click on rider Select DropDown
            IWebElement Rider = Properties.Driver.FindElement(By.XPath("//span[contains(@id, 'select2-rider_select-container') and contains(text(), 'Danish Zahid')]"));
            Rider.Click();

            //Selecting Rider
            IWebElement SelectRider = Properties.Driver.FindElement(By.XPath("//input[@class = 'select2-search__field']"));
            SelectRider.SendKeys("Ali Rider - Trax04877");

            //Selected Rider done
            IWebElement Ali = Properties.Driver.FindElement(By.XPath("//li[text() ='Ali Rider - Trax04877']"));
            Ali.Click();

            //Confirming rider
            IWebElement RiderConfirm = Properties.Driver.FindElement(By.XPath("//form[@id = 'rider_selection_form']/child::div[@class = 'form-group']/child::button[contains(text(), 'Confirm')]"));
            RiderConfirm.Submit();

            //Clicking on Yes
            IWebElement Yes = Properties.Driver.FindElement(By.XPath("//div[@class = 'swal-button-container']/child::button[contains(text(), 'Yes')]"));
            Yes.Submit();
        }

        [Test]
        public void DeliveryNote()
        {
            //Clicking on Side Bar
            Properties.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            IWebElement Menu = Properties.Driver.FindElement(By.XPath("//a[@id = 'sidebar_menu']"));
            Menu.Click();

            //Clicking on Last Mile
            Properties.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            IWebElement LastMile = Properties.Driver.FindElement(By.XPath("//i[@class= 'la la-motorcycle']/parent::span[contains(text(), 'Last Mile')]"));
            LastMile.Click();

            //Clicking on Delivery
            Properties.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            IWebElement Delivery = Properties.Driver.FindElement(By.XPath("//span[contains(text(), 'Delivery')]"));
            Delivery.Click();

            //Creating Delivery Note
            Properties.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            IWebElement CreateNote = Properties.Driver.FindElement(By.XPath("//a[@href = 'https://app.sonic.pk/admin/delivery/note']"));
            CreateNote.Click();

            //Select Category
            WebDriverWait w1 = new WebDriverWait(Properties.Driver, TimeSpan.FromSeconds(60));
            w1.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[contains(text(), 'Select Category*')]")));
            IWebElement Category = Properties.Driver.FindElement(By.XPath("//span[contains(text(), 'Select Category*')]"));
            Category.Click();

            WebDriverWait w2 = new WebDriverWait(Properties.Driver, TimeSpan.FromSeconds(60));
            w2.Until(ExpectedConditions.ElementIsVisible(By.XPath("//li[contains(text(), 'Hold In Operations')]")));
            IWebElement Categ = Properties.Driver.FindElement(By.XPath("//li[contains(text(), 'Hold In Operations')]"));
            Categ.Click();

            //Fake Click
            IWebElement Fake = Properties.Driver.FindElement(By.XPath("//h1[@class = 'mb-1']"));
            
            //Select Rider
            WebDriverWait w3 = new WebDriverWait(Properties.Driver, TimeSpan.FromSeconds(60));
            w3.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[contains(text(), 'Select Rider*')]")));
            IWebElement Rider = Properties.Driver.FindElement(By.XPath("//span[contains(text(), 'Select Rider*')]"));
            Rider.Click();

            Fake.Click();

            Properties.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
            Rider.Click();

            WebDriverWait w5 = new WebDriverWait(Properties.Driver, TimeSpan.FromSeconds(60));
            w5.Until(ExpectedConditions.ElementIsVisible(By.XPath("//li[contains(text(), 'Danish Danish - Trax03097 - Karachi')]")));
            IWebElement Ride = Properties.Driver.FindElement(By.XPath("//li[contains(text(), 'Danish Danish - Trax03097 - Karachi')]"));
            Ride.Click();

            //Select Route
            WebDriverWait w6 = new WebDriverWait(Properties.Driver, TimeSpan.FromSeconds(100));
            w6.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[contains(text(), 'Select Route*')]")));
            IWebElement Route = Properties.Driver.FindElement(By.XPath("//span[contains(text(), 'Select Route*')]"));
            Route.Click();

            Fake.Click();

            //WebDriverWait w7 = new WebDriverWait(Properties.Driver, TimeSpan.FromSeconds(100));
            //w7.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[contains(text(), 'Select Route*')]")));
            //Actions doubleclick3 = new Actions(Properties.Driver);
            //doubleclick3.DoubleClick(Route).Perform();

            Properties.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
            Route.Click();

            WebDriverWait w8 = new WebDriverWait(Properties.Driver, TimeSpan.FromSeconds(60));
            w8.Until(ExpectedConditions.ElementIsVisible(By.XPath("//li[contains(text(), 'COMPLETE PECHS AND DHA HEAVY PICKUP AND HEAVY DELIVERIES - (TRAX Office  to  DHA)')]")));
            IWebElement RouteSelect = Properties.Driver.FindElement(By.XPath("//li[contains(text(), 'COMPLETE PECHS AND DHA HEAVY PICKUP AND HEAVY DELIVERIES - (TRAX Office  to  DHA)')]"));
            RouteSelect.Click();

            //Enter Tracking Num
            WebDriverWait w9 = new WebDriverWait(Properties.Driver, TimeSpan.FromSeconds(60));
            w9.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@id = 'scan_tracking']")));
            IWebElement TrackingNum = Properties.Driver.FindElement(By.XPath("//input[@id = 'scan_tracking']"));
            Database TrackDN = new Database();
            TrackDN.Tracking_Number();
            TrackingNum.Click();
            Properties.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
            TrackingNum.SendKeys(TrackDN.num);

            //Submit Delivery Note
            IWebElement Submit = Properties.Driver.FindElement(By.XPath("//button[@id = 'deliveryNoteSubmitBtn']"));
            Properties.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
            IJavaScriptExecutor js = (IJavaScriptExecutor)Properties.Driver;
            js.ExecuteScript("arguments[0].scrollIntoView();", Submit);
            Submit.Submit();

            //Yes
            Properties.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
            IWebElement Yes = Properties.Driver.FindElement(By.XPath("//button[text()= 'Yes']"));
            Yes.Submit();
        }

        [TearDown]
        public void close()
        {
            Console.WriteLine("Execution Completed");
        }
    }
}
