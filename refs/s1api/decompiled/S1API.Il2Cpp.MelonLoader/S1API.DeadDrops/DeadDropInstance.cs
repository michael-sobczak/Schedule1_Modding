using System.Linq;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.Storage;
using S1API.Internal.Abstraction;
using S1API.Map;
using S1API.Storages;
using UnityEngine;

namespace S1API.DeadDrops;

public class DeadDropInstance : IGUIDReference
{
	internal readonly DeadDrop S1DeadDrop;

	private StorageInstance? _cachedStorage;

	public string GUID => ((object)S1DeadDrop.GUID/*cast due to .constrained prefix*/).ToString();

	public string Name => S1DeadDrop.DeadDropName;

	public string Description => S1DeadDrop.DeadDropDescription;

	public Region Region => (Region)S1DeadDrop.Region;

	public StorageInstance Storage => _cachedStorage ?? (_cachedStorage = new StorageInstance((StorageEntity)(object)S1DeadDrop.Storage));

	public int ItemCount => ((StorageEntity)S1DeadDrop.Storage).ItemCount;

	public bool IsEmpty => ItemCount == 0;

	public Vector3 Position => ((Component)S1DeadDrop).transform.position;

	internal DeadDropInstance(DeadDrop deadDrop)
	{
		S1DeadDrop = deadDrop;
	}

	internal static DeadDropInstance? GetFromGUID(string guid)
	{
		return DeadDropManager.All.FirstOrDefault((DeadDropInstance deadDrop) => deadDrop.GUID == guid);
	}
}
