using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Product;
using S1API.Internal.Utils;

namespace S1API.Products;

public sealed class ShroomInstance : ProductInstance
{
	internal ShroomInstance S1ShroomInstance => CrossType.As<ShroomInstance>((object)S1ItemInstance);

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
