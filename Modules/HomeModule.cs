using Nancy;
// Replace sample.objects
using SampleName.Objects;
using System.Collections.Generic;

// Replace namespace
namespace SampleName
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["Sample.cshtml"];
      };
    }
  }
}
