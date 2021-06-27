using NUnit.Framework;
using Selenium.Sampler.Controllers;
using Web.Sampler;

namespace Selenium.Sampler
{
  [SetUpFixture]
  public abstract class TestSetup
  {
    protected SessionController Session = new SessionController();

    [OneTimeSetUp]
    public void OneTimeConfiguration() => Session.InitilizeBrowser().Visit(FileSettings.GetHtmlFileFroAssemblyFolder("RegistrationForm"));

    [OneTimeTearDown]
    public void OneTimeDeconstruct() => Session.DisposeBrowser();
  }
}