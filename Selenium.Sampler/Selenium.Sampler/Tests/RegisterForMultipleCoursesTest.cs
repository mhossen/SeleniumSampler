using Data.Sampler.MockData;
using Data.Sampler.Models;
using NUnit.Framework;
using System.Threading;

namespace Selenium.Sampler.Tests
{
  [TestFixture]
  public sealed class RegisterForMultipleCoursesTest : TestSetup
  {
    [TestCaseSource(typeof(MockCourseRegister), nameof(MockCourseRegister.RegisterCourses))]
    public void RegisterMultipleUserCourseTest(CourseRegister course)
    {
      DriverSetup.FindById("fname").FillWithText(course.FullName);
      DriverSetup.FindById("email").FillWithText(course.Email);
      DriverSetup.FindById("phone").FillWithText(course.PhoneNumber);
      DriverSetup.SelectById("courseSelector").SelectOptionByValue(course.CourseType);
      DriverSetup.FindById("createbtn").Click();
    }
  }
}