using System.Collections.Generic;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Product;
using S1API.Internal.Utils;
using S1API.Items;
using S1API.Properties.Interfaces;
using UnityEngine;

namespace S1API.Products;

public class ProductInstance : ItemInstance
{
	internal ProductItemInstance S1ProductInstance => CrossType.As<ProductItemInstance>((object)S1ItemInstance);

	public bool IsPackaged => Object.op_Implicit((Object)(object)S1ProductInstance.AppliedPackaging);

	public PackagingDefinition AppliedPackaging => new PackagingDefinition((ItemDefinition)(object)S1ProductInstance.AppliedPackaging);

	public Quality Quality => ((QualityItemInstance)S1ProductInstance).Quality.ToAPI();

	public new ProductDefinition Definition => new ProductDefinition(((ItemInstance)S1ProductInstance).Definition);

	public IReadOnlyList<PropertyBase> Properties => Definition.Properties;

	internal ProductInstance(ProductItemInstance productInstance)
		: base((ItemInstance)(object)productInstance)
	{
	}
}
