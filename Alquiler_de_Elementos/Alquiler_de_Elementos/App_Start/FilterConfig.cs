using System.Web;
using System.Web.Mvc;

namespace Alquiler_de_Elementos
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
