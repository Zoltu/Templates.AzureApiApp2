using System.Diagnostics.Contracts;
using System.Web.Http;
using Swashbuckle.Application;

namespace magic_company_name_magic.magic_product_name_magic
{
	public static class WebApiConfig
	{
		public static void Register(HttpConfiguration config)
		{
			Contract.Requires(config != null);

			SetupRoutes(config);
			SetupSwagger(config);
		}

		public static void SetupRoutes(HttpConfiguration config)
		{
			Contract.Requires(config != null);

			config.MapHttpAttributeRoutes();
			config.Routes.MapHttpRoute(
				name: "magic_application_name_magicApi",
				routeTemplate: "api/{controller}/{id}",
				defaults: new { id = RouteParameter.Optional }
			);
		}

		public static void SetupSwagger(HttpConfiguration config)
		{
			Contract.Requires(config != null);

			var swaggerConfiguration = config.EnableSwagger(SetupSwaggerConfig);
			Contract.Assume(swaggerConfiguration != null);
			swaggerConfiguration.EnableSwaggerUi();
		}

		public static void SetupSwaggerConfig(SwaggerDocsConfig swaggerDocsConfig)
		{
			Contract.Requires(swaggerDocsConfig != null);

			swaggerDocsConfig.SingleApiVersion("v1", "magic_application_name_magic");
		}
	}
}
