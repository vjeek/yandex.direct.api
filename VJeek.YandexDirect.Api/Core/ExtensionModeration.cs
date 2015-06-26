using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VJeek.YandexDirect.Api.Core
{
	/// <summary>
	/// Результат модерации дополнительного элемента
	/// </summary>
	public class ExtensionModeration
	{
		/// <summary>
		/// Результат модерации связки объявления с указанным дополнительным элементом.
		/// </summary>
		public ModerationStatus Status { get; set; }

		/// <summary>
		/// Текстовое пояснение к статусу и/или причины отклонения на модерации.
		/// </summary>
		public string StatusClarification { get; set; }
	}
}
