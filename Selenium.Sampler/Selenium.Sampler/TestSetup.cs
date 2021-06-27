using NUnit.Framework;
using Web.Sampler;

namespace Selenium.Sampler
{
  [SetUpFixture]
  public abstract class TestSetup
  {
    protected DriverSetup DriverSetup = new DriverSetup();

    [OneTimeSetUp]
    public void OneTimeConfiguration() => DriverSetup.InitilizeBrowser().Visit(FileSettings.GetHtmlFileFroAssemblyFolder("RegistrationForm"));

    [OneTimeTearDown]
    public void OneTimeDeconstruct() => DriverSetup.DisposeBrowser();
  }
}