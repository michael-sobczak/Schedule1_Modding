internal static class SceneManagerAPIInternal // TypeDefIndex: 11981
{
	// Methods

	// RVA: 0x2CE8AE0 Offset: 0x2CE74E0 VA: 0x182CE8AE0
	public static int GetNumScenesInBuildSettings() { }

	[NativeThrows]
	// RVA: 0x2CE8B80 Offset: 0x2CE7580 VA: 0x182CE8B80
	public static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	// RVA: 0x2CE8B10 Offset: 0x2CE7510 VA: 0x182CE8B10
	private static AsyncOperation LoadSceneAsyncNameIndexInternal_Injected(string sceneName, int sceneBuildIndex, ref LoadSceneParameters parameters, bool mustCompleteNextFrame) { }
}
