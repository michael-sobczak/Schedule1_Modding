using UnityEngine;

namespace S1API.Entities;

internal static class NPCPrefabContainer
{
	private const string RootName = "@S1API_PersistentPrefabs";

	private static GameObject _persistentRoot;

	public static GameObject GetOrCreatePrefabsContainer()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		if ((Object)(object)_persistentRoot != (Object)null)
		{
			return _persistentRoot;
		}
		GameObject val = GameObject.Find("@S1API_PersistentPrefabs");
		if ((Object)(object)val != (Object)null)
		{
			_persistentRoot = val;
		}
		else
		{
			_persistentRoot = new GameObject("@S1API_PersistentPrefabs");
		}
		Object.DontDestroyOnLoad((Object)(object)_persistentRoot);
		return _persistentRoot;
	}

	public static GameObject GetOrCreateNPCPrefabContainer(string npcTypeName)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		if (string.IsNullOrEmpty(npcTypeName))
		{
			return null;
		}
		GameObject orCreatePrefabsContainer = GetOrCreatePrefabsContainer();
		if ((Object)(object)orCreatePrefabsContainer == (Object)null)
		{
			return null;
		}
		Transform val = orCreatePrefabsContainer.transform.Find(npcTypeName);
		if ((Object)(object)val == (Object)null)
		{
			GameObject val2 = new GameObject(npcTypeName);
			val2.transform.SetParent(orCreatePrefabsContainer.transform, false);
			return val2;
		}
		return ((Component)val).gameObject;
	}

	public static GameObject OrganizePrefab(GameObject prefab, string npcTypeName)
	{
		if ((Object)(object)prefab == (Object)null || string.IsNullOrEmpty(npcTypeName))
		{
			return null;
		}
		GameObject orCreateNPCPrefabContainer = GetOrCreateNPCPrefabContainer(npcTypeName);
		if ((Object)(object)orCreateNPCPrefabContainer != (Object)null)
		{
			prefab.transform.SetParent(orCreateNPCPrefabContainer.transform, false);
			prefab.SetActive(false);
		}
		return orCreateNPCPrefabContainer;
	}
}
