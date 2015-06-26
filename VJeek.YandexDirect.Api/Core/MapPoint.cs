using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VJeek.YandexDirect.Api.Core
{
	/// <summary>
	/// Положение точки на карте.
	/// </summary>
	public class MapPoint
	{
		/// <summary>
		/// Долгота точки. От -180 до 180.
		/// </summary>
		public decimal X { get; set; }

		/// <summary>
		/// Широта точки. От -90 до 90.
		/// </summary>
		public decimal Y { get; set; }

		/// <summary>
		/// Долгота левого нижнего угла области на карте. От -180 до 180.
		/// </summary>
		public decimal X1 { get; set; }

		/// <summary>
		/// Широта левого нижнего угла области на карте. От -90 до 90.
		/// </summary>
		public decimal Y1 { get; set; }

		/// <summary>
		/// Долгота правого верхнего угла области на карте. От -180 до 180.
		/// </summary>
		public decimal X2 { get; set; }

		/// <summary>
		/// Широта правого верхнего угла области на карте. От -90 до 90.
		/// </summary>
		public decimal Y2 { get; set; }
	}
}
