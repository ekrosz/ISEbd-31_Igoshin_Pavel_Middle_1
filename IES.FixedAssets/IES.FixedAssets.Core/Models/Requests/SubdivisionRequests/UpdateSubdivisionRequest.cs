using System;

namespace IES.FixedAssets.Core.Models.Requests.SubdivisionRequests
{
	public class UpdateSubdivisionRequest
	{
		public Guid Id { get; set; }

		public string Name { get; set; }
	}
}
