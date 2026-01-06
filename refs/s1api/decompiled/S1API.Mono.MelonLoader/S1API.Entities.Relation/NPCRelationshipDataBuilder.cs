using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using S1API.Logging;
using ScheduleOne.NPCs;
using ScheduleOne.NPCs.Relation;
using UnityEngine;

namespace S1API.Entities.Relation;

public sealed class NPCRelationshipDataBuilder
{
	internal sealed class RelationshipDefaultsData
	{
		public float? RelationDelta;

		public bool? Unlocked;

		public NPCRelationship.UnlockType? UnlockType;

		public List<string> ConnectionIDs;
	}

	private static readonly Log Logger = new Log("NPCRelationshipDataBuilder");

	private float? _relationDelta;

	private bool? _unlocked;

	private NPCRelationship.UnlockType? _unlockType;

	private readonly List<string> _connectionIDs = new List<string>();

	public NPCRelationshipDataBuilder WithDelta(float delta)
	{
		_relationDelta = Mathf.Clamp(delta, 0f, 5f);
		return this;
	}

	public NPCRelationshipDataBuilder WithNormalized(float normalized)
	{
		float num = Mathf.Clamp01(normalized);
		_relationDelta = num * 5f;
		return this;
	}

	public NPCRelationshipDataBuilder SetUnlocked(bool unlocked)
	{
		_unlocked = unlocked;
		return this;
	}

	public NPCRelationshipDataBuilder SetUnlockType(NPCRelationship.UnlockType type)
	{
		_unlockType = type;
		return this;
	}

	public NPCRelationshipDataBuilder SetUnlockType(string typeName)
	{
		if (!string.IsNullOrEmpty(typeName) && Enum.TryParse<NPCRelationship.UnlockType>(typeName, ignoreCase: true, out var result))
		{
			_unlockType = result;
		}
		return this;
	}

	public NPCRelationshipDataBuilder WithConnectionsById(IEnumerable<string> ids)
	{
		_connectionIDs.Clear();
		if (ids == null)
		{
			return this;
		}
		int num = 0;
		foreach (string id in ids)
		{
			if (!string.IsNullOrEmpty(id) && !_connectionIDs.Contains<string>(id, StringComparer.OrdinalIgnoreCase))
			{
				_connectionIDs.Add(id);
				num++;
			}
		}
		return this;
	}

	public NPCRelationshipDataBuilder WithConnectionsById(params string[] ids)
	{
		return WithConnectionsById((IEnumerable<string>)ids);
	}

	[Obsolete("Use WithConnections<T1, T2, ...>() or WithConnectionsById instead. NPC instances are not available during prefab configuration.")]
	public NPCRelationshipDataBuilder WithConnections(IEnumerable<NPC> npcs)
	{
		Logger.Warning("[Relationship Data] WithConnections(NPC[]) is obsolete. Use WithConnections<T1, T2, ...>() or WithConnectionsById instead to resolve IDs in Menu scene.");
		return WithConnections(npcs?.Select((NPC n) => n?.GetType()).ToArray());
	}

	private static string TryGetStaticNPCId(Type npcType)
	{
		if (npcType == null)
		{
			return null;
		}
		try
		{
			PropertyInfo property = npcType.GetProperty("NPCId", BindingFlags.Static | BindingFlags.Public | BindingFlags.FlattenHierarchy);
			if (property != null && property.PropertyType == typeof(string))
			{
				string text = property.GetValue(null) as string;
				if (!string.IsNullOrEmpty(text))
				{
					return text;
				}
			}
		}
		catch (Exception ex)
		{
			Logger.Warning("[Relationship Data] TryGetStaticNPCId: Exception reading static NPCId property for type '" + npcType.Name + "': " + ex.Message);
		}
		return null;
	}

