using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using S1API.Internal.Abstraction;
using UnityEngine;

namespace S1API.Items;

public class ItemDefinition : IGUIDReference
{
	internal ItemDefinition S1ItemDefinition { get; }

	public string ID
	{
		get
		{
			return S1ItemDefinition.ID;
		}
		set
		{
			S1ItemDefinition.ID = value;
		}
	}

	public string Name
	{
		get
		{
			return S1ItemDefinition.Name;
		}
		set
		{
			S1ItemDefinition.Name = value;
		}
	}

	public string Description
	{
		get
		{
			return S1ItemDefinition.Description;
		}
		set
		{
			S1ItemDefinition.Description = value;
		}
	}

	public int StackLimit
	{
		get
		{
			return S1ItemDefinition.StackLimit;
		}
		set
		{
			S1ItemDefinition.StackLimit = value;
		}
	}

	public ItemCategory Category
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Expected I4, but got Unknown
			return (ItemCategory)S1ItemDefinition.Category;
		}
		set
		{
			S1ItemDefinition.Category = (EItemCategory)value;
		}
	}

	public Sprite Icon
	{
		get
		{
			return S1ItemDefinition.Icon;
		}
		set
		{
			S1ItemDefinition.Icon = value;
		}
	}

	public bool AvailableInDemo
	{
		get
		{
			return S1ItemDefinition.AvailableInDemo;
		}
		set
		{
			S1ItemDefinition.AvailableInDemo = value;
		}
	}

	public LegalStatus LegalStatus
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Expected I4, but got Unknown
			return (LegalStatus)S1ItemDefinition.legalStatus;
		}
		set
		{
			S1ItemDefinition.legalStatus = (ELegalStatus)value;
		}
	}

	public Color LabelDisplayColor
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			return S1ItemDefinition.LabelDisplayColor;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			S1ItemDefinition.LabelDisplayColor = value;
		}
	}

	public string[] Keywords
	{
		get
		{
			return Il2CppArrayBase<string>.op_Implicit((Il2CppArrayBase<string>)(object)S1ItemDefinition.Keywords);
		}
		set
		{
			S1ItemDefinition.Keywords = Il2CppStringArray.op_Implicit(value);
		}
	}

	public string GUID => ID;

	internal ItemDefinition(ItemDefinition definition)
	{
		S1ItemDefinition = definition;
	}

	public virtual ItemInstance CreateInstance(int quantity = 1)
	{
		ItemInstance defaultInstance = S1ItemDefinition.GetDefaultInstance(quantity);
		return new ItemInstance(defaultInstance);
	}

	public override bool Equals(object? obj)
	{
		return obj is ItemDefinition itemDefinition && (Object)(object)S1ItemDefinition == (Object)(object)itemDefinition.S1ItemDefinition;
	}

	public override int GetHashCode()
	{
		return ((Object)S1ItemDefinition).GetHashCode();
	}

	public static bool operator ==(ItemDefinition? a, ItemDefinition? b)
	{
		if ((object)a == b)
		{
			return true;
		}
		if ((object)a == null || (object)b == null)
		{
			return false;
		}
		return a.S1ItemDefinition == b.S1ItemDefinition;
	}

	public static bool operator !=(ItemDefinition? a, ItemDefinition? b)
	{
		if ((object)a == b)
		{
			return false;
		}
		if ((object)a == null || (object)b == null)
		{
			return true;
		}
		return a.S1ItemDefinition != b.S1ItemDefinition;
	}
}
