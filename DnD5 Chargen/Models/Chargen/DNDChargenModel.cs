namespace DnD5_Chargen.Models.Chargen {
  using System.Collections.Generic;
  using Newtonsoft.Json;
  using System.IO;
  using Newtonsoft.Json.Serialization;
  using static Newtonsoft.Json.JsonConvert;
  using Newtonsoft.Json.Linq;
  using System.Linq;
  using System.Web.Hosting;

  public class DNDCharacterContainer {
  }

  public class Proficiency {
    public string Type { get; set; }
    public int Limit { get; set; }
    public List<string> Members { get; set; }
  }
}