using IES.FixedAssets.Database.Models;
using IES.FixedAssets.Database.Repositories.Contracts;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace IES.FixedAssets.Database.Extensions.RepositoryExtensions
{
	public static class ProviderRepositoryExtension
	{
		public static async Task<ProviderModel> GetProviderOrThrow(this IProviderRepository provaderRepository, Guid providerId)
			=> await provaderRepository.Get(providerId)
				?? throw new Exception("Данный поставщик не найден!");

		public static async Task IsUniqueNameOrThrow(this IProviderRepository provaderRepository, string name)
		{
			var entities = await provaderRepository.GetAll();

			var entity = entities
				.FirstOrDefault(e => string.Equals(e.Name, name, StringComparison.OrdinalIgnoreCase));

			if (entity != null)
				throw new Exception("Поставщик с данным именем уже существует!");
		}

		public static async Task IsUniqueNameOrThrow(this IProviderRepository provaderRepository, Guid id, string name)
		{
			var entities = await provaderRepository.GetAll();

			var entity = entities
				.FirstOrDefault(e => string.Equals(e.Name, name, StringComparison.OrdinalIgnoreCase));

			if (entity != null && entity.Id != id)
				throw new Exception("Поставщик с данным именем уже существует!");
		}
	}
}
