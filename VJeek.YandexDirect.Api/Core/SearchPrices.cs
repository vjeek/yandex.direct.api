using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VJeek.YandexDirect.Api.Core
{
	/// <summary>
	/// Цены позиций показа для данной фразы на поиске. Служат ориентиром при подборе ставок.
	/// </summary>
	public class SearchPrices
	{
		/// <summary>
		/// Позиция показа.
		/// </summary>
		public Position Position { get; set; }

		/// <summary>
		/// Ставка на поиске, обеспечивающая показ на указанной позиции.
		/// </summary>
		public long Price { get; set; }
	}
}
