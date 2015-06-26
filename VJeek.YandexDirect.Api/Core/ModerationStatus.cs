using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VJeek.YandexDirect.Api.Core
{
	/// <summary>
	/// Результат модерации связки объявления с указанным дополнительным элементом.
	/// </summary>
	public enum ModerationStatus
	{
// ReSharper disable InconsistentNaming
		/// <summary>
		/// Дополнение не отправлялось на модерацию.
		/// </summary>
		DRAFT,

		/// <summary>
		/// Дополнение находится на модерации.
		/// </summary>
		MODERATION,
		
		/// <summary>
		/// Дополнение принято модерацией. Объявление при показе будет содержать соответствующий дополнительный элемент: ссылку на визитку и данные из нее, изображение (только в Рекламной сети Яндекса), быстрые ссылки.
		/// </summary>
		ACCEPTED,

		/// <summary>
		/// Дополнение отклонено модерацией.
		/// </summary>
		REJECTED
// ReSharper restore InconsistentNaming
	}
}
