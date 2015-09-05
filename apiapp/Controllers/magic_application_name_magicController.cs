using System;
using System.Collections.Generic;
using System.Web.Http;

namespace apiapp.Controllers
{
	public class magic_application_name_magicController : System.Web.Http.ApiController
	{
		[HttpGet]
		[Route("api/magic_application_name_magic")]
		public String Get()
		{
			return "Hello API App!";
		}
	}
}
