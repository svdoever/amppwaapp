// Decompiled with JetBrains decompiler
// Type: MaterialTagHelpers.MaterialCardGridTagHelper
// Assembly: AmpPwaApps, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B83A9E8A-0CC6-4EF0-B265-B633C3C6E5B5
// Assembly location: C:\P\amp-oever\AmpPwaApps.dll

using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MaterialTagHelpers
{
  public class MaterialCardGridTagHelper : TagHelper
  {
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
      output.TagName = (string) null;
      output.PreContent.SetHtmlContent("<div class='card-container grid'>");
      output.PostContent.SetHtmlContent("</div>");
    }
  }
}
