using Il2CppScheduleOne.ItemFramework;

namespace S1API.Items;

public class ItemInstance
{
	internal readonly ItemInstance S1ItemInstance;

	public ItemDefinition Definition => new ItemDefinition(S1ItemInstance.Definition);

	public int Quantity
	{
		get
		{
			return S1ItemInstance.Quantity;
		}
		set
		{
			S1ItemInstance.SetQuantity(value);
		}
	}

	public bool IsStackable => Definition.StackLimit > 1;

	internal ItemInstance(ItemInstance itemInstance)
	{
		S1ItemInstance = itemInstance;
	}
}
