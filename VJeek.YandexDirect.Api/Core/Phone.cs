using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VJeek.YandexDirect.Api.Core
{
	/// <summary>
	/// Телефонный номер.
	/// </summary>
	public class Phone
	{
		/// <summary>
		/// Телефонный код страны. Должен содержать от 1 до 4 символов. Допустимы значения:
		/// начинающиеся со знака «+» и состоящие из цифр;
		/// значение «8» в сочетании с кодом города «800».
		/// Например, «+7» для России.
		/// </summary>
		public string CountryCode { get; set; }

		/// <summary>
		/// Телефонный код города. От 1 до 5 цифр. Должен быть отличен от 0.
		/// </summary>
		public string CityCode { get; set; }

		/// <summary>
		/// Телефонный номер для связи. От 5 до 9 цифр, суммарно с кодом страны и города — от 8 до 17 цифр.
		/// </summary>
		public string PhoneNumber { get; set; }

		/// <summary>
		/// Добавочный телефонный номер для соединения через офисную АТС. От 1 до 6 цифр.
		/// </summary>
		public string Extension { get; set; }
	}
}
