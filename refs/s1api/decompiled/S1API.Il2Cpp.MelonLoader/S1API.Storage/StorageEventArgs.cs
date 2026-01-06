namespace S1API.Storage;

public class StorageEventArgs
{
	public StorageEntity Storage { get; internal set; }

	public string ItemId => Storage?.ItemId;

	internal StorageEventArgs(StorageEntity storage)
	{
		Storage = storage;
	}
}
