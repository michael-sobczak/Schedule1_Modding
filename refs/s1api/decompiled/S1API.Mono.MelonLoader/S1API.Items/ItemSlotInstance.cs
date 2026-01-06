using S1API.Internal.Utils;
using S1API.Money;
using S1API.Products;
using ScheduleOne.ItemFramework;
using ScheduleOne.Product;

namespace S1API.Items;

public class ItemSlotInstance
{
	internal readonly ItemSlot S1ItemSlot;

	public int Quantity => S1ItemSlot.Quantity;

	public ItemInstance? ItemInstance
	{
		get
		{
			if (CrossType.Is<ProductItemInstance>(S1ItemSlot.ItemInstance, out var result))
			{
				return new ProductInstance(result);
			}
			if (CrossType.Is<CashInstance>(S1ItemSlot.ItemInstance, out var result2))
			{
				return new CashInstance((ItemInstance)(object)result2);
			}
			if (CrossType.Is<ItemInstance>(S1ItemSlot.ItemInstance, out var result3))
			{
				return new ItemInstance(result3);
			}
			return null;
		}
	}

	internal ItemSlotInstance(ItemSlot itemSlot)
	{
		S1ItemSlot = itemSlot;
	}

	public void AddQuantity(int amount)
	{
		S1ItemSlot.ChangeQuantity(amount, false);
	}
}
