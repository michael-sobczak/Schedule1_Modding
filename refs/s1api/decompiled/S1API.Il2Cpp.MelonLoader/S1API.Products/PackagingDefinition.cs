using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Product.Packaging;
using S1API.Internal.Utils;
using S1API.Items;

namespace S1API.Products;

public class PackagingDefinition : ItemDefinition
{
	internal PackagingDefinition S1PackagingDefinition => CrossType.As<PackagingDefinition>((object)base.S1ItemDefinition);

	public int Quantity => S1PackagingDefinition.Quantity;

	internal PackagingDefinition(ItemDefinition s1ItemDefinition)
		: base(s1ItemDefinition)
	{
	}
}
