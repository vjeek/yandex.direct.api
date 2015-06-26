using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VJeek.YandexDirect.Api.Core
{
	/// <summary>
	/// Позиция показа.
	/// </summary>
	public enum Position
	{
// ReSharper disable InconsistentNaming
		/// <summary>
		/// Блок гарантированных показов.
		/// </summary>
		FOOTERBLOCK,

		/// <summary>
		/// 1-е место в блоке гарантированных показов.
		/// </summary>
		FOOTERFIRST,

		/// <summary>
		/// Входа в спецразмещение.
		/// </summary>
		PREMIUMBLOCK,

		/// <summary>
		/// 1-е место в спецразмещении.
		/// </summary>
		PREMIUMFIRST
// ReSharper restore InconsistentNaming
	}
}
