using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using RiaPlus.Domain.Concrete;

namespace RiaPlus.WebUI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());

            //вирішує пробему з запуском після зміни ( проблеми через валідацію полів
            //в Domain.Product
            Database.SetInitializer<EFDbContext>(null);
        }
    }
}