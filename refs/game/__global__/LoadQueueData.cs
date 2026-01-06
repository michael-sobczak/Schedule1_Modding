public class LoadQueueData // TypeDefIndex: 12767
{
	// Fields
	public SceneScopeType ScopeType; // 0x10
	public NetworkConnection[] Connections; // 0x18
	public SceneLoadData SceneLoadData; // 0x20
	public string[] GlobalScenes; // 0x28
	public readonly bool AsServer; // 0x30

	// Methods

	// RVA: 0xD7C970 Offset: 0xD7B370 VA: 0x180D7C970
	public void .ctor() { }

	// RVA: 0xD7C880 Offset: 0xD7B280 VA: 0x180D7C880
	internal void .ctor(SceneScopeType scopeType, NetworkConnection[] conns, SceneLoadData sceneLoadData, string[] globalScenes, bool asServer) { }
}
