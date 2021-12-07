using IES.FixedAssets.Database.Models;
using IES.FixedAssets.Database.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IES.FixedAssets.Database.Extensions.RepositoryExtensions
{
	public static class FixedAssetRepositoryExtension
	{
		public async static Task IsUniqueNameOrThrow(this IFixedAssetRepository fixedAssetRepository, string name)
		{
			var entities = await fixedAssetRepository.GetAll();

			var entity = entities
				.FirstOrDefault(e => string.Equals(e.Name, name, StringComparison.OrdinalIgnoreCase));

			if (entity != null)
			{
				throw new Exception("ОС с таким наименованием уже существует!");
			}
		}

		public async static Task IsUniqueNameOrThrow(this IFixedAssetRepository fixedAssetRepository, Guid id, string name)
		{
			var entities = await fixedAssetRepository.GetAll();

			var entity = entities
				.FirstOrDefault(e => string.Equals(e.Name, name, StringComparison.OrdinalIgnoreCase));

			if (entity != null && entity.Id != id)
			{
				throw new Exception("ОС с таким наименованием уже существует!");
			}
		}

		public async static Task<FixedAssetModel> GetFixedAssetOrThrow(this IFixedAssetRepository fixedAssetRepository, Guid fixedAssetId) 
			=> await fixedAssetRepository.GetById(fixedAssetId)
				?? throw new Exception("Данное ОС не найдено!");
	}
}
