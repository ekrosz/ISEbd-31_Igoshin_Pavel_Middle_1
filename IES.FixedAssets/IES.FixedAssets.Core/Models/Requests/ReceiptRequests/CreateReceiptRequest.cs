﻿using IES.FixedAssets.Common.Enums;
using System;

namespace IES.FixedAssets.Core.Models.Requests.ReceiptRequests
{
	public sealed class CreateReceiptRequest
	{
		public string ProviderId { get; set; }

		public string Sum { get; set; }

		public string ReceiptDate { get; set; }

		public string OperationType { get; set; }
	}
}
