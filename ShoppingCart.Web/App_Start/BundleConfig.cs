using System.Web.Optimization;
using WebHelpers.Mvc5;

namespace ShoppingCart.Web.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Bundles/css")
                .Include("~/Content/css/bootstrap.min.css", new CssRewriteUrlTransformAbsolute())
                .Include("~/Content/css/bootstrap-select.css")
                .Include("~/Content/css/bootstrap-datepicker3.min.css")
                .Include("~/Content/css/font-awesome.min.css", new CssRewriteUrlTransformAbsolute())
                .Include("~/Content/css/icheck/blue.min.css", new CssRewriteUrlTransformAbsolute())
                .Include("~/Content/css/AdminLTE.css", new CssRewriteUrlTransformAbsolute())
                .Include("~/Content/css/skins/skin-blue.css")
                .Include("~/Content/site.css")
                .Include("~/Content/respond.css")
                .Include("~/Content/css/jquery.dataTables.css")
                .Include("~/Content/Datatables/dataTables.bootstrap4.min.css")
                .Include("~/Content/SocialMediaIcons.css")
                .Include("~/Content/footer.css")
                .Include("~/Content/MyStyles.css")
                .Include("~/Content/CommonTableStyles.css"));

            bundles.Add(new ScriptBundle("~/Bundles/js")
                .Include("~/Content/js/plugins/jquery/jquery-3.3.1.js")
                .Include("~/Content/js/plugins/bootstrap/bootstrap.js")
                .Include("~/Content/js/plugins/fastclick/fastclick.js")
                .Include("~/Content/js/plugins/slimscroll/jquery.slimscroll.js")
                .Include("~/Content/js/plugins/bootstrap-select/bootstrap-select.js")
                .Include("~/Content/js/plugins/moment/moment.js")
                .Include("~/Content/js/plugins/datepicker/bootstrap-datepicker.js")
                .Include("~/Content/js/plugins/icheck/icheck.js")
                .Include("~/Content/js/plugins/validator/validator.js")
                .Include("~/Content/js/plugins/inputmask/jquery.inputmask.bundle.js")
                .Include("~/Content/js/adminlte.js")
                .Include("~/Content/js/init.js")
                .Include("~/Scripts/jquery.unobtrusive-ajax.min.js")
                .Include("~/Scripts/jquery.dataTables.min.js")
                .Include("~/Scripts/dataTables.bootstrap4.min.js")
                .Include("~/Scripts/MyScipts.js")
                );

            //Added by Ashok
            bundles.Add(new StyleBundle("~/Content/css").Include(
                     "~/themes/bootshop/bootstrap.min.css",
                     "~/themes/css/base.css",
                     "~/themes/css/bootstrap-responsive.min.css",
                     "~/themes/css/font-awesome.css",
                     "~/themes/js/google-code-prettify/prettify.css"
                     ));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/themes/js/jquery.js",
                        "~/themes/js/bootstrap.min.js",
                        "~/themes/js/google-code-prettify/prettify.js",
                        "~/themes/js/bootshop.js",
                        "~/themes/js/jquery.lightbox-0.5.js"
                        ));
            //end
        }
    }
}
