using Il2CppInterop.Runtime.InteropTypes.Arrays;
using UnityEngine;

namespace S1API.AssetBundles;

public class WrappedAssetBundleRequest
{
	private readonly Il2CppAssetBundleRequest _realRequest;

	public Object Asset => _realRequest.asset;

	public Object[] AllAssets => Il2CppArrayBase<Object>.op_Implicit((Il2CppArrayBase<Object>)(object)_realRequest.allAssets);

	internal WrappedAssetBundleRequest(Il2CppAssetBundleRequest realRequest)
	{
		_realRequest = realRequest;
	}
}
