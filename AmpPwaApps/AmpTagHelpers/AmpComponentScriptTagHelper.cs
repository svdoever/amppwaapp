// Decompiled with JetBrains decompiler
// Type: AmpTagHelpers.AmpComponentScriptTagHelper
// Assembly: AmpPwaApps, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B83A9E8A-0CC6-4EF0-B265-B633C3C6E5B5
// Assembly location: C:\P\amp-oever\AmpPwaApps.dll

using Microsoft.AspNetCore.Razor.TagHelpers;
using System;

namespace AmpTagHelpers
{
  public class AmpComponentScriptTagHelper : TagHelper
  {
    private const string ComponentAttributeName = "component";
    private const string VersionAttributeName = "version";

    [HtmlAttributeName("version")]
    public string Version { get; set; } = "0.1";

    [HtmlAttributeName("component")]
    public string Component { get; set; }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
      if (string.IsNullOrWhiteSpace(this.Component))
        throw new Exception("amp-component-script: missing component attribute");
      output.TagName = (string) null;
      output.Content.AppendHtml(string.Format("<script async custom-element='{0}' src='https://cdn.ampproject.org/v0/{1}-{2}.js'></script>", (object) this.Component, (object) this.Component, (object) this.Version));
    }
  }
}
