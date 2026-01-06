using System.Collections.Generic;
using System.IO;
using System.Reflection;
using S1API.Logging;
using UnityEngine;

namespace S1API.AssetBundles;

public static class AssetLoader
{
	private static readonly Log _logger = new Log("AssetLoader");

	private static readonly Dictionary<string, WrappedAssetBundle> _cachedAssetBundles = new Dictionary<string, WrappedAssetBundle>();

	public static WrappedAssetBundle GetAssetBundleFromStream(string fullResourceName, Assembly overrideAssembly)
	{
		if (_cachedAssetBundles.TryGetValue(fullResourceName, out WrappedAssetBundle value))
		{
			return value;
		}
		Stream manifestResourceStream = overrideAssembly.GetManifestResourceStream(fullResourceName);
		WrappedAssetBundle wrappedAssetBundle = new WrappedAssetBundle(AssetBundle.LoadFromStream(manifestResourceStream));
		_cachedAssetBundles.TryAdd(fullResourceName, wrappedAssetBundle);
		return wrappedAssetBundle;
	}

	public static T EasyLoad<T>(string bundleName, string objectName) where T : Object
	{
		WrappedAssetBundle bundle;
		return EasyLoad<T>(bundleName, objectName, Assembly.GetExecutingAssembly(), out bundle);
	}

	public static T EasyLoad<T>(string bundleName, string objectName, out WrappedAssetBundle bundle) where T : Object
	{
		return EasyLoad<T>(bundleName, objectName, Assembly.GetExecutingAssembly(), out bundle);
	}

	public static T EasyLoad<T>(string bundleName, string objectName, Assembly assemblyOverride) where T : Object
	{
		WrappedAssetBundle bundle;
		return EasyLoad<T>(bundleName, objectName, assemblyOverride, out bundle);
	}

	public static T EasyLoad<T>(string bundleName, string objectName, Assembly assemblyOverride, out WrappedAssetBundle bundle) where T : Object
	{
		bundle = GetAssetBundleFromStream(assemblyOverride.GetName().Name + "." + bundleName, assemblyOverride);
		return bundle.LoadAsset<T>(objectName);
	}
}
