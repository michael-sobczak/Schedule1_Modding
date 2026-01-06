using S1API.Internal.Utils;
using ScheduleOne.ItemFramework;
using ScheduleOne.Product;

namespace S1API.Products;

public static class ProductDefinitionWrapper
{
	public static ProductDefinition Wrap(ProductDefinition def)
	{
		ItemDefinition s1ItemDefinition = def.S1ItemDefinition;
		if (CrossType.Is<WeedDefinition>(s1ItemDefinition, out var result))
		{
			return new WeedDefinition(result);
		}
		if (CrossType.Is<MethDefinition>(s1ItemDefinition, out var result2))
		{
			return new MethDefinition(result2);
		}
		if (CrossType.Is<CocaineDefinition>(s1ItemDefinition, out var result3))
		{
			return new CocaineDefinition(result3);
		}
		return def;
	}
}
