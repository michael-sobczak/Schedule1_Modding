public class UnloadQueueData // TypeDefIndex: 12775
{
	// Fields
	public readonly SceneScopeType ScopeType; // 0x10
	public NetworkConnection[] Connections; // 0x18
	public SceneUnloadData SceneUnloadData; // 0x20
	public string[] GlobalScenes; // 0x28
	public readonly bool AsServer; // 0x30

	// Methods

	// RVA: 0xD90010 Offset: 0xD8EA10 VA: 0x180D90010
	public void .ctor() { }

	// RVA: 0xD8FF50 Offset: 0xD8E950 VA: 0x180D8FF50
	internal void .ctor(SceneScopeType scopeType, NetworkConnection[] conns, SceneUnloadData sceneUnloadData, string[] globalScenes, bool asServer) { }
}
