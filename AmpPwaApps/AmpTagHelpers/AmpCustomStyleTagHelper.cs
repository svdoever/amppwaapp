// Decompiled with JetBrains decompiler
// Type: AmpTagHelpers.AmpCustomStyleTagHelper
// Assembly: AmpPwaApps, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B83A9E8A-0CC6-4EF0-B265-B633C3C6E5B5
// Assembly location: C:\P\amp-oever\AmpPwaApps.dll

using AmpPwaApps;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.IO;

namespace AmpTagHelpers
{
  public class AmpCustomStyleTagHelper : TagHelper
  {
    private const string PageTypeAttributeName = "page-type";
    private const string DefaultPageTypeAttributeName = "default-page-type";
    private IHostingEnvironment hostingEnvironment;
    private IUrlHelperFactory urlHelperFactory;
    private IActionContextAccessor actionContextAccesor;

    [HtmlAttributeName("page-type")]
    public string PageType { get; set; }

    [HtmlAttributeName("default-page-type")]
    public string DefaultPageType { get; set; }

    public AmpCustomStyleTagHelper(IHostingEnvironment hostingEnvironment, IUrlHelperFactory urlHelperFactory, IActionContextAccessor actionContextAccesor)
    {
      this.hostingEnvironment = hostingEnvironment;
      this.urlHelperFactory = urlHelperFactory;
      this.actionContextAccesor = actionContextAccesor;
    }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
      string str1;
      if (!string.IsNullOrWhiteSpace(this.PageType))
      {
        str1 = this.PageType;
      }
      else
      {
        if (string.IsNullOrWhiteSpace(this.PageType))
          throw new Exception("No default page type is specified");
        str1 = this.DefaultPageType;
      }
      string path = Path.Combine(Startup.HostingEnvironment.WebRootPath, this.urlHelperFactory.GetUrlHelper(this.actionContextAccesor.ActionContext).Content(string.Format("~/css/{0}.min.css", (object) str1)).Substring(1));
      if (!File.Exists(path))
        throw new Exception(string.Format("Expected page styles file {0} is missing", (object) path));
      string str2 = File.ReadAllText(path);
      output.TagName = (string) null;
      output.Content.AppendHtml(string.Format("<style amp-custom>{0}</style>", (object) str2));
    }
  }
}
