using System;

namespace IES.FixedAssets.Core.Models.Requests.ResponsibleRequests
{
	public class UpdateResponsibleRequest
	{
		public Guid Id { get; set; }

		public string Fio { get; set; }
	}
}
