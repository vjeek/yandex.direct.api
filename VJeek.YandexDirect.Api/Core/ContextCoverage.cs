using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VJeek.YandexDirect.Api.Core
{
	/// <summary>
	/// Ставки для данной фразы, позволяющие достичь охвата различных долей аудитории Рекламной сети Яндекса (прогноз). Служат ориентиром при подборе ставок.
	/// </summary>
	public class ContextCoverage
	{
		/// <summary>
		/// Ставки для данной фразы, позволяющие достичь охвата различных долей аудитории Рекламной сети Яндекса (прогноз). Служат ориентиром при подборе ставок.
		/// </summary>
		public ContextCoverageItem[] Items { get; set; }
	}
}
