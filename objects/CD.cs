using System.Collections.Generic;
using Artists.Objects;

namespace CDs.Objects
{
  public class CD
    {
    private string _name;
    private int _id;
    private static List<CD> cdList = new List<CD> {};

    public CD(string cdName)
    {
    _name = cdName;
    cdList.Add(this);
    _id = cdList.Count;
    }

    public string GetName()
    {
      return _name;
    }

    public int GetID()
    {
      return _id;
    }

    public static List<CD> GetAllCd()
    {
      return cdList;
    }



    public static CD Find(int searchCD)
    {
      return cdList[searchCD -1];
    }

  }
}
