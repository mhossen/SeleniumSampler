using Data.Sampler.Mock;
using Data.Sampler.Models;
using NUnit.Framework;

namespace Selenium.Sampler.Tests
{
  [TestFixture]
  public sealed class RegisterForMultipleCoursesTest : TestSetup
  {
    [TestCaseSource(typeof(MockCourseRegistry), nameof(MockCourseRegistry.RegisterCourses))]
    public void RegisterMultipleUserCourseTest(CourseRegister course)
    {
      Session
        .FindById("fname").FillWithText(course.FullName)
        .FindById("email").FillWithText(course.Email)
        .FindById("phone").FillWithText(course.PhoneNumber)
        .SelectById("courseSelector").SelectOptionByValue(course.CourseType)
        .FindById("createbtn").Click();
    }
  }
}