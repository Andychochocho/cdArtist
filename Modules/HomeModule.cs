using Nancy;
using Artists.Objects;
using CDs.Objects;
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

     Get["/add_cd/{id}"] = parameters =>
     {
       Dictionary<string, object> y = new Dictionary<string, object> ();
       var selectedArtist = Artist.Find(parameters.id);
       var artistCD = selectedArtist.GetCDS();
       y.Add("selectedArtist",selectedArtist);
       y.Add("cdList",artistCD);
       return View["add_cd.cshtml", y];
     };

    //  Post["/add_cd/{id}/new"] = parameters =>
    //  {
    //    Dictionary<string, object> y = new Dictionary<string, object> ();
    //    var selectedArtist = Artist.Find(parameters.id);
    //    var allCDS = selectedArtist.GetCDS();
    //    y.Add("selectedArtist",selectedArtist);
    //    y.Add("cdList",selectedArtist);
    //    return View["add_cd.cshtml", y];
    //  };

     Post["/add_cd/{id}/new"] = parameters =>
     {
      Dictionary<string, object> y = new Dictionary<string, object> ();
      var selectedArtist = Artist.Find(parameters.id);
      List<CD> artistCD = selectedArtist.GetCDS();

      var newCd = new CD(Request.Form["cdInput"]);

      selectedArtist.Save(newCd);

      y.Add("Artist", selectedArtist);
      y.Add("cdList", artistCD);
      return View["add_cd.cshtml", y];
     };
   }
  }
}
