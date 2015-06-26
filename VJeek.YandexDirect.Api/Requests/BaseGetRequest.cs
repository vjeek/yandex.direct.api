using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VJeek.YandexDirect.Api.Requests
{
	public abstract class BaseGetRequest : BaseRequest
	{
		BaseGetRequest()
			: base("get")
		{

		}

	}
}
