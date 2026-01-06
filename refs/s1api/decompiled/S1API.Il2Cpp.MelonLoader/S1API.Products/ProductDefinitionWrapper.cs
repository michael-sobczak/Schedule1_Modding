using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Product;
using S1API.Internal.Utils;

namespace S1API.Products;

public static class ProductDefinitionWrapper
{
	public static ProductDefinition Wrap(ProductDefinition def)
	{
		ItemDefinition s1ItemDefinition = def.S1ItemDefinition;
		if (CrossType.Is<WeedDefinition>((object)s1ItemDefinition, out WeedDefinition result))
		{
			return new WeedDefinition(result);
		}
		if (CrossType.Is<MethDefinition>((object)s1ItemDefinition, out MethDefinition result2))
		{
			return new MethDefinition(result2);
		}
		if (CrossType.Is<CocaineDefinition>((object)s1ItemDefinition, out CocaineDefinition result3))
		{
			return new CocaineDefinition(result3);
		}
		return def;
	}
}
