using System.Web;
using System.Web.Mvc;

namespace Test_Asp.net_VS2019
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
