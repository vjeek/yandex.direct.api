using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VJeek.YandexDirect.Api.Core
{
	/// <summary>
	/// Ссылка
	/// </summary>
	public class SiteLink
	{
		/// <summary>
		/// Текст быстрой ссылки.
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// Адрес быстрой ссылки.
		/// </summary>
		public string Href { get; set; }
	}
}
