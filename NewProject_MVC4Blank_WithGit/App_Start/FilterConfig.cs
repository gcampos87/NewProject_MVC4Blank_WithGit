using System.Web;
using System.Web.Mvc;

namespace NewProject_MVC4Blank_WithGit
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}