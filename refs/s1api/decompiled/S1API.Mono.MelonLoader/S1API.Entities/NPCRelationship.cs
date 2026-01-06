using System;
using System.Collections.Generic;
using System.Reflection;
using S1API.Entities.Relation;
using ScheduleOne.NPCs;
using ScheduleOne.NPCs.Relation;
using UnityEngine;

namespace S1API.Entities;

public sealed class NPCRelationship
{
	public enum UnlockType
	{
		Recommendation,
		DirectApproach
	}

	internal readonly NPC NPC;

	private readonly Dictionary<Action<float>, Delegate> _relationshipChangedHandlers = new Dictionary<Action<float>, Delegate>();

	private readonly Dictionary<Action<UnlockType, bool>, Delegate> _relationshipUnlockedHandlers = new Dictionary<Action<UnlockType, bool>, Delegate>();

	public float Delta
	{
		get
		{
			return (Component != null) ? Component.RelationDelta : 0f;
		}
		set
		{
			NPCRelationData component = Component;
			if (component != null)
			{
				component.SetRelationship(value);
			}
		}
	}

	public float Normalized => (Component != null) ? Component.NormalizedRelationDelta : 0f;

	public bool IsUnlocked => Component != null && Component.Unlocked;

	public UnlockType Type
	{
		get
		{
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			return (Component == null) ? UnlockType.DirectApproach : FromS1(Component.UnlockType);
		}
		set
		{
			SetUnlockType(value);
		}
	}

	public bool IsKnown => Component != null && Component.IsKnown();

	public bool IsMutuallyKnown => Component != null && Component.IsMutuallyKnown();

	public List<string> ConnectionIDs
	{
		get
		{
			List<string> list = new List<string>();
			NPCRelationData component = Component;
			if (component == null || component.Connections == null)
			{
				return list;
			}
			try
			{
				object connections = component.Connections;
				int listCount = GetListCount(connections);
				for (int i = 0; i < listCount; i++)
				{
					NPC listItem = GetListItem(connections, i);
					if ((Object)(object)listItem != (Object)null && listItem.ID != null)
					{
						list.Add(listItem.ID);
					}
				}
			}
			catch
			{
			}
			return list;
		}
	}

	internal NPCRelationData Component => NPC?.S1NPC?.RelationData;

	public event Action<float> OnChanged
	{
		add
		{
			if (value == null || Component == null || _relationshipChangedHandlers.ContainsKey(value))
			{
				return;
			}
			try
			{
				FieldInfo field = typeof(NPCRelationData).GetField("onRelationshipChange", BindingFlags.Instance | BindingFlags.Public);
				if (field == null)
				{
					return;
				}
				object value2 = field.GetValue(Component);
				Action<float> action = delegate(float d)
				{
					try
					{
						value(d);
					}
					catch
					{
					}
				};
				Delegate value3 = Delegate.Combine(value2 as Delegate, action);
				field.SetValue(Component, value3);
				_relationshipChangedHandlers[value] = action;
			}
			catch
			{
			}
		}
		remove
		{
			if (value == null || Component == null || !_relationshipChangedHandlers.TryGetValue(value, out Delegate value2))
			{
				return;
			}
			_relationshipChangedHandlers.Remove(value);
			try
			{
				FieldInfo field = typeof(NPCRelationData).GetField("onRelationshipChange", BindingFlags.Instance | BindingFlags.Public);
				if (!(field == null))
				{
					object value3 = field.GetValue(Component);
					Delegate value4 = ((value3 != null) ? Delegate.Remove(value3 as Delegate, value2) : null);
					field.SetValue(Component, value4);
				}
			}
			catch
			{
			}
		}
	}

	public event Action<UnlockType, bool> OnUnlocked
	{
		add
		{
			if (value == null || Component == null || _relationshipUnlockedHandlers.ContainsKey(value))
			{
				return;
			}
			try
			{
				FieldInfo field = typeof(NPCRelationData).GetField("onUnlocked", BindingFlags.Instance | BindingFlags.Public);
				if (field == null)
				{
					return;
				}
				object value2 = field.GetValue(Component);
				Action<EUnlockType, bool> action = delegate(EUnlockType t, bool notify)
				{
					//IL_0008: Unknown result type (might be due to invalid IL or missing references)
					try
					{
						value(FromS1(t), notify);
					}
					catch
					{
					}
				};
				Delegate value3 = Delegate.Combine(value2 as Delegate, action);
				field.SetValue(Component, value3);
				_relationshipUnlockedHandlers[value] = action;
			}
			catch
			{
			}
		}
		remove
		{
			if (value == null || Component == null || !_relationshipUnlockedHandlers.TryGetValue(value, out Delegate value2))
			{
				return;
			}
			_relationshipUnlockedHandlers.Remove(value);
			try
			{
				FieldInfo field = typeof(NPCRelationData).GetField("onUnlocked", BindingFlags.Instance | BindingFlags.Public);
				if (!(field == null))
				{
					object value3 = field.GetValue(Component);
					Delegate value4 = ((value3 != null) ? Delegate.Remove(value3 as Delegate, value2) : null);
					field.SetValue(Component, value4);
				}
			}
			catch
			{
			}
		}
	}

	internal NPCRelationship(NPC npc)
	{
		NPC = npc;
	}

	public void Add(float delta, bool network = true)
	{
		NPCRelationData component = Component;
		if (component != null)
		{
			component.ChangeRelationship(delta, network);
		}
	}

	public void Unlock(UnlockType type = UnlockType.DirectApproach, bool notify = true)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		NPCRelationData component = Component;
		if (component != null)
		{
			component.Unlock(ToS1(type), notify);
		}
	}

	public void SetUnlockType(UnlockType type)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if (Component == null)
		{
			return;
		}
		try
		{
			(typeof(NPCRelationData).GetProperty("UnlockType", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)?.GetSetMethod(nonPublic: true))?.Invoke(Component, new object[1] { ToS1(type) });
		}
		catch
		{
		}
	}

	public void UnlockConnections()
	{
		NPCRelationData component = Component;
		if (component != null)
		{
			component.UnlockConnections();
		}
	}

	[Obsolete("Declare defaults in NPC.ConfigurePrefab via NPCPrefabBuilder.WithRelationshipDefaults. Runtime mutation is disabled.")]
	public void BuildAndSetRelationshipData(Action<NPCRelationshipDataBuilder> configure)
	{
	}

	private static UnlockType FromS1(EUnlockType t)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return ((int)t != 0) ? UnlockType.DirectApproach : UnlockType.Recommendation;
	}

	private static EUnlockType ToS1(UnlockType t)
	{
		return (EUnlockType)((t != UnlockType.Recommendation) ? 1 : 0);
	}

	private static int GetListCount(object listObj)
	{
		if (listObj == null)
		{
			return 0;
		}
		PropertyInfo property = listObj.GetType().GetProperty("Count", BindingFlags.Instance | BindingFlags.Public);
		return (property != null) ? Convert.ToInt32(property.GetValue(listObj)) : 0;
	}

	private static NPC GetListItem(object listObj, int index)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (listObj == null)
		{
			return null;
		}
		PropertyInfo property = listObj.GetType().GetProperty("Item", BindingFlags.Instance | BindingFlags.Public);
		return (!(property != null)) ? ((NPC)null) : ((NPC)property.GetValue(listObj, new object[1] { index }));
	}
}
