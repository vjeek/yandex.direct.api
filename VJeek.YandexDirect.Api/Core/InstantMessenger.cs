using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VJeek.YandexDirect.Api.Core
{
	/// <summary>
	/// Контакт для обмена мгновенными сообщениями.
	/// </summary>
	public class InstantMessenger
	{
		/// <summary>
		/// Тип системы мгновенного обмена сообщениями — icq, jabber, skype, mail_agent.
		/// </summary>
		public string MessengerClient { get; set; }

		/// <summary>
		/// Логин (идентификатор) в системе мгновенного обмена сообщениями. Не более 255 символов.
		/// </summary>
		public string MessengerLogin { get; set; }
	}
}
