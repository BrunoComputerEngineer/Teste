using MercadoLivreSeleniumTest.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MercadoLivreSeleniumTest.Utility
{
    public static class Utils
    {
        public static string UrlBase
        {
            get
            {
                return new EnvironmentData().GetEnvironmentData().UrlBase;
            }
        }

        public static void WaitForObjectNotBePresent(IWebElement element, WebDriverWait wait)
        {
            wait.Until<bool>((d) =>
            {
                try
                {
                    d.FindElement(By.Id(element.GetAttribute("Id")));
                    if (!element.Displayed && element.Size.IsEmpty)
                    {
                        return true;
                    }
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return true;
                }
                catch (ElementNotVisibleException)
                {
                    return true;
                }
                catch (StaleElementReferenceException)
                {
                    return true;
                }
                catch (TargetInvocationException)
                {
                    return true;
                }
            });
        }

        public static void WaitForObjectNotBePresentByName(IWebElement element, WebDriverWait wait)
        {
            wait.Until<bool>((d) =>
            {
                try
                {
                    d.FindElement(By.Id(element.GetAttribute("Name")));
                    if (!element.Displayed && element.Size.IsEmpty)
                    {
                        return true;
                    }
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return true;
                }
                catch (ElementNotVisibleException)
                {
                    return true;
                }
                catch (StaleElementReferenceException)
                {
                    return true;
                }
                catch (TargetInvocationException)
                {
                    return true;
                }
            });
        }

        public static void WaitForCheckBoxBeSelected(IWebElement element, WebDriverWait wait)
        {
            wait.Until<bool>((d) =>
            {
                try
                {
                    d.FindElement(By.Id(element.GetAttribute("Id")));
                    if (element.Selected && element.Displayed)
                    {
                        return true;
                    }
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return true;
                }
                catch (ElementNotVisibleException)
                {
                    return true;
                }
                catch (StaleElementReferenceException)
                {
                    return true;
                }
                catch (TargetInvocationException)
                {
                    return true;
                }
            });
        }

        public static void WaitForCheckBoxNotBeSelected(IWebElement element, WebDriverWait wait)
        {
            wait.Until<bool>((d) =>
            {
                try
                {
                    d.FindElement(By.Id(element.GetAttribute("Id")));
                    if (!element.Selected && element.Displayed)
                    {
                        return true;
                    }
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return true;
                }
                catch (ElementNotVisibleException)
                {
                    return true;
                }
                catch (StaleElementReferenceException)
                {
                    return true;
                }
                catch (TargetInvocationException)
                {
                    return true;
                }
            });
        }

        public static void XWaitForObjectNotBePresent(IWebElement element, WebDriverWait wait)
        {
            wait.Until<bool>((d) =>
            {
                try
                {
                    if (!element.Displayed && element.Size.IsEmpty)
                    {
                        return true;
                    }
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return true;
                }
                catch (ElementNotVisibleException)
                {
                    return true;
                }
                catch (StaleElementReferenceException)
                {
                    return true;
                }
                catch (TargetInvocationException)
                {
                    return true;
                }
            });
        }
        public static string ApenasNumeros(string str)
        {
            var apenasDigitos = new Regex(@"[^\d]");
            return apenasDigitos.Replace(str, "");
        }
        public static void WaitForTextNotBePresentInLabel(IWebElement label, string text, WebDriverWait wait)
        {
            wait.Until<bool>((d) =>
            {
                try
                {
                    if (!label.Text.Contains(text))
                    {
                        return true;
                    }
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
                catch (ElementNotVisibleException)
                {
                    return false;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (TargetInvocationException)
                {
                    return false;
                }
            });
        }

        public static void WaitForTextBePresentInLabel(IWebElement label, string text, WebDriverWait wait)
        {
            wait.Until<bool>((d) =>
            {
                try
                {
                    if (label.Text.Contains(text))
                    {
                        return true;
                    }
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
                catch (ElementNotVisibleException)
                {
                    return false;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (TargetInvocationException)
                {
                    return false;
                }
            });
        }

        public static string XWaitForTextInTextBoxBeEqual(IWebElement textBox, string value, WebDriverWait wait)
        {

            wait.Until<bool>((d) =>
            {
                try
                {
                    if (textBox.GetAttribute("value") == value)
                    {
                        return true;
                    }
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
                catch (ElementNotVisibleException)
                {
                    return false;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (TargetInvocationException)
                {
                    return false;
                }
            });
            return "true";
        }

        public static bool XBooolWaitForTextInTextBoxBeEqual(IWebElement textBox, string value, WebDriverWait wait)
        {

            wait.Until<bool>((d) =>
            {
                try
                {
                    if (textBox.GetAttribute("value") == value)
                    {
                        return true;
                    }
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
                catch (ElementNotVisibleException)
                {
                    return false;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (TargetInvocationException)
                {
                    return false;
                }
            });
            return true;
        }

        public static void WaitForTextInTextBoxBeEqual(IWebElement textBox, string value, WebDriverWait wait)
        {
            wait.Until<bool>((d) =>
            {
                try
                {
                    if (textBox.GetAttribute("value") == value)
                    {
                        return true;
                    }
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
                catch (ElementNotVisibleException)
                {
                    return false;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (TargetInvocationException)
                {
                    return false;
                }
            });
        }

        public static void WaitForObjectBePresentAndNotEnabled(IWebElement element, WebDriverWait wait)
        {
            wait.Until<bool>((d) =>
            {
                try
                {
                    d.FindElement(By.Id(element.GetAttribute("Id")));
                    if (element.Displayed && !element.Enabled && !element.Size.IsEmpty)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
                catch (ElementNotVisibleException)
                {
                    return false;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (TargetInvocationException)
                {
                    return false;
                }
            });
        }

        public static void WaitForObjectBePresentAndEnabled(IWebElement element, WebDriverWait wait)
        {
            wait.Until<bool>((d) =>
            {
                try
                {
                    d.FindElement(By.Id(element.GetAttribute("Id")));
                    if (element.Displayed && element.Enabled && !element.Size.IsEmpty)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
                catch (ElementNotVisibleException)
                {
                    return false;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (TargetInvocationException)
                {
                    return false;
                }
            });
        }
        public static void BackSpace(IWebElement elememt)
        {

            string x = elememt.GetAttribute("value");

            while (x != "")
            {
                elememt.SendKeys(Keys.Backspace);
                x = elememt.GetAttribute("value");
            }
            elememt.SendKeys("0");
            elememt.SendKeys(Keys.Enter);
        }

        public static void XWaitForObjectBePresentAndEnabled(IWebElement element, WebDriverWait wait)
        {
            wait.Until<bool>((d) =>
            {
                try
                {
                    if (element.Displayed && element.Enabled && !element.Size.IsEmpty)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
                catch (ElementNotVisibleException)
                {
                    return false;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (TargetInvocationException)
                {
                    return false;
                }
            });
        }

        public static void WaitForObjectBePresentAndEnabledByName(IWebElement element, WebDriverWait wait)
        {
            wait.Until<bool>((d) =>
            {
                try
                {
                    d.FindElement(By.Name(element.GetAttribute("Name")));
                    if (element.Displayed && element.Enabled && !element.Size.IsEmpty)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
                catch (ElementNotVisibleException)
                {
                    return false;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (TargetInvocationException)
                {
                    return false;
                }
            });
        }

        public static IWebElement SetAttribute(this IWebElement element, string name, string value)
        {
            var driver = ((IWrapsDriver)element).WrappedDriver;
            var jsExecutor = (IJavaScriptExecutor)driver;
            jsExecutor.ExecuteScript("arguments[0].setAttribute(arguments[1], arguments[2]);", element, name, value);

            return element;
        }

        public static void XWaitForObjectBePresent(IWebElement element, WebDriverWait wait)
        {
            wait.Until<bool>((d) =>
            {
                try
                {
                    if (element.Displayed && !element.Size.IsEmpty)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
                catch (ElementNotVisibleException)
                {
                    return false;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (TargetInvocationException)
                {
                    return false;
                }
            });
        }

        public static void MoveToElementXPath(IWebDriver driver, string idElement)
        {
            Actions actions = new Actions(driver);
            var Element = driver.FindElement(By.XPath(idElement));
            actions.MoveToElement(Element);
            actions.Perform();
        }

        public static void MoveToElementXPath(IWebDriver driver, IWebElement element)
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(element);
            actions.Perform();
        }




        public static void WaitForObjectBePresent(IWebElement element, WebDriverWait wait)
        {
            wait.Until<bool>((d) =>
            {
                try
                {
                    d.FindElement(By.Id(element.GetAttribute("Id")));
                    if (element.Displayed && !element.Size.IsEmpty)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
                catch (ElementNotVisibleException)
                {
                    return false;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (TargetInvocationException)
                {
                    return false;
                }
            });
        }

        public static void WaitForObjectBePresentByName(IWebElement element, WebDriverWait wait)
        {
            wait.Until<bool>((d) =>
            {
                try
                {
                    d.FindElement(By.Name(element.GetAttribute("Name")));
                    if (element.Displayed && !element.Size.IsEmpty)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
                catch (ElementNotVisibleException)
                {
                    return false;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (TargetInvocationException)
                {
                    return false;
                }
            });
        }

        public static void WaitForObjectBeVisible(IWebElement element, WebDriverWait wait)
        {

            wait.Until<bool>((d) =>
            {
                try
                {
                    if (element.Displayed)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
                catch (ElementNotVisibleException)
                {
                    return false;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (TargetInvocationException)
                {
                    return false;
                }
            });
        }

        public static void WaitForObjectNotBeVisible(IWebElement element, WebDriverWait wait)
        {
            wait.Until<bool>((d) =>
            {
                try
                {
                    if (element.Displayed)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                catch (NoSuchElementException)
                {
                    return true;
                }
                catch (ElementNotVisibleException)
                {
                    return true;
                }
                catch (StaleElementReferenceException)
                {
                    return true;
                }
                catch (TargetInvocationException)
                {
                    return true;
                }
            });
        }

        public static int GetNumberOfRowsOnGridThatContainsValue(IWebElement grid, string value, IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            int numberOfRows = 0;

            WaitForObjectBePresentAndEnabled(grid, wait);
            IReadOnlyCollection<IWebElement> gridRows = grid.FindElements(By.TagName("tr"));

            foreach (var row in gridRows)
            {
                if (row.Text.Contains(value))
                {
                    numberOfRows++;
                }
            }

            return numberOfRows;
        }

        public static int XGetNumberOfRowsOnGridThatContainsValue(IWebElement grid, string value, IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            int numberOfRows = 0;

            XWaitForObjectBePresentAndEnabled(grid, wait);
            IReadOnlyCollection<IWebElement> gridRows = grid.FindElements(By.ClassName("_2PJVld"));

            foreach (var row in gridRows)
            {
                if (row.Text.Contains(value))
                {
                    numberOfRows++;
                }
            }

            return numberOfRows;
        }

        public static string ExtractNumbersFromString(string text)
        {
            string numbersText = String.Join("", System.Text.RegularExpressions.Regex.Split(text, @"[^\d]"));

            return numbersText;
        }

        public static int GetNumberOfRowsOnGridThatContainsValueByName(IWebElement grid, string value, IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            int numberOfRows = 0;

            WaitForObjectBePresentAndEnabledByName(grid, wait);
            IReadOnlyCollection<IWebElement> gridRows = grid.FindElements(By.ClassName("_2PJVld"));

            foreach (var row in gridRows)
            {
                if (row.Text.Contains(value))
                {
                    numberOfRows++;
                }
            }

            return numberOfRows;
        }

        public static IWebElement GetIdOfRowsOnGridThatContainsValueByName(IWebElement grid, string value, IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            int numberOfRows = 0;

            WaitForObjectBePresentAndEnabledByName(grid, wait);
            IReadOnlyCollection<IWebElement> gridRows = grid.FindElements(By.ClassName("_2PJVld"));
            IWebElement line = grid;
            foreach (var row in gridRows)
            {
                if (row.Text.Contains(value))
                {
                    numberOfRows++;

                    line = row;
                }
            }
            Assert.IsTrue(numberOfRows == 1);
            return line;
        }

        public static void WaitForWindowWithContainsTitleAndSwitchTo(string title, WebDriverWait wait)
        {
            wait.Until<bool>((d) =>
            {
                foreach (var handle in d.WindowHandles)
                {
                    d.SwitchTo().Window(handle);
                    if (d.Title.Contains(title))
                    {
                        return true;
                    }
                }
                return false;
            });
        }

        public static string GetConcatenatedTableRowsValue(IWebElement table, WebDriverWait wait)
        {
            WaitForObjectBePresentAndEnabled(table, wait);
            IReadOnlyCollection<IWebElement> tableRows = table.FindElements(By.TagName("tr"));
            StringBuilder concatenatedTableRows = new StringBuilder();

            foreach (var row in tableRows)
            {
                concatenatedTableRows.Append(row.Text);
            }

            return concatenatedTableRows.ToString();
        }

        public static void WaitForNumberOfWindowsOpenedBeEqual(int numberOfWindowsOpened, WebDriverWait wait)
        {
            wait.Until<bool>((d) =>
            {
                if (d.WindowHandles.Count == numberOfWindowsOpened)
                {
                    return true;
                }
                return false;
            });
        }

        public static void WaitForNumberOfSearchedItensOnGridBeEqual(int number, IWebElement gridResultLegend, WebDriverWait wait)
        {
            wait.Until<bool>((d) =>
            {
                try
                {
#pragma warning disable CS0618 // Type or member is obsolete
                    wait.Until(ExpectedConditions.ElementToBeClickable(gridResultLegend));
#pragma warning restore CS0618 // Type or member is obsolete
                    if (Regex.Replace(gridResultLegend.Text, @"[^0-9]+", "") == number.ToString())
                    {
                        return true;
                    }

                    return false;
                }
                catch (TargetInvocationException)
                {
                    return false;
                }
            });
        }

        public static bool VerifyIfObjectExists(IWebElement element, IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));

            try
            {
                wait.Until<bool>((d) =>
                {
                    try
                    {
                        d.FindElement(By.Id(element.GetAttribute("Id")));
                        if (element.Displayed && !element.Size.IsEmpty)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    catch (NoSuchElementException)
                    {
                        return false;
                    }
                    catch (ElementNotVisibleException)
                    {
                        return false;
                    }
                    catch (StaleElementReferenceException)
                    {
                        return false;
                    }
                    catch (TargetInvocationException)
                    {
                        return false;
                    }
                    catch (NullReferenceException)
                    {
                        return false;
                    }
                });
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }

            return true;
        }

        public static bool VerifyIfObjectExistsByName(IWebElement element, IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));

            try
            {
                wait.Until<bool>((d) =>
                {
                    try
                    {
                        d.FindElement(By.Name(element.GetAttribute("Name")));
                        if (element.Displayed && !element.Size.IsEmpty)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    catch (NoSuchElementException)
                    {
                        return false;
                    }
                    catch (ElementNotVisibleException)
                    {
                        return false;
                    }
                    catch (StaleElementReferenceException)
                    {
                        return false;
                    }
                    catch (TargetInvocationException)
                    {
                        return false;
                    }
                    catch (NullReferenceException)
                    {
                        return false;
                    }
                });
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }

            return true;
        }

        public static bool VerifyIfObjectExistsByClassName(IWebElement element, IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));

            try
            {
                wait.Until<bool>((d) =>
                {
                    try
                    {
                        d.FindElement(By.ClassName(element.GetAttribute("class")));
                        if (element.Displayed && !element.Size.IsEmpty)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    catch (NoSuchElementException)
                    {
                        return false;
                    }
                    catch (ElementNotVisibleException)
                    {
                        return false;
                    }
                    catch (StaleElementReferenceException)
                    {
                        return false;
                    }
                    catch (TargetInvocationException)
                    {
                        return false;
                    }
                    catch (NullReferenceException)
                    {
                        return false;
                    }
                });
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }

            return true;
        }

        public static bool XVerifyIfObjectExists(IWebElement element, IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));

            try
            {
                wait.Until<bool>((d) =>
                {
                    try
                    {
                        if (element.Displayed && !element.Size.IsEmpty)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    catch (NoSuchElementException)
                    {
                        return false;
                    }
                    catch (ElementNotVisibleException)
                    {
                        return false;
                    }
                    catch (StaleElementReferenceException)
                    {
                        return false;
                    }
                    catch (TargetInvocationException)
                    {
                        return false;
                    }
                    catch (NullReferenceException)
                    {
                        return false;
                    }
                });
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }

            return true;
        }

        public static void ForceClick(IWebElement element, WebDriverWait wait)
        {
            wait.Until<bool>((d) =>
            {
                try
                {
                    element.Click();
                    return true;

                }
                catch (NoSuchElementException)
                {
                    return false;
                }
                catch (ElementNotVisibleException)
                {
                    return false;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (TargetInvocationException)
                {
                    return false;
                }
            });
        }

        public static string ForceGetLabelText(IWebElement label, WebDriverWait wait)
        {
            string text = "";

            wait.Until<bool>((d) =>
            {
                try
                {
                    text = label.Text;
                    return true;

                }
                catch (NoSuchElementException)
                {
                    return false;
                }
                catch (ElementNotVisibleException)
                {
                    return false;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (TargetInvocationException)
                {
                    return false;
                }
            });

            return text;
        }

    }
}
