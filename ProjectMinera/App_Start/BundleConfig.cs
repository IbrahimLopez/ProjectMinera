using System.Web;
using System.Web.Optimization;

namespace ProjectMinera
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap-Navbars.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/assets/css/css").IncludeDirectory(
                      "~/assets/css", "*.css", true));

            bundles.Add(new StyleBundle("~/assets/scss/scss").IncludeDirectory(
                      "~/assets/scss", "*.scss", true));

            bundles.Add(new StyleBundle("~/assets/scss/css").IncludeDirectory(
                      "~/assets/scss", "*.css", true));

            bundles.Add(new ScriptBundle("~/bundles/scripts")
            .IncludeDirectory("~/assets/js", "*.js", true));

            bundles.Add(new StyleBundle("~/assets/scss/bootstrap/scss").IncludeDirectory(
                      "~/assets/scss/bootstrap", "*.scss", true));

            bundles.Add(new StyleBundle("~/assets/scss/bootstrap/css").IncludeDirectory(
                      "~/assets/scss/bootstrap", "*.css", true));

            bundles.Add(new ScriptBundle("~/assets/js")
                .IncludeDirectory("~/assets/js", "*.js", true));

            //bundles.Add(new StyleBundle("~/assets/css/css").Include(
            //          "~/assets/css/normalize.css",
            //          "~/assets/css/animate.css",
            //          "~/assets/css/bootstrap-select.css",
            //          "~/assets/css/bootstrap.css",
            //          "~/assets/css/bootstrap.min.css",
            //          "~/assets/css/font-awesome.min.css",
            //          "~/assets/css/themify-icons.css",
            //          "~/assets/css/flag-icon.min.css",
            //          "~/assets/css/themify-icons.css",
            //          "~/assets/css/cs-skin-elastic.css",
            //          "~/assets/css/variables.css"));

            //bundles.Add(new StyleBundle("~/assets/scss/scss").Include(
            //          "~/assets/scss/style.css",
            //          "~/assets/scss/_gauge.css",
            //          "~/assets/scss/_switches.css",
            //          "~/assets/scss/_widgets.css",
            //          "~/assets/scss/socials.css",
            //          "~/assets/scss/variables.css"
            //          ));


            //bundles.Add(new StyleBundle("~/assets/scss/boostrap/scss").Include(
            //          "~/assets/scss/boostrap/_alert.scss",
            //          "~/assets/scss/boostrap/_badge.scss",
            //          "~/assets/scss/boostrap/_breadcrumb.scss",
            //          "~/assets/scss/boostrap/_button-group.scss",
            //          "~/assets/scss/boostrap/_buttons.scss",
            //          "~/assets/scss/boostrap/_card.scss",
            //          "~/assets/scss/boostrap/_carousel.scss",
            //          "~/assets/scss/boostrap/_close.scss",
            //          "~/assets/scss/boostrap/_code.scss",
            //          "~/assets/scss/boostrap/_custom-forms.scss",
            //          "~/assets/scss/boostrap/_dropdown.scss",
            //          "~/assets/scss/boostrap/_forms.scss",
            //          "~/assets/scss/boostrap/_functions.scss",
            //          "~/assets/scss/boostrap/_grid.scss",
            //          "~/assets/scss/boostrap/_images.scss",
            //          "~/assets/scss/boostrap/_input-group.scss",
            //          "~/assets/scss/boostrap/_jumbotron.scss",
            //          "~/assets/scss/boostrap/_list-group.scss",
            //          "~/assets/scss/boostrap/_media.scss",
            //          "~/assets/scss/boostrap/_mixins.scss",
            //          "~/assets/scss/boostrap/_modal.scss",
            //          "~/assets/scss/boostrap/_nav.scss",
            //          "~/assets/scss/boostrap/_navbar.scss",
            //          "~/assets/scss/boostrap/_navbar.scss",
            //          "~/assets/scss/boostrap/_popover.scss",
            //          "~/assets/scss/boostrap/_print.scss"


            //          ));

            bundles.Add(new StyleBundle("~/assets/scss/css").Include(
                      "~/assets/scss/socials.css",
                      "~/assets/scss/style.css",
                      "~/assets/scss/variables.css",
                      "~/assets/scss/widgets.css"
                ));
        }
    }
}
