using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace WebDriver1
{
    public class WebDriver
    {
        [Test]
        public void GoogleSearch()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://pastebin.com/");
            driver.Manage().Window.Maximize();

            IWebElement txtField = driver.FindElement(By.Name("PostForm[text]"));
            txtField.SendKeys("Hello from WebDriver");

            IWebElement txtFieldTitle = driver.FindElement(By.Name("PostForm[name]"));
            txtFieldTitle.SendKeys("helloweb");

            IWebElement txtPasteExpiration = driver.FindElement(By.XPath("//*[@id=\"select2-postform-expiration-container\"]"));
            txtPasteExpiration.Click();

            IWebElement option10Minutes = driver.FindElement(By.XPath("//li[contains(text(), '10 Minutes')]"));
            option10Minutes.Click();

            IWebElement btnCreate = driver.FindElement(By.XPath("//*[@id=\"w0\"]/div[5]/div[1]/div[10]/button\r\n"));
            btnCreate.Click();
        }
    }
}
