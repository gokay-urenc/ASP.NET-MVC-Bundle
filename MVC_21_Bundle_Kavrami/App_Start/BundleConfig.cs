using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization; // Bu kütüphaneliğin gelmesi için NuGet'tan Browse'ye girip optimization yazıp 33,4 MB'lık dosyayı indirdik.

namespace MVC_21_Bundle_Kavrami.App_Start
{
    public class BundleConfig
    {
        // Sayfalarda bundle olayını çağırabilmek için Views klasörü içindeki web.config dosyasında namespaceler'e System.Web.Optimization yolu tanımlanmalıdır.
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css403").Include(
                "~/Content/bootstrap.css",
                "~/Content/Site.css"
                )); // CSS
            bundles.Add(new ScriptBundle("~/Content/js403").Include(
                "~/Scripts/bootstrap.js",
                "~/Scripts/jquery-1.10.2.js"
                )); // JavaScript
            BundleTable.EnableOptimizations = true; // Bundle optimize olayının çalışabilmesi için gereklidir.
        }
    }
}
/* CSS ve JavaScript dosyalarının çokluğu karışıklığa yol açar. Bundle karışıklığı önlediği gibi performansıda arttırır.
   CSS ve JavaScript dosyalarını optimize eder.
   Birden fazla StyleBundle ve ScriptBundle eklenebilir.
*/