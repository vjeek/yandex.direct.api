using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VJeek.YandexDirect.Api.Core
{
	/// <summary>
	/// Параметры объявления.
	/// </summary>
	public class TextAd
	{
		/// <summary>
		/// Заголовок объявления (до 33 символов, включая пробелы и знаки препинания; каждое слово не более 22 символов).
		/// </summary>
		public string Text { get; set; }

		/// <summary>
		/// Текст объявления (до 75 символов, включая пробелы и знаки препинания; каждое слово не более 23 символов).
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// Ссылка на сайт рекламодателя (не более 1024 символов). Должна содержать протокол и доменное имя. Может содержать подстановочные переменные.
		/// </summary>
		public string Href { get; set; }

		/// <summary>
		/// Рекламируемый домен. Определяется автоматически на основе ссылки объявления.
		/// </summary>
		public string DisplayDomain { get; set; }

		/// <summary>
		/// Признак того, что объявление является мобильным: YES или NO.
		/// </summary>
		public YesNo Mobile { get; set; }

		/// <summary>
		/// Идентификатор виртуальной визитки.
		/// </summary>
		public long? VCardId { get; set; }

		/// <summary>
		/// Хэш изображения.
		/// </summary>
		public string AdImageHash { get; set; }

		/// <summary>
		/// Идентификатор набора быстрых ссылок. Допускается только при наличии параметра Href.
		/// </summary>
		public long SiteLinkSetId { get; set; }

		/// <summary>
		/// Результат модерации связки визитки.
		/// </summary>
		public ExtensionModeration VCardModeration { get; set; }

		/// <summary>
		/// Результат модерации набора быстрых ссылок
		/// </summary>
		public ExtensionModeration SitelinksModeration { get; set; }

		/// <summary>
		/// Результат модерации изображения.
		/// </summary>
		public ExtensionModeration AdImageModeration { get; set; }
	}
}
