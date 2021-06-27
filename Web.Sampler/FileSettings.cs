using System.IO;
using System.Linq;

namespace Web.Sampler
{
  public class FileSettings
  {
    private static readonly string SampleHtmlPageLocation = Path.GetDirectoryName(typeof(FileSettings).Assembly.Location);

    public static string GetHtmlFileFroAssemblyFolder(string fileName)
    {
      return Directory.GetFiles(SampleHtmlPageLocation + @"\HtmlPages").FirstOrDefault(f => f.EndsWith($"{fileName}.html"));
    }
  }
}