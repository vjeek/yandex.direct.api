using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VJeek.YandexDirect.Api.Core
{
	/// <summary>
	/// Отражает, остановлены ли показы по фразе.
	/// </summary>
	public enum KeywordState
	{
		// ReSharper disable InconsistentNaming
		/// <summary>
		/// Показы объявлений по фразе возможны.
		/// </summary>
		ON,

		/// <summary>
		/// Показы остановлены владельцем.
		/// </summary>
		SUSPENDED,

		/// <summary>
		/// Фраза еще не отправлена на модерацию или отклонена модерацией.
		/// </summary>
		OFF
		// ReSharper restore InconsistentNaming

	}
}
