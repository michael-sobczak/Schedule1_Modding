using System.Collections.Generic;
using Il2CppScheduleOne.Quests;
using Il2CppScheduleOne.ScriptableObjects;
using S1API.Conditions;
using S1API.Internal.Utils;
using S1API.PhoneCalls.Constants;

namespace S1API.PhoneCalls;

public class CallStageEntry
{
	internal readonly Stage S1Stage;

	protected readonly List<SystemTriggerEntry> StartTriggerEntries = new List<SystemTriggerEntry>();

	protected readonly List<SystemTriggerEntry> DoneTriggerEntries = new List<SystemTriggerEntry>();

	public string Text
	{
		get
		{
			return S1Stage.Text;
		}
		set
		{
			S1Stage.Text = value;
		}
	}

	internal CallStageEntry(Stage stage)
	{
		S1Stage = stage;
	}

	public SystemTriggerEntry AddSystemTrigger(SystemTriggerType triggerType)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		SystemTrigger val = new SystemTrigger();
		SystemTriggerEntry systemTriggerEntry = new SystemTriggerEntry(val);
		switch (triggerType)
		{
		case SystemTriggerType.StartTrigger:
			S1Stage.OnStartTriggers = S1Stage.OnStartTriggers.AddItemToArray<SystemTrigger>((SystemTrigger[]?)(object)new SystemTrigger[1] { val });
			StartTriggerEntries.Add(systemTriggerEntry);
			break;
		case SystemTriggerType.DoneTrigger:
			S1Stage.OnDoneTriggers = S1Stage.OnDoneTriggers.AddItemToArray<SystemTrigger>((SystemTrigger[]?)(object)new SystemTrigger[1] { val });
			DoneTriggerEntries.Add(systemTriggerEntry);
			break;
		}
		return systemTriggerEntry;
	}
}
