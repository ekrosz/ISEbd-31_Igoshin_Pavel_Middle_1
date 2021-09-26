using System;

namespace IES.FixedAssets.Core.Models.Requests.ProviderRequests
{
	public sealed class UpdateProviderRequest
	{
		public Guid Id { get; set; }

		public string Name { get; set; }
	}
}
