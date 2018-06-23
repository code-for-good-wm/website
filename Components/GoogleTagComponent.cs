using System.Threading.Tasks;
using CodeForGood.Config;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CodeForGood.Components
{

    public class GoogleTagComponent : TagHelperComponent
    {

        public override int Order => 1;
        private readonly IGoogleSettings _googleSettings;

        private string containerSnippet => @"
<!-- Google Tag Manager -->
<script>(function(w,d,s,l,i){{w[l]=w[l]||[];w[l].push({{'gtm.start':
new Date().getTime(),event:'gtm.js'}});var f=d.getElementsByTagName(s)[0],
j=d.createElement(s),dl=l!='dataLayer'?'&l='+l:'';j.async=true;j.src=
'https://www.googletagmanager.com/gtm.js?id='+i+dl;f.parentNode.insertBefore(j,f);
}})(window,document,'script','dataLayer','{0}');</script>
<!-- End Google Tag Manager -->";

        private string noscriptSnippet => @"
<!-- Google Tag Manager (noscript) -->
<noscript><iframe src=""https://www.googletagmanager.com/ns.html?id={0}""
height=""0"" width=""0"" style=""display:none;visibility:hidden""></iframe></noscript>
<!-- End Google Tag Manager (noscript) -->";

        public GoogleTagComponent(IGoogleSettings googleSettings)
        {
            _googleSettings = googleSettings;
        }

        public override Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            if (string.IsNullOrWhiteSpace(_googleSettings.TagManagerContainerID))
            {
                return Task.CompletedTask;
            }

            if (string.Equals(context.TagName, "head",
                    System.StringComparison.OrdinalIgnoreCase))
            {
                output.PreContent.AppendHtml(string.Format(containerSnippet, _googleSettings.TagManagerContainerID));
            }

            if (string.Equals(context.TagName, "body",
                    System.StringComparison.OrdinalIgnoreCase))
            {

                output.PreContent.AppendHtml(string.Format(noscriptSnippet, _googleSettings.TagManagerContainerID));
            }

            return Task.CompletedTask;
        }
    }
}
