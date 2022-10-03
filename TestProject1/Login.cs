using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Sonic_Admin
{
    public class Login
    {
        public void OpenChrome()
        {
            Properties.Driver = new ChromeDriver();
            Properties.Driver.Navigate().GoToUrl("https://app.sonic.pk/admin/login");
            Properties.Driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        public void SignIn()
        {
            //Input Phone Num
            IWebElement PhoneNum = Properties.Driver.FindElement(By.XPath("//input[@id = 'phone_number']"));
            PhoneNum.Click();
            PhoneNum.SendKeys("03452163169");

            //Input Password
            IWebElement Password = Properties.Driver.FindElement(By.XPath("//input[@id = 'pin']"));
            Password.Click();
            Password.SendKeys("1234");

            //Click Login
            IWebElement Login = Properties.Driver.FindElement(By.XPath("//button[@id = 'login_button']"));
            Login.Submit();
        }
    }
}