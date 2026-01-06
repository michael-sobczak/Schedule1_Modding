using UnityEngine;

namespace S1API.AssetBundles;

public class WrappedAssetBundleRequest
{
	private readonly AssetBundleRequest _realRequest;

	public Object Asset => _realRequest.asset;

	public Object[] AllAssets => _realRequest.allAssets;

	internal WrappedAssetBundleRequest(AssetBundleRequest realRequest)
	{
		_realRequest = realRequest;
	}
}
