// Decompiled with JetBrains decompiler
// Type: AmpPwaApps.Areas.AmpPwaVideos.DeserializeYaml
// Assembly: AmpPwaApps, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B83A9E8A-0CC6-4EF0-B265-B633C3C6E5B5
// Assembly location: C:\P\amp-oever\AmpPwaApps.dll

using AmpPwaApps.Areas.AmpPwaVideos.Models;
using System.Collections.Generic;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace AmpPwaApps.Areas.AmpPwaVideos
{
  public static class DeserializeYaml
  {
    public static Conference GetConference(string agendaYaml, string speakersYaml)
    {
      Dictionary<string, Session[]> dictionary1 = DeserializeYaml.Deserialize<Dictionary<string, Session[]>>(agendaYaml);
      Dictionary<string, Speaker> dictionary2 = DeserializeYaml.Deserialize<Dictionary<string, Speaker>>(speakersYaml);
      return new Conference()
      {
        Agenda = dictionary1,
        Speakers = dictionary2
      };
    }

    public static T Deserialize<T>(string yaml)
    {
      return new DeserializerBuilder().WithNamingConvention((INamingConvention) new CamelCaseNamingConvention()).Build().Deserialize<T>(yaml);
    }
  }
}
