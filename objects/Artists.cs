using System.Collections.Generic;


namespace Artists.Objects
{
  public class Artist
  {
    private string _name;
    private int _id;
    // private List<CD> _cdList;
    private static List<Artist> listArtist = new List<Artist> {};

    public Artist(string artistName)
    {
      _name = artistName;
      listArtist.Add(this);
      _id = listArtist.Count;
      // _cdList = new List<CD>{};
    }

    public string GetArtistName()
    {
      return _name;
    }

    public int GetId()
    {
      return _id;
    }

    // public void AddCD(CD x)
    // {
    //   _cdList.Add(x);
    // }
    public static List<Artist> GetAll()
    {
      return listArtist;
    }

    
  }
}
