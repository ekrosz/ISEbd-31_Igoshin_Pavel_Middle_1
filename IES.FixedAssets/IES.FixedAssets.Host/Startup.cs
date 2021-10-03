using AutoMapper;
using IES.FixedAssets.Common.Helpers.Tools;
using IES.FixedAssets.Core.Models.Dto;
using IES.FixedAssets.Core.Models.Requests.EntryJournalRequests;
using IES.FixedAssets.Core.Models.Requests.FixedAssetRequest;
using IES.FixedAssets.Core.Models.Requests.ProviderRequests;
using IES.FixedAssets.Core.Models.Requests.ReceiptRequests;
using IES.FixedAssets.Core.Models.Requests.ReceiptTableRequests;
using IES.FixedAssets.Core.Services;
using IES.FixedAssets.Core.Services.Contracts;
using IES.FixedAssets.Database;
using IES.FixedAssets.Database.Models;
using IES.FixedAssets.Database.Repositories;
using IES.FixedAssets.Database.Repositories.Contracts;
using Unity;
using Unity.Lifetime;

namespace IES.FixedAssets.Host
{
	public static class Startup
	{
		public static IUnityContainer BuildUnityContainer()
		{
			var container = new UnityContainer();

			AddDatabase(container);
			AddRepositories(container);
			AddServices(container);
			AddMappings(container);

			return container;
		}

		private static void AddDatabase(IUnityContainer container)
		{
			var context = new FixedAssetsContext();

			container.RegisterInstance<FixedAssetsContext>(context);
		}

		private static void AddRepositories(IUnityContainer container)
		{
			container.RegisterType<IAccountChartRepository, AccountChartRepository>(new HierarchicalLifetimeManager());
			container.RegisterType<IEntryJournalRepository, EntryJournalRepository>(new HierarchicalLifetimeManager());
			container.RegisterType<IFixedAssetRepository, FixedAssetRepository>(new HierarchicalLifetimeManager());
			container.RegisterType<IProviderRepository, ProviderRepository>(new HierarchicalLifetimeManager());
			container.RegisterType<IReceiptRepository, ReceiptRepository>(new HierarchicalLifetimeManager());
			container.RegisterType<IReceiptTableRepository, ReceiptTableRepository>(new HierarchicalLifetimeManager());
		}

		private static void AddServices(IUnityContainer container)
		{
			container.RegisterType<IAccountChartService, AccountChartService>(new HierarchicalLifetimeManager());
			container.RegisterType<IEntryJournalService, EntryJournalService>(new HierarchicalLifetimeManager());
			container.RegisterType<IFixedAssetService, FixedAssetService>(new HierarchicalLifetimeManager());
			container.RegisterType<IProviderService, ProviderService>(new HierarchicalLifetimeManager());
			container.RegisterType<IReceiptService, ReceiptService>(new HierarchicalLifetimeManager());
			container.RegisterType<IReceiptTableService, ReceiptTableService>(new HierarchicalLifetimeManager());
		}

		private static void AddMappings(IUnityContainer container)
		{
			var config = new MapperConfiguration(cfg => 
			{
				cfg.CreateMap<CreditAccountChartModel, AccountChartDto>();
				cfg.CreateMap<DebitAccountChartModel, AccountChartDto>();
				cfg.CreateMap<EntryJournalModel, EntryJournalDto>();
				cfg.CreateMap<FixedAssetModel, FixedAssetDto>();
				cfg.CreateMap<ProviderModel, ProviderDto>();
				cfg.CreateMap<ReceiptModel, ReceiptDto>()
				.ForMember(dto => dto.OperationType, from => from.MapFrom(entity => entity.OperationType.GetDescription()));
				cfg.CreateMap<ReceiptTableModel, ReceiptTableDto>();

				cfg.CreateMap<CreateEntryJournalRequest, EntryJournalModel>();
				cfg.CreateMap<CreateFixedAssetRequest, FixedAssetModel>();
				cfg.CreateMap<CreateProviderRequest, ProviderModel>();
				cfg.CreateMap<CreateReceiptRequest, ReceiptModel>();
				cfg.CreateMap<CreateReceiptTableRequest, ReceiptTableModel>();

				cfg.CreateMap<UpdateEntryJournalRequest, EntryJournalModel>();
				cfg.CreateMap<UpdateFixedAssetRequest, FixedAssetModel>();
				cfg.CreateMap<UpdateProviderRequest, ProviderModel>();
				cfg.CreateMap<UpdateReceiptRequest, ReceiptModel>();
				cfg.CreateMap<UpdateReceiptTableRequest, ReceiptTableModel>();
			});

			var mapper = config.CreateMapper();

			container.RegisterInstance<IMapper>(mapper);
		}
	}
}
