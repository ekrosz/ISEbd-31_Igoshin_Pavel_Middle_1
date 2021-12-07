using System;
using System.ComponentModel;

namespace IES.FixedAssets.Core.Models.Dto
{
	public class SubdivisionDto
	{
		public Guid Id { get; set; }

		[DisplayName("Наименование")]
		public string Name { get; set; }
	}
}
