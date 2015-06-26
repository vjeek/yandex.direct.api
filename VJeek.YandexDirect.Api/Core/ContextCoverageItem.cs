using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VJeek.YandexDirect.Api.Core
{
	/// <summary>
	/// Вероятность достичь охвата различных долей аудитории Рекламной сети Яндекса (прогноз) при текущей цене.
	/// </summary>
	public class ContextCoverageItem
	{
		/// <summary>
		/// Частота показа (доля аудитории) в Рекламной сети Яндекса. Указывается в процентах от 0 до 100.
		/// </summary>
		public decimal Probability { get; set; }

		/// <summary>
		/// Ставка в Рекламной сети, при которой прогнозируется указанная частота показа.
		/// </summary>
		public decimal Price { get; set; }
	}
}
