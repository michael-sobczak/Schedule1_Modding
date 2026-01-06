using System;
using UnityEngine;

namespace S1API.AssetBundles;

public class WrappedAssetBundle
{
	private readonly AssetBundle _realBundle;

	public bool IsStreamedAssetBundle => _realBundle.isStreamedSceneAssetBundle;

	public WrappedAssetBundle(AssetBundle realBundle)
	{
		_realBundle = realBundle;
	}

	public bool Contains(string name)
	{
		return _realBundle.Contains(name);
	}

	public string[] GetAllAssetNames()
	{
		return _realBundle.GetAllAssetNames();
	}

	public string[] GetAllScenePaths()
	{
		return _realBundle.GetAllScenePaths();
	}

	public Object Load(string name)
	{
		return LoadAsset(name);
	}

	public Object LoadAsset(string name)
	{
		return this.LoadAsset<Object>(name);
	}

	public T Load<T>(string name) where T : Object
	{
		return LoadAsset<T>(name);
	}

	public T LoadAsset<T>(string name) where T : Object
	{
		return _realBundle.LoadAsset<T>(name);
	}

	public Object Load(string name, Type type)
	{
		return LoadAsset(name, type);
	}

	public Object LoadAsset(string name, Type type)
	{
		return _realBundle.LoadAsset(name, type);
	}

	public WrappedAssetBundleRequest LoadAssetAsync(string name)
	{
		return this.LoadAssetAsync<Object>(name);
	}

	public WrappedAssetBundleRequest LoadAssetAsync<T>(string name) where T : Object
	{
		return new WrappedAssetBundleRequest(_realBundle.LoadAssetAsync<T>(name));
	}

	public WrappedAssetBundleRequest LoadAssetAsync(string name, Type type)
	{
		return new WrappedAssetBundleRequest(_realBundle.LoadAssetAsync(name, type));
	}

	public Object[] LoadAll()
	{
		return LoadAllAssets();
	}

	public Object[] LoadAllAssets()
	{
		return this.LoadAllAssets<Object>();
	}

	public T[] LoadAllAssets<T>() where T : Object
	{
		return _realBundle.LoadAllAssets<T>();
	}

	public Object[] LoadAllAssets(Type type)
	{
		return _realBundle.LoadAllAssets(type);
	}

	public Object[] LoadAssetWithSubAssets(string name)
	{
		return this.LoadAssetWithSubAssets<Object>(name);
	}

	public T[] LoadAssetWithSubAssets<T>(string name) where T : Object
	{
		return _realBundle.LoadAssetWithSubAssets<T>(name);
	}

	public Object[] LoadAssetWithSubAssets(string name, Type type)
	{
		return _realBundle.LoadAssetWithSubAssets(name, type);
	}

	public void Unload(bool unloadAllLoadedObjects)
	{
		_realBundle.Unload(unloadAllLoadedObjects);
	}
}
