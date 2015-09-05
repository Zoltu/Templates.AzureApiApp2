using System.Web.Http;

namespace magic_company_name_magic.magic_product_name_magic
{
	public class WebApiApplication : System.Web.HttpApplication
	{
		protected void Application_Start()
		{
			GlobalConfiguration.Configure(WebApiConfig.Register);
		}
	}
}
