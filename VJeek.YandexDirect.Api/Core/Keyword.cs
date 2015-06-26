using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VJeek.YandexDirect.Api.Core
{
	/// <summary>
	/// Ключевая фраза.
	/// </summary>
	public class KeywordGetItem
	{
		/// <summary>
		/// Идентификатор ключевой фразы.
		/// </summary>
		public long Id { get; set; }

		/// <summary>
		/// Идентификатор группы объявлений, к которой относится ключевая фраза.
		/// </summary>
		public long AdGroupId { get; set; }

		/// <summary>
		/// Идентификатор кампании, к которой относится ключевая фраза.
		/// </summary>
		public long CampaignId { get; set; }

		/// <summary>
		/// Ключевая фраза. Может содержать минус-слова.
		/// </summary>
		public string Keyword { get; set; }

		/// <summary>
		/// Значение подстановочной переменной {param1}. Не более 255 символов.
		/// </summary>
		public string UserParam1 { get; set; }

		/// <summary>
		/// Значение подстановочной переменной {param2}. Не более 255 символов.
		/// </summary>
		public string UserParam2 { get; set; }

		/// <summary>
		/// Ставка на поиске Яндекса.
		/// </summary>
		public long? Bid { get; set; }

		/// <summary>
		/// Ставка в Рекламной сети Яндекса.
		/// </summary>
		public long? ContextBid { get; set; }

		/// <summary>
		/// Приоритет фразы: LOW, NORMAL или HIGH.
		/// </summary>
		public Priority StrategyPriority { get; set; }

		/// <summary>
		/// Статус ключевой фразы.
		/// </summary>
		public KeywordStatus Status { get; set; }

		/// <summary>
		/// Состояние ключевой фразы.
		/// </summary>
		public KeywordState State { get; set; }

		/// <summary>
		/// Продуктивность фразы и рекомендации по ее повышению.
		/// </summary>
		public Productivity Productivity { get; set; }
	}
}
