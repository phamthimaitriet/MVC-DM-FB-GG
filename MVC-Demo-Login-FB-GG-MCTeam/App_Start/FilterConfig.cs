using System.Web;
using System.Web.Mvc;

namespace MVC_Demo_Login_FB_GG_MCTeam
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
