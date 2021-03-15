using System.Web;
using System.Web.Mvc;

namespace _5951071108_TranLeThanhTinh
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
