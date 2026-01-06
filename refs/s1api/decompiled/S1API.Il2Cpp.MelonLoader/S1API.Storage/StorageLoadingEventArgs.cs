using System;

namespace S1API.Storage;

public class StorageLoadingEventArgs : StorageEventArgs
{
	public int ItemCountBeingLoaded { get; internal set; }

	public int CurrentSlotCount => base.Storage?.SlotCount ?? 0;

	public bool NeedsMoreSlots => ItemCountBeingLoaded > CurrentSlotCount;

	public int AdditionalSlotsNeeded => Math.Max(0, ItemCountBeingLoaded - CurrentSlotCount);

	internal StorageLoadingEventArgs(StorageEntity storage, int itemCount)
		: base(storage)
	{
		ItemCountBeingLoaded = itemCount;
	}
}
