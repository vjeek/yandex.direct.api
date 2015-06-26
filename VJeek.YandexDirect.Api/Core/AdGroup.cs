using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VJeek.YandexDirect.Api.Core
{
	/// <summary>
	/// Группа объявлений.
	/// </summary>
	public class AdGroup
	{
		/// <summary>
		/// Идентификатор группы объявлений.
		/// </summary>
		public long Id { get; set; }

		/// <summary>
		/// Название группы.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Идентификатор кампании.
		/// </summary>
		public long CampaignId { get; set; }

		/// <summary>
		/// Массив идентификаторов регионов, для которых показы включены или выключены.
		/// Идентификатор 0 — показывать во всех регионах.
		/// Минус перед идентификатором региона — выключить показы в данном регионе. Например [1,-219] — показывать для Москвы и Московской области, кроме Черноголовки.
		/// </summary>
		public long[] RegionIds { get; set; }

		/// <summary>
		/// Массив минус-слов, общих для всех фраз группы объявлений.
		/// </summary>
		public string[] NegativeKeywords { get; set; }

		/// <summary>
		/// Статус группы. Описание статусов см. в разделе Статус группы.
		/// </summary>
		public AdGroupStatus Status { get; set; }
	}
}
