using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VJeek.YandexDirect.Api.Core
{
	/// <summary>
	/// Элемент набора быстрых ссылок.
	/// </summary>
	public class SiteLinkSetGetItem
	{
		/// <summary>
		/// Идентификатор набора быстрых ссылок.
		/// </summary>
		public long Id { get; set; }

		/// <summary>
		/// Массив, содержащий от 1 до 4 объектов Sitelink.
		/// </summary>
		public SiteLink[] SiteLinks { get; set; }
	}
}
