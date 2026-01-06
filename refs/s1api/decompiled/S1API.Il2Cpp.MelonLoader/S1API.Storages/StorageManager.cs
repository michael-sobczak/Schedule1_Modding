using System;
using System.Collections.Generic;
using Il2CppScheduleOne.Storage;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace S1API.Storages;

public static class StorageManager
{
	public static StorageInstance[] GetAll()
	{
		List<StorageInstance> list = new List<StorageInstance>();
		if (WorldStorageEntity.All == null)
		{
			return list.ToArray();
		}
		Enumerator<WorldStorageEntity> enumerator = WorldStorageEntity.All.GetEnumerator();
		while (enumerator.MoveNext())
		{
			WorldStorageEntity current = enumerator.Current;
			if ((Object)(object)current != (Object)null)
			{
				list.Add(new StorageInstance((StorageEntity)(object)current));
			}
		}
		return list.ToArray();
	}

	public static StorageInstance? FindByName(string name)
	{
		if (string.IsNullOrEmpty(name) || WorldStorageEntity.All == null)
		{
			return null;
		}
		Enumerator<WorldStorageEntity> enumerator = WorldStorageEntity.All.GetEnumerator();
		while (enumerator.MoveNext())
		{
			WorldStorageEntity current = enumerator.Current;
			if ((Object)(object)current != (Object)null && ((StorageEntity)current).StorageEntityName == name)
			{
				return new StorageInstance((StorageEntity)(object)current);
			}
		}
		return null;
	}

	public static StorageInstance[] FindByPredicate(Func<StorageInstance, bool> predicate)
	{
		if (predicate == null || WorldStorageEntity.All == null)
		{
			return Array.Empty<StorageInstance>();
		}
		List<StorageInstance> list = new List<StorageInstance>();
		Enumerator<WorldStorageEntity> enumerator = WorldStorageEntity.All.GetEnumerator();
		while (enumerator.MoveNext())
		{
			WorldStorageEntity current = enumerator.Current;
			if ((Object)(object)current != (Object)null)
			{
				StorageInstance storageInstance = new StorageInstance((StorageEntity)(object)current);
				if (predicate(storageInstance))
				{
					list.Add(storageInstance);
				}
			}
		}
		return list.ToArray();
	}
}
