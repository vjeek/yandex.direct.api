using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VJeek.YandexDirect.Api.Requests
{
	public abstract class BaseRequest
	{
		private readonly string _method;
		private object _params { get; set; }

		public object Params { get; set; }

		protected BaseRequest(string method)
		{
			if (string.IsNullOrWhiteSpace(method))
				throw new ArgumentOutOfRangeException("method", "method cannot be null or empty");

			_method = method;


		}
	}
}
