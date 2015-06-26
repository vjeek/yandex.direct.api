using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VJeek.YandexDirect.Api.Core
{

	/// <summary>
	/// Результат операции, выполненной над объявлением.
	/// </summary>
	public enum AdStatus
	{
		// ReSharper disable InconsistentNaming
		/// <summary>
		/// Объявление создано и еще не отправлено на модерацию.
		/// </summary>
		DRAFT,

		/// <summary>
		/// Объявление находится на модерации.
		/// </summary>
		MODERATION,

		/// <summary>
		/// Объявление допущено к показам автоматически, но будет дополнительно проверено модератором.
		/// </summary>
		PREACCEPTED,

		/// <summary>
		/// Объявление принято модерацией.
		/// </summary>
		ACCEPTED,

		/// <summary>
		/// Объявление отклонено модерацией.
		/// </summary>
		REJECTED
		// ReSharper restore InconsistentNaming
	}
}
