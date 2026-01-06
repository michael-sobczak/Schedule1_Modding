using Il2CppScheduleOne.ItemFramework;
using S1API.Internal.Utils;
using S1API.Items;
using UnityEngine;

namespace S1API.Money;

public class CashInstance : ItemInstance
{
	internal CashInstance S1CashInstance => CrossType.As<CashInstance>((object)S1ItemInstance);

	internal CashInstance(ItemInstance itemInstance)
		: base(itemInstance)
	{
	}

	public void AddQuantity(float amount)
	{
		S1CashInstance.SetBalance(Mathf.Clamp(S1CashInstance.Balance + amount, 0f, float.MaxValue), false);
	}

	public void SetQuantity(float newQuantity)
	{
		S1CashInstance.SetBalance(newQuantity, false);
	}
}
