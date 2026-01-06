public struct SceneLoadEndEventArgs // TypeDefIndex: 12762
{
	// Fields
	public readonly LoadQueueData QueueData; // 0x0
	public readonly Scene[] LoadedScenes; // 0x8
	public readonly string[] SkippedSceneNames; // 0x10
	public readonly string[] UnloadedSceneNames; // 0x18

	// Methods

	// RVA: 0xD63E30 Offset: 0xD62830 VA: 0x180D63E30
	internal void .ctor(LoadQueueData lqd, string[] skipped, Scene[] loaded, string[] unloadedSceneNames) { }
}
