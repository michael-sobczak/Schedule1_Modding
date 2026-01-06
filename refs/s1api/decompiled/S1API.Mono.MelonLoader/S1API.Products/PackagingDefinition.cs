using S1API.Internal.Utils;
using S1API.Items;
using ScheduleOne.ItemFramework;
using ScheduleOne.Product.Packaging;

namespace S1API.Products;

public class PackagingDefinition : ItemDefinition
{
	internal PackagingDefinition S1PackagingDefinition => CrossType.As<PackagingDefinition>(base.S1ItemDefinition);

	public int Quantity => S1PackagingDefinition.Quantity;

	internal PackagingDefinition(ItemDefinition s1ItemDefinition)
		: base(s1ItemDefinition)
	{
	}
}
