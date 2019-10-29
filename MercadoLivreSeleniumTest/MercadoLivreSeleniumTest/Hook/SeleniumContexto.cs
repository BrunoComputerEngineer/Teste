using MercadoLivreSeleniumTest.Domain;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MercadoLivreSeleniumTest.Hook
{
    public class SeleniumContext : IDisposable
    {
        public IWebDriver WebDriver { get; private set; }

        private EnvironmentData environmentData = new EnvironmentData().GetEnvironmentData();

        public SeleniumContext()
        {
            //create the selenium context
            switch (environmentData.Browser)
            {
                case "GoogleChrome":
                    ChromeOptions options = new ChromeOptions();
                    options.AddArguments("--disable-infobars");
                    options.AddArguments("start-maximized");
                    string pathDriver = new DirectoryInfo(new System.Uri(Assembly.GetExecutingAssembly().CodeBase).AbsolutePath).Parent.Parent.Parent.FullName;
                    WebDriver = new ChromeDriver(pathDriver, options);
                    break;
                case "FireFox":
                    WebDriver = new FirefoxDriver();
                    break;
                case "InternetExplorer":
                    WebDriver = new InternetExplorerDriver();
                    break;
                default:
                    throw new NullReferenceException("The WebDriver browser wait instance was not initialized. You should first call the method Start.");
                    break;
            }

        }

        public void Dispose()
        {
            WebDriver?.Quit();
            WebDriver?.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
