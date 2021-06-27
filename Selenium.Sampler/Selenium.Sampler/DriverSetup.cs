using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace Selenium.Sampler
{
  public class DriverSetup
  {
    public IWebDriver Driver { get; private set; }
    public IWebElement Element { get; private set; }
    public SelectElement Select { get; private set; }

    public DriverSetup InitilizeBrowser()
    {
      if (Driver is null)
      {
        Driver = new ChromeDriver();
      }

      Driver.Manage().Window.Maximize();
      Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

      return this;
    }

    public DriverSetup Visit(string url)
    {
      Driver.Navigate().GoToUrl(url);
      return this;
    }

    public DriverSetup FindById(string id)
    {
      Element = Driver.FindElement(By.Id(id));
      return this;
    }

    public DriverSetup FillWithText(string text)
    {
      Element.SendKeys(text);
      return this;
    }

    public DriverSetup SelectById(string id)
    {
      Select = new SelectElement(this.FindById(id).Element);
      return this;
    }

    public DriverSetup SelectOptionByValue(string value)
    {
      Select.SelectByValue(value);
      return this;
    }

    public DriverSetup Click()
    {
      Thread.Sleep(350);
      Element.Click();
      return this;
    }

    public void DisposeBrowser() => Driver?.Quit();
  }
}