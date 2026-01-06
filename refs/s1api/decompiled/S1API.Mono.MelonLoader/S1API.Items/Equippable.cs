using ScheduleOne.Equipping;
using ScheduleOne.ItemFramework;

namespace S1API.Items;

public class Equippable
{
	internal Equippable S1Equippable { get; }

	public bool CanInteractWhenEquipped
	{
		get
		{
			return S1Equippable.CanInteractWhenEquipped;
		}
		set
		{
			S1Equippable.CanInteractWhenEquipped = value;
		}
	}

	public bool CanPickUpWhenEquipped
	{
		get
		{
			return S1Equippable.CanPickUpWhenEquipped;
		}
		set
		{
			S1Equippable.CanPickUpWhenEquipped = value;
		}
	}

	internal Equippable(Equippable equippable)
	{
		S1Equippable = equippable;
	}

	public virtual void Equip(ItemInstance item)
	{
		ItemInstance val = item?.S1ItemInstance;
		if (val != null)
		{
			S1Equippable.Equip(val);
		}
	}

	public virtual void Unequip()
	{
		S1Equippable.Unequip();
	}
}
