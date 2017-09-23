using System.Web;
using System.Web.Mvc;

namespace Farsiman.Drogueria.PermisosControlados.WebApi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
