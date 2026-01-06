using MelonLoader;
using S1API.Internal;
using S1API.Internal.Lifecycle;
using S1API.Lifecycle;

namespace S1API;

public class S1API : MelonMod
{
	public override void OnPreSupportModule()
	{
		VersionChecker.CheckMelonLoaderVersion();
	}

	public override void OnSceneWasLoaded(int buildIndex, string sceneName)
	{
		if (sceneName == "Main")
		{
			GameLifecycle.Initialize();
		}
	}

	public override void OnSceneWasUnloaded(int buildIndex, string sceneName)
	{
		SceneStateCleaner.ResetForSceneChange(sceneName, afterUnload: true);
		if (sceneName == "Main")
		{
			GameLifecycle.Reset();
		}
	}

	public override void OnSceneWasInitialized(int buildIndex, string sceneName)
	{
		NPCNetworkBootstrap.EnsurePrefabsWarmup();
		SceneStateCleaner.ResetForSceneChange(sceneName, afterUnload: false);
	}
}
