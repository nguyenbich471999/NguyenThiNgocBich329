using System.Web;
using System.Web.Mvc;

namespace NguyenThiNgocBich329
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
