using System;
using System.Collections;
using MelonLoader;
using S1API.Entities;
using S1API.Graffiti;
using S1API.Internal.Abstraction;
using S1API.Internal.Utils;
using S1API.Quests.Constants;
using ScheduleOne.Quests;
using UnityEngine;

namespace S1API.Quests;

public class QuestEntry
{
	internal readonly QuestEntry S1QuestEntry;

	public QuestState State => (QuestState)S1QuestEntry.State;

	public string Title
	{
		get
		{
			return S1QuestEntry.Title;
		}
		set
		{
			S1QuestEntry.SetEntryTitle(value);
		}
	}

	public Vector3 POIPosition
	{
		get
		{
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			object obj = ReflectionUtils.TryGetFieldOrProperty(S1QuestEntry, "PoILocation");
			Transform val = (Transform)((obj is Transform) ? obj : null);
			if (val != null && (Object)(object)val != (Object)null)
			{
				return val.position;
			}
			return Vector3.zero;
		}
		set
		{
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			object obj = ReflectionUtils.TryGetFieldOrProperty(S1QuestEntry, "PoILocation");
			Transform val = (Transform)((obj is Transform) ? obj : null);
			if (val != null && (Object)(object)val != (Object)null)
			{
				val.position = value;
				return;
			}
			Transform transform = ((Component)S1QuestEntry).transform;
			S1QuestEntry.PoILocation = transform;
			transform.position = value;
			S1QuestEntry.AutoCreatePoI = true;
		}
	}

	public event Action OnComplete
	{
		add
		{
			EventHelper.AddListener(value, S1QuestEntry.onComplete);
		}
		remove
		{
			EventHelper.RemoveListener(value, S1QuestEntry.onComplete);
		}
	}

	internal QuestEntry(QuestEntry questEntry)
	{
		S1QuestEntry = questEntry;
	}

	public void Begin()
	{
		S1QuestEntry.Begin();
	}

	public void Complete()
	{
		S1QuestEntry.Complete();
	}

	public void SetState(QuestState questState)
	{
		S1QuestEntry.SetState((EQuestState)questState, true);
	}

	public bool SetPOIToNPC<T>() where T : NPC
	{
		NPC nPC = NPC.Get<T>();
		if (nPC == null)
		{
			return false;
		}
		return SetPOIToNPC(nPC);
	}

	public bool SetPOIToNPC(NPC npc)
	{
		if (npc == null || (Object)(object)npc.gameObject == (Object)null)
		{
			return false;
		}
		Transform transform = npc.Transform;
		if ((Object)(object)transform == (Object)null)
		{
			return false;
		}
		S1QuestEntry.PoILocation = transform;
		S1QuestEntry.AutoCreatePoI = true;
		S1QuestEntry.AutoUpdatePoILocation = true;
		MelonCoroutines.Start(EnsurePOICreationForNPC(S1QuestEntry));
		return true;
	}

	public bool SetPOIToSpraySurface(SpraySurface spraySurface)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		if (spraySurface == null)
		{
			return false;
		}
		POIPosition = spraySurface.Position;
		return true;
	}

	private static IEnumerator EnsurePOICreationForNPC(QuestEntry questEntry)
	{
		yield return null;
		if ((Object)(object)questEntry.PoILocation != (Object)null && questEntry.AutoCreatePoI)
		{
			try
			{
				questEntry.CreatePoI();
			}
			catch (Exception ex)
			{
				Debug.LogWarning((object)("[S1API] Failed to create POI for quest entry: " + ex.Message));
			}
		}
	}
}
