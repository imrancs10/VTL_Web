using System.Web;
using System.Web.Mvc;
using VTL_Web.Infrastructure.Authentication;

namespace VTL_Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new CustomAuthorize());
            //filters.Add(new RequreSecureConnectionFilter());
        }
    }
}
