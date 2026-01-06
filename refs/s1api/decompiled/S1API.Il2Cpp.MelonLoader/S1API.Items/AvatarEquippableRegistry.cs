using System;
using System.Reflection;
using Il2CppScheduleOne.AvatarFramework.Equipping;
using S1API.AssetBundles;
using S1API.Logging;
using S1API.Rendering;
using UnityEngine;

namespace S1API.Items;

public static class AvatarEquippableRegistry
{
	private static readonly Log _logger = new Log("AvatarEquippableRegistry");

	public static bool RegisterAvatarEquippable(string assetPath, GameObject prefab)
	{
		if (string.IsNullOrEmpty(assetPath))
		{
			_logger.Error("Cannot register AvatarEquippable: assetPath is null or empty");
			return false;
		}
		if ((Object)(object)prefab == (Object)null)
		{
			_logger.Error("Cannot register AvatarEquippable at '" + assetPath + "': prefab is null");
			return false;
		}
		AvatarEquippable component = prefab.GetComponent<AvatarEquippable>();
		if ((Object)(object)component == (Object)null)
		{
			_logger.Warning("Prefab '" + ((Object)prefab).name + "' does not have an AvatarEquippable component. It will still be registered, but may not work correctly.");
		}
		bool flag = RuntimeResourceRegistry.RegisterGameObject(assetPath, prefab);
		if (flag)
		{
			_logger.Msg("Registered AvatarEquippable prefab: " + assetPath);
		}
		return flag;
	}

	public static bool LoadAndRegisterFromBundle(WrappedAssetBundle bundle, string prefabName, string assetPath)
	{
		if (bundle == null)
		{
			_logger.Error("Cannot load AvatarEquippable: bundle is null");
			return false;
		}
		try
		{
			GameObject val = bundle.LoadAsset<GameObject>(prefabName);
			if ((Object)(object)val == (Object)null)
			{
				_logger.Error("Failed to load prefab '" + prefabName + "' from AssetBundle");
				return false;
			}
			return RegisterAvatarEquippable(assetPath, val);
		}
		catch (Exception ex)
		{
			_logger.Error("Exception loading AvatarEquippable from bundle: " + ex.Message);
			_logger.Error(ex.StackTrace);
			return false;
		}
	}

	public static bool LoadAndRegisterFromEmbeddedBundle(string bundleName, string prefabName, string assetPath, Assembly assemblyOverride = null)
	{
		try
		{
			Assembly assembly = assemblyOverride ?? Assembly.GetExecutingAssembly();
			WrappedAssetBundle assetBundleFromStream = AssetLoader.GetAssetBundleFromStream(assembly.GetName().Name + "." + bundleName, assembly);
			return LoadAndRegisterFromBundle(assetBundleFromStream, prefabName, assetPath);
		}
		catch (Exception ex)
		{
			_logger.Error("Exception loading AvatarEquippable from embedded bundle '" + bundleName + "': " + ex.Message);
			_logger.Error(ex.StackTrace);
			return false;
		}
	}

	public static bool IsRegistered(string assetPath)
	{
		return RuntimeResourceRegistry.IsRegistered(assetPath);
	}

	public static GameObject GetRegisteredPrefab(string assetPath)
	{
		return RuntimeResourceRegistry.GetRegisteredAsset<GameObject>(assetPath);
	}
}
