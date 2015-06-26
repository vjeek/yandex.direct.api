using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VJeek.YandexDirect.Api.Core
{
	/// <summary>
	/// Текущее состояние объявления.
	/// </summary>
	public enum AdState
	{
		// ReSharper disable InconsistentNaming
		/// <summary>
		/// Показы объявления остановлены владельцем с помощью метода suspend или в веб-интерфейсе.
		/// </summary>
		SUSPENDED,

		/// <summary>
		/// Показы объявления автоматически остановлены мониторингом доступности сайта
		/// </summary>
		OFF_BY_MONITORING,

		/// <summary>
		/// Объявление активно и может быть показано (при наличии средств на кампании, в соответствии с настройками временного таргетинга и т. п.).
		/// </summary>
		ON,

		/// <summary>
		/// Объявление неактивно (черновик, ожидает модерации, отклонено).
		/// </summary>
		OFF,

		/// <summary>
		/// Объявление помещено в архив с помощью метода archive или пользователем в веб-интерфейсе.
		/// </summary>
		ARCHIVED
		// ReSharper restore InconsistentNaming
	}
}
