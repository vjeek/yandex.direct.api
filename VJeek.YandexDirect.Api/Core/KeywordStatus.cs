using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VJeek.YandexDirect.Api.Core
{
	
	/// <summary>
	/// Статус ключевой фразы. 
	/// </summary>
	public enum KeywordStatus
	{
		// ReSharper disable InconsistentNaming
		/// <summary>
		/// Новая фраза: еще не отправлена на модерацию или находится на модерации.
		/// Если в кампании есть хотя бы одно объявление, которое активно или отправлено на модерацию, новые фразы отправляются на модерацию автоматически.
		/// </summary>
		DRAFT,

		/// <summary>
		/// Фраза принята модерацией.
		/// </summary>
		ACCEPTED,

		/// <summary>
		/// Фраза отклонена модерацией.
		/// </summary>
		REJECTED,

		/// <summary>
		/// Неизвестный статус. Используется для обеспечения обратной совместимости и отображения статусов, не поддерживаемых в данной версии API.
		/// </summary>
		UNKNOWN
		// ReSharper restore InconsistentNaming
	}
}
