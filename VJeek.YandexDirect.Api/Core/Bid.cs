using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VJeek.YandexDirect.Api.Core
{
	/// <summary>
	/// Ставка для ключевых фраз.
	/// </summary>
	public class BidGet
	{
		/// <summary>
		/// Идентификатор кампании, к которой относится ключевая фраза.
		/// </summary>
		public long CampaignId { get; set; }

		/// <summary>
		/// Идентификатор группы объявлений, к которой относится ключевая фраза.
		/// </summary>
		public long AdGroupId { get; set; }

		/// <summary>
		/// Идентификатор ключевой фразы.
		/// </summary>
		public long KeywordId { get; set; }

		/// <summary>
		/// Ставка на поиске Яндекса.
		/// </summary>
		public long? Bid { get; set; }

		/// <summary>
		/// Ставка в Рекламной сети Яндекса.
		/// </summary>
		public long? ContextBid { get; set; }

		/// <summary>
		/// Приоритет фразы
		/// </summary>
		public Priority? StrategyPriority { get; set; }

		/// <summary>
		/// Массив конкурирующих ставок для данной фразы, по всем регионам. Служит ориентиром при подборе ставок.
		/// </summary>
		public long[] CompetitorsBids { get; set; }

		/// <summary>
		/// Цены позиций показа для данной фразы на поиске. Служат ориентиром при подборе ставок.
		/// </summary>
		public SearchPrices[] SearchPrices { get; set; }

		/// <summary>
		/// Ставки для данной фразы, позволяющие достичь охвата различных долей аудитории Рекламной сети Яндекса (прогноз). Служат ориентиром при подборе ставок.
		/// </summary>
		public ContextCoverage ContextCoverage { get; set; }

		/// <summary>
		/// Минимальная цена, установленная для рекламодателя, при которой возможен показ на поиске.
		/// </summary>
		public long? MinSearchPrice { get; set; }

		/// <summary>
		/// Текущая цена клика на поиске с учетом автоброкера. Эта цена может быть списана при клике по объявлению на странице результатов поиска (по запросу, точно соответствующему ключевой фразе).
		/// </summary>
		public long? CurrentSearchPrice { get; set; }
	}
}
