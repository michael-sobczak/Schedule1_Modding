using System;
using S1API.Logging;

namespace S1API.Building;

public static class BuildEvents
{
	private static readonly Log Logger = new Log("BuildEvents");

	public static event Action<BuildEventArgs> OnGridItemCreated;

	public static event Action<BuildEventArgs> OnSurfaceItemCreated;

	public static event Action<BuildEventArgs> OnBuildableItemInitialized;

	internal static void RaiseGridItemCreated(BuildEventArgs args)
	{
		if (args == null)
		{
			return;
		}
		try
		{
			BuildEvents.OnGridItemCreated?.Invoke(args);
		}
		catch (Exception ex)
		{
			Logger.Error($"Exception in OnGridItemCreated handler for item '{args.ItemId}': {ex.Message}\n{ex.StackTrace}");
		}
	}

	internal static void RaiseSurfaceItemCreated(BuildEventArgs args)
	{
		if (args == null)
		{
			return;
		}
		try
		{
			BuildEvents.OnSurfaceItemCreated?.Invoke(args);
		}
		catch (Exception ex)
		{
			Logger.Error($"Exception in OnSurfaceItemCreated handler for item '{args.ItemId}': {ex.Message}\n{ex.StackTrace}");
		}
	}

	internal static void RaiseBuildableItemInitialized(BuildEventArgs args)
	{
		if (args == null)
		{
			return;
		}
		try
		{
			BuildEvents.OnBuildableItemInitialized?.Invoke(args);
		}
		catch (Exception ex)
		{
			Logger.Error($"Exception in OnBuildableItemInitialized handler for item '{args.ItemId}': {ex.Message}\n{ex.StackTrace}");
		}
	}
}
