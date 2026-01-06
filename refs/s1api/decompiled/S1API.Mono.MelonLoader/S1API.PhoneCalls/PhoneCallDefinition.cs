using System;
using System.Collections.Generic;
using S1API.Entities;
using S1API.Internal.Utils;
using ScheduleOne.ScriptableObjects;
using UnityEngine;

namespace S1API.PhoneCalls;

public abstract class PhoneCallDefinition
{
	public CallerDefinition? Caller;

	public readonly PhoneCallData S1PhoneCallData;

	protected readonly List<CallStageEntry> StageEntries = new List<CallStageEntry>();

	protected PhoneCallDefinition(string name, Sprite? profilePicture = null)
	{
		S1PhoneCallData = ScriptableObject.CreateInstance<PhoneCallData>();
		PhoneCallData s1PhoneCallData = S1PhoneCallData;
		if (s1PhoneCallData.Stages == null)
		{
			s1PhoneCallData.Stages = Array.Empty<Stage>();
		}
		AddCallerID(name, profilePicture);
	}

	protected PhoneCallDefinition(NPC? npcCallerID)
	{
		S1PhoneCallData = ScriptableObject.CreateInstance<PhoneCallData>();
		PhoneCallData s1PhoneCallData = S1PhoneCallData;
		if (s1PhoneCallData.Stages == null)
		{
			s1PhoneCallData.Stages = Array.Empty<Stage>();
		}
		AddCallerID(npcCallerID);
	}

	protected CallerDefinition AddCallerID(string name, Sprite? profilePicture = null)
	{
		CallerID val = ScriptableObject.CreateInstance<CallerID>();
		val.Name = name;
		val.ProfilePicture = profilePicture;
		S1PhoneCallData.CallerID = val;
		Caller = new CallerDefinition(val)
		{
			Name = name,
			ProfilePicture = profilePicture
		};
		return Caller;
	}

	protected CallerDefinition AddCallerID(NPC? npc)
	{
		CallerID val = ScriptableObject.CreateInstance<CallerID>();
		val.Name = npc?.FullName ?? "Unknown Caller";
		val.ProfilePicture = npc?.Icon;
		S1PhoneCallData.CallerID = val;
		Caller = new CallerDefinition(val)
		{
			Name = (npc?.FullName ?? "Unknown Caller"),
			ProfilePicture = npc?.Icon
		};
		return Caller;
	}

	protected CallStageEntry AddStage(string text)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		Stage val = new Stage
		{
			Text = text
		};
		S1PhoneCallData.Stages = S1PhoneCallData.Stages.AddItemToArray(val);
		CallStageEntry callStageEntry = new CallStageEntry(val)
		{
			Text = text
		};
		StageEntries.Add(callStageEntry);
		return callStageEntry;
	}

	public void Completed()
	{
		S1PhoneCallData.Completed();
	}
}
