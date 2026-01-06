using Il2CppScheduleOne.ItemFramework;
using S1API.Internal.Utils;
using S1API.Items;

namespace S1API.Money;

public class CashDefinition : ItemDefinition
{
	internal CashDefinition S1CashDefinition => CrossType.As<CashDefinition>((object)base.S1ItemDefinition);

	internal CashDefinition(CashDefinition s1ItemDefinition)
		: base((ItemDefinition)(object)s1ItemDefinition)
	{
	}

	public override ItemInstance CreateInstance(int quantity = 1)
	{
		return new CashInstance(((ItemDefinition)S1CashDefinition).GetDefaultInstance(quantity));
	}
}
