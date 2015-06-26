using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VJeek.YandexDirect.Api.Core;
using VJeek.YandexDirect.Api.Requests.AdGroup;
using VJeek.YandexDirect.Api.Results.AdGroup;

namespace VJeek.YandexDirect.Api.Interfaces
{
	public interface IAdGroupService
	{
		AddAdGroupsResult Add(AdGroup[] adGroups);

		DeleteAdGroupsResult Delete(long[] ids);

		GetAdGroupsResult Get(GetAdGroupsRequest request);
	}
}
