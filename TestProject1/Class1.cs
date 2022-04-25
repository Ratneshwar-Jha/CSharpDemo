using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace TestProject1
{
    public class Class1
    {
        IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            //new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            //driver = new ChromeDriver();

            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            driver = new EdgeDriver();
            driver.Manage().Window.Maximize();
            //Implicit wait
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            
        }
        [Test]
        public void Test1()
        {


            //driver.Url = "https://www.google.com/";
           driver.Url = "https://rahulshettyacademy.com/loginpagePractise/";

            TestContext.Progress.WriteLine("Title is " + driver.Title);
            TestContext.Progress.WriteLine("URL is " + driver.Url);

            driver.FindElement(By.Id("username")).SendKeys("rahulshetty");
            driver.FindElement(By.Name("password")).SendKeys("123456");
            driver.FindElement(By.XPath("//div[@class='form-group'][5]/label/span/input")).Click();
          
            
            

            driver.FindElement(By.XPath("//input[@id='signInBtn']")).Click();
            //Explicit wait
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(8));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.TextToBePresentInElementValue(driver.FindElement(By.XPath("//input[@id='signInBtn']")), "Sign In"));

            String ErrorMessage = driver.FindElement(By.ClassName("alert-danger")).Text;
            TestContext.Progress.WriteLine("Error Message is " + ErrorMessage);
            // TestContext.Progress.WriteLine("page Source is " + driver.PageSource);

            //String s = driver.PageSource;
            //driver.Close();
            //driver.Quit();

            string s1 = "Hello ";
            string s2 = s1;
            s1 += "World";

            System.Console.WriteLine(s2);
            //Output: Hello
        }
    }
}
