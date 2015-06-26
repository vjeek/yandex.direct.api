using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

namespace VJeek.YandexDirect.Api.Core
{
	/// <summary>
	/// Визитка.
	/// </summary>
	public class VCardGetItem
	{
		/// <summary>
		/// Идентификатор визитки.
		/// </summary>
		public long Id { get; set; }

		/// <summary>
		/// Идентификатор кампании.
		/// </summary>
		public long CampaignId { get; set; }

		/// <summary>
		/// Страна. Не более 50 символов.
		/// </summary>
		public string Country { get; set; }

		/// <summary>
		/// Город. Не более 55 символов.
		/// </summary>
		public string City { get; set; }

		/// <summary>
		/// Режим работы организации или режим обслуживания клиентов. Задается как строка, в которой указан диапазон дней недели, рабочих часов и минут.
		/// Дни недели обозначаются цифрами от 0 до 6, где 0 — понедельник, 6 — воскресенье.
		/// Минуты задают кратно 15: 0, 15, 30 или 45.
		/// Формат строки: "день_с;день_по;час_с;минуты_с;час_до;мин_до".
		/// Например, строка "0;4;10;0;18;0" задает такой режим:
		/// 0;4 — с понедельника по пятницу;
		/// 10;0 — с 10 часов 0 минут;
		/// 18;0 — до 18 часов 0 минут.
		/// Режим может состоять из нескольких строк указанного формата, например: "0;4;10;0;18;0;5;6;11;0;16;0". Здесь в дополнение к предыдущему примеру задан режим:
		/// 5;6 — с субботы по воскресенье;
		/// 11;0 — с 11 часов 0 минут;
		/// 16;0 — до 16 часов 0 минут.
		/// Круглосуточный режим работы задается строкой "0;6;00;00;00;00".
		/// Не более 255 символов.
		/// </summary>
		public string WorkTime { get; set; }

		/// <summary>
		/// Структура, задающая номер телефона.
		/// </summary>
		public Phone Phone { get; set; }

		/// <summary>
		/// Улица. Не более 55 символов.
		/// </summary>
		public string Street { get; set; }

		/// <summary>
		/// Номер дома. Не более 30 символов.
		/// </summary>
		public string House { get; set; }

		/// <summary>
		/// Номер строения или корпуса. Не более 10 символов.
		/// </summary>
		public string Building { get; set; }

		/// <summary>
		/// Номер квартиры или офиса. Не более 100 символов.
		/// </summary>
		public string Apartment { get; set; }

		/// <summary>
		/// Структура, задающая контакт для обмена мгновенными сообщениями.
		/// </summary>
		public InstantMessenger InstantMessenger { get; set; }

		/// <summary>
		/// Название организации. Не более 255 символов.
		/// </summary>
		public string CompanyName { get; set; }

		/// <summary>
		/// Дополнительная информация о рекламируемом товаре или услуге. Не более 200 символов.
		/// </summary>
		public string ExtraMessage { get; set; }

		/// <summary>
		/// Адрес электронной почты. Не более 255 символов.
		/// </summary>
		public string ContactEmail { get; set; }

		/// <summary>
		/// Код ОГРН для юридических лиц. Не более 255 символов.
		/// </summary>
		public string Ogrn { get; set; }

		/// <summary>
		/// Идентификатор станции метро.
		/// </summary>
		public long MetroStationId { get; set; }

		/// <summary>
		/// Структура, описывающая положение метки на карте. Если не задана, метка ставится по указанному адресу клиента.
		/// </summary>
		public MapPoint PointOnMap { get; set; }

		/// <summary>
		/// Контактное лицо. Не более 155 символов.
		/// </summary>
		public string ContactPerson { get; set; }
	}
}
