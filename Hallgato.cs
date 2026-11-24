using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WPF_Adatkotes_StatikusEroforras
{
  public class Hallgató
  {
    public string Vezetéknév{ get; set;}
    public string Keresztnév { get; set; }
    public string EHA { get; set; }
    public string email { get; set; }
    public double GöngyölítettÁtlag { get; set; }

    public Hallgató(string VN, string KN, 
      string E, 
      string e, double GÁ)
    {
      Vezetéknév = VN;
      Keresztnév = KN;
      EHA = E;
      email = e;
      GöngyölítettÁtlag = GÁ;
    }

    public Hallgató() : this("Nagyon", "Okos", 
      "NAOKXXX.KEFO", "naok@net.hu", 3.24) { }
  }
}
