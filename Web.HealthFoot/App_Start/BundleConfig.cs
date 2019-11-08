using System.Web;
using System.Web.Optimization;

namespace Web.HealthFoot
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            //Pantilla de administardor
            bundles.Add(new StyleBundle("~/Content/admincss").Include(
                      "~/Content/Admin/bootstrap.min.css",
                      "~/Content/Admin/metismenu.min.css",
                      "~/Content/Admin/style.css"));

            bundles.Add(new StyleBundle("~/Content/styleadmin").Include(
                      "~/Content/Admin/style.css"));

            bundles.Add(new StyleBundle("~/Content/font").Include(
                "~/Content/Admin/icons.css"
                , new CssRewriteUrlTransform()));

            bundles.Add(new StyleBundle("~/Content/cssdatatable").Include(
                "~/Content/Admin/datatables/dataTables.bootstrap4.min.css",
                "~/Content/Admin/datatables/dataTables.responsive.bootstrap4.min.css"
                ));

            bundles.Add(new ScriptBundle("~/bundles/slimscroll").Include(
                     "~/Scripts/Admin/jquery.slimscroll.js"));


            bundles.Add(new ScriptBundle("~/bundles/adminbootstrap").Include(
                      "~/Scripts/Admin/bootstrap.bundle.min.js"));


            bundles.Add(new ScriptBundle("~/bundles/metismenu").Include(
                      "~/Scripts/Admin/metisMenu.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/waves").Include(
                      "~/Scripts/Admin/waves.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jsdatatable").Include(
                      "~/Content/Admin/datatables/jquery.dataTables.min.js",
                      "~/Content/Admin/datatables/dataTables.bootstrap4.min.js",
                      "~/Content/Admin/datatables/dataTables.responsive.min.js",
                      "~/Content/Admin/datatables/responsive.bootstrap4.min.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                      "~/Scripts/Admin/app.js"));

            bundles.Add(new ScriptBundle("~/bundles/init").Include(
                      "~/Scripts/init.js"));
        }
    }
}
