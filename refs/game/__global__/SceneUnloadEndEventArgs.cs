public struct SceneUnloadEndEventArgs // TypeDefIndex: 12764
{
	// Fields
	public readonly UnloadQueueData QueueData; // 0x0
	[Obsolete("Use UnloadedScenesV2")]
	public int[] UnloadedSceneHandles; // 0x8
	[Obsolete("Use UnloadedScenesV2")]
	public string[] UnloadedSceneNames; // 0x10
	public List<Scene> UnloadedScenes; // 0x18
	public List<UnloadedScene> UnloadedScenesV2; // 0x20

	// Methods

	// RVA: 0xD63EA0 Offset: 0xD628A0 VA: 0x180D63EA0
	internal void .ctor(UnloadQueueData sqd, List<Scene> unloadedScenes, List<UnloadedScene> newUnloadedScenes) { }
}
