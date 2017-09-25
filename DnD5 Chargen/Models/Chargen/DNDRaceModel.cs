﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DnD5_Chargen.Models.Chargen {
  public class DNDRaceContainer {
    public List<DNDRace> RaceList { get; set; }

    public class DNDRace {
      public string Type { get; set; }
      [JsonProperty("ability-bonuses")]
      public List<AbilityBonus> AbilityBonuses { get; set; }
      [JsonProperty("age-text")]
      public string AgeText { get; set; }
      [JsonProperty("alignment-text")]
      public string AlignmentText { get; set; }
      public string Size { get; set; }
      [JsonProperty("size-text")]
      public string SizeText { get; set; }
      [JsonProperty("walk-speed")]
      public int WalkSpeed { get; set; }
      [JsonProperty("speed-text")]
      public string SpeedText { get; set; }
      public bool Darkvision { get; set; }
      [JsonProperty("vision-text")]
      public string VisionText { get; set; }
      public List<Bonus> Bonuses { get; set; }
      [JsonProperty("race-features")]
      public List<RaceFeature> RaceFeatures { get; set; }
      public List<Proficiency> Proficiencies { get; set; }
      public List<string> Languages { get; set; }
      [JsonProperty("language-text")]
      public string LanguageText { get; set; }
      [JsonProperty("subrace-text")]
      public string SubraceText { get; set; }
      public List<Subrace> Subraces { get; set; }
    }

    public class Subrace : DNDRace {
      public string Description { get; set; }
    }

    public class AbilityBonus {
      public string Ability { get; set; }
      public int Bonus { get; set; }
    }

    public class RaceFeature {
    }

    public class Proficiency {
      public string Type { get; set; }
      public int Limit { get; set; }
      public List<string> Members { get; set; }
    }
  }
}