using MVC_21_Bundle_Kavrami.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MVC_21_Bundle_Kavrami
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start() // Projenin ilk start verdiği anda çalışan methoddur.
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles); // Bu satır AppStart klasöründe açtığımız BundleConfig class'ı içindeki methodu tetikler ve methoda BundleTable tipinde bir parametre gönderiyoruz.
        }
    }
}
// Projenin ana hatlarını kontrol eden dosyadır. Projenin çalışma, durdurulma, hata gibi anlarını burada yakalayıp işlem yapabiliriz.