using Nancy;
using Artists.Objects;
using System.Collections.Generic;

// Replace namespace
namespace ArtistCD
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];

      Post["/viewArtist"] = _ => {
      Artist newArtist = new Artist(Request.Form["artistInput"]);
      List<Artist> listArtist = Artist.GetAll();
      return View["viewArtist.cshtml", listArtist];
     };
    }
  }
}
