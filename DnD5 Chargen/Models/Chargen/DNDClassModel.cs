using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DnD5_Chargen.Models.Chargen {

  public class DNDClassContainer {

    public List<DNDClass> ClassList { get; set; }

    public class DNDClass {
      public string Type { get; set; }
      [JsonProperty("hit-dice")]
      public HitDice HitDice { get; set; }
      public Rage Rage { get; set; }
//    public List<Proficiency> Proficiencies { get; set; }
      [JsonProperty("starting-equipment")]
      public List<StartingEquipment> StartingEquipment { get; set; }
      [JsonProperty("class-features")]
      public List<ClassFeature> ClassFeatures { get; set; }
      public List<Subclass> Subclasses { get; set; }
    }


    public class HitDice {
      [JsonProperty("dice-num")]
      public int DiceCount { get; set; }
      [JsonProperty("dice-size")]
      public int DiceSize { get; set; }
      [JsonProperty("hp-average")]
      public int HitPointAverage { get; set; }
    }

    public class Rage {
      [JsonProperty("starting-rages")]
      public int InitialRageCount { get; set; }
      [JsonProperty("rage-increase-levels")]
      public List<int> RageIncreaseLevels { get; set; }
      [JsonProperty("starting-rage-damage")]
      public int InitialRageDamage { get; set; }
      public List<int> RageDamageIncreaseLevels { get; set; }
    }

    public class StartingEquipment {
      public string Type { get; set; }
      public List<object> Options { get; set; }
    }

    public class ClassFeature {
      public string Name { get; set; }
      public int Level { get; set; }
      public string Text { get; set; }
      [JsonProperty("append-section")]
      public string AppendSection { get; set; }
      public List<Option> Options { get; set; }
    }

    public class Option {
      public string Name { get; set; }
      public string Text { get; set; }
    }

    public class Subclass {
      public string Type { get; set; }
      public string Description { get; set; }
      [JsonProperty("class-features")]
      public List<ClassFeature> ClassFeatures { get; set; }
      public string Name { get; set; }
    }

  }
}