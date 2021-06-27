using Data.Sampler.MockData;
using NUnit.Framework;
using System.Threading;

namespace Selenium.Sampler.Tests
{
  [TestFixture]
  public sealed class RegisterForOneCourseTests : TestSetup
  {
    [Test]
    public void CreateSingleRegistrationTest()
    {
      var course = MockCourseRegister.CreateCourseRegister();

      DriverSetup.FindById("fname").FillWithText(course.FullName);
      DriverSetup.FindById("email").FillWithText(course.Email);
      DriverSetup.FindById("phone").FillWithText(course.PhoneNumber);
      DriverSetup.SelectById("courseSelector").SelectOptionByValue(course.CourseType);
      DriverSetup.FindById("createbtn").Click();
      Thread.Sleep(2000);
    }
  }
}