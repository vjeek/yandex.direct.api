using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VJeek.YandexDirect.Api.Core
{
	/// <summary>
	/// Объект, содержащий продуктивность фразы и рекомендации по ее повышению.
	/// </summary>
	public class Productivity
	{
		/// <summary>
		/// Значение продуктивности фразы (до 1 знака после запятой).
		/// </summary>
		public decimal Value { get; set; }

		/// <summary>
		/// Массив номеров рекомендаций для данной фразы.
		/// </summary>
		public int[] References { get; set; }
	}
}
