using System;
using System.Diagnostics.Contracts;
using System.Web.Http;

namespace magic_company_name_magic.magic_product_name_magic.Controllers
{
	public class magic_application_name_magicController : ApiController
	{
		[HttpGet]
		[Route("api/magic_application_name_magic")]
		public String Get()
		{
			Contract.Ensures(Contract.Result<String>() != null);

			return "Hello API App!";
		}
	}
}
