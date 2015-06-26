using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VJeek.YandexDirect.Api.Core
{
	/// <summary>
	/// Структура, задающая страницу при постраничной выборке данных.
	/// </summary>
	public sealed class Page
	{
		/// <summary>
		/// Количество возвращаемых объектов (размер страницы). От 0 до 10 000. Если не указано, используется ограничение 10 000.
		/// </summary>
		public long Limit { get; set; }

		/// <summary>
		/// Количество объектов, которое должно быть пропущено при выборке. Если не указано, подразумевается 0.
		/// </summary>
		public long Offset { get; set; }
	}
}
