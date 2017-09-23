using System.Web;
using System.Web.Mvc;

namespace DnD5_Chargen {
  public class FilterConfig {
    public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
      filters.Add(new HandleErrorAttribute());
    }
  }
}
