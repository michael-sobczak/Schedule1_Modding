public struct LoadSceneParameters // TypeDefIndex: 11986
{
	// Fields
	[SerializeField]
	private LoadSceneMode m_LoadSceneMode; // 0x0
	[SerializeField]
	private LocalPhysicsMode m_LocalPhysicsMode; // 0x4

	// Properties
	public LoadSceneMode loadSceneMode { set; }
	public LocalPhysicsMode localPhysicsMode { set; }

	// Methods

	// RVA: 0x5276C0 Offset: 0x5260C0 VA: 0x1805276C0
	public void set_loadSceneMode(LoadSceneMode value) { }

	// RVA: 0x5276B0 Offset: 0x5260B0 VA: 0x1805276B0
	public void set_localPhysicsMode(LocalPhysicsMode value) { }

	// RVA: 0x50DD40 Offset: 0x50C740 VA: 0x18050DD40
	public void .ctor(LoadSceneMode mode) { }
}
