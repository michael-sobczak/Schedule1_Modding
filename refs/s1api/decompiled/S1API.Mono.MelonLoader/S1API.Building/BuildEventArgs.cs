using S1API.Items;
using S1API.Storage;
using UnityEngine;

namespace S1API.Building;

public class BuildEventArgs
{
	public ItemInstance ItemInstance { get; internal set; }

	public GameObject GameObject { get; internal set; }

	public string ItemId => ItemInstance?.Definition?.ID;

	public StorageEntity Storage { get; internal set; }

	internal BuildEventArgs(ItemInstance itemInstance, GameObject gameObject, StorageEntity storage = null)
	{
		ItemInstance = itemInstance;
		GameObject = gameObject;
		Storage = storage;
	}
}
