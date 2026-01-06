using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using HarmonyLib;
using MelonLoader;
using S1API.Entities;
using S1API.Internal.Abstraction;
using S1API.Internal.Utils;
using S1API.Quests.Constants;
using S1API.Saveables;
using ScheduleOne.DevUtilities;
using ScheduleOne.Map;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Quests;
using ScheduleOne.UI;
using ScheduleOne.UI.Phone.ContactsApp;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace S1API.Quests;

public abstract class Quest : Saveable
{
	public readonly List<QuestEntry> QuestEntries = new List<QuestEntry>();

	[SaveableField("QuestData")]
	private readonly QuestData _questData;

	internal readonly Quest S1Quest;

	private readonly GameObject _gameObject;

	protected abstract string Title { get; }

	protected abstract string Description { get; }

	protected virtual bool AutoBegin => true;

	protected QuestState QuestState => (QuestState)S1Quest.State;

	internal string? SaveFolder => S1Quest.SaveFolderName;

	protected virtual Sprite? QuestIcon => null;

	public event Action OnComplete
	{
		add
		{
			EventHelper.AddListener(value, S1Quest.onComplete);
		}
		remove
		{
			EventHelper.RemoveListener(value, S1Quest.onComplete);
		}
	}

	public event Action? OnFail;

