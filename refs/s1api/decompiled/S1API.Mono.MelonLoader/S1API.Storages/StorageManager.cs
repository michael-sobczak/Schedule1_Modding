using System;
using System.Collections.Generic;
using ScheduleOne.Storage;
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
		foreach (WorldStorageEntity item in WorldStorageEntity.All)
		{
			if ((Object)(object)item != (Object)null)
			{
				list.Add(new StorageInstance((StorageEntity)(object)item));
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
		foreach (WorldStorageEntity item in WorldStorageEntity.All)
		{
			if ((Object)(object)item != (Object)null && ((StorageEntity)item).StorageEntityName == name)
			{
				return new StorageInstance((StorageEntity)(object)item);
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
		foreach (WorldStorageEntity item in WorldStorageEntity.All)
		{
			if ((Object)(object)item != (Object)null)
			{
				StorageInstance storageInstance = new StorageInstance((StorageEntity)(object)item);
				if (predicate(storageInstance))
				{
					list.Add(storageInstance);
				}
			}
		}
		return list.ToArray();
	}
}
