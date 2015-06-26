using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VJeek.YandexDirect.Api.Core;
using VJeek.YandexDirect.Api.Requests;

namespace VJeek.YandexDirect.Api.Requests.AdGroup
{
	/// <summary>
	/// Запрос на добавления групп объявлений.
	/// </summary>
	public class AddAdGroupsRequest : BaseAddRequest<AdGroup>
	{
		public AdGroup[] AdGroups { get; set; }
	}
}
