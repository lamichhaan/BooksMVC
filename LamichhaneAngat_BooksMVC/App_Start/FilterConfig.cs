using System.Web;
using System.Web.Mvc;

namespace LamichhaneAngat_BooksMVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