	private static string TryResolveNPCIdFromType(Type npcType)
	{
		if (npcType == null)
		{
			return null;
		}
		try
		{
			string name = npcType.Name;
			List<string> list = new List<string>();
			list.Add(name.ToLowerInvariant());
			string text = Regex.Replace(name, "([a-z])([A-Z])", "$1_$2").ToLowerInvariant();
			if (text != name.ToLowerInvariant())
			{
				list.Add(text);
			}
			List<NPC> nPCRegistry = NPCManager.NPCRegistry;
			if (nPCRegistry != null)
			{
				foreach (string item in list)
				{
					foreach (NPC item2 in nPCRegistry)
					{
						if ((Object)(object)item2 != (Object)null && string.Equals(item2.ID, item, StringComparison.OrdinalIgnoreCase))
						{
							return item;
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			Logger.Warning("[Relationship Data] TryResolveNPCIdFromType: Exception resolving ID for NPC type '" + (npcType?.Name ?? "<null>") + "': " + ex.Message);
		}
		return null;
	}

	[Obsolete("Use WithConnections<T1, T2, ...>() or WithConnectionsById instead. NPC instances are not available during prefab configuration.")]
	public NPCRelationshipDataBuilder WithConnections(params NPC[] npcs)
	{
		return WithConnections((IEnumerable<NPC>)npcs);
	}

	public NPCRelationshipDataBuilder WithConnections<T1, T2>() where T1 : NPC where T2 : NPC
	{
		return WithConnections(typeof(T1), typeof(T2));
	}

	public NPCRelationshipDataBuilder WithConnections<T1, T2, T3>() where T1 : NPC where T2 : NPC where T3 : NPC
	{
		return WithConnections(typeof(T1), typeof(T2), typeof(T3));
	}

	public NPCRelationshipDataBuilder WithConnections(params Type[] npcTypes)
	{
		_connectionIDs.Clear();
		if (npcTypes == null || npcTypes.Length == 0)
		{
			return this;
		}
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		foreach (Type type in npcTypes)
		{
			if (type == null)
			{
				num2++;
				Logger.Warning("[Relationship Data] WithConnections: Received null NPC type");
				continue;
			}
			if (!typeof(NPC).IsAssignableFrom(type))
			{
				Logger.Warning("[Relationship Data] WithConnections: Type '" + type.Name + "' is not an NPC type");
				continue;
			}
			string text = TryGetStaticNPCId(type);
			if (string.IsNullOrEmpty(text) && type.Assembly == typeof(NPCRelationshipDataBuilder).Assembly)
			{
				text = TryResolveNPCIdFromType(type);
				if (!string.IsNullOrEmpty(text))
				{
					num4++;
				}
			}
			if (string.IsNullOrEmpty(text))
			{
				num3++;
				Logger.Warning("[Relationship Data] WithConnections: Could not resolve ID for NPC type '" + type.Name + "'. Ensure the NPC class has a static NPCId property (e.g., public new static string NPCId => \"npc_id\";)");
			}
			else if (!_connectionIDs.Contains<string>(text, StringComparer.OrdinalIgnoreCase))
			{
				_connectionIDs.Add(text);
				num++;
			}
		}
		return this;
	}

	internal RelationshipDefaultsData CaptureData()
	{
		return new RelationshipDefaultsData
		{
			RelationDelta = _relationDelta,
			Unlocked = _unlocked,
			UnlockType = _unlockType,
			ConnectionIDs = ((_connectionIDs.Count > 0) ? new List<string>(_connectionIDs) : null)
		};
	}

	public void ApplyTo(NPCRelationData relationData, NPC owner, bool preserveUnlockState = false)
	{
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		if (relationData == null)
		{
			return;
		}
		try
		{
			if (_relationDelta.HasValue)
			{
				relationData.SetRelationship(_relationDelta.Value);
			}
		}
		catch
		{
		}
		try
		{
			if (_connectionIDs.Count > 0)
			{
				List<NPC> nPCRegistry = NPCManager.NPCRegistry;
				List<NPC> connections = relationData.Connections;
				if (connections != null)
				{
					int count = connections.Count;
					connections.Clear();
					int num = 0;
					int num2 = 0;
					for (int i = 0; i < _connectionIDs.Count; i++)
					{
						string text = _connectionIDs[i];
						NPC val = null;
						foreach (NPC item in nPCRegistry)
						{
							if ((Object)(object)item != (Object)null && item != owner && string.Equals(item.ID, text, StringComparison.OrdinalIgnoreCase))
							{
								val = item;
								break;
							}
						}
						if ((Object)(object)val != (Object)null)
						{
							if (!connections.Contains(val))
							{
								connections.Add(val);
								num++;
							}
							else
							{
								num++;
							}
						}
						else
						{
							num2++;
							Logger.Warning("[Relationship Data] ApplyTo: Connection ID '" + text + "' not found in NPC registry for NPC '" + (owner?.ID ?? "<null>") + "'");
						}
					}
				}
				else
				{
					Logger.Warning("[Relationship Data] ApplyTo: Connections list is null for NPC '" + (owner?.ID ?? "<null>") + "'");
				}
			}
		}
		catch (Exception ex)
		{
			Logger.Error("[Relationship Data] ApplyTo: Exception applying connections to NPC '" + (owner?.ID ?? "<null>") + "': " + ex.Message);
		}
		try
		{
			if (!preserveUnlockState && _unlocked.HasValue)
			{
				if (_unlocked.Value)
				{
					NPCRelationship.UnlockType t = ((!_unlockType.HasValue) ? NPCRelationship.UnlockType.DirectApproach : _unlockType.Value);
					relationData.Unlock(ToS1(t), false);
				}
				else if (_unlockType.HasValue)
				{
					(typeof(NPCRelationData).GetProperty("UnlockType", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)?.GetSetMethod(nonPublic: true))?.Invoke(relationData, new object[1] { ToS1(_unlockType.Value) });
				}
			}
			else if (_unlockType.HasValue && !preserveUnlockState)
			{
				(typeof(NPCRelationData).GetProperty("UnlockType", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)?.GetSetMethod(nonPublic: true))?.Invoke(relationData, new object[1] { ToS1(_unlockType.Value) });
			}
		}
		catch
		{
		}
	}

	private static EUnlockType ToS1(NPCRelationship.UnlockType t)
	{
		return (EUnlockType)((t != NPCRelationship.UnlockType.Recommendation) ? 1 : 0);
	}
}
