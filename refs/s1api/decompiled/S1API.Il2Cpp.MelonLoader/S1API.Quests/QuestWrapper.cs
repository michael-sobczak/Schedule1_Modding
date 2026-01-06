using System;
using System.Collections.Generic;
using Il2CppScheduleOne.Quests;
using Il2CppSystem.Collections.Generic;
using S1API.Internal.Abstraction;

namespace S1API.Quests;

public sealed class QuestWrapper
{
	private readonly Quest? _modQuest;

	private readonly Quest? _baseGameQuest;

	private readonly bool _isBaseGameQuest;

	private readonly Dictionary<Action, Action<EQuestState>> _failWrapperActions = new Dictionary<Action, Action<EQuestState>>();

	public string Title => _isBaseGameQuest ? _baseGameQuest.Title : _modQuest.S1Quest.Title;

	public List<QuestEntry> QuestEntries
	{
		get
		{
			if (_isBaseGameQuest)
			{
				List<QuestEntry> list = new List<QuestEntry>();
				if (_baseGameQuest.Entries != null)
				{
					Enumerator<QuestEntry> enumerator = _baseGameQuest.Entries.GetEnumerator();
					while (enumerator.MoveNext())
					{
						QuestEntry current = enumerator.Current;
						list.Add(new QuestEntry(current));
					}
				}
				return list;
			}
			return _modQuest.QuestEntries;
		}
	}

	public event Action OnComplete
	{
		add
		{
			if (_isBaseGameQuest)
			{
				EventHelper.AddListener(value, _baseGameQuest.onComplete);
			}
			else
			{
				_modQuest.OnComplete += value;
			}
		}
		remove
		{
			if (_isBaseGameQuest)
			{
				EventHelper.RemoveListener(value, _baseGameQuest.onComplete);
			}
			else
			{
				_modQuest.OnComplete -= value;
			}
		}
	}

	public event Action OnFail
	{
		add
		{
			if (_isBaseGameQuest)
			{
				Action<EQuestState> action = delegate(EQuestState state)
				{
					//IL_0001: Unknown result type (might be due to invalid IL or missing references)
					//IL_0003: Invalid comparison between Unknown and I4
					if ((int)state == 3)
					{
						value?.Invoke();
					}
				};
				_failWrapperActions[value] = action;
				EventHelper.AddListener(action, _baseGameQuest.onQuestEnd);
			}
			else
			{
				_modQuest.OnFail += value;
			}
		}
		remove
		{
			if (_isBaseGameQuest)
			{
				if (_failWrapperActions.TryGetValue(value, out Action<EQuestState> value2))
				{
					EventHelper.RemoveListener(value2, _baseGameQuest.onQuestEnd);
					_failWrapperActions.Remove(value);
				}
			}
			else
			{
				_modQuest.OnFail -= value;
			}
		}
	}

	internal QuestWrapper(Quest modQuest)
	{
		_modQuest = modQuest;
		_baseGameQuest = null;
		_isBaseGameQuest = false;
	}

	internal QuestWrapper(Quest baseGameQuest)
	{
		_modQuest = null;
		_baseGameQuest = baseGameQuest;
		_isBaseGameQuest = true;
	}
}
