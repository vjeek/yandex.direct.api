using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VJeek.YandexDirect.Api.Core
{
	/// <summary>
	/// Статус группы.
	/// Статус группы отражает обобщенный результат модерации ключевых фраз
	/// Ключевые фразы отправлются на модерацию автоматически, когда на модерацию отправляется кампания либо одно из объявлений группы.
	/// </summary>
	public enum AdGroupStatus
	{
// ReSharper disable InconsistentNaming
		/// <summary>
		/// Группа создана и еще не отправлена на модерацию.
		/// </summary>
		DRAFT,

		/// <summary>
		/// Группа находится на модерации.
		/// </summary>
		MODERATION,

		/// <summary>
		/// Группа допущена к показам автоматически, но будет дополнительно проверена модератором.
		/// </summary>
		PREACCEPTED,

		/// <summary>
		/// Хотя бы одна фраза группы принята модерацией (некоторые могли быть отклонены).
		/// </summary>
		ACCEPTED,

		/// <summary>
		/// Все фразы отклонены.
		/// </summary>
		REJECTED
// ReSharper restore InconsistentNaming
	}
}
