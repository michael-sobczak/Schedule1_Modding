using System.Collections.Generic;
using System.Globalization;
using S1API.Entities;
using S1API.Products;
using S1API.Quests.Constants;
using ScheduleOne;

namespace S1API.Console;

public static class ConsoleHelper
{
	public static void Submit(string command)
	{
		Console.SubmitCommand(command);
	}

	public static void Submit(IEnumerable<string> arguments)
	{
		List<string> list = new List<string>(arguments);
		Console.SubmitCommand(list);
	}

	public static void RunCashCommand(int amount)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		ChangeCashCommand val = new ChangeCashCommand();
		List<string> list = new List<string>();
		list.Add(amount.ToString());
		((ConsoleCommand)val).Execute(list);
	}

	public static void RunOnlineBalanceCommand(int amount)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		ChangeOnlineBalanceCommand val = new ChangeOnlineBalanceCommand();
		List<string> list = new List<string>();
		list.Add(amount.ToString());
		((ConsoleCommand)val).Execute(list);
	}

	public static void AddItemToInventory(string itemCode, int? quantity = null)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		AddItemToInventoryCommand val = new AddItemToInventoryCommand();
		List<string> list = new List<string>();
		list.Add(itemCode);
		if (quantity.HasValue)
		{
			list.Add(quantity.Value.ToString());
		}
		((ConsoleCommand)val).Execute(list);
	}

	public static void ClearInventory()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		ClearInventoryCommand val = new ClearInventoryCommand();
		List<string> list = new List<string>();
		((ConsoleCommand)val).Execute(list);
	}

	public static void ClearTrash()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		ClearTrash val = new ClearTrash();
		List<string> list = new List<string>();
		((ConsoleCommand)val).Execute(list);
	}

	public static void ClearWanted()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		ClearWanted val = new ClearWanted();
		List<string> list = new List<string>();
		((ConsoleCommand)val).Execute(list);
	}

	public static void GiveXp(int amount)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		GiveXP val = new GiveXP();
		List<string> list = new List<string>();
		list.Add(amount.ToString());
		((ConsoleCommand)val).Execute(list);
	}

	public static void GrowPlants()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		GrowPlants val = new GrowPlants();
		List<string> list = new List<string>();
		((ConsoleCommand)val).Execute(list);
	}

	public static void LowerWanted()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		LowerWanted val = new LowerWanted();
		List<string> list = new List<string>();
		((ConsoleCommand)val).Execute(list);
	}

	public static void RaiseWanted()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		RaisedWanted val = new RaisedWanted();
		List<string> list = new List<string>();
		((ConsoleCommand)val).Execute(list);
	}

	public static void SaveGame()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		Save val = new Save();
		List<string> list = new List<string>();
		((ConsoleCommand)val).Execute(list);
	}

	public static void DiscoverProduct(string productCode)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		SetDiscovered val = new SetDiscovered();
		List<string> list = new List<string>();
		list.Add(productCode);
		((ConsoleCommand)val).Execute(list);
	}

	public static void SetPlayerEnergyLevel(float amount)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		SetEnergy val = new SetEnergy();
		List<string> list = new List<string>();
		list.Add(amount.ToString(CultureInfo.InvariantCulture));
		((ConsoleCommand)val).Execute(list);
	}

	public static void SetPlayerHealth(float amount)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		SetHealth val = new SetHealth();
		List<string> list = new List<string>();
		list.Add(amount.ToString(CultureInfo.InvariantCulture));
		((ConsoleCommand)val).Execute(list);
	}

	public static void SetPlayerJumpMultiplier(float multiplier)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		SetJumpMultiplier val = new SetJumpMultiplier();
		List<string> list = new List<string>();
		list.Add(multiplier.ToString(CultureInfo.InvariantCulture));
		((ConsoleCommand)val).Execute(list);
	}

	public static void SetLawIntensity(float intensity)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		SetLawIntensity val = new SetLawIntensity();
		List<string> list = new List<string>();
		list.Add(intensity.ToString(CultureInfo.InvariantCulture));
		((ConsoleCommand)val).Execute(list);
	}

	public static void SetPlayerMoveSpeedMultiplier(float multiplier)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		SetMoveSpeedCommand val = new SetMoveSpeedCommand();
		List<string> list = new List<string>();
		list.Add(multiplier.ToString(CultureInfo.InvariantCulture));
		((ConsoleCommand)val).Execute(list);
	}

	public static void SetQuality(Quality quality)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		SetQuality val = new SetQuality();
		List<string> list = new List<string>();
		list.Add(quality.ToString());
		((ConsoleCommand)val).Execute(list);
	}

	public static void SetQuestState(string questName, QuestState state)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		SetQuestState val = new SetQuestState();
		List<string> list = new List<string>();
		list.Add(questName);
		list.Add(state.ToString());
		((ConsoleCommand)val).Execute(list);
	}

	public static void SetNpcRelationship(string npcId, float level)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		SetRelationship val = new SetRelationship();
		List<string> list = new List<string>();
		list.Add(npcId);
		list.Add(level.ToString(CultureInfo.InvariantCulture));
		((ConsoleCommand)val).Execute(list);
	}

	public static void SetNpcRelationship(NPC npc, float level)
	{
		SetNpcRelationship(npc.ID, level);
	}

	public static void UnlockNpc(NPC npc)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		SetUnlocked val = new SetUnlocked();
		List<string> list = new List<string>();
		list.Add(npc.ID);
		((ConsoleCommand)val).Execute(list);
	}

	public static void SetTime(string hhmm)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		SetTimeCommand val = new SetTimeCommand();
		List<string> list = new List<string>();
		list.Add(hhmm);
		((ConsoleCommand)val).Execute(list);
	}

	public static void SpawnVehicle(string vehicleCode)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		SpawnVehicleCommand val = new SpawnVehicleCommand();
		List<string> list = new List<string>();
		list.Add(vehicleCode);
		((ConsoleCommand)val).Execute(list);
	}
}
