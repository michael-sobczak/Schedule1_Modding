using S1API.Internal.Utils;
using ScheduleOne.ItemFramework;
using ScheduleOne.Product;

namespace S1API.Products;

public sealed class ShroomInstance : ProductInstance
{
	internal ShroomInstance S1ShroomInstance => CrossType.As<ShroomInstance>(S1ItemInstance);

	public new ShroomDefinition Definition
	{
		get
		{
			ItemDefinition definition = ((ItemInstance)S1ShroomInstance).Definition;
			return new ShroomDefinition((ShroomDefinition)(object)((definition is ShroomDefinition) ? definition : null));
		}
	}

	public string Name => ((ItemInstance)S1ShroomInstance).Name;

	internal ShroomInstance(ShroomInstance shroomInstance)
		: base((ProductItemInstance)(object)shroomInstance)
	{
	}
}
