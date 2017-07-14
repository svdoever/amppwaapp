// Decompiled with JetBrains decompiler
// Type: AmpPwaApps.Areas.AmpPwaVideos.Models.Conference
// Assembly: AmpPwaApps, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B83A9E8A-0CC6-4EF0-B265-B633C3C6E5B5
// Assembly location: C:\P\amp-oever\AmpPwaApps.dll

using System.Collections.Generic;

namespace AmpPwaApps.Areas.AmpPwaVideos.Models
{
  public class Conference
  {
    public Dictionary<string, Session[]> Agenda { get; set; }

    public Dictionary<string, Speaker> Speakers { get; set; }
  }
}
