using System;
using S1API.Internal.Utils;
using ScheduleOne;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.Money;
using UnityEngine;

namespace S1API.Money;

public static class Money
{
	private static MoneyManager Internal => NetworkSingleton<MoneyManager>.Instance;

	public static event Action? OnBalanceChanged;

	public static void ChangeCashBalance(float amount, bool visualizeChange = true, bool playCashSound = false)
	{
		MoneyManager obj = Internal;
		if (obj != null)
		{
			obj.ChangeCashBalance(amount, visualizeChange, playCashSound);
		}
		Money.OnBalanceChanged?.Invoke();
	}

	public static void CreateOnlineTransaction(string transactionName, float unitAmount, float quantity, string transactionNote)
	{
		MoneyManager obj = Internal;
		if (obj != null)
		{
			obj.CreateOnlineTransaction(transactionName, unitAmount, quantity, transactionNote);
		}
		Money.OnBalanceChanged?.Invoke();
	}

	public static float GetNetWorth()
	{
		return ((Object)(object)Internal != (Object)null) ? Internal.GetNetWorth() : 0f;
	}

	public static float GetCashBalance()
	{
		return ((Object)(object)Internal != (Object)null) ? Internal.cashBalance : 0f;
	}

	public static float GetOnlineBalance()
	{
		return ((Object)(object)Internal != (Object)null) ? Internal.sync___get_value_onlineBalance() : 0f;
	}

	public static void AddNetworthCalculation(Action<object> callback)
	{
		if ((Object)(object)Internal != (Object)null)
		{
			MoneyManager obj = Internal;
			obj.onNetworthCalculation = (Action<FloatContainer>)Delegate.Combine(obj.onNetworthCalculation, callback);
		}
	}

	public static void RemoveNetworthCalculation(Action<object> callback)
	{
		if ((Object)(object)Internal != (Object)null)
		{
			MoneyManager obj = Internal;
			obj.onNetworthCalculation = (Action<FloatContainer>)Delegate.Remove(obj.onNetworthCalculation, callback);
		}
	}

	public static CashInstance CreateCashInstance(float amount)
	{
		CashDefinition item = Registry.GetItem<CashDefinition>("cash");
		ItemInstance itemInstance = CrossType.As<ItemInstance>(((ItemDefinition)item).GetDefaultInstance(1));
		CashInstance cashInstance = new CashInstance(itemInstance);
		cashInstance.SetQuantity(amount);
		return cashInstance;
	}
}