	public Quest()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected O, but got Unknown
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected O, but got Unknown
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected O, but got Unknown
		_questData = new QuestData(GetType().Name);
		_gameObject = new GameObject("Quest");
		S1Quest = _gameObject.AddComponent<Quest>();
		S1Quest.StaticGUID = string.Empty;
		FieldInfo fieldInfo = AccessTools.Field(typeof(Quest), "title");
		fieldInfo.SetValue(S1Quest, Title);
		S1Quest.onActiveState = new UnityEvent();
		S1Quest.onComplete = new UnityEvent();
		S1Quest.onInitialComplete = new UnityEvent();
		S1Quest.onQuestBegin = new UnityEvent();
		S1Quest.onQuestEnd = new UnityEvent<EQuestState>();
		S1Quest.onTrackChange = new UnityEvent<bool>();
		S1Quest.TrackOnBegin = true;
		S1Quest.AutoCompleteOnAllEntriesComplete = true;
		FieldInfo fieldInfo2 = AccessTools.Field(typeof(Quest), "autoInitialize");
		fieldInfo2.SetValue(S1Quest, false);
		GameObject val = new GameObject("IconPrefab", new Type[3]
		{
			CrossType.Of<RectTransform>(),
			CrossType.Of<CanvasRenderer>(),
			CrossType.Of<Image>()
		});
		val.transform.SetParent(_gameObject.transform);
		Image component = val.GetComponent<Image>();
		component.sprite = QuestIcon ?? ((App<ContactsApp>)(object)PlayerSingleton<ContactsApp>.Instance).AppIcon;
		S1Quest.IconPrefab = val.GetComponent<RectTransform>();
		GameObject val2 = new GameObject("PoIUIPrefab", new Type[4]
		{
			CrossType.Of<RectTransform>(),
			CrossType.Of<CanvasRenderer>(),
			CrossType.Of<EventTrigger>(),
			CrossType.Of<Button>()
		});
		val2.transform.SetParent(_gameObject.transform);
		GameObject val3 = new GameObject("MainLabel", new Type[3]
		{
			CrossType.Of<RectTransform>(),
			CrossType.Of<CanvasRenderer>(),
			CrossType.Of<Text>()
		});
		val3.transform.SetParent(val2.transform);
		GameObject val4 = new GameObject("IconContainer", new Type[3]
		{
			CrossType.Of<RectTransform>(),
			CrossType.Of<CanvasRenderer>(),
			CrossType.Of<Image>()
		});
		val4.transform.SetParent(val2.transform);
		Image component2 = val4.GetComponent<Image>();
		component2.sprite = QuestIcon ?? ((App<ContactsApp>)(object)PlayerSingleton<ContactsApp>.Instance).AppIcon;
		RectTransform component3 = ((Component)component2).GetComponent<RectTransform>();
		component3.sizeDelta = new Vector2(20f, 20f);
		GameObject val5 = new GameObject("POIPrefab");
		val5.SetActive(false);
		val5.transform.SetParent(_gameObject.transform);
		POI val6 = val5.AddComponent<POI>();
		val6.DefaultMainText = "Did it work?";
		FieldInfo fieldInfo3 = AccessTools.Field(typeof(POI), "UIPrefab");
		fieldInfo3.SetValue(val6, val2);
		S1Quest.PoIPrefab = val5;
		S1Quest.onQuestEnd.AddListener((UnityAction<EQuestState>)OnQuestEnded);
	}

	internal override void CreateInternal()
	{
		base.CreateInternal();
		S1Quest.InitializeQuest(Title, Description, Array.Empty<QuestEntryData>(), S1Quest?.StaticGUID);
		if (AutoBegin)
		{
			Quest s1Quest = S1Quest;
			if (s1Quest != null)
			{
				s1Quest.Begin(true);
			}
		}
	}

	internal override void SaveInternal(string folderPath, ref List<string> extraSaveables)
	{
		string text = Path.Combine(folderPath, S1Quest.SaveFolderName);
		if (!Directory.Exists(text))
		{
			Directory.CreateDirectory(text);
		}
		base.SaveInternal(text, ref extraSaveables);
	}

	internal void OnQuestEnded(EQuestState questState)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Invalid comparison between Unknown and I4
		if ((int)questState == 3)
		{
			this.OnFail?.Invoke();
		}
		Quest.Quests.Remove(S1Quest);
		QuestManager.Quests.Remove(this);
	}

	protected QuestEntry AddEntry(string title, Vector3? poiPosition = null)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		GameObject val = new GameObject("QuestEntry");
		Transform transform = val.transform;
		GameObject gameObject = _gameObject;
		transform.SetParent((gameObject != null) ? gameObject.transform : null);
		QuestEntry val2 = val.AddComponent<QuestEntry>();
		if (!poiPosition.HasValue)
		{
			val2.PoILocation = null;
			val2.AutoCreatePoI = false;
		}
		else
		{
			val2.PoILocation = val.transform;
			val2.AutoCreatePoI = true;
		}
		S1Quest.Entries.Add(val2);
		QuestEntry questEntry = new QuestEntry(val2)
		{
			Title = title
		};
		if (poiPosition.HasValue)
		{
			questEntry.POIPosition = poiPosition.Value;
		}
		QuestEntries.Add(questEntry);
		return questEntry;
	}

	protected QuestEntry AddEntry(string title, NPC npc)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		if (npc == null)
		{
			throw new ArgumentNullException("npc");
		}
		GameObject val = new GameObject("QuestEntry");
		Transform transform = val.transform;
		GameObject gameObject = _gameObject;
		transform.SetParent((gameObject != null) ? gameObject.transform : null);
		val.SetActive(true);
		QuestEntry val2 = val.AddComponent<QuestEntry>();
		Transform transform2 = npc.Transform;
		if ((Object)(object)transform2 == (Object)null)
		{
			val2.PoILocation = null;
			val2.AutoCreatePoI = false;
			val2.AutoUpdatePoILocation = false;
		}
		else
		{
			val2.PoILocation = transform2;
			val2.AutoCreatePoI = true;
			val2.AutoUpdatePoILocation = true;
		}
		S1Quest.Entries.Add(val2);
		QuestEntry questEntry = new QuestEntry(val2)
		{
			Title = title
		};
		QuestEntries.Add(questEntry);
		if ((Object)(object)val2.PoILocation != (Object)null && val2.AutoCreatePoI)
		{
			MelonCoroutines.Start(EnsurePOICreation(val2));
		}
		return questEntry;
	}

	public void Begin()
	{
		Quest s1Quest = S1Quest;
		if (s1Quest != null)
		{
			s1Quest.Begin(true);
		}
	}

	public void Cancel()
	{
		Quest s1Quest = S1Quest;
		if (s1Quest != null)
		{
			s1Quest.Cancel(true);
		}
	}

	public void Expire()
	{
		Quest s1Quest = S1Quest;
		if (s1Quest != null)
		{
			s1Quest.Expire(true);
		}
	}

	public void Fail()
	{
		Quest s1Quest = S1Quest;
		if (s1Quest != null)
		{
			s1Quest.Fail(true);
		}
	}

	public void Complete()
	{
		Quest s1Quest = S1Quest;
		if (s1Quest != null)
		{
			s1Quest.Complete(true);
		}
	}

	public void End()
	{
		Quest s1Quest = S1Quest;
		if (s1Quest != null)
		{
			s1Quest.End();
		}
	}

	private static IEnumerator EnsurePOICreation(QuestEntry questEntry)
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
