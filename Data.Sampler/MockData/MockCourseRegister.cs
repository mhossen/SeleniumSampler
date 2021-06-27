using Data.Sampler.Enums;
using Data.Sampler.Models;
using Faker;
using FizzWare.NBuilder;
using System.Collections.Generic;

namespace Data.Sampler.MockData
{
  public class MockCourseRegister
  {
    public static CourseRegister CreateCourseRegister()
    {
      var register = Builder<CourseRegister>.CreateNew()
        .With(r => r.CourseType = Enum.Random<CourseType>().ToString().ToLower())
        .With(r => r.FullName = Name.FullName(NameFormats.Standard))
        .With(r => r.Email = Internet.Email(r.FullName))
        .With(r => r.PhoneNumber = string.Format("{0:###-###-####}", Phone.Number()))
        .Build();

      return register;
    }

    public static IEnumerable<CourseRegister> RegisterCourses()
    {
      var registers = Builder<CourseRegister>.CreateListOfSize(100)
        .All()
        .With(r => r.CourseType = Enum.Random<CourseType>().ToString().ToLower())
        .With(r => r.FullName = Name.FullName(NameFormats.Standard))
        .With(r => r.Email = Internet.Email(r.FullName))
        .With(r => r.PhoneNumber = string.Format("{0:###-###-####}", Phone.Number()))
        .Build();

      return registers;
    }
  }
}