using IES.FixedAssets.Database.Models;
using IES.FixedAssets.Database.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IES.FixedAssets.Database.Extensions.RepositoryExtensions
{
	public static class FixedAssetRepositoryExtension
	{
		public async static Task IsUniqueNameOrThrow(this IFixedAssetRepository fixedAssetRepository, string name)
		{
			var entity = await fixedAssetRepository.GetByName(name);

			if (entity != null)
			{
				throw new Exception("ОС с таким названием уже существует!");
			}
		}

		public async static Task<FixedAssetModel> GetFixedAssetOrThrow(this IFixedAssetRepository fixedAssetRepository, Guid fixedAssetId)
		{
			var entity = await fixedAssetRepository.GetById(fixedAssetId);

			if (entity == null)
				throw new Exception("Данное ОС не найдено!");

			return entity;
		}
	}
}
