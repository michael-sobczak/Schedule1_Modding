using System.Collections.Generic;
using System.Linq;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Product;

namespace S1API.Products;

public static class ProductManager
{
	public static ProductDefinition[] DiscoveredProducts => ((IEnumerable<ProductDefinition>)ProductManager.DiscoveredProducts.ToArray()).Select((ProductDefinition productDefinition) => ProductDefinitionWrapper.Wrap(new ProductDefinition((ItemDefinition)(object)productDefinition))).ToArray();
}
