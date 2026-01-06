using System.Linq;
using ScheduleOne.ItemFramework;
using ScheduleOne.Product;

namespace S1API.Products;

public static class ProductManager
{
	public static ProductDefinition[] DiscoveredProducts => (from productDefinition in ProductManager.DiscoveredProducts.ToArray()
		select ProductDefinitionWrapper.Wrap(new ProductDefinition((ItemDefinition)(object)productDefinition))).ToArray();
}
