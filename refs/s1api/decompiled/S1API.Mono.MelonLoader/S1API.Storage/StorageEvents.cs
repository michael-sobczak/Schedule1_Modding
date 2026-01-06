using System;
using S1API.Logging;

namespace S1API.Storage;

public static class StorageEvents
{
	private static readonly Log Logger = new Log("StorageEvents");

	public static event Action<StorageEventArgs> OnStorageCreated;

	public static event Action<StorageLoadingEventArgs> OnStorageLoading;

	public static event Action<StorageEventArgs> OnStorageOpening;

	internal static void RaiseStorageCreated(StorageEventArgs args)
	{
		if (args == null)
		{
			return;
		}
		try
		{
			StorageEvents.OnStorageCreated?.Invoke(args);
		}
		catch (Exception ex)
		{
			Logger.Error("Exception in OnStorageCreated handler for storage '" + args.ItemId + "': " + ex.Message + "\n" + ex.StackTrace);
		}
	}

	internal static void RaiseStorageLoading(StorageLoadingEventArgs args)
	{
		if (args == null)
		{
			return;
		}
		try
		{
			StorageEvents.OnStorageLoading?.Invoke(args);
		}
		catch (Exception ex)
		{
			Logger.Error("Exception in OnStorageLoading handler for storage '" + args.ItemId + "': " + ex.Message + "\n" + ex.StackTrace);
		}
	}

	internal static void RaiseStorageOpening(StorageEventArgs args)
	{
		if (args == null)
		{
			return;
		}
		try
		{
			StorageEvents.OnStorageOpening?.Invoke(args);
		}
		catch (Exception ex)
		{
			Logger.Error("Exception in OnStorageOpening handler for storage '" + args.ItemId + "': " + ex.Message + "\n" + ex.StackTrace);
		}
	}
}
