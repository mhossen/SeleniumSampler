using Data.Sampler.Mock;
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
      var course = MockCourseRegistry.CreateCourseRegister();

      Session
        .FindById("fname").FillWithText(course.FullName)
        .FindById("email").FillWithText(course.Email)
        .FindById("phone").FillWithText(course.PhoneNumber)
        .SelectById("courseSelector").SelectOptionByValue(course.CourseType)
        .FindById("createbtn").Click();
      Thread.Sleep(2000);
    }
  }
}