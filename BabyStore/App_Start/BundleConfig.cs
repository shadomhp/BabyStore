using System.Collections.Generic;
using System.Web;
using System.Web.Optimization;

namespace BabyStore
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            //messages_pt_PT.min.js-> Valida os campos traduzindo valores do JqueryValidation para Porguguês
            //methods_Pt_br -> Corrige validação de , para decimal Padrão Brasil
            //jquery.maskMoney.js -> Adiciona um MaskedMoney na view
            //CustomValidacoes.js -> Corrige o DataAnnotatios Range para pegar valor corretamente
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*",
                        "~/Scripts/messages_pt_PT.min.js",
                        "~/Scripts/methods_pt_br.js",
                        "~/Scripts/jquery.maskMoney.js",
                        "~/Scripts/CustomValidacoes.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }

    public class AsIsBundleOrderer : IBundleOrderer

    {
        public IEnumerable<BundleFile> OrderFiles(BundleContext context, IEnumerable<BundleFile> files)
        {
            return files;
        }
    }
}
