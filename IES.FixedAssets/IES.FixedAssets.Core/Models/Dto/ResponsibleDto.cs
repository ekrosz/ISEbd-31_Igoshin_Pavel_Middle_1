using System;
using System.ComponentModel;

namespace IES.FixedAssets.Core.Models.Dto
{
	public class ResponsibleDto
	{
		public Guid Id { get; set; }

		[DisplayName("ФИО")]
		public string Fio { get; set; }
	}
}
