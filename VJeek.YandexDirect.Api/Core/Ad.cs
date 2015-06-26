using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VJeek.YandexDirect.Api.Core
{
	/// <summary>
	/// Объявление.
	/// </summary>
	public class Ad
	{
		/// <summary>
		/// Идентификатор объявления.
		/// </summary>
		public long Id { get; set; }

		/// <summary>
		/// Идентификатор кампании, к которой относится объявление.
		/// </summary>
		public long CampaignId { get; set; }

		/// <summary>
		/// Идентификатор группы, к которой относится объявление.
		/// </summary>
		public long AdGroupId { get; set; }

		/// <summary>
		/// Статус объявления.
		/// </summary>
		public AdStatus Status { get; set; }

		/// <summary>
		/// Текстовое пояснение к статусу и/или причины отклонения на модерации.
		/// </summary>
		public string StatusClarification { get; set; }

		/// <summary>
		/// Состояние объявления.
		/// </summary>
		public AdState State { get; set; }


		/// <summary>
		/// Особая категория.
		/// На модерации объявлению может быть присвоена отметка о принадлежности рекламируемого товара или услуги к особой категории. При этом у объявления появляется параметр AdCategories, недоступный для изменения.
		/// Возможные категории:
		/// ABORTION — медицинские услуги по искусственному прерыванию беременности;
		/// ALCOHOL — алкогольная продукция, пиво и напитки на его основе;
		/// BABY_FOOD — детское питание;
		/// DIETARY_SUPPLEMENTS — БАД;
		/// MEDICINE — лекарственные средства, медицинская техника, медицинские услуги, в том числе методы лечения;
		/// PSEUDO_WEAPON — изделия, конструктивно сходные с оружием;
		/// TOBACCO — табак и табачные изделия.
		/// При показе таких объявлений выводятся предупреждения в соответствии с законодательством РФ.
		/// </summary>
		//todo:move to enum
		public string[] AdCategories { get; set; }

		/// <summary>
		/// Возрастная метка.
		/// </summary>
		public Age? AgeLabel { get; set; }

		/// <summary>
		/// Параметры объявления.
		/// </summary>
		public TextAd TextAd { get; set; }
	}
}
