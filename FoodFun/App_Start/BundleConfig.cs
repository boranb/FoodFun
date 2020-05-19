using System.Web;
using System.Web.Optimization;

namespace FoodFun
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.UseCdn = true;


            // local js kullan release yaptığımızda cdn kullan

            bundles.Add(new ScriptBundle("~/bundles/jquery", "https://code.jquery.com/jquery-3.4.1.min.js").Include(
                "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/datetimepicker", "https://cdnjs.cloudflare.com/ajax/libs/jquery-datetimepicker/2.5.20/jquery.datetimepicker.full.min.js").Include(
                "~/Scripts/jquery.datetimepicker.full.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/niceselect", "https://cdnjs.cloudflare.com/ajax/libs/jquery-nice-select/1.1.0/js/jquery.nice-select.min.js").Include(
                "~/Scripts/jquery.nice-select.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap", "https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.bundle.min.js").Include(
                "~/Scripts/bootstrap.bundle.js"));

            bundles.Add(new ScriptBundle("~/bundles/wow", "https://cdnjs.cloudflare.com/ajax/libs/wow/1.1.2/wow.min.js").Include(
                "~/Scripts/wow.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/main")
                .Include("~/Scripts/main.js"));


            // local css kullan release yaptığımızda cdn kullan

            bundles.Add(new StyleBundle("~/Content/bootstrap", "https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css").Include(
                "~/Content/bootstrap.css"));

            bundles.Add(new StyleBundle("~/Content/datetimepicker", "https://cdnjs.cloudflare.com/ajax/libs/jquery-datetimepicker/2.5.20/jquery.datetimepicker.min.css").Include(
                "~/Content/jquery.datetimepicker.min.css"));

            bundles.Add(new StyleBundle("~/Content/fontawesome", "https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.13.0/css/all.min.css").Include(
                "~/Content/fontawesome-all.css"));

            bundles.Add(new StyleBundle("~/Content/animate", "https://cdnjs.cloudflare.com/ajax/libs/animate.css/3.7.0/animate.min.css").Include(
                "~/Content/animate-3.7.0.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/style.css"));

            //normalde bunu yazmaya gerek yok, release mod'da şalışırken farkı göstermek istedik

#if DEBUG
            BundleTable.EnableOptimizations = false;
#else
            BundleTable.EnableOptimizations = true; // boş alanları silip minify halde yayınlar
#endif

        }

    }
}