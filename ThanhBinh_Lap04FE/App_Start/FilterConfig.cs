using System.Web;
using System.Web.Mvc;

namespace ThanhBinh_Lap04FE
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
